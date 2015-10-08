var DnaTranscriber = function() {};

DnaTranscriber._dnaToRnaMap = {
    "G": "C",
    "C": "G",
    "T": "A",
    "A": "U"
};

DnaTranscriber._rnaToDnaMap = {
    "C": "G",
    "G": "C",
    "A": "T",
    "U": "A"
}

DnaTranscriber.prototype._transcribe = function(input, map) {
    var result = "";
    for (var i = 0; i < input.length; i++) {
        result += map[input[i]];
    }
    return result;
}

DnaTranscriber.prototype.toRna = function(input) {
    return this._transcribe(input, DnaTranscriber._dnaToRnaMap);
}

DnaTranscriber.prototype.toDna = function(input) {
    return this._transcribe(input, DnaTranscriber._rnaToDnaMap);
}

module.exports = DnaTranscriber;