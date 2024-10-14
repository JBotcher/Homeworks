using System;

class Program
{
    static void Main()
    {
        // --------------- 1. ხმოვნების დათვლა ---------------

        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine().ToLower();  // მომხმარებლის ტექსტის შეყვანა და ასოების ქვედა რეგისტრში გადაყვანა

        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };  // ხმოვნების სია
        int vowelCount = 0;  // ხმოვნების რაოდენობა

        foreach (char character in input)  // ტექსტის თითოეული სიმბოლოს შემოწმება
        {
            if (Array.Exists(vowels, vowel => vowel == character))  // ამოწმებს, არის თუ არა სიმბოლო ხმოვნების სიაში
            {
                vowelCount++;
            }
        }

        Console.WriteLine("Number of vowels: " + vowelCount);  // ხმოვნების რაოდენობის დაბეჭდვა

        //---------------2.გამრავლების ტაბულა---------------

        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());  // მომხმარებლის მიერ რიცხვის შეყვანა

        Console.WriteLine("Multiplication Table of " + number + ":");
        for (int i = 1; i <= 10; i++)  // 1-დან 10-მდე გამრავლება
        {
            Console.WriteLine(number + " x " + i + " = " + (number * i));
        }

        // --------------- 3. მატრიცების შეკრება ---------------

        int[,] matrix1 = new int[3, 3];  // პირველი 3x3 მატრიცა
        int[,] matrix2 = new int[3, 3];  // მეორე 3x3 მატრიცა
        int[,] sumMatrix = new int[3, 3];  // მატრიცების ჯამის მატრიცა

        Console.WriteLine("Enter values for the first 3x3 matrix:");
        for (int i = 0; i < 3; i++)  // პირველი მატრიცის შევსება
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Enter value for matrix1[{i},{j}]: ");
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter values for the second 3x3 matrix:");
        for (int i = 0; i < 3; i++)  // მეორე მატრიცის შევსება
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Enter value for matrix2[{i},{j}]: ");
                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++)  // მატრიცების შეკრება
        {
            for (int j = 0; j < 3; j++)
            {
                sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        Console.WriteLine("Sum of the matrices:");
        for (int i = 0; i < 3; i++)  // შეკრებილი მატრიცის გამოქვეყნება
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(sumMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // --------------- 4. კონსოლური კალკულატორი მენიუთი ---------------
        bool exit = false;  // აპლიკაციის გასათიშად
        while (!exit)
        {
            // მენიუს ჩვენება
            Console.WriteLine("Calculator Menu:");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Exit");
            Console.Write("Choose an option: ");

            int choice = Convert.ToInt32(Console.ReadLine());  // არჩევანის შეყვანა

            if (choice >= 1 && choice <= 4)  // თუ არჩევანი არის 1-დან 4-მდე
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                switch (choice)
                {
                    case 1:  // მიმატება
                        result = num1 + num2;
                        break;
                    case 2:  // გამოკლება
                        result = num1 - num2;
                        break;
                    case 3:  // გამრავლება
                        result = num1 * num2;
                        break;
                    case 4:  // გაყოფა
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            continue;
                        }
                        break;
                }
                Console.WriteLine("Result: " + result);  // შედეგის ჩვენება
            }
            else if (choice == 5)  // აპლიკაციის გათიშვა
            {
                exit = true;
                Console.WriteLine("Exiting...");
            }
            else
            {
                Console.WriteLine("Invalid option, try again.");  // არასწორი არჩევანი
            }
        }
    }
}
