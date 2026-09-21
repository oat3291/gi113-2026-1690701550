/*
 * Student ID :1690701550
 * Name       :Sirasak Tumtong
 * Section    :129B
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
int monsterMaxHp = 100;
int currentHp = monsterMaxHp;
Console.WriteLine("==============================================");
Console.WriteLine($"Monster Attack! [ Monster Hp: {monsterMaxHp}]");
Console.WriteLine("==============================================");
Console.WriteLine("");
Console.Write("Enter Damage To Monster:");
string input = Console.ReadLine();
int damage;
if (int.TryParse(input, out damage))
{
    currentHp = currentHp - damage;
    Console.WriteLine("==============================================");
    Console.WriteLine($"Your Attack Deal Damage - {damage}"!);
    Console.WriteLine($"Monster Current Hp Left - {currentHp}"!);
    Console.WriteLine("==============================================");
    if (currentHp <= 0)
    {
        Console.WriteLine("Monster Die!");
    }
    else
    {
        Console.WriteLine("Monster Alive!");
    }
}
else
{
    Console.WriteLine("Enter Positive Interger Only!");
}
