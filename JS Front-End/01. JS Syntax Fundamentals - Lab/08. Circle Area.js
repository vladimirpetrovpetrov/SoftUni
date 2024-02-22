function solve(arg){
    let typeOfTheArg = typeof(arg);
    if(typeOfTheArg == 'number'){
        console.log((Math.PI * arg**2).toFixed(2));
    }else{
        console.log(`We can not calculate the circle area, because we receive a ${typeOfTheArg}.`)
    }
}

solve(5);
solve('name')