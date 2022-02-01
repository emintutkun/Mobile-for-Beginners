function Cevir(tx) {
    return parseInt(document.getElementById(tx).value)
}

function Topla() {
    sonuc = Cevir("s1") + Cevir("s2")
    document.getElementById("sonuc").innerHTML = sonuc
}

function Cikar() {
    sonuc = Cevir("s1") - Cevir("s2")
    document.getElementById("sonuc").innerHTML = sonuc
}

function Carp() {
    sonuc = Cevir("s1") * Cevir("s2")
    document.getElementById("sonuc").innerHTML = sonuc
}

function Bol() {
    sonuc = Cevir("s1") / Cevir("s2")
    document.getElementById("sonuc").innerHTML = sonuc
}

//const cikar = ( ) => document.getElementById("sonuc").innerHTML = Cevir("s1") - Cevir("s2") //Cikar() fonksiyonunun diğer kullanımı (15.01.2022 dersi konularından)