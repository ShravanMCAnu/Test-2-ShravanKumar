// See https://aka.ms/new-console-template for more information
using Test_2_ShravanKumar_Project_5;

Add objAdd = new Add();
Console.WriteLine("Add of two Numbers with two integer data type parameters:" + objAdd.AddingTwoNumbers(1, 2));

Console.WriteLine("Add of two Numbers  with three integer data type parameters:" + objAdd.AddingTwoNumbers(1, 2, 3));

Console.WriteLine("Add of two Numbers with one integer , one double data type parameters:" + objAdd.AddingTwoNumbers(1.566, 2));

Console.WriteLine("Add of two Numbers with one double , one integer data type parameters:" + objAdd.AddingTwoNumbers(1, 2.857));

Console.WriteLine("Add of two Numbers one integer data type parameter:" + objAdd.AddingTwoNumbers(1));

Console.WriteLine("Add of two Numbers  one double data type parameter:" + objAdd.AddingTwoNumbers(2.586));

Console.WriteLine("Add of two Numbers with two double data type parameters:" + objAdd.AddingTwoNumbers(2.586, 1.856));

