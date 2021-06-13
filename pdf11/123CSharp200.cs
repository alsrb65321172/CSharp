using
System;
using
System.Collections.Generic
using
System.Linq
namespace
CSharp200
{
class
Student
{
public
string Name { get ; set ;
public
int Id { get ; set ;
public
List int > Scores { get ; set ;
}
class
Program
{
static
List Student > students
static
void Main string [] args
{
students
= new List Student
{
new
Student Name PjKim ", Id =19001001, Scores = new List int >{
new
Student Name BsKim ", Id =19001002, Scores = new List int >{
new
Student Name YsCho ", Id =19001003, Scores = new List int >{
new
Student Name BiKang ", Id =19001004, Scores = new List int >{
};
Print(students);
HighScore
(0,
HighScore
(1,
//
HighScore (2,
}
private static void
HighScore int exam, int cut)
{
var
highScores = from student in students
where
student.Scores [exam] >= cut
select new { Name =
student.Name , Score = student.Scores [exam]
Console.WriteLine
($"{exam + 번째 시험에서 {cut} 이상의 점수를 받은 학생
foreach
var item in highScores
{
Console.WriteLine
t{ item.Name , 10}{ item.Score
}
}
private
static void Print List Student > students
{
foreach
var item in students
{
Console.Write
item.Id , 10}{ item.Name , 10}");
foreach
var score in item.Scores
{
Console.Write
($"{ 5}");
}
Console.WriteLine
item.Scores.Average ToString ("
}
}
}
}