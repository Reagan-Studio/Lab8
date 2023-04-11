

////номер2(с)----------------------------------------------------------------------------------------------------------------------
//static bool StartsWithW(string str)
//{
//    return str.StartsWith("W");
//}

//static bool ContainsHyphen(string str)
//{
//    return str.Contains("-");
//}

//string[] words = { "Waste re-co", "Water","aaa-bb", "Air-Play Wooo", "Dish-washer" };

//var startsWithW = new List<string>();
//foreach (var word in words)
//{
//    string[] array = word.Split(' ');
//    foreach (string str in array)
//    {
//        if (new StringPredicate(StartsWithW).Invoke(str))
//        {
//            startsWithW.Add(str);
//        }
//    }
//}
//Console.WriteLine("Все слова, начинающиеся на букву ‘W’:");
//foreach (var word in startsWithW)
//{
//    Console.WriteLine(word);
//}


//var containsHyphen = new List<string>();
//foreach (var word in words)
//{
//    string[] array = word.Split(' ');
//    foreach (string str in array)
//    {
//        if (new StringPredicate(ContainsHyphen).Invoke(str))
//        {
//            containsHyphen.Add(str);
//        }
//    }
//}

//Console.WriteLine("Все составные слова, включащие дефис:");
//foreach (var word in containsHyphen)
//{
//    Console.WriteLine(word);
//}

//delegate bool StringPredicate(string str);






////номер2(b)-------------------------------------------------------------------------------------------------------------------------------
//static int TenCharacterStringsCounter(string[] array)
//{
//    Func<string, bool> TenSimbStringPredicate = s => s.Length == 10;

//    int counter = 0;

//    foreach (string str in array)
//    {
//        if (TenSimbStringPredicate(str))
//        {
//            counter++;
//        }
//    }
//    return counter;
//}

//static int FiveLetWordsCounter(string[] array)
//{
//    Func<string, bool> FiveLetWordPredicate = str => str.Split(' ').Count(w => w.Length == 5) > 0;

//    int count = 0;

//    foreach (string s in array)
//    {
//        if (FiveLetWordPredicate(s))
//        {
//            count++;
//        }
//    }
//    return count;
//}


//string[] array = new string[]
//{
//    "паенрогнек",
//    "енгош инмнпмнгми",
//    "кенгш",
//    "ываирнголд",
//    "е рпаен",
//    "шриршр рммгг"
//};

//int tenCharacterStringsCounter = TenCharacterStringsCounter(array);
//int fiveLetWordsCounter = FiveLetWordsCounter(array);

//Console.WriteLine($"Кол-во десятизначных строк в массиве = {tenCharacterStringsCounter}");
//Console.WriteLine($"Кол-во предложений, содержащих пятибуквенные слова в массиве = {fiveLetWordsCounter}");






////номер2(a)------------------------------------------------------------------------------------------------------------------------------------
//int StringsCounter(string[] strings, StringPredicate predicate)
//{
//    int count = 0;
//    foreach (string str in strings)
//    {
//        if (predicate(str))
//        {
//            count++;
//        }
//    }
//    return count;
//}

//int StringsWithoutUpperCounter(string[] strings)
//{
//    StringPredicate predicate = str => !str.Any(char.IsUpper);
//    return StringsCounter(strings, predicate);
//}

//int PalindromesCounter(string[] strings)
//{
//    StringPredicate predicate = str =>
//    {
//        int length = str.Length;
//        for (int i = 0; i < length / 2; i++)
//        {
//            if (str[i] != str[length - i - 1])
//            {
//                return false;
//            }
//        }
//        return true;
//    };
//    return StringsCounter(strings, predicate);
//}

//string[] strings = new string[] { "dgugfhe","nuhegew","ycftcRvcc", "hello", "bob", "vaav" };

//int WithoutUpperCount = StringsWithoutUpperCounter(strings);
//int PalindromesCount = PalindromesCounter(strings);

//Console.WriteLine($"Kол-во строк, в которых нет заглавных букв  = {WithoutUpperCount}");
//Console.WriteLine($"Kол-во палиндромов = {PalindromesCount}");

//public delegate bool StringPredicate(string str);






