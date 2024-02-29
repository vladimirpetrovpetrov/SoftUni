function solve(input,toReplace) {
    let symbol = '*';
    let replacement = symbol.repeat(toReplace.length);
    input = input.replace(toReplace,replacement);
    while(input.includes(toReplace)){
        input = input.replace(toReplace,replacement);
    }
    console.log(input);
}

solve('A small sentence with some words', 'small')
solve('Find the hidden word', 'hidden')