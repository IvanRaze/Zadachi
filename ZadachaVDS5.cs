double a = Convert.ToDouble(Console.ReadLine());
double balance = 0;
if (a < 100)
{
    balance += a * 0.05 + a + 15;
}
else if (a > 100 & a < 200)
{
    balance += a * 0.07 + a + 15;
}
else
{
    balance += a * 0.1 + a + 15;
}
Console.WriteLine(balance);
