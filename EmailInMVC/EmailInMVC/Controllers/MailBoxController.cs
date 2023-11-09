using MailKit;
using MailKit.Net.Imap;
using MimeKit;
using System;
using System.Net.Security;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmailInMVC.Auth;
using System.Net.Mail;

namespace WebApplication1.Controllers
{

    [AuthController]
    public class MailBoxController : Controller
    {
        //All the data to be needed in our action methods
        private const string GmailPassword = "qcui ztyn doln lnmj";
        private const string GmailImapServer = "imap.gmail.com";
        private const int GmailImapPort = 993;

        public ActionResult MailInbox()
        {
            // below we are creating a list of type MIME message to store  all the messages
            List<MimeMessage> messages = new List<MimeMessage>();

            string GmailEmail = Session["usr"] as string;

            using (var client = new ImapClient())
            {
                // First we are making a object 'Client' of ImapClient() class ]
                // and then using its connect function connecting to the IMAP Server.
                client.Connect(GmailImapServer, GmailImapPort, true);

                // Now after connecting we are going to authenticate with out gmailID and password
                client.Authenticate(GmailEmail, GmailPassword);

                // Accessing the data in our Inbox folder
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                //Storing all the inbox messages to our list
                int messageCount = inbox.Count;
                int maxMessagesToShow = 20;
                int startIndex = Math.Max(0, messageCount - maxMessagesToShow);

                for (int i = startIndex; i < messageCount; i++)
                {
                    var message = inbox.GetMessage(i);
                    messages.Add(message);
                }

                ViewBag.messageCount = messageCount;

                // Disconnecting from the IMAP server
                client.Disconnect(true);

                // passing the message count to the view
                ViewBag.EmailCount = messageCount;
            }


            // Pass the list of messages to the view
            return View(messages);
        }
    }
}