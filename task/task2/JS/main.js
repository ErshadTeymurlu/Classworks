let inputs = document.querySelectorAll("input")
let button = document.querySelector("button")
button.addEventListener('change',()=>{
    for(let i= 0; i<inputs.length;i++){
        console.log(inputs[i].value);
    }
})           