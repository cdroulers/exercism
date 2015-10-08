function isLeapYear(input) {
    return (!isDivisibleBy(input, 100) || isDivisibleBy(input, 400)) && isDivisibleBy(input, 4);
}

function isDivisibleBy(number, divisor) {
    return number % divisor === 0;
}

module.exports = isLeapYear;