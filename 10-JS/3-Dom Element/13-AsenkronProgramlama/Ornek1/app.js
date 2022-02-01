function Task1() {
    setTimeout(() => {
        console.log("Görev 1 Bitti!")
    }, 5000);
}

function Task2() {
    console.log("Görev 2 Bitti!")
}

Task1()
Task2()

//Bu örnekte ilk olarak Task2 yazılır. 5 sn sonra Task1 ekrana yazılır.

