// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Console.Clear();
// Console.WriteLine ("Введите любые числа через пробел");
// string elements = Console.ReadLine();

// int[] baseArray = GetArrayFromString(elements);

// Console.WriteLine(String.Join(",", GetArrayFromString(elements)));

// int x = ResultArray(baseArray);

// Console.WriteLine(x);

// int[] GetArrayFromString(string stringArray)
// {
//     string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//     int[] res = new int[nums.Length];

//     for (int i = 0; i < nums.Length; i++)
//     {
//         res[i] = int.Parse(nums[i]);
//     }
//     return res;
// }




// int ResultArray(int [] array){

// int count =0;
//   for (int i =0; i<array.Length; i++){
//     if (array[i]>0){
//     count ++;}
//   }
//   return count;
  
//   }










// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.Clear();
Console.Write ("Введите b1: ");
double b1 = int.Parse (Console.ReadLine());
Console.Write ("Введите k1: ");
double k1 = int.Parse (Console.ReadLine());
Console.Write ("Введите b2: ");
double b2 = int.Parse (Console.ReadLine());
Console.Write ("Введите k2: ");
double k2 = int.Parse (Console.ReadLine());

Console.WriteLine(String.Join($", ", GetPoint (b1, k1, b2, k2)));

// Console.WriteLine (GetPoint(b1, k1, b2, k2));

// double x = (b2-b1)/(k1-k2);
// double y = k1*(b2-b1)/(k1-k2)+b1;

double [] GetPoint (double inb1, double ink1, double inb2, double ink2){
  double []result = new double [2];
  result[0] = (inb2-inb1)/(ink1-ink2);
  result[1] = ink1*(inb2-inb1)/(ink1-ink2)+inb1;
  return result;
  }


// Console.WriteLine($"Точка пересечения двух пярмых Х = {result[0]:0.000}, Y= {result[1]:0.000}");

Console.WriteLine(String.Join(" ", GetPoint));