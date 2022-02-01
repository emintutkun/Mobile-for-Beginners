function Task1(callback) {
    setTimeout(() => {
        console.log("Görev 1 Bitti!")
        
    }, 5000);
    callback()
}

function Task2() {
    console.log("Görev 2 Bitti!")
}

Task1(Task2)


function Task1(callback) {
//     setTimeout(() => {
//         console.log("Görev 1 Bitti!")
//         callback() // callback, timeout dışına yazılırsa önce task2 çalışır. ama içeride yazılırsa önce task1 çalışır ve iki task de süre doluncaya kadar bekletilir
//     }, 5000);   
// }

// function Task2() {
//     console.log("Görev 2 Bitti!")
// }
// Task1(Task2)
s
