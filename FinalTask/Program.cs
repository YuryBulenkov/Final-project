Console.WriteLine("Введите количество элементов массива: ");
int size  = int.Parse(Console.ReadLine());

string[] array1 = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент массива под индексом{i}:  ");
    string res = Console.ReadLine();
    array1[i] = res;  
}
Console.Write("[");
Console.Write(string.Join(" ,",array1));
Console.Write("]");

int count = 0;
for (int i = 0; i < array1.Length; i++)
{
    if(array1[i].Length <= 3)
    {
        count++;
    }   
}
Console.Write(" => [");

string[] array2 = new string[count];
int j = 0;
for (int i = 0; i < array1.Length; i++)
{
    if(array1[i].Length <= 3) 
    {
        array2[j] = array1[i];
        Console.Write( array2[j] + " ," );
        j++;
    }
}   
Console.Write("]");
