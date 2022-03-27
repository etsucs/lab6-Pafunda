/**       
 *--------------------------------------------------------------------
 * 	   File name: {RetailPrice}
 * 	Project name: {RetailPrice.cs}
 *--------------------------------------------------------------------
 * Author’s name and email:	 {Mason Pafunda PAFUNDA@ETSU.EDU}				
 *          Course-Section: {CSCI-1250-001}
 *           Creation Date:	 {3/27/2022}		
 * -------------------------------------------------------------------
 */

Console.WriteLine("Enter the wholesale price.");
double firstValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Enter the mark up percentage without the percent sign.");
double secondValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

CalculateRetail(firstValue, secondValue);

static void CalculateRetail(double price, double markUp )
{

    markUp = (markUp / 100) + 1;

    price *= markUp;

    Console.WriteLine($"The price after mark up is {price}.");


}