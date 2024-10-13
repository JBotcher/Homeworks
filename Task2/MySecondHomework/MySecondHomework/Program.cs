// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
class Program
{
    static void Main()
    {
        // --------------- 1. არითმეტიკული ოპერაციები ---------------
        int num1 = 10;
        int num2 = 20;

        Console.WriteLine(num1 + num2);   // მიმატება
        Console.WriteLine(num1 - num2);   //გამოკლება
        Console.WriteLine(num1 * num2);   //გამრავლება
        Console.WriteLine(num1 / num2);   //გაყოფა
        Console.WriteLine(num1 % num2);   //ნაშთი

        // --------------- 2. სიზუსტის სხვაობა float, double, decimal ---------------
        float a1 = 1.0f / 7.0f;
        double a2 = 1.0 / 7.0;
        decimal a3 = 1.0m / 7.0m;

        Console.WriteLine(a1 * 7);
        Console.WriteLine(a2 * 7);
        Console.WriteLine(a3 * 7);

        // --------------- 3. ტიპების კონვერტაცია ---------------
        int b1 = 10;        // int ტიპის ცვლადი
        double b2 = 15.5;   // double ტიპის ცვლადი
        float b3 = 20.3f;   // float ტიპის ცვლადი
        decimal b4 = 25.75m;   // decimal ტიპის ცვლადი

        // implicit conversion: int to double
        b2 = b1;
        Console.WriteLine(b2);  // int-იდან double-ში კონვერტაცია

        // explicit conversion: double to float
        b3 = Convert.ToSingle(b2);
        Console.WriteLine(b3);    // double-დან float-ში კონვერტაცია

        // explicit conversion: float to decimal
        b4 = Convert.ToDecimal(b3);
        Console.WriteLine(b4);   // float-დან decimal-ში კონვერტაცია:

        // explicit conversion: decimal to float
        b3 = Convert.ToSingle(b4);
        Console.WriteLine(b3);    // decimal-დან float-ში კონვერტაცია

        // explicit conversion: float to double
        b2 = Convert.ToDouble(b3);
        Console.WriteLine(b2);   // float-დან double-ში კონვერტაცია

        // explicit conversion: double to int
        b1 = Convert.ToInt32(b2);
        Console.WriteLine(b1);      // double-დან int-ში კონვერტაცია

        // explicit conversion: decimal to double
        b2 = Convert.ToDouble(b4);
        Console.WriteLine(b2);   // decimal-დან double-ში კონვერტაცია

        // explicit conversion: int to float
        b3 = Convert.ToSingle(b1);
        Console.WriteLine(b3);    // int-დან float-ში კონვერტაცია

        // explicit conversion: int to decimal
        b4 = Convert.ToDecimal(b1);
        Console.WriteLine(b4);   // int-დან decimal-ში კონვერტაცია

        // --------------- 4. ცვლადების მნიშვნელობის გაცვლა ---------------
        int x = 5, y = 10;
        // ცვლადების მნიშვნელობების გაცვლა მათემატიკური ოპერაციებით
        x = x + y;  // ახლა x არის 15 (5 + 10)
        y = x - y;  // ახლა y არის 5 (15 - 10)
        x = x - y;  // ახლა x არის 10 (15 - 5)

        Console.WriteLine(x);
        Console.WriteLine(y);

        // --------------- 5. BMI გამოთვლა ---------------
        double height = Convert.ToDouble(Console.ReadLine());
        double weight = Convert.ToDouble(Console.ReadLine());

        double bmi = weight / (height * height);
        Console.WriteLine(bmi);

        if (bmi < 18.5)
        {
            Console.WriteLine("გამხდარი");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("ნორმალური წონა");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("ჭარბწონიანი");
        }
        else
        {
            Console.WriteLine("მსუქანი");
        }
    }
}
