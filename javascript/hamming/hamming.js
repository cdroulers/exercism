function hamming(one, two) {
    if (one.length !== two.length) {
        throw new Error('DNA strands must be of equal length.');
    }

    return one.split("").map(function (x, i) {
        return x === two[i];
    }).reduce(function (val, x) {
        return val + (x ? 0 : 1);
    }, 0);
}

module.exports = hamming;