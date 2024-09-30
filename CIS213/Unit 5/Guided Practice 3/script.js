/*
CIS213: Unit 5, Guided Practice 3
Author: Ruben Thomas
Date: 7.18.2024
*/
var delivrInfo = {}; //declare delivrInfo as an empty object
var delivSummary = document.getElementById("deliveryTo")
var foodInfo = {}; 
var foodSummary = document.getElementById("order");

function processDeliveryInfo() {
    var prop;
    delivrInfo.name = document.getElementById("name").value;
    delivrInfo.address = document.getElementById("address").value;
    delivrInfo.city = document.getElementById("city").value;
    delivrInfo.email = document.getElementById("email").value;
    delivrInfo.phone = document.getElementById("phone").value;

    //loop to add all the properties to the delivery summary panel
    for (prop in delivrInfo) {
        delivSummary.innerHTML += "<p>" + delivrInfo[prop] + "</p>";
    }
    document.getElementById("deliveryTo").style.display = "block";
}

function processFood() {
    var prop;
    var crust = document.getElementsByName("crust");
    var toppings = [];
    var toppingBoxes = document.getElementsByName("toppings")
    var instr = document.getElementById("instructions").value;

    if (crust[0].checked) {
        foodInfo.crust = crust[0].value;
    }
    else {
        foodInfo.crust = crust[1].value;
    }

    foodInfo.size = document.getElementById("size").value;

    for (var i = 0; i < 5; i++) {
        if (toppingBoxes[i].checked) {
            toppings += toppingBoxes[i].value + ", ";
        }
    }
    foodInfo.toppings = toppings;

    if (instr.value) {
        foodInfo.instructions = instr.value;
    }

    foodSummary.innerHTML = "<p><span>Crust:</span> " + foodInfo.crust + "</p>";
    foodSummary.innerHTML += "<p><span>Size:</span> " + foodInfo.size + "</p>";
    foodSummary.innerHTML += "<p><span>Toppings:</span> " + foodInfo.toppings + "</p>";
    foodSummary.innerHTML += "<p>Instructions:</p>";
    document.getElementById("order").style.display = "block";
}

function previewOrder() {
    document.getElementById("previewBtn").style.display = "none";
    processDeliveryInfo();
    processFood();
}

function createEventListener() {
    var previewBtn = document.getElementById("previewBtn");
    if (previewBtn.addEventListener) {
        previewBtn.addEventListener("click", previewOrder, false);
    }
    else if (previewBtn.attachEvent) {
        previewBtn.attachEvent("onclick", previewOrder);
    }
}

if (window.addEventListener) {
    window.addEventListener("load", createEventListener, false);
}
else if (window.attachEvent) {
    window.attachEvent("onload", createEventListener);
}

