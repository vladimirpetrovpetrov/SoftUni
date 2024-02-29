function solve(n, array) {
    let newArr = [];
    newArr.length = n;
    for (let i = 0; i < n; i++) {
        newArr[newArr.length - 1 - i] = array[i];
    }
    let result = "";
    for (let i = 0; i < newArr.length; i++) {
        result = result + (newArr[i] + " ");
    }
    console.log(result)
}

solve(3, [10, 20, 30, 40, 50]);
solve(4, [-1, 20, 99, 5]);
solve(2, [66, 43, 75, 89, 47]);