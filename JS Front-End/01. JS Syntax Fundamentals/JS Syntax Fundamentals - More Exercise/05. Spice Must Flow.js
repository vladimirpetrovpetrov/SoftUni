function solve(yield) {
    let totalExtracted = 0;
    let totalDays = 0;
    while(yield >= 100){
        totalExtracted += yield;
        totalExtracted -= 26;
        yield-=10;
        totalDays++;
        if(yield<100){
            totalExtracted-=26;
        }
    }
    console.log(totalDays);
    console.log(totalExtracted)
}

solve(111);
solve(450);