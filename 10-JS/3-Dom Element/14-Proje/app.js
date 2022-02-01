let btnTopla = document.getElementById("add")
let btnCikar = document.getElementById("sub")
let btnCarp = document.getElementById("multiple")
let btnBol = document.getElementById("divide")

var sonuc = document.getElementById("sonuc")

let ilkDeger
let ikinciDeger

function Topla() {
    ilkDeger = parseInt(document.getElementById("ilkDeger").value)
    ikinciDeger = parseInt(document.getElementById("ikinciDeger").value)
    sonuc.innerHTML = "Sonuç : " + Number(ilkDeger + ikinciDeger)
}
function Cikar() {
    ilkDeger = parseInt(document.getElementById("ilkDeger").value)
    ikinciDeger = parseInt(document.getElementById("ikinciDeger").value)
    sonuc.innerHTML = "Sonuç : " + Number(ilkDeger - ikinciDeger)
}
function Bol() {
    ilkDeger = parseInt(document.getElementById("ilkDeger").value)
    ikinciDeger = parseInt(document.getElementById("ikinciDeger").value)
    sonuc.innerHTML = "Sonuç : " + Number(ilkDeger / ikinciDeger)
}
function Carp() {
    ilkDeger = parseInt(document.getElementById("ilkDeger").value)
    ikinciDeger = parseInt(document.getElementById("ikinciDeger").value)
    sonuc.innerHTML = "Sonuç : " + Number(ilkDeger * ikinciDeger)
}

btnTopla.addEventListener("click", Topla)
btnCikar.addEventListener("click", Cikar)
btnCarp.addEventListener("click", Carp)
btnBol.addEventListener("click", Bol)

// function Secim() {
//     switch (buton) {
//         case btnTopla:
//             document.getElementById("sonuc").innerHTML = Topla(ilkDeger, ikinciDeger)
//             break;
//         case btnCikar:
//             document.getElementById("sonuc").innerHTML = Cikar(ilkDeger, ikinciDeger)
//             break;
//         case btnCarp:
//             document.getElementById("sonuc").innerHTML = socumeCarp(ilkDeger, ikinciDeger)
//             break;
//         case btnBol:
//             document.getElementById("sonuc").innerHTML = Bol(ilkDeger, ikinciDeger)
//             break;
//         default:
//             document.getElementById("sonuc").innerHTML = "Geçersiz Buton Değeri"
//             break;
//     }
// }