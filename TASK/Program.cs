/* Написать программу, которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам.*/


void array(string[] stringArray)
{
    for(int i = 0; i < stringArray.Length; i ++)
{
    Console.WriteLine($"Введите {i+1} элемент массива");
    stringArray[i] = Console.ReadLine();
}
}
string[] symbol(string[] stringArray)
{
    int n = 0;
    for(int i = 0; i < stringArray.Length; i ++)
    {
        if(stringArray[i].Length <= 3)
        n ++;
    }
    string[] result = new string[n];
    int j = 0;
    for(int i; i < stringArray.Length; i ++)
    {
        if (stringArray[i].Length <= 3)
        {
            result[j] = stringArray[i];
            j ++;
        }
    }
    return result;
}