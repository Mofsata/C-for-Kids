// using System;

// methods

// static void great(string name = "Stranger"){
//     Console.WriteLine("Hello " + name);
// }

// Console.WriteLine("Enter your name");
// string? input = Console.ReadLine();
// if (input == "")
//     great();
// else
//     great(input);


// // Simple Calculator

// static int sum(int x ,int y) {
//     return x + y ;
// }
// static int sub(int x ,int y) {
//     return x - y ;
// }
// static int times(int x, int y){
//     return x*y;
// }
// static int div(int x, int y){
//     return x/y;
// }
// static int pow(int x, int y){
//     int j = x;
//     for (int i = y; i > 1; i--){
//         x *=j;
//     }
//     return x;
// }
// Console.WriteLine("Enter first number :");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number :");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Choose the operation ( + , - , * , / , ^ )");
// string? s = Console.ReadLine();

// switch(s) {
//     case "+" :
//         Console.WriteLine(sum(m,n));
//         break;
//     case "-" :
//         Console.WriteLine(sub(m,n));
//         break;
//     case "*" :
//         Console.WriteLine(times(m,n));
//         break;
//     case "/" :
//         Console.WriteLine(div(m,n));
//         break;
//     case "^" :
//         Console.WriteLine(pow(m,n));
//         break;
//     default :
//         Console.WriteLine("Invalid operation!");
//         break;
// }
