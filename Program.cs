// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1;
// bool found = false;
// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }
// System.Console.WriteLine(found ? "Студент найден" : "Студент не найден");

int variant = 1;
bool isPrime = true;
for (int divisor = 1; divisor < variant; divisor++)
{
    if (variant % divisor == 0)
    {
        isPrime = false;
        break;
    }

}
if (variant != 1)
{
    System.Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");
}
else
{
    System.Console.WriteLine("Число 1 не является ни простым, ни составным");
}

