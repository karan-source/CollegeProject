// verify at login

var loginEmail = document.getElementById("login-email");
var loginPassword = document.getElementById("login-password");

var loginButton = document.getElementById("login-btn");

loginButton.addEventListener('click', function () {


    if (loginEmail.value == "") {
        validations("email-required");

    } else if (loginPassword.value == "") {
        document.getElementById("email-required").style.display = "none";
        validations("password-required");

    } else {

        document.getElementById("email-required").style.display = "none";
        document.getElementById("password-required").style.display = "none";

        $(document).ready(function () {

            var jsondata = new FormData();
            jsondata.append("Email", loginEmail.value);
            jsondata.append("Password", loginPassword.value);

            $.ajax({
                url: "/Home/Login",
                method: "POST",
                data: jsondata,
                contentType: false,
                cache: false,
                processData: false,
                dataType: 'json',
                success: function (data) {
                    if (data == 1) {
                        alert("Login Successful");
                        window.location.href = "/Home/Index";
                    } else {
                        validations("credentials-matching");
                    }
                },
                error: function (errMsg) {
                    alert(JSON.stringify(errMsg));
                }
            });
        });

    }

    function validations(elementId) {
        document.getElementById(elementId).style.display = "block";
    }

});


