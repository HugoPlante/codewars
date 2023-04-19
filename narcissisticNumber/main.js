function narcissistic(number) {
    let digits = number.toString().split('');
    let sum = 0;
    digits.map((digit) => {
        sum += Math.pow(digit, digits.length);
    });
    return sum === number;
}
