Console.Clear();
Console.WriteLine("Введите целое число");
string s = Console.ReadLine()!;
int l = s.Length;
int sum = 0;
for (int i = 0; i < l; i++)
    sum = int.Parse(s[i].ToString()) - int.Parse(s[l - i - 1].ToString());
if (sum == 0)
    Console.WriteLine("Число является палиндромом");    
else 
    Console.WriteLine("Число палиндромом не является");   