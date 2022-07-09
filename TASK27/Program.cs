//принимает на вход число и выдает суммы цифр в числе
Console.WriteLine("Введите число");
string num1 = Console.ReadLine();
int num = Convert.ToInt32(num1);
int Funct()
{
    int N = num1.Length;
    var array = num.ToString().Select(e=>int.Parse(e.ToString())).ToArray();
    //int[] array = new int[num.Length];
    //char [] array = num.ToCharArray(); 
    int sum = 0;

    for (int i=0; i<N; i++)
    {
        sum = sum + array[i];
    }
return sum;

}
Console.WriteLine(Funct());