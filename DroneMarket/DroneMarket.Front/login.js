document.getElementById("signin-btn").addEventListener("click", function() {
    var emailInput = document.getElementById("email").value;
    var passwordInput = document.getElementById("password").value;
    
    if (passwordInput === "yourpassword" && emailInput === "someone@gmail.com") {
        window.location.href = "index.html"; 
    } else {
        var errorMessage = document.getElementById("error-message");
        errorMessage.style.display = "block"; 
    }
});
