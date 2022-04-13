// Задача 4. Напишите программу, которая на вход принимает число Number, а на выходе показывает все четные числа от 1 до N
Console.Clear(); // Clear the console berofe starting.
Console.WriteLine("This program find all even number from 1 to Number.");
Console.WriteLine("Please ender your integer number for finding:");
int Number=Convert.ToInt32(Console.ReadLine()); //Enter Number for checking
int Index=1; // Initialize Index variable for counting and checking
int TotalNumber = 0; //Initialize TotalNumber variable to count total number of all even numbers
Console.Write("There are the following even numbers between 1 and " + Number +" : ");
while (Index<=Number)
{
   int Result=Index % 2; // Auxiliary variable is used to hold the result of our check
     if (Result==0)
      {
           Console.Write(Index + " ");
           TotalNumber++;
      }
      Index++;
}
if (TotalNumber==0) // There are not any even numbers
{
    Console.Write("Nothing was found!");
}
Console.WriteLine();
Console.WriteLine("Total number of all even number = "+ " "+ TotalNumber);