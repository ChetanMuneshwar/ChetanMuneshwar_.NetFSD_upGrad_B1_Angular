let correctUsername = "admin";
let correctPassword = "1234";

let attempts = 0;
let maxAttempts = 3;

while (attempts < maxAttempts) {

    let username = prompt("admin");
    let password = prompt("1234");

    if (username === correctUsername && password === correctPassword) {
        console.log("Login Successful!");
        break;
    } else {
        attempts++;
        console.log("Invalid credentials. Attempts left: " + (maxAttempts - attempts));
    }
}