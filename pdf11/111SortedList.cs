using System;
using System.Collections.Generic
namespace A111_SortedList
{
class Program
{
static void Main (string [] args)
{
SortedList <int , string > s1 = new SortedList <int , string>();
s1.Add(3, "
Three
s1.Add(4, "
Four
s1.Add(1, "One");
s1.Add(2, "
Two
for
int i = 0; i < s1.Count; i
Console.Write
("k: {0}, v: {1} / ", s1. i ], s1. i
Console.WriteLine
foreach
var kvp in s1)
Console.Write
("{0, 10} ", kvp
Console.WriteLine
SortedList
string , int > s2 = new SortedList string , int
s2.Add("
one ",
s2.Add("
two ",
s2.Add("
three ",
s2.Add("
four ",
//
Console.WriteLine ( one
Console.WriteLine
( two
foreach
var kvp in s2)
Console.Write
("{0, 10} ", kvp
Console.WriteLine
//
for int i = 0; i < s2.Count; i
//
Console.Write ("k: {0}, v: {1}", s2. i ], s2. i
int
val
if
(s2. ten ", out val
Console.WriteLine
key : ten , value : {0}", val
else
Console.WriteLine
ten ] : Key is not valid
if
(s2. one ", out val
Console.WriteLine
key : one , value : {0}", val
Console.WriteLine
(s2. one ")); // returns true
Console.WriteLine
(s2. ten ")); // returns false
Console.WriteLine
(s2.ContainsValue(2)); // returns true
Console.WriteLine
(s2.ContainsValue(6)); // returns false
s2.Remove("
one ");// 키가 one ' 요소 삭제
s2.RemoveAt(0); //
첫번째 요소 삭제
foreach
KeyValuePair string , int > kvp in s2)
Console.Write
("{0, 10} ", kvp
Console.WriteLine
}
}
}