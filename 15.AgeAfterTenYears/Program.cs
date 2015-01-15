//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Please enter your birthday in format (dd.mm.yyyy): ");
        string input = Console.ReadLine();
        DateTime birthday = Convert.ToDateTime(input);
        DateTime now = DateTime.Now;
        int age = now.Year - birthday.Year;
        if (now.DayOfYear < birthday.DayOfYear)
        {
            age = age-1;
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("After 10 years you will be {0}", age + 10);
        }
        else
        {
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("After 10 years you will be {0}", age + 10);
        }
    }
}