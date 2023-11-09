using System;


namespace RelationshipFluentApi_Final.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string ProfileName { get; set; }
        public string Description { get; set; }
        public User user { get; set; } // Cascade Principle
    }
}