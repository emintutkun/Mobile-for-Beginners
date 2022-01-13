let value
const drinks =document.querySelector(".list-group")
const cay = document.querySelector(".list-group-item:nth-child(2)")

value = drinks
//value = cay
//value = drinks.childNodes //text dahil
value = drinks.children //yalnızca elementler
value = drinks.children[0]
value = drinks.firstElementChild
value = drinks.lastElementChild
value = drinks.children.length
value = drinks.childElementCount
value = drinks.children[1].textContent ="Yeşil Çay"

const container = document.querySelector("thead").children[0].children[0].textContent= "Meksika"
value = container
value = drinks.parentElement.parentElement.parentElement

//value = drinks.children[1]
//value = drinks.children[1].previousElementSibling
//value = drinks.children[1].nextElementSibling


console.log(value)