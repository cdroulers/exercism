var PhoneNumber = function (n) {
    var cleanNumber = n.replace(/[^\d]/g, "");
    if (cleanNumber.length === 11 && cleanNumber[0] === "1") {
        this._countryCode = cleanNumber[0];
        cleanNumber = cleanNumber.slice(1);
    }

    if (cleanNumber.length === 10) {
        this._number = cleanNumber;
    }
    else {
        this._number = "0000000000";
    }

    this._areaCode = cleanNumber.slice(0, 3);
    this._firstPart = cleanNumber.slice(3, 6);
    this._secondPart = cleanNumber.slice(6);
}

PhoneNumber.prototype.number = function () {
    return this._number;
}

PhoneNumber.prototype.areaCode = function () {
    return this._areaCode;
}

PhoneNumber.prototype.toString = function () {
    return `(${ this._areaCode }) ${ this._firstPart }-${ this._secondPart }`;
}

module.exports = PhoneNumber;