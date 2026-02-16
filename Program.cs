using System;
using System.Globalization;

public class Program
{
//Objective: Use % to filter values from random numbers.

//Requirements:

//1. Generate 20 random numbers between 1 and 50.


//2. Only print the numbers that are divisible by 5.


//Example Output:
//Random numbers: 3, 10, 17, 25, 40 Multiples of 5: 10, 25, 40



// My Global variables

static int numberHolder = 0;
//static int[] Randomholder = new int[]


//declare a new list almost the same as an int, we use static and type the list
// object making sure its an int type with greater less than brackets, then 
//give it a name, and = it to a new list int  with the same <> and fill curly brackets
// with the names 

static List<int> randomHolder = new List<int> {};


	public static void Main()
	{
        Random rand = new Random();
        for (int i = 0; i < 20; i++)
        {
            int randValue = rand.Next(1, 51); // 1..50 if matching your requirement
            randomHolder.Add(randValue);
        }

        for (int i = 0; i < 20; i++)
        //randomHolder[i] % 5 = 0
        if (randomHolder[i] % 5 == 0){
        Console.WriteLine(string.Join(", ", randomHolder[i]));
        //thats cool! I learned that string join still works on INTs because
        // it accepts IEnumerables and calls ToString() internally to convert
        //them to their string text counterparts. Nice. No int string errors here
        }
    }
}