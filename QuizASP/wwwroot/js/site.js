function helyesE(valasz, helyesvalasz, id) {
    var backgroundcolor = document.getElementById(id).style.backgroundColor;
    if (valasz == helyesvalasz) {
        document.getElementById(id).style.backgroundColor = "green";

    } else {
        document.getElementById(id).style.backgroundColor = "red";

    }
    setTimeout(function () { document.getElementById(id).style.backgroundColor = backgroundcolor; }, 1500);
    setTimeout(function () { document.getElementById(id).style.color = "white"; }, 1500);
}
