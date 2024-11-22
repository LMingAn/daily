double d = 75.2;
string str = "135";
Console.WriteLine("d = {0} ", d.ToString());
if (int.Parse(str) == 135)
    Console.WriteLine("str convert to int successfully.");
else
    Console.WriteLine("str convert to int failed.");
Console.ReadLine();