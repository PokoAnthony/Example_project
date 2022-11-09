Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "инна") {
    Console.WriteLine("Ура, это же Инна!");
} else {
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
