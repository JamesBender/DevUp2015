(function init() {

    //function declarations

    //foo();
    //bar();


    function foo(){
        document.writeln('foo!<br/>');
    };

    var bar = function(){
        document.writeln('bar<br/>');
    };

   // bar();


    //argument list and the arguments array
    function tooFew(a, b, c, d) {
        var message = "a: " + a + "<br/>";
        message += "b: " + b + "<br/>";
        message += "c: " + c + "<br/>";
        message += "d: " + d + "<br/>";
        document.writeln(message);
        document.writeln('<br/>');
    }

    function tooMany(a) {
        var message = "a: " + a + "<br/>";
        message += "from arguments array:<br/>";
        message += "0: " + arguments[0] + "<br/>";
        message += "1: " + arguments[1] + "<br/>";
        document.writeln(message);
        document.writeln('<br/>');
    }

    //tooFew(1, "a parameter!");
    //document.writeln('===========<br/>');
    //tooMany(1, "a parameter!");


    //Functions as values
    var englishGreeting = function(name) {
        return "Hi " + name + "!";
    };

    var frenchGreeting = function(name) {
        return "Bonjour " + name + "!";
    };

    var spanishGreeting = function(name){
        return "Hola " + name + "!";
    }

    function sayHello(name, typeOfGreeting){
        var greeting = typeOfGreeting(name);
        document.writeln(greeting + '<br/>');
    };

    sayHello('James', englishGreeting);
    sayHello('James', frenchGreeting);
    sayHello('James', spanishGreeting);

})();