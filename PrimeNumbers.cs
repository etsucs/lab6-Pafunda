/**       
 *--------------------------------------------------------------------
 * 	   File name: {PrimeNumbers}
 * 	Project name: {PrimeNumbers.cs}
 *--------------------------------------------------------------------
 * Author’s name and email:	 {Mason Pafunda PAFUNDA@ETSU.EDU}				
 *          Course-Section: {CSCI-1250-001}
 *           Creation Date:	 {3/27/2022}		
 * -------------------------------------------------------------------
 */

Console.WriteLine("Enter a number you want to see if it is a prime number, true means it is a prime number false means it is a regular");


int inputNumber = Convert.ToInt32(Console.ReadLine());


isPrime(inputNumber);


static async void isPrime(int number)
{

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
}

static void CalculateRetail(double price, double markUp )
{

    markUp = (markUp / 100) + 1;

    price *= markUp;

    Console.WriteLine($"The price after mark up is {price}.");


}