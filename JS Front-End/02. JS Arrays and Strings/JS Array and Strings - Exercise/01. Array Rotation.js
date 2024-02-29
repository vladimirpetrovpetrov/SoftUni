function solve(arr,n) {
    for (let i = 0; i < n; i++){
        let temp = arr.shift();
        arr.push(temp);
    }
    console.log(arr.join(" "))
}

solve([51,47,32,61,21], 2);