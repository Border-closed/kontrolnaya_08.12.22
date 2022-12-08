// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
//меньше или равна 3 символам
// ["hello", "2", "///"] -> ["2","///"]

//Создание массива пользователем
string [] massiv = new string [5];

//Ввод массива пользователем
void vvod (string [] massiv,string text)
{
    for (int i = 0; i<massiv.Length; i++)
   {
    Console.Write(text);
    massiv [i] = Console.ReadLine();
   }
}

//Вывод массива 
void print (string [] massiv)
{
    for (int i = 0; i<massiv.Length; i++)
   {
    Console.Write ($"{massiv[i]}"+", ");
   }
}

vvod (massiv,"Введите строку массива ");
Console.WriteLine();
Console.Write ("Вы ввели массив ");
print (massiv);
Console.WriteLine();
Console.Write ("Элементы массива, длина которых 3 и меньше символов ");

for (int i = 0; i < massiv.Length; i++)
{
    int Length = massiv[i].Length;
    if (Length<=3)
    {
        Console.Write ($"{massiv[i]}"+", ");
    }
}
Console.WriteLine();