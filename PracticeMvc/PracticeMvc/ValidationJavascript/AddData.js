function ValidateAll() {
    var valid = true
    if (!ValidateName()) valid = false
    return valid;
}

function ValidateName()
{
    var val = document.getElementById('Name');
    if (val.value == 0 || val.value == null) {
        alert("Please enter the name");
        document.getElementById("Name")

        val.focus();
        return false;
    }
    else {
        
        return true;
    }
}