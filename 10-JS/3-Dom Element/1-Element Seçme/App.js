let element
// var element
element = document.getElementById("ok")
element = document.getElementById("ipt")
element = document.getElementsByClassName("list-group-item")
element = document.getElementsByClassName("list-group-item")[0]
element = document.getElementsByTagName("li")


//query selector il bulduğu dom
element = document.querySelector("#drinks") //id bazında
element = document.querySelector("#ok")
element = document.querySelector(".list-group-item")//ilk list goup
element = document.querySelector(".list-group")
element = document.querySelector("li")

//queryselectorall dom
element = document.querySelectorAll("list-group-item")//tüm list group
element.forEach(function(el){
    console.log(el)
})

console.log(element)