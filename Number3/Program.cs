string Ned(int a)
{
    if (a == 6 || a == 7 ) 
    { 
        return "Да"; 
    }
    else if (a < 6 && a > 0) 
    { 
        return "Нет";
    }
    else 
    { 
        return "Нет такого дня недели"; 
    }}
Console.Write("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(Ned(a));

