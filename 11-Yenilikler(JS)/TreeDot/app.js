let x = [10,20,30]
console.log(x)

y = [...x, 50] //Three dots mevcut dizie ekleme yapar
console.log(y)

let a = [10,20,30,40]
a = [...a, ...a.filter(x => x < 20)]
console.log(a)

akucuk20 = a.filter(x => x < 20)
console.log(akucuk20)

bos = []
console.log(bos)

bos1 = {name : [{ad : "Abdullah", medeniHal : "Bekar", meslek : "Öğrenci"}, {ad : "Recep", medeniHal : "Bilinmiyor", meslek : "Kaldırım Mühendisi"},
                 {ad : "Emin", medeniHal : "Boşanmış", meslek : "Balici"}, {ad : "Semi", medeniHal : "Evli", meslek : "Doblocu"}],
        soyad : ["USLU", "BALCI", "TUTKUN", "AVCI"]}
//console.log(bos1)

for(let k in bos1.name){
    console.log(bos1.name[k].ad + " " +  bos1.soyad[k] + " " + bos1.name[k].medeniHal + " " + bos1.name[k].meslek)
}
    

ogrenciler = [{id : 1, name : "Recep", soyad : "BALCI"},
              {id : 2, name : "Abdullah Halid", soyad : "USLU"}]

for(let i in ogrenciler){
    console.log(ogrenciler[i].id + " " + ogrenciler[i].name + " " + ogrenciler[i].soyad)
}              
//console.log(ogrenciler)

yogrenci = {id : 3, name : "Ahmet", soyad : "YILMAZ"}
ogrenciler = [...ogrenciler, yogrenci]

console.log(ogrenciler)

