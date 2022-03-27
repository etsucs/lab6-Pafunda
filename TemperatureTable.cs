/**       
 *--------------------------------------------------------------------
 * 	   File name: {TemperatureTable}
 * 	Project name: {TemperatureTable.cs}
 *--------------------------------------------------------------------
 * Author’s name and email:	 {Mason Pafunda PAFUNDA@ETSU.EDU}				
 *          Course-Section: {CSCI-1250-001}
 *           Creation Date:	 {3/27/2022}		
 * -------------------------------------------------------------------
 */


Console.WriteLine("Enter a temperature in Fahrenheit you would like in Celsius.");
Console.WriteLine("");

double temperature = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

Console.Write($"{temperature} degrees Fahrenheit is equal to ");

Celsius(temperature);


static async void Celsius(double number)
{

    double firstVariable = ((5.0/9.0) * (number - 32));
    Console.Write($"{firstVariable} degrees Celsius");
    Console.WriteLine("");

    for (int i = 80; i < 101; i ++)
    {
        double secondVariable = ((5.0/9.0) * (i - 32));
        Console.WriteLine("");
        Console.WriteLine($"{i} degrees fahrenheit is equal to {secondVariable} degrees celsius.");
    }
}



