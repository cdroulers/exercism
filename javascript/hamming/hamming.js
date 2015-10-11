function hamming(one, two) {
    if (one.length !== two.length) {
        throw new Error('DNA strands must be of equal length.');
    }

    return one.split("").reduce(function (val, x, i) {
        return val + (x === two[i] ? 0 : 1);
    }, 0);
}

module.exports = hamming;