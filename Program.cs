//char c = 'A';
//Console.WriteLine((int)c);
//for  (int i = 60; i < 100; i++)
//    Console.Write((char)i + " ");
//Console.WriteLine(char.IsDigit('2'));
//Console.WriteLine(char.IsLetter('x'));
char[] mas = new char[10];
Random random= new Random();
for (int i = 0; i < mas.GetLength(0); i++)
{  
    mas[i] = (char)random.Next(36, 100);
    Console.Write(mas[i] + " ");
}
Console.WriteLine();
int k = 0;
for (int i = 0; i < mas.GetLength(0); i++)
{
    char ch1 = mas[i];
    bool p = char.IsLetter(ch1);
    if (p) Console.Write(ch1); k++;
    
}
Console.WriteLine();
Console.WriteLine($"букв в массиве: {k}");