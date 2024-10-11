function AddRow(){
    var row = document.querySelector(".row").cloneNode(true);
    var table = document.querySelector("#table");
    table.appendChild(row);
}

function DeleteRow(button){
    button.parentElement.remove();
}

function MoveUp(button){
    let obj = button.parentElement.previousElementSibling;
    if (obj){
        button.parentElement.after(obj);
    }
}

function MoveDown(button){
    let obj = button.parentElement.nextElementSibling;
    if(obj){
        button.parentElement.before(obj);
    }
}

function Save(){
    let input_1 = document.querySelectorAll(".input1");
    let input_2 = document.querySelectorAll(".input2");

    var a = []
    for (var i = 1; i < input_1.length; i++){
        a.push(input_1[i].value + " : " + input_2[i].value);
    }
    a = JSON.stringify(a);
    a = '{' + a.slice(1, a.length - 1) + '}';

    let outputDiv = document.querySelector("#output");
    outputDiv.innerHTML = a;
}
