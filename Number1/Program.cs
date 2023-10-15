/*Console.WriteLine("Введите трёхзначное число: ");
string a = Console.ReadLine();
Console.Write(a[1]);
*/

int Ten(int a) 
{
    int res = a / 10 % 10;
    return res; 
}

Console.WriteLine("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ваша вторая цифра: " + Ten(a));
