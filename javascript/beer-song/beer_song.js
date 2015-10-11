var format = "_number_ bottles of beer on the wall, _number_ bottles of beer.\nTake one down and pass it around, _nextnumber_ bottles of beer on the wall.\n";
var format2 = "2 bottles of beer on the wall, 2 bottles of beer.\nTake one down and pass it around, 1 bottle of beer on the wall.\n";
var format1 = "1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.\n";
var format0 = "No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.\n";

var formats = {
    0: format0,
    1: format1,
    2: format2
}

function verse(number) {
    if (formats[number]) {
        return formats[number];
    }

    return format.replace(/_number_/g, number).replace(/_nextnumber_/g, number - 1);
}

function sing(begin, end) {
    var results = [];
    end = end ? end : 0;
    for (var i = begin; i >= end; i--) {
        results.push(verse(i));
    }
    return results.join("\n");
}

module.exports.verse = verse;
module.exports.sing = sing;