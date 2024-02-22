function solve(num) {
    let result = 0;
    while (num > 0) {
        result += num % 10;
        num /= 10;
        num = parseInt(num)
        
    }
    console.log(result);
}


solve(245678);
solve(97561);
solve(543);