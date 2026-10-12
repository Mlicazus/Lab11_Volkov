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

// int variant = 1;
// bool isPrime = true;
// for (int divisor = 1; divisor < variant; divisor++)
// {
//     if (variant % divisor == 0)
//     {
//         isPrime = false;
//         break;
//     }

// }
// if (variant != 1)
// {
//     System.Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");
// }
// else
// {
//     System.Console.WriteLine("Число 1 не является ни простым, ни составным");
// }

// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// int count = 0;
// foreach (int points in pointsPerLab) 
// {
//     if (points < 0) 
//     {
//         continue;
//     }
//     sum += points;
//     count++;
// }
// System.Console.WriteLine($"Сумма баллов: {sum}");
// System.Console.WriteLine($"Сдано работ: {count}");

// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;
// for (int i = 0; i < groupIds.Length; i++)
// {
//     for (int j = i + 1; j < groupIds.Length; j++)
//     {
//         if (groupIds[i] == groupIds[j])
//         {
//             hasDuplicates = true;
//             System.Console.WriteLine($"i: {i}, j: {j}");
//             break;
//         }
//     }
// }
// System.Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");