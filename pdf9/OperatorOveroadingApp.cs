class OperatorOverloadingApp {
public static void Main () {
Complex c, c1, c2;
c1 = new Complex (1, 2);
c2 = new Complex (3, 4);
c = c1 + c2;
Console.WriteLine(c1 + " + " + c2 + " = " + c);
}
}