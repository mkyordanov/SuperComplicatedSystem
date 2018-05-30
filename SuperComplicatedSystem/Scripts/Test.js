var pc = document.getElementsByClassName("PC");
console.log(pc);
var type = document.getElementsByClassName("type");
var child;
for (var i = 0; i < type.length; i++) {
    child = type[i].firstElementChild.style.display = "none";
}

var model = document.getElementsByClassName("model");
for (var i = 0; i < model.length; i++) {
    child = model[i].firstElementChild.style.display = "none";
}
console.log(pc);
for (var i = 0; i < pc.length; i++) {
    console.log(pc[i]);
    pc[i].addEventListener("click", function (e) {
        var current = e.target;
        var cl = current.getAttribute("class").split(" ");
        var a;
        for (var i = 0; i < pc.length; i++) {
            if (Number(pc[i].getAttribute("class").split(" ")[0]) === Number(cl[0])) {
                a = pc[i];
                break;
            }
        }
        for (var i = 0; i < a.children.length; i++) {
            //console.log(a.children[i]);
            //console.log(a.children[i].getAttribute("class").split(" ")[1]);
            //console.log(cl);
            //console.log(a.children[i].getAttribute("class").split(" ")[1]);
            //console.log(cl[1] === "name" && a.children[i].getAttribute("class").split(" ")[1] === "type")
            //console.log();
            //if (cl[1] === "name" && a.children[i].getAttribute("class").split(" ")[1] === "type") {
            //    console.log(a.children[i].firstElementChild);
            //    a.children[i].firstElementChild.style.display = "block";
            //}
            //else if (cl[1] === "type" && a.children[i].getAttribute("class").split(" ")[1] === "model") {
            //    console.log(a.children[i].firstElementChild);
            //    a.children[i].firstElementChild.style.display = "block";
            //}

            if (a.children[i].getAttribute("class").split(" ")[1] === "type") {
                console.log(a.children[i].firstElementChild);
                a.children[i].firstElementChild.style.display = "block";
            }
            //else if (a.children[i].getAttribute("class").split(" ")[1] === "model") {
            //    console.log(a.children[i].firstElementChild);
            //    a.children[i].firstElementChild.style.display = "block";
            //}
        }
    })
}

