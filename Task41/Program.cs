// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write($"Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumb = new int[m];

void InputNumbers(int m){


for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    massiveNumb[i] = Convert.ToInt32(Console.ReadLine());
  }
}
int Count(int[] massiveNumb)
{
  int count = 0;
  for (int i = 0; i < massiveNumb.Length; i++)
  {
    if(massiveNumb[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Количество чисел больше 0 = {Count(massiveNumb)} ");


