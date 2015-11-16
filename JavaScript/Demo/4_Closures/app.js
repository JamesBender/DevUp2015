(function init() {
    //'this' - method invocation, function invocation, constructor invocation, apply invocation

    //method invocation - 'this' bound to object
    var myObject = {
        value: 0,
        increment: function(inc){
            this.value += typeof inc === 'number' ? inc : 1;
        }
    };

    myObject.increment();
    document.writeln(myObject.value + '<br\>');
    myObject.increment(3);
    document.writeln(myObject.value + '<br\>');


    //function invocation - 'this' bound to global

    function add(x, y) {
        return x + y;
    };

    myObject.double = function(){
        var that = this;

        var helper = function(){
            that.value = add(that.value, that.value);
        };

        helper();
    };

    //myObject.double();
    //document.writeln(myObject.value);

    //constructor invocation - 'this' bound to the object that is created (it's prototype)
    var Mood = function(currentMoode){
        this.mood = currentMoode;
    };

    Mood.prototype.getMood = function () {
        return this.mood;
    };


    var myMood = new Mood('happy');
    var yourMood = new Mood('super happy');
    var theirMood = new Mood('super duper happy');

    var moods = "my mood: " + myMood.mood + "<br/>";
    moods += "your mood: " + yourMood.mood + "<br/>";
    moods += "their mood: " + theirMood.mood;

//    document.writeln(moods);

    //Apply invocation - 'this' bound to the first argument since the second argument is an array of parameters
    var applyObj = {
        customValue: 'I am passed in.'
    };

    var complexAdd = function(x, y) {
        document.writeln(this.customValue);
        return x + y;
    }

//    var result = complexAdd.apply(applyObj, [2,5]);
//    document.writeln('apply result: ' + result);


    //Closure over loops/block scope
    var messages = [];

    for (var i = 0; i < 5; i++){
        messages[i] = function(){
            return "Message #" + i + '<br/>';
        };
    };

    //for (var j = 0; j < 5; j++){
    //    document.writeln(messages[j]());
    //};


    function buildFunction(idx){
        return function() {
            return 'Message #' + idx + '<br/>';
        };
    };

    //for (var i = 0; i < 5; i++){
    //    messages[i] = buildFunction(i);
    //};
    //
    //for (var j = 0; j < 5; j++){
    //    document.writeln(messages[j]());
    //}

})();