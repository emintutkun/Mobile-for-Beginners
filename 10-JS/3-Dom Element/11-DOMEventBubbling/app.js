//Bu yöntem de aşağıdakilerden haerhangi bir elemente tıklandığında diğerlerine de tıklanmış gibi olur
document.getElementById("entryhead" ).addEventListener("click", function (e) {
    console.log("H3 Entry")
  } )
  
  document.querySelector(".row" ).addEventListener("click", function (e) {
    console.log("row")
  } )
  
  document.querySelector(".container" ).addEventListener("click", function (e) {
    console.log("container")
  } )