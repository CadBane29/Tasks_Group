// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Напишите номер дня недели.");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Понедельник, день тяжелый");
}
else if(number == 2)
{
    Console.WriteLine("Вторник тоже напряженный.");
}
else if(number == 3)
{
    Console.WriteLine("Долго длится как всегда, день с названием Среда.");
}
else if(number == 4)
{
    Console.WriteLine("И в Четверг все как обычно, ни сикунды жизни личной.");
}
else if(number == 5)
{
    Console.WriteLine("Буду в Пятницу опять, я о завтра лишь мечать.");
}
else if(number == 6)
{
    Console.WriteLine("Наконец-таки Суббота!");
}
else if(number == 7)
{
    Console.WriteLine("Воскресенье, а завтра работа Т_Т");
}
else
{
    Console.WriteLine("Пожалуйста введите цифру 1-7, календарных дней больше не прибавилось!!!");
}