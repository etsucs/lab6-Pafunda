/**       
 *--------------------------------------------------------------------
 * 	   File name: {ShowCharacter}
 * 	Project name: {ShowCharacter.cs}
 *--------------------------------------------------------------------
 * Author’s name and email:	 {Mason Pafunda PAFUNDA@ETSU.EDU}				
 *          Course-Section: {CSCI-1250-001}
 *           Creation Date:	 {3/27/2022}		
 * -------------------------------------------------------------------
 */

Console.WriteLine("Enter a string");
string firstValue = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Enter an integer");
int secondValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

ShowCharacter(firstValue, secondValue);




static void ShowCharacter (string words, int characterNumber)
{

    characterNumber -= 1;

    char solution = words[characterNumber];

    characterNumber += 1;

    Console.WriteLine($"The {characterNumber} character in {words} is {solution}.");

}