async function task1() {
    await setTimeout(() => {
        console.log("Görev Bitti")
    },5000)
}
async function task2() {
    console.log("Görev 2 Bitti")
}

async function allTask2() {
    await task1()
    await task2()
}
allTask2()
