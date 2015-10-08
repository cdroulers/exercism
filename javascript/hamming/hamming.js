function hamming(one, two) {
    if (one.length !== two.length) {
        throw new Error('DNA strands must be of equal length.');
    }

    var distance = 0;
    for (var i = 0; i < one.length; i++) {
        distance += one[i] === two[i] ? 0 : 1;
    }

    return distance;
}

module.exports = hamming;