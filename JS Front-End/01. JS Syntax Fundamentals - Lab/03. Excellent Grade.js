function solve(grade){
    if(grade >= 5.50){
        console.log('Excellent');
    } else {
        console.log('Not excellent')
    }
}

let grade = 5.50;
solve(grade);
grade = 5.49;
solve(grade);