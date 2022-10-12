Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == ("данил"))
{
   Console.WriteLine("Ура! Это же Данил!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
