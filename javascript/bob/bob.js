var Bob = function() {};

Bob.prototype.hey = function(input) {
    if (this.isSilence(input)) {
        return "Fine. Be that way!";
    }

    if (this.isYelling(input)) {
        return "Woah, chill out!";
    }

    if (this.isQuestion(input)) {
        return "Sure.";
    }

    return "Whatever.";
};

Bob.prototype.isYelling = function (input) {
    return input.toUpperCase() === input && /[A-Z]+/.test(input);
}

Bob.prototype.isSilence = function (input) {
    return /^\s*$/.test(input);
}

Bob.prototype.isQuestion = function (input) {
    return input.indexOf("?") === input.length - 1;
}

module.exports = Bob;
