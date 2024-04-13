
//zad1

/*Console.WriteLine("Write firrt number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Write secend number");
int b = int.Parse(Console.ReadLine());

if(a == b)
{
    Console.WriteLine($"Numbers {a} and {b} are eaqual");
}
else
{
    Console.WriteLine($"Numbers {a} and {b} are not eaqual");
}*/

//zad2
/*
Console.WriteLine("Write firrt number");
int c = int.Parse(Console.ReadLine());
if (c % 2 == 0)
{
    Console.WriteLine($"Number {c} is even number");
}
else
{
    Console.WriteLine($"Number {c} is odd number");
}
*/
//zad 3
/*Console.WriteLine("Hello please write your number ");
double number = double.Parse(Console.ReadLine());
if( number < 0)
{
    Console.WriteLine($"Number {number} is negative");
}
else if  ( number == 0 ) 
{
    Console.WriteLine($"Sorry you cant write {number}");
}
else
{
    Console.WriteLine($"number {number} is positive");
}
*/
//zad 4

/*Console.WriteLine("Hello write the year you want to check if it is a leap year");
int year = int.Parse(Console.ReadLine());
if( year % 4 == 0)
{
    Console.WriteLine("the year is a leap year");
}
else
{
    Console.WriteLine("the year is not a leap year");
}
*/
//zad5 posel 21 senator 30 //prezydent 35

/*Console.WriteLine("Hello please tell me how old are you?");
double age = double.Parse(Console.ReadLine());
if (21 <= age && age < 30)
{
    Console.WriteLine($"You are {age} years old and u can be envoy, Prime Minister");
}
else if (age >= 30 && age < 35)
{
    Console.WriteLine($"You are {age} years old and u can be envoy, Prime Minister, Senator");
}
else if ( age >= 35)
{
    Console.WriteLine($"You are {age} years old and u can be envoy, Prime Minister, Senator, President");
}
else 
{
    Console.WriteLine($"You are {age} years old and u cant be envoy, Prime Minister, Senator, President");
}
*/
//zad 6
/*
Console.WriteLine("Hello please write your height");
double height = double.Parse(Console.ReadLine());

if (height <= 150)
{
    Console.WriteLine("You are dwarf");
}
else if (height > 150 && height <= 170)
{
    Console.WriteLine("You are short");
}
else if (height > 170 && height < 180)
{
    Console.WriteLine("You have avarage height");
}
else if (height >= 180 && height < 190)
{
    Console.WriteLine("You are tall");
}
else
{
    Console.WriteLine("You are very tall");
}*/

//zad 7
/*
Console.WriteLine("Please write 3 numbers");
double first_Number = double.Parse(Console.ReadLine());
double secend_Number = double.Parse(Console.ReadLine());
double third_Number = double.Parse(Console.ReadLine());

if (first_Number > secend_Number && first_Number > third_Number)
{
    
    Console.WriteLine($"{first_Number} is the biggest");
}
else if (secend_Number > third_Number && secend_Number > first_Number)
{
    Console.WriteLine($"{secend_Number} is the biggest");
}
else if (third_Number > first_Number && third_Number > secend_Number)
{
    Console.WriteLine($"{third_Number} is the biggest");
}
else if ((first_Number > secend_Number) && first_Number == third_Number)
{
    Console.WriteLine($"{first_Number} is the biggest");
}
else if ( first_Number > third_Number && first_Number == secend_Number)
{
    Console.WriteLine($"{first_Number} is the biggest");
}
else if ((secend_Number > first_Number) && secend_Number == third_Number)
{
    Console.WriteLine($"{secend_Number} is the biggest");
}
else if (secend_Number > third_Number && secend_Number == first_Number)
{
    Console.WriteLine($"{secend_Number} is the biggest");
}
else if ((third_Number > first_Number) && third_Number == secend_Number)
{
    Console.WriteLine($"{third_Number} is the biggest");
}
else if (third_Number > secend_Number && third_Number == first_Number)
{
    Console.WriteLine($"{third_Number} is the biggest");
}
else
{
    Console.WriteLine($"All numbers are the same");
}*/

