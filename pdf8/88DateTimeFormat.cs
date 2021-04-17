using System;
using System.Globalization;
namespace A088_DateTimeFormat
{
class Program
{
static void Main (string [] args)
{
DateTime today = DateTime.Now;
Console.WriteLine(today.ToString ("yyyy 년 MM 월 dd 일"))
Console.WriteLine("string.Format ("{0}:yyyy 년 MM 월 dd 일 }", today));
Console.WriteLine(today.ToString ("MMMM dd , yyyy ddd",CultureInfo.CreateSpecificCulture en US")));
Console.WriteLine(today.ToString ("MMMM dd , yyyy ddd ", new CultureInfo("en US")));
//오전 , 오후
Console.WriteLine(today.ToString ("tt"));
today = today.AddHours (12);
Console.WriteLine(today.ToString ("tt"));
today = today.AddHours (-12);
Console.WriteLine("\n 표준 포맷 지정자");
//d : 축약된 날짜 형식
Console.WriteLine("d : " + today.ToString ("d"));
Console.WriteLine("d : " + today.ToString ("d ", new CultureInfo ("en- 
}
}
}