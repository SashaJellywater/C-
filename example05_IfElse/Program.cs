Console.WriteLine("введите имя пользователя");
string username = Console.ReadLine();
if(username.ToLower() == "luna")
{
    Console.WriteLine("Hi, little kitty!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}