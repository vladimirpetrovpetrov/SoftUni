function solve(x1, y1, x2, y2) {
    //Точка 1
    let first = Math.sqrt((0-x1)**2 + (0-y1)**2);
    let check = Number.isInteger(first);
    if(check){
        console.log(`\{${x1}, ${y1}\} to {0, 0} is valid`)
    }else{
        console.log(`\{${x1}, ${y1}\} to {0, 0} is invalid`)
    }
    //Точка 2
    let second = Math.sqrt((0-x2)**2 + (0-y2)**2);
    check = Number.isInteger(second);
    if(check){
        console.log(`\{${x2}, ${y2}\} to {0, 0} is valid`)
    }else{
        console.log(`\{${x2}, ${y2}\} to {0, 0} is invalid`)
    }
    //Точка 3
    let third = Math.sqrt((x2-x1)**2 + (y2-y1)**2);
    check = Number.isInteger(third);
    if(check){
        console.log(`\{${x1}, ${y1}\} to \{${x2}, ${y2}\} is valid`)
    }else{
        console.log(`\{${x2}, ${y2}\} to \{${x2}, ${y2}\} is invalid`)
    }
}

solve(3, 0, 0, 4);
solve(2,1,1,1);