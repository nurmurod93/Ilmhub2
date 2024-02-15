//// // hafta kunlarini enum sifatida yozish
// enum DaysOfWeek : short
//{
//    Monday = 1,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday,
//    Sunday,
//};

//// // enum With switch case
//DaysOfWeek weekDay = DaysOfWeek.Monday;
//switch(weekDay)
//{
//    case DaysOfWeek.Monday:
//        Console.WriteLine("Zoom meeting on Monday");
//        break;
//        case DaysOfWeek.Tuesday:
//        Console.WriteLine("Zoom meeting on Tuesday");
//        break;
//        default: Console.WriteLine("Zoom meeting yo'q");
//        break;
//}

// // hafta kunlarini const sifatida yozish
//const string dushanba = "dushanba";
//const string seshanba = "seshanba";
//const string chorshanba = "chorshanba";
//const string Payshanba = "payshanba";
//const string juma = "juma";
//const string shanba = "shanba";
//const string yakshanba = "yakshanba";

/*
 * int 
 * double
 * float 
 * decimal
 * short
 * byte
 * long
 * string
 */

// // C# dagi ilk versiyalarda nullable fichani qo'shish imkoniyatini beradi

// Nullable<int> nulable = null;


// // Bunda value type dagi tiplar faqat o'zining berilgan intervalidagi qiymatlarni qabul qiladi;
// int value1 = 1;
// double value2 = 2.34;
// float value3 = 3.67F;


// //Bunday value type dagi tiplar ham o'zining intervalidagi  qiymatlarni ham qabul qiladi;
// int? number = null;
// int? number2 = 20;

// // Bunday string tipdagi qiymatni ham null qiymatni ham qabul qiladi
// string? text = "matn";
// string text1 = null;
// string text2 = default;
// string text3 = "";


/*
 * ?, !, ??, ??=
 */


// // ! nullable operator compiler'ga o'zgaruvchi null emasligini eslatadi
//string? text = "salom";
//string matn = text!;
//Console.WriteLine("string -> matn: " + matn);


// // ?? operator agar o'zgaruvchining qiymati null kelsa, boshqa qiymatni shart asosida beradi.
// int? c = null;
// int d = c ?? -1;
// c ??= -2;
// if (c == null)
// {
//      d = -1;
// }
// Console.WriteLine($"d is {d}"); // output: d is -1
// Console.WriteLine($"c is {c}"); // output: d is -1



/*
 * Arifmetik: +, -, /, *, %
 * Mantiqiy: va, yoki, emas, &&, ||, !
 * Bitwise: va, yoki, &, |,
 * Taqqoslash: >, <, <=, >=, !=, ==
 * Biriktirish: =, +=, -=, *=, /=
 */

// // Biriktirish operatorlariga misol
// int a = 10;
// int c = 20;
// c *= a; // => c = c * a;
// c /= a; // => c = c / a;
// c += a; // => c = c + a;
// c -= a; // => c = c - a;

//string c = Console.WriteLine();



//if (a == b)
//{
//    Console.WriteLine("A = B");
//}
//else
//{
//    Console.WriteLine("B != A"); 
//}

//Console.WriteLine("A qiymatni kiriting:");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("B qiymatini kiriting: ");
//int b = Convert.ToInt32(Console.ReadLine());


// string c = a > b ? "A > B" : "B > A"; // ternary operatori
// if (a > b)
// { 
//      c = "A > B";
// }
// else
// { 
//      c = "B > A";
// } 
// Console.WriteLine(c);


// // ??= operator agar berilgan o'zgaruvchi qiymati null bo'lsa, shartdan keyingi qiymatni biriktiradi
// int z = 6;
// int w = 7;
// int? x = null;
// int y = x ??= z;
// Console.WriteLine(y);

// Console.WriteLine("A qiymatni kiriting: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("B qiymatni kiriting: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Operator kiriting: ");
// string c = Console.ReadLine();

// if (c == "+")
// {
//      Console.WriteLine(a + b);
// }
// else if (c == "-")
// {
//      Console.WriteLine(a - b);
// }
// else if (c == "*")
// {
//      Console.WriteLine(a * b);
// }
// else if (c == "/")
// {
//      Console.WriteLine(a / b);
// }
// else if (c == "%")
// {
//      Console.WeriteLine(a % b);
// }
// else
// {
//      Console.WriteLine("Kerakli operatorni kiriting!");
// }


