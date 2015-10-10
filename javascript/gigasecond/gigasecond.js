var Gigasecond = function(birthDate) {
    this.birthDate = birthDate;
};

Gigasecond.prototype.date = function() {
    var result = new Date(this.birthDate.getTime());
    result.setSeconds(result.getSeconds() + Math.pow(10, 9));
    result.setHours(0, 0, 0);
    return result;
};


module.exports = Gigasecond;