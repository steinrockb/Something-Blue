$(document).ready(function () {

    $("#signInButton").click(signIn);
});

function signIn() {

    var emailText = $("#InputEmail").val();
    var passwordText = $("#InputPassword").val();

    $.ajax({
        method: "POST",
        url: "Global/LoginUser",
        data: { email: emailText, password: passwordText },
        success: function (result) {
            if (result.includes("Error")) {
                alert("Invalid username/password");
            }
            else {
                window.location = "../" + result;
            }
        }
    });

    return false;
}
