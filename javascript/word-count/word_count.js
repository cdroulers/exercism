function word_count(s) {
    var words = s.split(/\s+/).filter(function (x) { return x; });
    var results = {};
    words.forEach(function (w) {
        if (results.hasOwnProperty(w)) {
            results[w]++;
        } else {
            results[w] = 1;
        }
    });
    return results;
}

module.exports = word_count;