//zad 8
/*Console.WriteLine("Hello please write your math test results");
int math = int.Parse(Console.ReadLine());
Console.WriteLine("Hello please write your physics test results");
int physics = int.Parse(Console.ReadLine());
Console.WriteLine("Hello please write your chemistry test results");
int chemistry = int.Parse(Console.ReadLine());

if (math > 70 && physics > 55 && chemistry > 45 && (math + physics + chemistry > 180))
{
    Console.WriteLine(" Kandydat dopuszczony do rekrutacji");
}
else if ((math + physics > 150) || (math + chemistry > 150))
{
    Console.WriteLine(" Kandydat dopuszczony do rekrutacji");
}
else
{
    Console.WriteLine(" Kandydat nie został dopuszczony do rekrutacji");
}

//zad 9

Console.WriteLine("Plese enter the temperature");
double temperature = double.Parse(Console.ReadLine());

if (temperature < 0)
{
    Console.WriteLine("cholernie piźdz");
}
else if (temperature >= 0 && temperature < 10)
{
    Console.WriteLine("zimno");

}
else if (temperature >= 10 && temperature < 20)
{
    Console.WriteLine("chłodno ");

}
else if (temperature >= 20 && temperature < 30)
{
    Console.WriteLine("w sam raz ");

}
else if (temperature >= 30 && temperature < 40)
{
    Console.WriteLine("zaczyna być słabo, bo gorąco");

}
else
{
    Console.WriteLine("a weź wyprowadzam się na Alaskę.");
}
*/
//zad 10 

/*Console.WriteLine("Please give the lengths of the sides of the triangle");
Console.WriteLine("Enter first side length of the triangle");
double lenght1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter secend side length of the triangle");
double lenght2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter third side length of the triangle");
double lenght3 = double.Parse(Console.ReadLine());

if ( (lenght1 + lenght2) > lenght3 && (lenght1 + lenght3) > lenght2 && (lenght2 + lenght3) > lenght1)
{
    Console.WriteLine("You can build the trinagle");
}
else if (lenght1<=0 || lenght2 <= 0 || lenght3 <= 0)
{
    Console.WriteLine("The side of the trinagle cant be <= 0");
}
else
{
    Console.WriteLine("You cant build the trinagle");
}*/

/*//zad 11
*//*Console.WriteLine("Please write your grade");
int grade = int.Parse(Console.ReadLine());

switch (grade)
{
    case 1:
        Console.WriteLine("Niedostateczny");
        break;
    case 2:
        Console.WriteLine("Dopuszczający");
        break;
    case 3:
        Console.WriteLine("Dostateczny");
        break;
    case 4:
        Console.WriteLine("Dobry");
        break;
    case 5:
        Console.WriteLine("Bardzo dobry");
        break;
    case 6:
        Console.WriteLine("Celujący");
        break;*//*

}*/

//zad 12

/*   Console.WriteLine("Please write number of the week day ");
int day = int.Parse(Console.ReadLine());
switch (day)
{
case 1:
   Console.WriteLine("Monady");
   break;
case 2:
   Console.WriteLine("Tuesday");
   break;
case 3:
   Console.WriteLine("Wednesday");
   break;
case 4:
   Console.WriteLine("Thursday");
   break;
case 5:
   Console.WriteLine("Friday");
   break;
case 6:
   Console.WriteLine("Saturday");
   break;
case 7:
   Console.WriteLine("Sunday");
   break;

}
*/

//zad 13
bool resParse1, resParse2;
double first_Number, secend_Number;
Console.WriteLine("Write your first number");
resParse1 = double.TryParse(Console.ReadLine(), out first_Number);
Console.WriteLine("Write your secend number");
resParse2 = double.TryParse(Console.ReadLine(), out secend_Number);
Console.WriteLine("Choose your operation");
Console.WriteLine("1.Add");
Console.WriteLine("2.Minus");
Console.WriteLine("3.Multiply");
Console.WriteLine("4.Divide");
int operation = int.Parse(Console.ReadLine());
 if (!resParse1)
{
    Console.WriteLine("You have to write number");
}
 else if (!resParse2)
{
    Console.WriteLine("You have to write number");
}
 else if (operation == 4 && secend_Number == 0)
{
    Console.WriteLine("You cant divide by 0!");   
}
else 
{
    switch (operation)
    {
        case 1 :
            Console.WriteLine($"{first_Number} + {secend_Number} = {first_Number + secend_Number}");
            break;
        case 2:
            Console.WriteLine($"{first_Number} - {secend_Number} = {first_Number - secend_Number}");
            break;
        case 3:
            Console.WriteLine($"{first_Number} * {secend_Number} = {first_Number * secend_Number}");
            break;
        case 4:
            Console.WriteLine($"{first_Number} / {secend_Number} = {first_Number / secend_Number}");
            break;
        default:
            Console.WriteLine("Wrong operation");
            break;
    }
}



