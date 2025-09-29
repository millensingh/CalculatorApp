

using System.Runtime.ExceptionServices;

try
    {
    // First Number
    Console.WriteLine("Enter First Number: ");

// This is a string that takes input from the user
int firstNumber = Convert.ToInt32(Console.ReadLine());

// Second Number
Console.WriteLine("Enter Second Number ");

// This is a string that takes input from the user
int secondNumber = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter the operation (+, -, * /) ");
char operation = Convert.ToChar(Console.ReadLine());
int result = 0;

switch (operation)
{
    case '+':
        result = firstNumber + secondNumber;
        break;
    case '-':
        result = firstNumber - secondNumber;
        break;
    case '*':
        result = firstNumber * secondNumber;
        break;
    case '/':
        result = firstNumber / secondNumber;
        break;
    default:
        Console.WriteLine("Invalid operation");
        break;
}


// PRINTS RESULT
Console.WriteLine($"Result: {result}");

    }
    catch (FormatException ex)
    {
        // Handle the case where the input is not valid
        Console.WriteLine("Please enter a valid number.");
    }
    catch(DivideByZeroException ex)
    {
        // Handle the divide by zero error
        Console.WriteLine($"You cannot divide by zero.");
    }
    finally
    {
    // This block runs no matter what
    Console.WriteLine("Operation completed.");
}
