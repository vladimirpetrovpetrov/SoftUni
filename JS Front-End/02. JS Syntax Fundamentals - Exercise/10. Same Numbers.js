function solve(num) {
    let sum = 0;
    let isTrue = true;
    let lastDigit;
    let temp = num % 10;
    while(num>0){
        lastDigit = num % 10;
        if(temp != lastDigit){
            isTrue = false;
        }
        temp = lastDigit;
        sum += lastDigit;
        num = parseInt(num/10);
    }
    console.log(isTrue)
    console.log(sum);
}

solve(2222222);
solve(1234);

