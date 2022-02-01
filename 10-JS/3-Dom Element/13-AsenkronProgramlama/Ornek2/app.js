async function Task1() {
   await setTimeout(() => {
        console.log("Görev 1 Bitti!")
    }, 5000);
}

async function Task2() {
    await console.log("Görev 2 Bitti!")
}

async function AllTasks() {
    await Task1()
    await Task2()
}

AllTasks()



