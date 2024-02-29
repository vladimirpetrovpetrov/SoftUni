function solve(inputString, startIndex, count) {
    const result = inputString.substring(startIndex, startIndex + count);
    console.log(result);
}

solve('ASentence', 1, 8);
solve('SkipWord', 4, 7);