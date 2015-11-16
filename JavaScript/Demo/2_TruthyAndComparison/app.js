(function init() {

    // Truthyness
    function checkForTruthy(value) {
        if (value) {
            return true;
        }
        return false;
    }

    document.getElementById('falseTest').innerHTML = checkForTruthy(false);
    document.getElementById('nullTest').innerHTML = checkForTruthy(null);
    document.getElementById('undefinedTest').innerHTML = checkForTruthy(undefined);
    document.getElementById('emptyStringTest').innerHTML = checkForTruthy('');
    document.getElementById('zeroTest').innerHTML = checkForTruthy(0);
    document.getElementById('naNTest').innerHTML = checkForTruthy(NaN);
    document.getElementById('trueAsString').innerHTML = checkForTruthy('true');
    document.getElementById('trueAsValue').innerHTML = checkForTruthy(true);
    document.getElementById('trueAsNumber').innerHTML = checkForTruthy(1);
    document.getElementById('trueAsNumberString').innerHTML = checkForTruthy('1');

    function loseCompare(val1, val2) {
        if (val1 == val2) {
            return 'are equal';
        }
        return 'not equal';
    }

    function strictCompare(val1, val2) {
        if (val1 === val2) {
            return 'are equal';
        }
        return 'not equal';
    }

    document.getElementById('loseCompareResult').innerHTML = loseCompare('5', 5);
    document.getElementById('strictCompareResult').innerHTML = strictCompare('5', 5);
    document.getElementById('bothStringCompareResult').innerHTML = strictCompare('5', '5');
    document.getElementById('bthNumericCompareResult').innerHTML = strictCompare(5, 5);
})();