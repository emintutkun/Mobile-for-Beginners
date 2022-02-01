function myDisplay(some) {
    document.getElementById("demo").innerHTML = some
}

let myPromise = new Promise(function (resolve, reject){
    let a = 5
    let b = 6
    let x = a + b
    if(x == 11){
        resolve("OK")
    }else{
        reject("Error")
    }
})

myPromise.then(
    function(value){myDisplay(value)},
    function(error){myDisplay(error)}
)