// switch(C)
// {
//      case "+":
//          Console.WriteLine(a + b);
//          break;
//      case "-":
//          Console,WriteLine(a - b);
//          break;

// 1 soat 38 min

//using System.Globalization;

//int n, a, b;

//n = Convert.ToInt32(Console.ReadLine());
//a = Convert.ToInt32(Console.ReadLine());
//b = Convert.ToInt32(Console.ReadLine());


//switch((n > 0))
//{
//    case true: Console.WriteLine("Katta a");
//        break;

//}

////Goto operatori

//var matrices = new Dictionary<string, int[][]>
//{
//    ["A"] =
//    [
//        [1, 2, 3, 4],
//        [4, 3, 2, 1]
//    ],
//    ["B"] =
//    [
//        [5, 6, 7, 8],
//        [8, 7, 6, 5]
//    ],
//};

//CheckMatrices(matrices, 4);

//void CheckMatrices(Dictionary<string, int[][]> matrixLookup, int target)
//{
//    foreach (var (key, matrix) in matrixLookup)
//    {
//        for (int row = 0; row < matrix.Length; row++)
//        {
//            for (int col = 0; col < matrix[row].Length; col++)
//            {
//                if (matrix[row][col] == target)
//                {
//                    goto Found;
//                }
//            }
//        }
//        Console.WriteLine($"Not found {target} in matrix {key}.");
//        continue;

//        Found:
//        Console.WriteLine($"Found {target} in matrix {key}.");
//    }
//}
//// Output:
//// Found 4 in matrix A.
//// Not found 4 in matrix B.
///

//int[,] array2DDeclaration = new int[4, 2];

//int[,,] array3DDeclaration = new int[4, 2, 3];

//// Two-dimensional array.
//int[,] array2DInitialization = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
//// Three-dimensional array.
//int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4,   5,  6 } },
//                                { { 7, 8, 9 }, { 10, 11, 12 } } };

//// Accessing array elements.
//System.Console.WriteLine(array2DInitialization[0, 0]);
//System.Console.WriteLine(array2DInitialization[0, 1]);
//System.Console.WriteLine(array2DInitialization[1, 0]);
//System.Console.WriteLine(array2DInitialization[1, 1]);

//System.Console.WriteLine(array2DInitialization[3, 0]);
//System.Console.WriteLine(array2DInitialization[3, 1]);
//// Output:
//// 1
//// 2
//// 3
//// 4
//// 7
//// 8

//System.Console.WriteLine(array3D[1, 0, 1]);
//System.Console.WriteLine(array3D[1, 1, 2]);
//// Output:
//// 8
//// 12

//// Getting the total count of elements or the length of a given dimension.
//var allLength = array3D.Length;
//var total = 1;

//object[] array = new object[allLength]; 

//for (int i = 0; i < array3D.Rank; i++)
//{
//    total *= array3D.GetLength(i);
//}
//System.Console.WriteLine($"{allLength} equals {total}");
//// Output:
//// 12 equals 12




/*string str = "Salom";
for (; ; )
{
    str += "Salom ";
}
Console.WriteLine(str);
*/

//int a = 0;
//while (a < 6)
//{
//    if (a == 3)
//    {
//        continue;
//    }
//    else
//    {
//        Console.WriteLine(a);
//    }
//    a++;
//}

try
{
    string mystring = default;
    mystring.Insert(0, "hello");

    int i = 20;
    int j = 0;
    default result = DivideNumber(i, j);

    object obj = default;
    int i2 = (int)obj;
    // Suspect of casting error
}
catch (InvalidCastException ex)
{
    Console.WriteLine("Invalid casting. {0}", ex.Message);
}
catch (StackOverflowException ex)
{
    Console.WriteLine("Overflow. {0}", ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Attempted divide by zero. {0}", ex.Message);
}

static double DivideNumber(double num1, double num2)
{
    if (num1 < num2)
    {
        num1 += 20;
        return num1 / num2;
    }
}