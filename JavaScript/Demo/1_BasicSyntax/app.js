(function init() {

    //variable declaration

    var myInt = 5;
    var myString = 'Hello';
    var myDate = new Date(2015, 6, 24);

  //  document.writeln(myDate);
    //hoisting

    var x = 'Hello';
    //document.writeln(x);
    //document.writeln("<br/>");


    //this wont work
    var a = "peas";
    //document.writeln('Here we go');
    //document.writeln(a + ' and ' + b);
    //document.writeln('Did you miss it?');
    //document.writeln("<br/>");

    var b = 'carrots';

    //document.writeln(a + ' and ' + b);
    //document.writeln("<br/>");


    var sum = myString + myInt;  //String(myInt) || myInt.toString();

    //document.writeln(sum);
    //document.writeln("<br/>");
    //
    //
    sum = Number(myString) + myInt;

    document.writeln(sum);
    document.writeln("<br/>");

})();