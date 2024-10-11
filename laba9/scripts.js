var mainText;
var bgText;
var pressedButton;
var currentValue;
var currentOperation;

function Initialization(){
    mainText = document.getElementById('mainText');
    bgText = document.getElementById('bgText');
}

function AddSymbol(number, button) {
    if (currentOperation == '='){
        mainText.textContent = '';
        currentOperation = null;
    }

    if (mainText.textContent == '0' && number != '.'){
        mainText.textContent = 'error';
        bgText.textContent = '';
        currentOperation = '=';
    }
    else if (mainText.textContent == '' && number == '.'){
        mainText.textContent = '0' + number;
    }
    else{
        mainText.textContent += number;
    }
    AddBorder(button);
}

function Clear(button){
    mainText.textContent = '';
    AddBorder(button);
}

function RemoveLastSymbol(button){
    let newValue = mainText.textContent;
    newValue = newValue.substring(0, newValue.length - 1);
    mainText.textContent = newValue;
    AddBorder(button);
}

function PressCalculateButton(button){
    mainText.textContent = CalculateNewCurrentValue();
    bgText.textContent = '';
    currentOperation = '=';
    AddBorder(button);
}

function CalculateNewCurrentValue() {
    switch (currentOperation)
    {
        case '+':
            return currentValue + GetNewCurrentValue();
        case '-':
            return currentValue - GetNewCurrentValue();
        case '*':
            return currentValue * GetNewCurrentValue();
        case '/':
            return currentValue / GetNewCurrentValue();
        default:
            return currentValue
    }
}

function AddBorder(button){
    if (pressedButton)
        pressedButton.style.boxShadow = 'none';
    button.style.boxShadow = '1px 1px 1px #76b3d8, -1px -1px 1px #76b3d8';
    pressedButton = button;
}

function PressOperationButton(operation, button){
    SetCurrentValue();
    currentOperation = operation;
    bgText.textContent = currentValue + currentOperation;
    mainText.textContent = '';
    AddBorder(button);
}

function SetCurrentValue(){
    currentValue = Number(document.getElementById('mainText').textContent);
}

function GetNewCurrentValue(){
    SetCurrentValue();
    return currentValue;
}