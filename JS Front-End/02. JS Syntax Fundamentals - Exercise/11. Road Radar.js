function solve(speed, zone) {
    switch (zone) {
        case 'residential':
            let speedLimitRes = 20;
            if (speed >= 0 && speed <= speedLimitRes) {
                console.log(`Driving ${speed} km/h in a ${speedLimitRes} zone`)
            } else {
                let difference = speed - speedLimitRes;
                let cause = "";
                if (difference <= 20) {
                    cause = 'speeding';
                }
                else if (difference > 20 && difference <= 40) {
                    cause = 'excessive speeding';
                } else {
                    cause = 'reckless driving'
                }

                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedLimitRes} - ${cause}`)
            }
            break;
        case 'city':
            const speedLimitCity = 50;
            if (speed >= 0 && speed <= speedLimitCity) {
                console.log(`Driving ${speed} km/h in a ${speedLimitCity} zone`)
            } else {
                let difference = speed - speedLimitCity;
                let cause = "";
                if (difference <= 20) {
                    cause = 'speeding';
                }
                else if (difference > 20 && difference <= 40) {
                    cause = 'excessive speeding';
                } else {
                    cause = 'reckless driving'
                }

                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedLimitCity} - ${cause}`)
            }
            break;
        case 'interstate':
            const speedLimitState = 90;
            if (speed >= 0 && speed <= speedLimitState) {
                console.log(`Driving ${speed} km/h in a ${speedLimitState} zone`)
            } else {
                let difference = speed - speedLimitState;
                let cause = "";
                if (difference <= 20) {
                    cause = 'speeding';
                }
                else if (difference > 20 && difference <= 40) {
                    cause = 'excessive speeding';
                } else {
                    cause = 'reckless driving'
                }

                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedLimitState} - ${cause}`)
            }
            break;
        case 'motorway':
            
            const speedLimitHw = 130;
            if (speed >= 0 && speed <= speedLimitHw) {
                console.log(`Driving ${speed} km/h in a ${speedLimitHw} zone`)
            } else {
                let difference = speed - speedLimitHw;
                let cause = "";
                if (difference <= 20) {
                    cause = 'speeding';
                }
                else if (difference > 20 && difference <= 40) {
                    cause = 'excessive speeding';
                } else {
                    cause = 'reckless driving'
                }

                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedLimitHw} - ${cause}`)
            }
            break;
        default:
            break;
    }
}

solve(40, 'city');
solve(21, 'residential');
solve(120, 'interstate');
solve(200, 'motorway');
