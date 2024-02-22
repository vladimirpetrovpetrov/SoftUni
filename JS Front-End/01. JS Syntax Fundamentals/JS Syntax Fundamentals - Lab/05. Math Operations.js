function solve(n,m,operator) {
    if(operator == '+'){
        console.log(n+m);
    }else if (operator == '-') {
        console.log(n-m);
    }else if (operator == '*') {
        console.log(n*m);
    }else if (operator == '/') {
        console.log(n/m);
    }else if (operator == '%') {
        console.log(n%m);
    }else if (operator == '**') {
        console.log(n**m);
    }else{
        console.log('Error!');
    }
}

solve(5,6,'+');
solve(3,5.5,'*');