using System;
class Complex {
private double realPart ;;// 실수부
private double imagePart ;;// 허수부
public Complex (double rVal , double iVal ) {
realPart = rVal ;
imagePart = iVal ;
}
public static Complex operator+( Complex x1, Complex x2) {
Complex x = new Complex (0, 0);
x.realPart = x1.realPart + x2.realPart;
x.imagePart = x1.imagePart + x2.imagePart;
return x ;
}
override public string ToString () {
return "("+ realPart + "," + imagePart + "i )";
}
}