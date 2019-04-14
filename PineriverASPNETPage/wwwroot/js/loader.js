$(document).ready(function () {
    document.querySelector(".loader").classList.toggle("loader-inactive");
    var int = setInterval(function () {
        document.querySelector("body").classList.toggle("loading");
        clearInterval(int);
    }, 2500);
    console.log("Loaded");
 });