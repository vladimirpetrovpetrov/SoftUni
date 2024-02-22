function solve(string){
    let words = [];

    if(!string.includes(' ')){
        console.log(string.toUpperCase());
        return;
    }

    let wordToAdd = '';
    for (let i = 0; i < string.length; i++) {
        const element = string[i];

        if(!/\W/.test(element) && element !== ' '){
            wordToAdd += element;
        }else{
            if(wordToAdd.length > 0){
                words.push(wordToAdd.toUpperCase());
            }
            wordToAdd = '';
        }
    }
    console.log(words.join(', '));
}
solve('Hi, how are you?');
solve('hello');