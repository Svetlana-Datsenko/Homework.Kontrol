// Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на
// старте выполнения алгоритма.

using System.Runtime.InteropServices;

Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[m];
void array(string[] stringArray)
{
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.WriteLine($"Введите {i + 1} элемент массива");
    stringArray[i] = Console.ReadLine();
  }
}
string[] threeSymbol(string[] stringArray)
{
  int count = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length <= 3)
      count++;
  }
  string[] result = new string[count];
  int j = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length <= 3)
    {
      result[j] = stringArray[i];
      j++;
    }
  }
  return result;
}
  


void printArray(string[] stringArray)
{
  Console.Write("[");
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.Write($"'{stringArray[i]}'  ");
  }
    Console.Write("]");
}
array(stringArray);
printArray(stringArray);
Console.Write(" -> ");
printArray(threeSymbol(stringArray));