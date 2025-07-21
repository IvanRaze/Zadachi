double a = Convert.ToDouble(Console.ReadLine());
double balance = 0;
if (a < 100)
{
    balance += a * 0.05 + a;
}
else if (a > 100 & a < 200)
{
    balance += a * 0.07 + a;
}
else
{
    balance += a * 0.1 + a;
}
Console.WriteLine(balance);