////номер1(д)--------------------------------------------------------------------------------------------------------------------------
//static void MaxMinValues(double[] points, Func<double, double>[] functions)
//{
//    foreach (Func<double, double> f in functions)
//    {
//        double minValue = double.MaxValue;
//        double maxValue = double.MinValue;

//        foreach (double x in points)
//        {
//            if (f(x) < minValue)
//            {
//                minValue = f(x);
//            }

//            if (f(x) > maxValue)
//            {
//                maxValue = f(x);
//            }
//        }

//        Console.WriteLine($"\nМинимальное значение для функции {f.Method.Name} из массива точек = {minValue}");
//        Console.WriteLine($"Максимальное значение для функции {f.Method.Name} из массива точек = {maxValue}");
//    }
//}


//double[] points = { -10, -7.5, -5, -3, 1, 3, 6, 9, 10 };
//Func<double, double>[] functions = { FuncCos, FuncSqrt_Abc, FuncC, FuncD, FuncE };
//MaxMinValues(points, functions);


////a
//double FuncCos(double x) { return Math.Cos(x); }

////b
//double FuncSqrt_Abc(double x) { return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1; }

////c
//double FuncC(double x) => (-1) * Math.Pow(x / Math.PI, 2) - 2 * x + 5 * Math.PI;

////d
//double FuncD(double x)
//{
//    double result = 0;
//    for (int i = 1; i <= 100; i++)
//    {
//        result += Math.Pow(x / Math.PI * i - 1, 2);
//    }
//    return result;
//}

////e
//double FuncE(double x)
//{
//    if (x < 0)
//    {
//        return 0.25 * Math.Sin(x) * Math.Sin(x) + 1;
//    }
//    else
//    {
//        return 0.5 * Math.Cos(x) - 1;
//    }
//}






////номер1(г)--------------------------------------------------------------------------------------------------------------------
//Func<double, double>[] functions = { FuncCos, FuncSqrt_Abc, FuncC, FuncD, FuncE };

//Predicate<double> isNegative = y => y < 0;
//Predicate<double> isInRange = y => y >= -1 && y <= 1;


//int TotalNegativeCounter = 0;
//int TotalRangeCounter = 0;


//foreach (Func<double, double> f in functions)
//{
//    TabulateFunction(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, f);
//    int NegativeCounter = TabulateFunction_(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, f, isNegative);
//    int InRangeCounter = TabulateFunction_(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, f, isInRange);
//    Console.WriteLine($"Кол-во отрицательных значений функции = {NegativeCounter}, значений в диапазоне [-1, 1] = {InRangeCounter}");

//    TotalNegativeCounter += NegativeCounter;
//    TotalRangeCounter += InRangeCounter;
//}


////стандарт табуляция
//static void TabulateFunction(double a, double b, double step, Func<double, double> f)
//{
//    Console.WriteLine($"\n\n\nЗначение функции {f.Method.Name} на отрезке [{a}; {b}] с шагом {step}:");
//    for (double x = a; x <= b; x += step)
//    {
//        Console.WriteLine($"x={x}\tf(x)={f(x)}");
//    }
//}

////просто пересчет нужного
//static int TabulateFunction_(double a, double b, double step, Func<double, double> f, Predicate<double> condition)
//{
//    int counter = 0;
//    for (double x = a; x <= b; x += step)
//    {
//        if (condition(f(x)))
//        {
//            counter++;
//        }
//    }
//    return counter;
//}

//Console.WriteLine($"\nОбщее кол-во отрицательных значений = {TotalNegativeCounter}, общее кол-во значений в диапазоне [-1, 1] = {TotalRangeCounter}");


////a
//double FuncCos(double x) { return Math.Cos(x); }

////b
//double FuncSqrt_Abc(double x) { return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1; }

////c
//double FuncC(double x) => (-1) * Math.Pow(x / Math.PI, 2) - 2 * x + 5 * Math.PI;

////d
//double FuncD(double x)
//{
//    double result = 0;
//    for (int i = 1; i <= 100; i++)
//    {
//        result += Math.Pow(x / Math.PI * i - 1, 2);
//    }
//    return result;
//}

////e
//double FuncE(double x)
//{
//    if (x < 0)
//    {
//        return 0.25 * Math.Sin(x) * Math.Sin(x) + 1;
//    }
//    else
//    {
//        return 0.5 * Math.Cos(x) - 1;
//    }
//}







