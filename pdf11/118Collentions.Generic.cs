using System;
using
System.Collections.Generic
namespace A118_Predicate
{
class Program
{
static void Main(string[]
args
{
Predicate<
int > isEven = n => n % 2 ==
Console.WriteLine
isEven (
Predicate<string>
isLowerCase = s => s.Equals s.ToLower
Console.WriteLine
isLowerCase ("This is a lowercase
}
static bool
IsEven int n) => n % 2 == 0;
static bool
IsLowerCase (string s) => s.Equals s.ToLower
}
}