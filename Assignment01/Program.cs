/*
 * Student ID : 1690701550
 * Name       : Sirasak Tumtong
 * Section    : 129B
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
const string charSelect = "Character Select";
string charName = "Nicole";
var charRank = 'A';
int charLevel = 10;
var critRate = 0.75f;
double critDamage = 50.7;
bool isParryable = true;
Console.WriteLine($"{charSelect}");
Console.WriteLine();
Console.WriteLine($"Name:{charName}");
Console.WriteLine($"Rank:{charRank}");
Console.WriteLine($"Level:{charLevel}");
Console.WriteLine($"Critrate:{critRate}");
Console.WriteLine($"Critdamage:{critDamage}");
Console.WriteLine($"Parryable:{isParryable}");
Console.WriteLine();
double critRateAsDouble = critRate;
Console.WriteLine($"Critrate As Double:{critRateAsDouble}");
int critDamageTruncated = (int)critDamage;
int critDamageChanged = Convert.ToInt32(critDamage);
Console.WriteLine($"Crit damage:{critDamageTruncated}");
Console.WriteLine($"Critdamage Change:{critDamageChanged}");