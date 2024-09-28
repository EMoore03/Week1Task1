
Task1();
Task2();
Task3();
Task4();
Task5();
void Task1()
{
    Console.WriteLine("Please enter your name :");
    String name = Console.ReadLine();
    Console.WriteLine("Please enter your age");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Hello {name}, you will be {(age + 5)} in 5 years");
}

void Task2()
{
    int userAge;
    Console.WriteLine("Please enter your age in years");
    userAge = Convert.ToInt32(Console.ReadLine());
    if (userAge < 13)
    {
        Console.WriteLine("You are a child.");
    }
    else if (userAge >=13 && userAge <= 19)
    {
        Console.WriteLine("You are a teenager");
    }
    else
    {
        Console.WriteLine("You are an adult");
    }
}

void Task3()
{
    int Value;
    Console.WriteLine("Please enter an integer");
    Value = Convert.ToInt32(Console.ReadLine());
    if (Value > 0)
    {
        Console.WriteLine("Tis is a positive integer");
    }
    else if(Value < 0)
    {
        Console.WriteLine("This is a negative number");
    }
    else if (Value == 0)
    {
        Console.WriteLine("This Value equals 0");
    }
}

void Task4()
{
    // Checks if it is a leap year
    Console.WriteLine("Please enter a year");
    int year = Convert.ToInt32(Console.ReadLine());
    if (year<0)
    {
        Console.WriteLine($"{year} is not a valid year. It must not be a negative number.");
    }
    else
    {
        if ((year % 4 == 0 && year % 100 != 0) ||  (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year");
        }
    }
}

void Task5()
{
    //Even or Odd
    Console.WriteLine("Please enter a number");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number % 2 == 0)
    {
        Console.WriteLine($"{number} is an even number");
    }
    else 
    {
        Console.WriteLine($"{number} is an odd number");
    }
}

void Task6()
{

}
