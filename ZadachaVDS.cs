int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер операции:\n 1.Сложение\n 2.Вычитание\n 3.Умножение");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 1:
        Console.WriteLine(b+c);
        break;
    case 2:
        Console.WriteLine(b-c);
        break;
    case 3:
        Console.WriteLine(b*c);
        break;
    default:
        Console.WriteLine("Операция не определена");
        break;
}
