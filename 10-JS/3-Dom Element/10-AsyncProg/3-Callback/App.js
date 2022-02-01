function task1(callback) {
    setTimeout(() => {
        console.log("Görev Bitti")
        callback()
    }, 5000)
}
function task2() {
    console.log("Görev 2 Bitti")
}
task1(task2)

