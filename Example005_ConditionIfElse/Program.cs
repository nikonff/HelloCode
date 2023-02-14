Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "анатолий")
{
    Console.WriteLine("Ура, это же АНАТОЛИЙ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}