let buttonJS = document.querySelector("button");
let random = function ColorChanges(max){
    return Math.floor(Math.random() * max)
}
buttonJS.addEventListener('click',()=>{
    let divJS = document.createElement('div')
    divJS.classList.add("divStyle","mb-2");
    let colorsChanges = 'rgb(' + random(255) +','+ random(255) +','+ random(255) + ')';
    divJS.style.backgroundColor = colorsChanges;
    let wrapper = document.querySelector("body")
    wrapper.prepend(divJS);
})