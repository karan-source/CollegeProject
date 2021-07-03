// Sign Up credentials

var signUpEmail = document.getElementById("sign-up-email");
var signUpPassword = document.getElementById("sign-up-password");
var confirmPassword = document.getElementById("confirm-password");
var signUpButton = document.getElementById("sign-up-btn");

var passw = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,20}$/;

signUpButton.addEventListener('click', function () {

    debugger

    if (signUpEmail.value == "") {
        validations("email-required");

    } else if (signUpPassword.value == "") {
        validations("password-required");

    } else if (signUpPassword.value.length < 8) {
        document.getElementById("password-required").innerHTML = "Password length should be greater than 8";
        validations("password-required");

    } else if (!signUpPassword.value.match(passw)) {
        document.getElementById("password-required").innerHTML = "Password must contain alpha-numeric characters";
        validations("password-required");

    } else if (confirmPassword.value == "") {
        validations("confirm-required");

    } else if (signUpPassword.value != confirmPassword.value) {
        document.getElementById("confirm-required").innerHTML = "Password not matching";
        validations("confirm-required");
        okValidations("email-required");
        okValidations("password-required");

    } else {

        okValidations("email-required");
        okValidations("password-required");
        okValidations("confirm-required");

        $(document).ready(function () {

            var jsondata = new FormData();
            jsondata.append("Email", signUpEmail.value);
            jsondata.append("Password", signUpPassword.value);

            $.ajax({
                url: "/Home/SignUp",
                method: "POST",
                data: jsondata,
                contentType: false,
                cache: false,
                processData: false,
                dataType: 'json',
                success: function (data) {
                    if (data == 1) {
                        alert("Sign Up Done");
                        window.location.href = "/Home/Login";
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

    function okValidations(elementId) {
        document.getElementById(elementId).style.display = "none";
    }

});