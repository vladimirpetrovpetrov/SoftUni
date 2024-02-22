function solve(numOne, operator, numTwo) {
    let result;
    switch (operator) {
        case '+':
            result = numOne + numTwo;
            console.log(result.toFixed(2))
            break;
        case '-':
            result = numOne - numTwo;
            console.log(result.toFixed(2))
            break;
        case '/':
            result = numOne / numTwo;
            console.log(result.toFixed(2))
            break;
        case '*':
            result = numOne * numTwo;
            console.log(result.toFixed(2))
            break;

        default:
            break;
    }
}

solve(5, '+', 10);
solve(25.5, '-', 3);