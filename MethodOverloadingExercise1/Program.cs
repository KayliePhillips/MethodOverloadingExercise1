using MethodOverloadingExercise1;


Console.WriteLine(Methods.Add(0, 1)); //adding two integers

Console.WriteLine(Methods.Add(5.32m, 6.33m)); //adding two decimals

Console.WriteLine(Methods.Add(12, 6, true)); //3 parameters:2 integers, 1 boolean

Console.WriteLine(Methods.Add(0, 1, true)); //3 parameters:2 integers, 1 boolean

Console.WriteLine(Methods.Add(-12, -5, true)); //3 parameters:2 integers, 1 boolean

Console.WriteLine(Methods.Add(0, -1, true)); //3 parameters:2 integers, 1 boolean

Console.WriteLine(Methods.Add(4, 2, false)); //3 parameters:2 integers, 1 boolean


