$(document).ready(function () {
    $("#SignUpButton").click(SignUp);
});

function SignUp() {
    var firstNameText = $("#inputFirstName").val();
    var lastNameText = $("#inputLastName").val();
    var emailText = $("#inputEmail").val();
    var passwordText = $("#inputPassword").val();
    var confirmPassText = $("#inputPasswordConfirm").val();

    $.ajax({
        method: "POST",
        url: "Global/SignUp",
        data: { firstName: firstNameText, lastName: lastNameText, email: emailText, password: passwordText },
        success: function (result) {
            if (result) {
                window.location = "../" + result;
            }
            else {
                alert("Sign Up failed.");
            }
        }
    });

    return false;
}
