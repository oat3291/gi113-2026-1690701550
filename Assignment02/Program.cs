/*
 * Student ID :1690701550
 * Name       :Sirasak Tumtong
 * Section    :129B
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
const string MaterialName = "Iron";
const double SmeltRate = 0.25;
const double SalvageRate = 0.30;
const double MaxBatch = 500.0;
Console.WriteLine("--- " + MaterialName + " Forge Program ---");
Console.WriteLine("Material: " + MaterialName);
Console.WriteLine("Smelt Rate  (Ore -> Ingot) : " + SmeltRate.ToString("F2"));
Console.WriteLine("Salvage Rate(Ingot -> Ore) : " + SalvageRate.ToString("F2"));
Console.WriteLine("Max Batch Size             : " + MaxBatch.ToString("F2"));
Console.WriteLine("--------------------------------------");
Console.WriteLine("Menu Options:");
Console.WriteLine("  S or s - Smelt (Convert Ore to Ingot)");
Console.WriteLine("  B or b - Breakdown (Convert Ingot back to Ore)");
Console.WriteLine("--------------------------------------");
Console.Write("Enter Amount: ");
string amountInput = Console.ReadLine();
double amount;
bool isAmountValid = double.TryParse(amountInput, out amount);
if (isAmountValid && amount > 0 && amount <= MaxBatch)
{
Console.Write("Enter Menu (S/B): ");
string menuInput = Console.ReadLine();
char menu;
bool isMenuValid = char.TryParse(menuInput, out menu);
if (isMenuValid)
{
if (menu == 'S' || menu == 's')
{
double result = amount * SmeltRate;
Console.WriteLine("=> " + amount.ToString("F2") + " " + MaterialName + " Ore = " + result.ToString("F2") + " " + MaterialName + " Ingot");
}
else if (menu == 'B' || menu == 'b')
{
double result = amount / SalvageRate;
Console.WriteLine("=> " + amount.ToString("F2") + " " + MaterialName + " Ingot = " + result.ToString("F2") + " " + MaterialName + " Ore");
}
else
{
Console.WriteLine("error: menu");
}
}
else
{
Console.WriteLine("error: menu");
}
}
else
{
if (!isAmountValid)
{
Console.WriteLine("error: amount");
}
else if (amount <= 0)
{
Console.WriteLine("error: amount");
}
else if (amount > MaxBatch)
{
Console.WriteLine("error: amount");
}
}
