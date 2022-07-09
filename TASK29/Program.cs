// задает массив из 8 элементов и выводит их на экран
int[] Funct()
{
int [] array = new int [8];
for (int i = 0; i<8; i++)
{
array [i] = new Random().Next(-999,999);
}
return array;
}
Console.WriteLine(string.Join("|",Funct()));