////номер1(в)------------------------------------------------------------------------------------------------------------------
//Func<double, double>[] functions = { FuncCos, FuncSqrt_Abc, FuncC, FuncD, FuncE };

//foreach (Func<double, double> f in functions)
//{
//    TabulateFunction(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, f);
//}

//static void TabulateFunction(double a, double b, double step, Func<double, double> f)
//{
//    Console.WriteLine($"\n\n\nЗначение функции {f.Method.Name} на отрезке [{a}; {b}] с шагом {step}:");
//    for (double x = a; x <= b; x += step)
//    {
//        Console.WriteLine($"x={x}\tf(x)={f(x)}");
//    }
//}

////a
//double FuncCos(double x) { return Math.Cos(x); }

////b
//double FuncSqrt_Abc(double x) { return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1; }

////c
//double FuncC(double x) => (-1) * Math.Pow(x / Math.PI, 2) - 2 * x + 5 * Math.PI;

////d
//double FuncD(double x)
//{
//    double result = 0;
//    for (int i = 1; i <= 100; i++)
//    {
//        result += Math.Pow(x / Math.PI * i - 1, 2);
//    }
//    return result;
//}

////e
//double FuncE(double x)
//{
//    if (x < 0)
//    {
//        return 0.25 * Math.Sin(x) * Math.Sin(x) + 1;
//    }
//    else
//    {
//        return 0.5 * Math.Cos(x) - 1;
//    }
//}






////номер1(б)----------------------------------------------------------------------------------------------------------------------
////a
//TabulateFunction(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, FuncCos);

////b
//TabulateFunction(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, FuncSqrt_Abc);

////c
//TabulateFunction(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, x => ((-1) * Math.Pow(x / Math.PI, 2) - 2 * x + 5 * Math.PI));

////d
//TabulateFunction(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, x =>
//{
//    double result = 0;
//    for (int i = 1; i <= 100; i++)
//    {
//        result += Math.Pow(x / Math.PI * i - 1, 2);
//    }
//    return result;
//});

////e
//TabulateFunction(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, x =>
//{
//    if (x < 0)
//    {
//        return 0.25 * Math.Sin(x) * Math.Sin(x) + 1;
//    }
//    else
//    {
//        return 0.5 * Math.Cos(x) - 1;
//    }
//});


//static void TabulateFunction(double a, double b, double step, Func<double, double> f)
//{
//    Console.WriteLine($"\n\n\nЗначение функции {f.Method.Name} на отрезке [{a}; {b}] с шагом {step}:");
//    for (double x = a; x <= b; x += step)
//    {
//        Console.WriteLine($"x={x}\tf(x)={f(x)}");
//    }
//}


//double FuncCos(double x) { return Math.Cos(x); }

//double FuncSqrt_Abc(double x) { return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1; }






////номер1(а)-------------------------------------------------------------------------------------------------------------------
////a
//TabulateFunction(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, FuncCos);

////b
//TabulateFunction(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, FuncSqrt_Abc);

////c
//TabulateFunction(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, x => ((-1) * Math.Pow(x / Math.PI, 2) - 2 * x + 5 * Math.PI));

////d
//TabulateFunction(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, x =>
//{
//    double result = 0;
//    for (int i = 1; i <= 100; i++)
//    {
//        result += Math.Pow(x / Math.PI * i - 1, 2);
//    }
//    return result;
//});

////e
//TabulateFunction(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, x =>
//{
//    if (x < 0)
//    {
//        return 0.25 * Math.Sin(x) * Math.Sin(x) + 1;
//    }
//    else
//    {
//        return 0.5 * Math.Cos(x) - 1;
//    }
//});


//static void TabulateFunction(double a, double b, double step, ArifmFunc f)
//{
//    Console.WriteLine($"\n\n\nЗначение функции {f.Method.Name} на отрезке [{a}; {b}] с шагом {step}:");
//    for (double x = a; x <= b; x += step)
//    {
//        Console.WriteLine($"x={x}\tf(x)={f(x)}");
//    }
//}


//double FuncCos(double x) { return Math.Cos(x); }

//double FuncSqrt_Abc(double x) { return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1; }

//public delegate double ArifmFunc(double x);



