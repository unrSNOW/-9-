Console.WriteLine("введите трехзначное число x:");
int x = int.Parse(Console.ReadLine());
int sum;
int proz;
sum = ((x % 10) + (x/10 %10) + (x / 100));
if (sum >= 10 && sum <= 99) Console.WriteLine(sum);
else Console.WriteLine("сумма цифр числа не является двухзначной");
proz = ((x % 10) * (x / 10 %10) * (x / 100));
if (proz >= 100 && proz <= 999) Console.WriteLine(proz);
else Console.WriteLine("произведение чисел не является трехзначным");


