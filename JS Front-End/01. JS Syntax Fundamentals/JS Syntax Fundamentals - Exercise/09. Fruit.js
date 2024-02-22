function solve(fruit,grams,pricePerKg) {
    let weightInKg = grams / 1000;
    let price = weightInKg * pricePerKg;    
    let roundedPrice = price.toFixed(2);

    console.log(`I need $${roundedPrice} to buy ${weightInKg.toFixed(2)} kilograms ${fruit}.`)
}

solve('orange', 2500, 1.80);
solve('apple', 1563, 2.35);