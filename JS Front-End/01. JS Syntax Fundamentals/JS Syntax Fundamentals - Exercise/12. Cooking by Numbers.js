function solve(num, opOne, opTwo, opThree, opFour, opFive) {
    let operations = [opOne, opTwo, opThree, opFour, opFive]
    let op = "";
    let parsedInt = parseInt(num);
    for (let i = 0; i < 5; i++) {
        op = operations[i];
        switch (op) {
            case 'chop':
                parsedInt /= 2;
                console.log(parsedInt);
                break;
            case 'dice':
                parsedInt = Math.sqrt(parsedInt);
                console.log(parsedInt);
                break;
            case 'spice':
                parsedInt += 1;
                console.log(parsedInt);
                break;
            case 'bake':
                parsedInt *= 3;
                console.log(parsedInt);
                break;
            case 'fillet':
                parsedInt -= (parsedInt * 0.20);
                console.log(parsedInt);
                break;
            default:
                break;
        }
    }
}

// solve('32', 'chop', 'chop', 'chop', 'chop', 'chop');
solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet');