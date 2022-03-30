/**       
*--------------------------------------------------------------------
* 	   File name: {Homework6}
* 	Project name: {Program.cs}
*--------------------------------------------------------------------
* Author’s name and email:	 {Mason Pafunda PAFUNDA@ETSU.EDU}				
*          Course-Section: {CSCI-1250-001}
*           Creation Date:	 {3/27/2022}		
* -------------------------------------------------------------------
*/

CalculateRetail();

IsPrime();

ShowCharacter();

Console.WriteLine("Enter a temperature in Fahrenhiet you would like in celsius.");
double number = Convert.ToDouble(Console.ReadLine());

Celsius(number);





static void CalculateRetail()
{
    Console.WriteLine("Enter the wholesale price.");
    double firstValue = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("");

    Console.WriteLine("Enter the mark up percentage without the percent sign.");
    double secondValue = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("");

    CalculateRetailTwo(firstValue, secondValue);

    static void CalculateRetailTwo(double price, double markUp )
    {

        markUp = (markUp / 100) + 1;

        price *= markUp;

        Console.WriteLine($"The price after mark up is {price}.");


    }
    Console.WriteLine("");   
}


static void IsPrime()
{
    Console.WriteLine("Enter a number you believe is true and I will tell you whether it is true, a prime, or false, not a prime.");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    bool randomValue = false;

    bool randomValueTwo = true;

    int numberTwo = number - 1;

    if ((number == 2) || (number == 1))
    {
        Console.WriteLine($"{randomValueTwo}");
    }

    else if (((number % 2) == 0) && (number != 2))
    {
    Console.WriteLine($"{randomValue}");
    }

    else
    {
        for (int i = 2; i < number; i++ )        
        {
            if (((number % i) == 0))
            {
                Console.WriteLine($"{randomValue}");
            
                break;
            }

            else if (i == numberTwo)
            {
            Console.WriteLine($"{randomValueTwo}");
            }
        }
    }
    Console.WriteLine("");
}

static void ShowCharacter()
{

    Console.WriteLine("Enter the word or phrase you want to use.");
    string words = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("Enter the character you would like returned based on its human index number.");
    int characterNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    words = words.Replace(" ", "");

    characterNumber -= 1;

    char solution = words[characterNumber];

    characterNumber += 1;

    Console.WriteLine($"The {characterNumber} character in {words} is {solution}.");
    Console.WriteLine("");

}   

static void Celsius(double number)
{
    
    
    
    Console.WriteLine($"{number} degrees Fahrenheit is equal to ");

    Formula(number);
    



    static void Formula(double number)
    {
        number = ((5.0/9.0) * (number - 32));
        Console.Write($"{number} degrees Celsius");
        Console.WriteLine("");
    }


}
   
 

for (int i = 80; i < 101; i ++)
    {
        
        Celsius(i);
        
    }