var file = document.getElementsByClassName("file");

for (var i = 0; i < file.length; i++) {
    file[i].addEventListener("click", function (e) {
        var current = e.target;
        if (current.nodeName == "SPAN") {
            current = current.parentElement;
        }

        var data = [];
        treeTraversal(current, data);
        console.log(data);
        var xhr = new XMLHttpRequest();
        xhr.open('POST', 'Home/SaveData');
        xhr.setRequestHeader('Content-Type', 'application/json');
        xhr.onload = function () {
            if (xhr.status === 200) {
                var info = JSON.parse(data);
            }
        };
        xhr.send(JSON.stringify(data));


    });
};

function treeTraversal(currentElement, object) {
    object.push(currentElement.children[1].innerHTML);
    if (currentElement.children.length < 3) {
        return;
    }

    for (var i = 0; i < currentElement.children.length; i++) {
        if (currentElement.children[i].nodeName === "SPAN") {
            continue;
        }
        treeTraversal(currentElement.children[i], object);
    }

}