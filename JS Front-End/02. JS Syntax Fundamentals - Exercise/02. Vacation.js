function solve(count, type, day) {
    let price;

    switch (type) {
        case 'Students':
            if (day == 'Friday') {
                price = 8.45 * count;
            } else if (day == 'Saturday') {
                price = 9.80 * count;
            } else if (day == 'Sunday') {
                price = 10.46 * count;
            } else {
                break;
            }

            if(count>=30){
                price *= 0.85;
            }
            break;
        case 'Business':
            if(count>=100){
                count -= 10;
            }
            if (day == 'Friday') {
                price = 10.90 * count;
            } else if (day == 'Saturday') {
                price = 15.60 * count;
            } else if (day == 'Sunday') {
                price = 16.00 * count;
            } else {
                break;
            }
            if(count>=100){
                price *= 0.85;
            }
            break;
        case 'Regular':
            if (day == 'Friday') {
                price = 15.00 * count;
            } else if (day == 'Saturday') {
                price = 20.00 * count;
            } else if (day == 'Sunday') {
                price = 22.50 * count;
            } else {
                break;
            }
            if(count >= 10 && count <= 20){
                price *= 0.95;
            }
            break;
        default:
            break;
    }
    console.log(`Total price: ${price.toFixed(2)}`)
}

solve(30,'Students','Sunday')
solve(40,'Regular','Saturday')