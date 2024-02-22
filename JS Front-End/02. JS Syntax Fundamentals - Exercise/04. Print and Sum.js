function solve(start,end) {
    let sum = 0;
    let message = "";
    for (let i = start; i <= end; i++) {
        sum+=i;
        if(i==end){
            message+=`${i}`;
        }else{
            message+=`${i} `;
        }
    }
    console.log(message);
    console.log(`Sum: ${sum}`)
}

solve(5,10);
solve(0,26);
solve(50,60);