//Принимает на вход два числа (А и В) и возвращает число А в натуральную степень В
Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console. WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());

string Function(int numA, int numB)

{
Double result = numA;
for (int i=1; i<numB; i++)
{
result = result*numA;
}
return $"ваш результат {result}";
}
Console.WriteLine(Function(A, B));
