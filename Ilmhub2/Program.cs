/*tiplar
*int 
*float
*doudle
* short
* long
* byte
*/


//double doubleValue = 2.54;
//decimal decimalValue = 2.54m;
//float floatValue = 2.54f;

// ko'p o'zgaruvchilarni qiymat bermasdan elon qilish
// int i, j;
// i=1
// j=2;
// int k = 1, m = 0;

//// konstanta o'zgaruvchi qiymati bilan elon qilgandan so'ng o'zgartirish mumkin emas.
// const double Pi =3.14;
// Pi = 2.14;


// // O'zgaruvchi nomiga C# tilining tayanch/kalit so'zlaridan foydalanish uchun oldiga @ belgisi qo'yiladi.
//string @int = "20";
//int @string = 20;

//// O'zgaruvchilarga manoli nom berish kerak 
// string sodikvjnso = "30"; bu xato

//// Mahalliy o'zgaruvchilar nomi camelCase Saklida yoziladi
// string firstName = "Mark";

//// value type dagi o'zgaruvchilarga qiymat berish va chop etish
// byte number1 = 10;
// int number2 = 10;
// float number3 = 10.1f;
// double number4 = 10.1;
// long number5 = 10;
// short number6 = 10;
// decimal number7 = 10.1m;


// Console.WriteLine("byte - " + number1);
// Console.WriteLine("int - " + number2);
// Console.WriteLine("float - " + number3);
// Console.WriteLine("double - " + number4);
// Console.WriteLine("long - " + number5);
// Console.WriteLine("Short - " + number6);
// console.WriteLine("decimal - " + number7);


// // value type'dagi tiplarning maksimal qiymatlari
// byte value1 = byte.MaxValue;
// int value2 = int.MaxValue;
// float value3 = float.MaxValue;
// double value4 = double.MaxValue;
// long value5 = long.MaxValue;
// short value6 = short.MaxValue;
// decimal value7 = decimal.MazValue;


// Console.WriteLine(value1);
// Console.WriteLine(value2);
// Console.WriteLine(value3);
// Console.WriteLine(value4);
// Console.WriteLine(value5);
// Console.writeLine(value6);
// Console.WriteLine(value7);


// // Ichma-ich qavslar haqida
// byte value1 = byte.MaxValue;
//{
//    byte value10 = 20;
//    {
//        byte value20 = 30;
//        {
//            byte value30 = 40;
//        }
//    }
//}    


// uint, ulong, ushort - kabi tiplar int, long, short intervalining faqat musbatini oladi
// uint - unsigned integer

// // i1 va i2 o'zgaruvchilardagi qiymatlar int tipining maxsimal qiymati
// int - i1 = 2147483647;
// int - i2 = 2147483647;


// // output -2
// int i3 = i1 + i2;
// Console.WriteLine(i3);

// // output: System.OverflowException: Arithmetic operation resulted in an overflow.
// int i4 = checked(i4);


// // Compile timi'da tipi aniq bo'ladi
// var value1 = 24;
// var value2 = true;
// var value3 = "hello";
// var value4 = 'y';
// var value5 = 4.76;

// int i = 0, j = 1, k;//
// var value6,value7; // 

// // Runtime'da tipi aniq bo'ladi
// dynamic value1 = 24;
// dynamic value2 = true;
// dynamic value3 = "hello";
// dynamic value4 = 'y';
// dynamic value5 = 4.76;


// dynamic value6 = 8, value7 = 10; //

// static dynamic Method1() { return 1; } //
// static var Method() { return 1; } //

// static dynamic Method1(dynamic object1) { return 1; } //
// static var Method2(var object2) { return 1; } //



//int a = 1;
//while (a <= 8)
//{
//    if (a == 5)
//    {
//        a++;
//        continue;
//    }
//    Console.WriteLine(a);


//}



//class Program
//{
//    static void Main(string[] args)
//    {
//      /*  for (int i = 0; i < 10; i++)
//        {
//            if (i == 8) continue;
//            else Console.Write(i + " ");
//        }*/

//    int i = 0;
//    while(i < 10)
//    {
//        i++;
//        if(i == 5)
//        {
//            continue;
//        }
//        Console.WriteLine(i);
//    }
//    }
//}

//// cs0131 xatosi const doimiy qiymatning o'zgartirishga harakat qilingan

//const int value = 10;
//value = 20;

//// buyerda o'zgaruvchi qiymati o'zgara oladi
//int v = 10;
//v = 20;

// cs0133 xatosi constni barcha qisimlari const bo'lishi kerak

//int size = 5;
//const int value = 10 + size;

//const int valuea  = 20 + 30;


//using Ilmhub2;

//class Program
//{
//    public static void  Main() 
//    {
//        Car car = new Car();

//        Console.WriteLine(car);
//    }
//}


//for (int i=1; i<=10; i++)
//{
//    if(i%2==0)
//    {
//        Console.WriteLine(i);
//    }
//}

//int i = 1;
//while(i<=10)
//{
//    if (i%2==0)
//    {
//        Console.WriteLine(i);
//    }
//    i++;
//}

//int i = 1;
//do
//{   
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//    i++;
//}
//while (i <= 10);

//int a = 10;

// List<int> a = [1, 2, 3];
//foreach (var item in a)
//{
//    Console.WriteLine(item);
//}


///*
// * Agar bu holatda int yoki decimal tipdagi qiymat 0 ga bo'linadigan bolsa exsepshen kelib chiqadi
// * 
// */

//try
//{
//    int i = 22;
//    int result = i / 0;
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("You cannot divide number with zero ", ex.Message);
//}

////Bu holatda dastur o'zi istisno otib yuboradi
//int i = 23;
//int result = i / 0;
//Console.WriteLine(result);

//try
//{
//    string mystring = default;
//    mystring.Insert(0, "hello");

//    int i = 20;
//    int j = 0; 
//    default result = DivideNumber(i, j);

//    object obj = default;
//    int i2 = (int)obj;
//    // Suspect of casting error
//}
//catch(InvalidCastException ex)
//{
//    Console.WriteLine("Invalid casting. {0}", ex.Message);
//}
//catch(StackOverflowException ex)
//{
//    Console.WriteLine("Overflow. {0}", ex.Message);
//}
//catch(DivideByZeroException ex)
//{
//    Console.WriteLine("Attempted divide by zero. {0}", ex.Message);
//}

//static double DivideNumber(double num1, double num2)
//{
//    if(num1 < num2)
//    {
//        num1 += 20;
//        return num1 / num2;
//    }
//}