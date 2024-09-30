/***************************************
 * CIS213: Unit 3, Guided Practice 1
 * Author: Ruben Thomas
 * Date: 7.12.2024
 */
"use strict"
function populateInfo() {
    if (location.search) {
        var greeting = location.search;
        greeting = greeting.replace(/\+/g, " "); 
        greeting = greeting.substring(greeting.lastIndexOf("=") + 1);
        document.getElementById("greetingtext").innerHTML =
            decodeURIComponent(greeting);
    }
}

if (window.addEventListener) {
    window.addEventListener("load", populateInfo, false);
}

else if (window.attachEvent) {
    window.attachEvent("onload", populateInfo);
}