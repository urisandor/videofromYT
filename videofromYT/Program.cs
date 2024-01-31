namespace videofromYT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Constans
            // constans

            //const double pi = 3.14;
            //pi = 420;
            #endregion

            #region Type Casting
            // type casting

            //double a = 3.14;
            //int b = Convert.ToInt32(a);

            //int c = 123;
            //double d = Convert.ToDouble(c) + 0.1;

            //int e = 321;
            //String f = Convert.ToString(e);

            //String g = "$";
            //char h = Convert.ToChar(g);

            //String i = "true";
            //bool j = Convert.ToBoolean(i);

            //Console.WriteLine(b.GetType());
            //Console.WriteLine(d.GetType());
            //Console.WriteLine(f.GetType());
            //Console.WriteLine(h.GetType());
            //Console.WriteLine(j.GetType()); 


            //Console.ReadKey();
            #endregion

            #region User Input
            // Console.WriteLine("What's your name?");
            // String name = Console.ReadLine();
            //
            // Console.WriteLine("What's your age?");
            // int age = Convert.ToInt32(Console.ReadLine());
            //
            //
            // Console.WriteLine("Hello " + name);
            // Console.WriteLine("Your age is " + age);
            #endregion

            #region Arithmetic operators
            // int friends = 10;

            //friends = friends + 2;
            //friends += 2;
            //friends++;

            // friends = friends - 1;
            // friends--;
            // friends -= 2;
            // 
            // friends = friends * 2;
            // friends *= 2;
            // 
            // 
            // friends = friends / 2;
            // friends /= 2;
            #endregion

            #region Math Methods 
            //math methods

            // double x =3; 
            // int y = 5;
            // 
            // double a = Math.Pow(x, 2);   
            // double b = Math.Sqrt(x);
            // double c = Math.Abs(x);
            // double d = Math.Round(x);
            // double e = Math.Ceiling(x);
            // double f = Math.Floor(x);
            // double g = Math.Max(x, y);
            // double h = Math.Min(x, y);
            // 
            // Console.WriteLine(a);
            #endregion

            #region Random Generator
            // Random random = new Random();
            // 
            // int num1 = random.Next(1, 6);
            // int num2 = random.Next(1, 6);
            // int num3 = random.Next(1, 6);
            // 
            // double num = random.NextDouble(); //Between 0-1
            // 
            // Console.WriteLine(num1);
            // Console.WriteLine(num2);
            // Console.WriteLine(num3);
            #endregion

            #region Hypotensue
            // Console.WriteLine("Enter side A: ");
            // double a = Convert.ToDouble(Console.ReadLine());
            // 
            // Console.WriteLine("Enter side B: ");
            // double b = Convert.ToDouble(Console.ReadLine());
            // 
            // double c = Math.Sqrt((a * a + b * b));
            // 
            // Console.WriteLine("The Hypotensue is: " + c);
            // 
            // Console.ReadKey();
            #endregion

            #region String Methods
            // String fullName = "Bro Code";
            // String phoneNumber = "123-456-7890";

            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //Console.WriteLine(fullName);

            //phoneNumber = phoneNumber.Replace("-","");
            //Console.WriteLine(phoneNumber);

            //String userName = fullName.Insert(0,"Mr.");
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length);

            // String firstName = fullName.Substring(0, 3);
            // String lastName = fullName.Substring(4, 4);
            // 
            // Console.WriteLine(firstName);
            // Console.WriteLine(lastName);
            // 
            // Console.ReadKey();
            #endregion

            #region Statement
            //if statement = a basic form of decision making
            // -------------------- Example 1 -------------------- 

            // Console.WriteLine("Please enter your age: ");
            // int age = Convert.ToInt32(Console.ReadLine());
            // 
            // if (age >= 18)
            // {
            //     Console.WriteLine("You are now signed up!");
            // }
            // else if (age < 0)
            // {
            //     Console.WriteLine("You haven't been born yet!");
            // }
            // else
            // {
            //     Console.WriteLine("You must be 18+ to sign up!");
            // }
            // // -------------------- Example 2 -------------------- 
            // 
            // Console.WriteLine("Please enter your name: ");
            // String name = Console.ReadLine();
            // 
            // if (name == "")
            // {
            //     Console.WriteLine("You did not enter your name!");
            // }
            // else
            // {
            //     Console.WriteLine("Hello " + name);
            // }
            // 
            // Console.ReadKey();
            #endregion

            #region Switch Case
            // switch = an efficient alternative to many else if statements

            // Console.WriteLine("What day is it today?");
            // String day = Console.ReadLine();
            // 
            // switch (day)
            // {
            //     case "Monday":
            //         Console.WriteLine("It's Monday!");
            //         break;
            //     case "Tuesday":
            //         Console.WriteLine("It's Tuesday!");
            //         break;
            //     case "Wednesday":
            //         Console.WriteLine("It's Wednesday!");
            //         break;
            //     case "Thursday":
            //         Console.WriteLine("It's Thursday!");
            //         break;
            //     case "Friday":
            //         Console.WriteLine("It's Friday!");
            //         break;
            //     case "Saturday":
            //         Console.WriteLine("It's Saturday!");
            //         break;
            //     case "Sunday":
            //         Console.WriteLine("It's Sunday!");
            //         break;
            //     default:
            //         Console.WriteLine(day + " is not a day!");
            //         break;
            #endregion

            #region Logical Operators
            // logical operators = Can be used to check if more than 1 condition is true/false

            // && (AND)
            // || (OR)

            // Console.WriteLine("What's the temperature outside: (C)");
            // double temp = Convert.ToDouble(Console.ReadLine());
            // 
            // if (temp >= 10 && temp <= 25)
            // {
            //     Console.WriteLine("It's warm outside!");
            // }
            // else if (temp <= -50 || temp >= 50)
            // {
            //     Console.WriteLine("DO NOT GO OUTSIDE!");
            // }
            #endregion

            #region While Loop
            // while loop = repeats some code while some condition remains true

            // String name = "";
            // 
            // while (name == "")
            // {
            //     Console.Write("Enter your name: ");
            //     name = Console.ReadLine();
            // }
            // 
            // Console.WriteLine("Hello " + name);
            #endregion

            #region For Loop
            // for loop = repeats some code a FINITE amount of times

            // Count up to 10
            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // 
            // // Count down from 10
            // for (int i = 10; i > 0; i--)
            // {
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine("HAPPY NEW YEAR!");
            #endregion

            #region Nested Loops 
            // nested loops = loops inside of other loops
            //                Uses vary. Used a lot in sorting algorithms

            // Console.Write("How many rows?: ");
            // int rows = Convert.ToInt32(Console.ReadLine());
            // 
            // Console.Write("How many columns?: ");
            // int columns = Convert.ToInt32(Console.ReadLine());
            // 
            // Console.Write("What symbol: ");
            // String symbol = Console.ReadLine();
            // 
            // for (int i = 0; i < rows; i++)
            // {
            //     for (int j = 0; j < columns; j++)
            //     {
            //         Console.Write(symbol);
            //     }
            //     Console.WriteLine();
            // }
            // 
            // Console.ReadKey();
            #endregion

            #region Random number Guessing Game
            //  Random random = new Random();
            //  bool playAgain = true;
            //  int min = 1;
            //  int max = 100;
            //  int guess;
            //  int number;
            //  int guesses;
            //  String response;
            // 
            //  while (playAgain)
            //  {
            //      guess = 0;
            //      guesses = 0;
            //      response = "";
            //      number = random.Next(min, max + 1);
            // 
            //      while (guess != number)
            //      {
            //          Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
            //          guess = Convert.ToInt32(Console.ReadLine());
            //          Console.WriteLine("Guess: " + guess);
            // 
            //          if (guess > number)
            //          {
            //              Console.WriteLine(guess + " is to high!");
            //          }
            //          else if (guess < number)
            //          {
            //              Console.WriteLine(guess + " is to low!");
            //          }
            //          guesses++;
            //      }
            //      Console.WriteLine("Number: " + number);
            //      Console.WriteLine("YOU WIN!");
            //      Console.WriteLine("Guesses: " + guesses);
            // 
            //      Console.WriteLine("Would you like to play again (Y/N): ");
            //      response = Console.ReadLine();
            //      response = response.ToUpper();
            // 
            //      if (response == "Y")
            //      {
            //          playAgain = true;
            //      }
            //      else
            //      {
            //          playAgain = false;
            //      }
            //  }
            // 
            //  Console.WriteLine("Thanks for playing! ... I guess");
            // 
            //  Console.ReadKey();
            #endregion

            #region Rock Paper Scissors
            // Random random = new Random();
            // bool playAgain = true;
            // String player;
            // String computer;
            // String answer;
            // 
            // while (playAgain)
            // {
            //     player = "";
            //     computer = "";
            //     answer = "";
            // 
            //     while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            //     {
            //         Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
            //         player = Console.ReadLine();
            //         player = player.ToUpper();
            //     }
            // 
            // 
            //     switch (random.Next(1, 4))
            //     {
            //         case 1:
            //             computer = "ROCK";
            //             break;
            //         case 2:
            //             computer = "PAPER";
            //             break;
            //         case 3:
            //             computer = "SCISSORS";
            //             break;
            //     }
            // 
            //     Console.WriteLine("Player: " + player);
            //     Console.WriteLine("Computer: " + computer);
            // 
            //     switch (player)
            //     {
            //         case "ROCK":
            //             if (computer == "ROCK")
            //             {
            //                 Console.WriteLine("It's a draw!");
            //             }
            //             else if (computer == "PAPER")
            //             {
            //                 Console.WriteLine("You lose!");
            //             }
            //             else
            //             {
            //                 Console.WriteLine("You win!");
            //             }
            //             break;
            //         case "PAPER":
            //             if (computer == "ROCK")
            //             {
            //                 Console.WriteLine("You win!");
            //             }
            //             else if (computer == "PAPER")
            //             {
            //                 Console.WriteLine("It's a draw!");
            //             }
            //             else
            //             {
            //                 Console.WriteLine("You lose!");
            //             }
            //             break;
            //         case "SCISSORS":
            //             if (computer == "ROCK")
            //             {
            //                 Console.WriteLine("You lose!");
            //             }
            //             else if (computer == "PAPER")
            //             {
            //                 Console.WriteLine("You win!");
            //             }
            //             else
            //             {
            //                 Console.WriteLine("It's a draw!");
            //             }
            //             break;
            //     }
            // 
            //     Console.Write("Would you like to play again (Y/N): ");
            //     answer = Console.ReadLine();
            //     answer = answer.ToUpper();
            // 
            //     if (answer == "Y")
            //     {
            //         playAgain = true;
            //     }
            //     else
            //     {
            //         playAgain = false;
            //     }
            // 
            // }
            // 
            // Console.WriteLine("Thanks for playing!");
            // 
            // Console.ReadKey();
            #endregion

            #region Calculator Program
            // do
            // {
            //     double num1 = 0;
            //     double num2 = 0;
            //     double result = 0;
            // 
            //     Console.WriteLine("------------------");
            //     Console.WriteLine("Calculator Program");
            //     Console.WriteLine("------------------");
            // 
            //     Console.Write("Enter number 1: ");
            //     num1 = Convert.ToDouble(Console.ReadLine());
            // 
            //     Console.Write("Enter number 2: ");
            //     num2 = Convert.ToDouble(Console.ReadLine());
            // 
            //     Console.WriteLine("Enter an option: ");
            //     Console.WriteLine("\t+ : Add");
            //     Console.WriteLine("\t- : Subtract");
            //     Console.WriteLine("\t* : Multiply");
            //     Console.WriteLine("\t/ : Divide");
            //     Console.Write("Enter an option: ");
            // 
            // 
            //     switch (Console.ReadLine())
            //     {
            //         case "+":
            //             result = num1 + num2;
            //             Console.WriteLine($"Your result: {num1} + {num2} = " + result);
            //             break;
            //         case "-":
            //             result = num1 - num2;
            //             Console.WriteLine($"Your result: {num1} - {num2} = " + result);
            //             break;
            //         case "*":
            //             result = num1 * num2;
            //             Console.WriteLine($"Your result: {num1} * {num2} = " + result);
            //             break;
            //         case "/":
            //             result = num1 / num2;
            //             Console.WriteLine($"Your result: {num1} / {num2} = " + result);
            //             break;
            //         default:
            //             Console.WriteLine("That was not a valid option");
            //             break;
            //     }
            //     Console.Write("Would you like to continue? (Y = yes, N = No): ");
            // } while (Console.ReadLine().ToUpper() == "Y");
            // 
            // Console.WriteLine("Bye!");
            // Console.ReadKey();
            #endregion

            #region Arrays
            // array = a variable that can store multiple values. fixed size

            //String[] cars = {"BMW", "Mustang", "Corvette"};

            // String[] cars = new string[3];
            // 
            // cars[0] = "Tesla";
            // cars[1] = "Mustang";
            // cars[2] = "Corvette";
            // 
            // for (int i = 0; i < cars.Length; i++)
            // {
            //     Console.WriteLine(cars[i]);
            // }
            // 
            // Console.ReadKey();
            #endregion

            #region Foreach Loop
            // foreach loop = a simpler way to iterate over an array, but it's less flexible

            // String[] cars = { "BMW", "Mustang", "Corvette", "Mercedes", "Wolswagen" };
            // 
            // foreach (String car in cars)
            // {
            //     Console.WriteLine(car);
            // }
            // 
            // Console.ReadKey();

            #endregion

            #region Method
            // method  = performs a section of code, whenever it's called "invoked".
            //           benefit = Let's us reuse code w/o writing it multiple times
            //           Good practice is to capitalize method names (I forgot in this video)

            // String name = "Bro";
            // int age = 21;
            //
            // SingHappyBirthday(name, age);
            //
            // Console.ReadKey();

            //static void SingHappyBirthday(String birthdayBoy, int yearsOld)
            //{
            //    Console.WriteLine("Happy birthday to you!");
            //    Console.WriteLine("Happy birthday to you!");
            //    Console.WriteLine("Happy birthday dear " + birthdayBoy);
            //    Console.WriteLine("You are " + yearsOld + " years old!");
            //    Console.WriteLine("Happy birthday to you!");
            //    Console.WriteLine();
            //    
            //}
            #endregion

            #region Return Keyword
            // return  = returns data back to the place where a method is invoked

            // double x;
            // double y;
            // double result;
            // 
            // Console.WriteLine("Enter in number 1: ");
            // x = Convert.ToDouble(Console.ReadLine());
            // 
            // Console.WriteLine("Enter in number 2: ");
            // y = Convert.ToDouble(Console.ReadLine());
            // 
            // result = Multiply(x, y);
            // 
            // Console.WriteLine(result);
            // 
            // Console.ReadKey();

            // static double Multiply(double x, double y)
            // {
            //     return x * y;
            // }
            #endregion

            #region Methods Overloading

            // static void Main2(string[] args)
            // {
            // 
            // 
            //     // method overloading  = methods share same name, but different parameters
            //     //                       name + parameters = signature
            //     //                       methods must have a unique signature
            // 
            //     double total;
            // 
            //     total = Multiply(2, 3, 4);
            // 
            //     Console.WriteLine(total);
            //     Console.ReadKey();
            // }
            // 
            // // static double Multiply(double a, double b)
            // // {
            // //     return a * b;
            // // }
            // static double Multiply(double a, double b, double c)
            // {
            //     return a * b * c;
            // 
            // }
            #endregion



        }

    }
}


 

