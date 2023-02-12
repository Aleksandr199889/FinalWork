// Написать программу, которая из имеющего массива строк формирует массив из строк, длина которых меньше или равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рек. использовать коллекции, лучше обойтись исключительно массивами.
// Примеры:
// ["hello","2","world",":-)"] -> ["2",":-)"]

string[] array1 = new string[4];
void PrintArray(string [] arr)
{
    string [] array = {"hello","2","world",":-)"};
    Console.Write("Начальный массив: "+"[" + string.Join(", ", array) +"]");

}
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Введите необходимое количество элементов от 1 до 3х:");
int n = Convert.ToInt32(Console.ReadLine());
string[] array2 = new string[n];

for (int i = 0; i < n; i++)
{
    string s;
    Console.Write("Введите элемент из начального массива: ");
    s = Console.ReadLine();
    if (s!=" ")
    {
        array2[i]= s;
    }
}
Console.Write("Конечный массив: "+ "[" + string.Join(", ", array2) + "]");
