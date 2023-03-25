//Приветствие пользователя.
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
   Console.WriteLine("Ура, да это же Маша красавица наша! ");
}
else
{
   Console.Write("Привет, ");
   Console.WriteLine(username);
}