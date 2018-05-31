var pc = document.getElementsByClassName("PC");
var type = document.getElementsByClassName("type");
var model = document.getElementsByClassName("model");
var plus = document.getElementsByClassName("plus");
var minus;
var child;
for (var i = 0; i < type.length; i++) {
    child = type[i].style.display = "none";
}

for (var i = 0; i < model.length; i++) {
    child = model[i].style.display = "none";
}

for (var i = 0; i < plus.length; i++) {
    plus[i].addEventListener("click", expand);     
};

function expand(e) {
    var current = e.target;
    current.innerHTML = "-";
    current.classList.remove('plus');
    current.classList.add('minus');
    current.removeEventListener("click", expand);

    minus = document.getElementsByClassName("minus");
    for (var i = 0; i < minus.length; i++) {
        minus[i].addEventListener("click", collapse);
    }
    console.log(minus);
    if (current.nodeName == "SPAN") {
        current = current.parentElement;
    }
    for (var i = 2; i < current.children.length; i++) {
        current.children[i].style.display = "block";
        current.children[i].children[0].style.display = "inline-block";
        current.children[i].children[1].style.display = "inline-block";
    }
}

function collapse(e) {
    var current = e.target;
    current.innerHTML = "+";
    current.classList.remove('minus');
    current.classList.add('plus');
    current.removeEventListener("click", collapse);

    plus = document.getElementsByClassName("plus");
    for (var i = 0; i < plus.length; i++) {
        plus[i].addEventListener("click", expand);
    }

    if (current.nodeName == "SPAN") {
        current = current.parentElement;
    }
    for (var i = 2; i < current.children.length; i++) {
        current.children[i].style.display = "none";
        current.children[i].children[0].style.display = "none";
        current.children[i].children[1].style.display = "none";
    }
};