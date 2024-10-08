/*
CIS213 Unit 4, Guided Practice 3
Author: Ruben Thomas
Date: 7.16.2024
*/

"use strict"

function processStorage() {
    if (document.getElementById("rememberinput").checked) { 
        sessionStorage.username =
    document.getElementById("usernameinput").value;
    }
}

function populateInfo() {
    if (sessionStorage.username) {
        document.getElementById("usernameinput").value =
        sessionStorage.username;
    }
}

function handleSubmit(evt) {
    if (evt.preventDefault) {
        evt.preventDefault();
    }
    else {
        evt.returnValue = false;
    }

    processStorage();
    document.getElementsByTagName("form")[0].submit();
}

function createEventListener() {
    var loginForm = document.getElementsByTagName("form")[0]; 
    if (loginForm.addEventListener) {
        loginForm.addEventListener("submit", handleSubmit, false);
    }

    else if (loginForm.attachEvent) {
        loginForm.attachEvent("onsubmit", handleSubmit);
    }
}

function setUpPage() {
    populateInfo();
    createEventListener();
}

if (window.addEventListener) {
    window.addEventListener("load", setUpPage, false);
}

else if (window.attachEvent) {
    window.attachEvent("onload", setUpPage);
}
