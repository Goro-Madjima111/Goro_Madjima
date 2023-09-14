//Напишите программу, запрашивающую у пользователя радиус 
//окружности и производящую просчет площади круга, используя 
//заранее заданную константу числа PI.
const double n = Math.PI;
Console.Write("Введите радиус окружности:");
double r = double.Parse(Console.ReadLine());
double s = n * r * r;
Console.WriteLine($"Площадь круга:{s:F3}");

//Напишите программу, запрашивающую у пользователя данные о 
//нем и выводящую его досье. 
//Используйте для данного задания Интерполяцию. 
Console.Write("Введите ваше имя: ");
string name  = Console.ReadLine();
Console.Write("Введите ваш возраст: ");
int age = int.Parse(Console.ReadLine());
Console.Write("Введите ваш город: ");
string city  = Console.ReadLine();

Console.WriteLine($"Имя: {name}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Город: {city}");
