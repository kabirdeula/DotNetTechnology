using System;
//a namespace called user defined is defined
namespace UserDefined
{
//a class called test weather is defined
class Testweather
{
//main method is called
static void Main(string[] args)
{
//an instance of the class temperat is defined
Temperat tem = new Temperat();
try
{
//the show method of temperat class is called using the instance of the temperat class
tem.show();
}
catch(WeatheriscoldException e)
{
Console.WriteLine("\n\n\t\tTemp is rare or below: {0}", e.Message);
}
Console.ReadKey();
}
}
}
//a custom exception class called Weather is cold Exception class is created which is thrown if the weather is cold
public class WeatheriscoldException: Exception
{
public WeatheriscoldException(string message): base(message)
{
}
}
//a class called temperat is defined
public class Temperat
{
//a variable called temp is defined and assigned to zero
int temp = 0;
//a method called show is defined
public void show()
{
//the temperature is checked to determine the weather
if(temp == 0)
{
throw (new WeatheriscoldException("The temperature is found to be zero and hence the weather is cold\n\n"));
}
else
{
Console.WriteLine("The Temperature is: {0}", temp);
}
}
}