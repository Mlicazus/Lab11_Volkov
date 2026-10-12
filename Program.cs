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
// for (int divisor = 2; divisor < variant; divisor++)
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

// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;
// for (int day = 1; day <= days && !found; day++)
// {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
//     {
//         bool isFree = (day == 3 && lesson == 4);
//         if (isFree)
//         {
//             System.Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }
// if (!found)
// {
//     System.Console.WriteLine("Свободных слотов нет");
// }

// // Задача А
// int[] massif = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// int search = 11;
// bool isSearch = false;
// for (int i = 0; i < massif.Length; i++)
// {
//     if (massif[i] == search)
//     {
//         isSearch = true;
//         break;
//     }
// }
// System.Console.WriteLine(isSearch ? "Число найдено" : "Число не найдено");

// // Задача В
// int[] massif = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// int sum = 0;
// for (int i = 0; i < massif.Length; i++)
// {
//     if (massif[i] % 2 == 0)
//     {
//         sum += massif[i];
//         continue;
//     }
// }
// System.Console.WriteLine($"Сумма чётных чисел: {sum}");

// System.Console.Write("Введите свою фамилию: ");
// string surname = System.Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname))
// {
//     System.Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// System.Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// // Вариант 2
// using System.Runtime.InteropServices;

// System.Console.WriteLine("Введите числа (0 - конец): ");
// int number = int.Parse(System.Console.ReadLine());
// for (;number != 0;)
// {
//     bool isSimple = true;
//     for (int i = 2; i < number; i++)
//     {
//         if (number % i == 0)
//         {
//             isSimple = false;
//             break;
//         }
//     }
//     System.Console.WriteLine(isSimple ? $"Число {number} - простое" : $"Число {number} - не простое");
//     number = int.Parse(System.Console.ReadLine());
// }

// // Вариант 8
// int[] massif1 = { 1, 2, 3, 4, 5 };
// int[] massif2 = { 6, 7, 8, 9, 10 };
// bool isEquals = false;
// for (int i = 0; i < massif1.Length; i++)
// {
//     for (int j = 0; j < massif2.Length; j++)
//     {
//         if (massif1[i] == massif2[j])
//         {
//             isEquals == true;
//             break;
//         }
//     }
//     if (isEquals)
//     {
//         break;
//     }
// }
// System.Console.WriteLine(isEquals ? "Есть одно число, встречающиеся в обоих массивах" : "Нету числа, встречающиеся в обоих массивах");
