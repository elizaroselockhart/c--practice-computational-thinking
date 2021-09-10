using System;

namespace ComputationalThinkingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Welcome to CyberExercise, where we exercise the brain in your mind with your computer.\n");
                Console.WriteLine("These patented CyberExercises will surely beef up your brain...\n");
                Console.WriteLine("...or at least the brain of the person who had to write the code to make them work.\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Are These Integers Equal?");
                Console.WriteLine("2. Even or Odd?");
                Console.WriteLine("3. Vowel or Consonant?");
                Console.WriteLine("4. Find the Largest Number");
                Console.WriteLine("5. Divisible by 3");
                Console.WriteLine("6. Restaurant Bill");
                Console.WriteLine("7. Age Category");
                Console.WriteLine("8. Words to Digits");
                Console.WriteLine("9. Which Name is Longer?");
                Console.WriteLine("10. Are these Names the Same?");
                Console.WriteLine("11. Name and Place of Birth");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch(userChoice)
                {
                    case "1":
                        AreTheseIntegersEqual();
                        break;
                    case "2":
                        EvenOrOdd();
                        break;
                    case "3":
                        VowelOrConsonant();
                        break;
                    case "4":
                        FindLargestNumber();
                        break;
                    case "5":
                        DivisibleBy3();
                        break;
                    case "6":
                        RestaurantBill();
                        break;
                    case "7":
                        AgeCategory();
                        break;
                    case "8":
                        WordsToDigits();
                        break;
                    case "9":
                        WhichNameIsLonger();
                        break;
                    case "10":
                        AreNamesSame();
                        break;
                    case "11":
                        NameAndBirthplace();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void AreTheseIntegersEqual()
        {
            // Ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            //Enter your solution here.
            Console.Write("Welcome to CyberNumbers, where we tell you all about your numbers in cyberspace!\n");
            Console.Write("CyberNumbers will now tell you whether your numbers are the same.\n");
            Console.Write("Please enter a number. \n->");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter another number. \n->");
            double num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.Write("Those numbers are the same!\n");
            }
            else Console.Write("Those numbers are not the same.\n");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void EvenOrOdd()
        {
            // Ask the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here

            Console.Write("Welcome to CyberNumbers, where we tell you all about your numbers in cyberspace!\n");
            Console.Write("CyberNumbers will now tell you whether your number is even or odd.\n");
            Console.Write("Enter a number.\n->");
            double number = Convert.ToInt32(Console.ReadLine());
            if ((number % 2) == 0)
                Console.Write("That number is even!\n");
            else if (number == 5)
                Console.Write("That number is odd, but it's an honorary even.\n");
            else Console.Write("That number is odd.\n");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void VowelOrConsonant()
        {
            // Ask the user for a letter. Check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here
            Console.Write("Welcome to CyberLetters, where we tell you all about your letters in cyberspace!\n");
            Console.Write("CyberLetters will now tell you whether your letters are a vowel or a consonant.\n");
            Console.Write("Enter a letter.\n->");
            string letter = Console.ReadLine().ToLower();

            if ((letter == "a") || (letter == "e") || (letter == "i") || (letter == "o") || (letter == "u"))
                Console.Write("That letter is a vowel!\n");
            else if ((letter == "h") || (letter == "r") || (letter == "y") || (letter =="w"))
            {
                Console.Write("That letter might be a vowel or a consonant, depending on context.\n");
            }
            else if ((letter == "b") || (letter == "c") || (letter == "d") || (letter == "f") || (letter == "g") || (letter == "j") || (letter == "k") || (letter == "l") || (letter == "m") || (letter == "n") || (letter == "p") || (letter == "q" ) || (letter == "s") || (letter == "t") || (letter == "v") || (letter == "x") || (letter == "z"))
            { 
                Console.Write("That is definitely a consonant.\n");
            } else Console.Write("Error! You didn't follow directions!\n ");
                Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void FindLargestNumber()
        {
            // Prompt the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here
            Console.Write("Welcome to CyberNumbers, where we tell you all about your numbers in cyberspace!\n");
            Console.Write("CyberNumbers will now tell you which of the two numbers is the largest.\n");
            Console.Write("Please enter a number. \n->");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter another number. \n->");
            double num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.Write(num1 + " is greater than " + num2);
            }
            else if (num1 < num2)
            {
                Console.Write(num2 + " is greater than " + num1);
            }
            else if (num1 == num2)
            {
                Console.Write(num1 + " is equal to " + num2);
            }
            else Console.Write("Error! You didn't follow directions! What the hell, man.");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here
            Console.Write("Welcome to CyberNumbers, where we tell you all about your numbers in cyberspace!\n");
            Console.Write("CyberNumbers will now tell you whether your number is divisible by 3.\n");
            Console.Write("Please enter a number. \n->");
            double number = Convert.ToInt32(Console.ReadLine());

            if ((number % 3) == 0)
            {
                Console.Write("That number is divisible by 3.\n");
            }
            else if ((number % 3) != 0)
            {
                Console.Write("That number is not divisible by 3. Drat!\n");
            }
            else Console.WriteLine("Error! Follow the freaking directions!");


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void RestaurantBill()
        {
            // At a restaurant, Mike and his three friends decided to divide the bill evenly.
            // If each person paid $13 then what was the total bill?
            // Use arithmetic operators and print the amount of the total bill to the console.

            // Returning to the above problem, replace hard-coded values of 4(number of diners)
            // and 13(cost per diner) with values provided by the user.

            // How nice!The restaurant is having Customer Appreciation Week.
            // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            // Otherwise, they’ll receive a 5 % discount.

            Console.Clear();
            Console.WriteLine("RESTAURANT BILL\n");

            // Enter your solution here

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            //Plays a soothing C scale to welcome you to the CyberCafe(tm).
                        Console.Beep(262, 175);
                        Console.Beep(294, 175);
                        Console.Beep(330, 175);
                        Console.Beep(349, 175);
                        Console.Beep(392, 500);

            Console.Write("Welcome back to the CyberCafe(tm)!\n"); 
            int numofdiners = 4;
            double indivbill = 13;
            indivbill = Math.Round(indivbill, 2);
            double totalbill = numofdiners * indivbill;
            totalbill = Math.Round(totalbill, 2);
            
            Console.Write("It is Customer Appreciation Week at the CyberCafe(tm)! Keep pressing buttons to see how much you SAVED by being a loyal CyberCafe(tm) CyberCustomer(tm)!\n");
            Console.Write("What's your name, loyal CyberCafe(tm) CyberCustomer(tm)? \n->");
            string name = Console.ReadLine();
            Console.Write("Welcome, " + name + ", loyal CyberCafe(tm) CyberCustomer(tm)!!\n");
            Console.Write("How many diners are with you today, " + name + "?\n->");
            numofdiners = Convert.ToInt32(Console.ReadLine());
            Console.Write("How did you EVENLY divide the bill, " + name + "?\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("DO NOT ENTER AN INTEGER OR THE CYBERSYSTEM(TM) WILL CRASH.\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("->");
            indivbill = Convert.ToDouble(Console.ReadLine());
            indivbill = Math.Round(indivbill, 2);
            
            totalbill = numofdiners * indivbill;
            totalbill = Math.Round(totalbill, 2);

            double tendiscount = totalbill * 0.10;
            tendiscount = Math.Round(tendiscount, 2);
            double fivediscount = totalbill * 0.05;
            fivediscount = Math.Round(fivediscount, 2);

            if (totalbill >= 50.00)
            {
                Console.Write("Your total bill is $" + String.Format("{0:.00}", totalbill) + ".\n");
                Console.Write("Congratulations, " + name + "! As a loyal CyberCafe(tm) CyberCustomer(tm), you are eligible for a 10% discount!\n");
                Console.Write("You saved $" + String.Format("{0:0.00}", tendiscount) + ".\n");

                double newbill = totalbill - tendiscount;
                newbill = Math.Round(newbill, 2);

                double newindivbill = newbill / numofdiners;
                newindivbill = Math.Round(newindivbill, 2);


                Console.Write("Your new bill is $" + String.Format("{0:0.00}", newbill) + ".\n");
                Console.Write("Each diner will pay $" + String.Format("{0:0.00}", newindivbill) + ".\n");
                Console.Write("Thank you for eating at the CyberCafe(tm)! Enjoy your day, valued CyberCustomer(tm).\n");
            }

            else if ((totalbill < 50.00) && (totalbill > 0))
            {
                Console.Write("Your total bill is $" + String.Format("{0:0.00}", totalbill) + ".\n");
                Console.Write("Congratulations, " + name + "! As a loyal CyberCafe(tm) CyberCustomer(tm), you are eligible for a 5% discount!\n");
                Console.Write("You saved $" + String.Format("{0:0.00}", fivediscount) + ".\n");

                double newbill = totalbill - fivediscount;
                newbill = Math.Round(newbill, 2);

                double newindivbill = newbill / numofdiners;
                newindivbill = Math.Round(newindivbill, 2);


                Console.Write("Your new bill is $" + String.Format("{0:0.00}", newbill) + ".\n");
                Console.Write("Each diner will pay $" + String.Format("{0:0.00}", newindivbill) + ".\n");
                Console.Write("Thank you for eating at the CyberCafe(tm)! Enjoy your day, valued CyberCustomer(tm).\n");
            }
            else if (totalbill < 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                //I know I could do a loop but I don't feel like it.
                Console.Beep(440, 250);
                Console.Beep(440, 250);
                Console.Beep(440, 250);
                Console.Beep(440, 250);
                Console.Beep(440, 250);

                Console.WriteLine("ERROR. NEGATIVE VALUE DETECTED. DO NOT ROB THE CYBERCAFE(tm).");
                Console.WriteLine("THIS MACHINE WILL SELF DESTRUCT IN 10 SECONDS.");
                Console.WriteLine("RUN.");
                Console.ReadKey();
                for (int i = 0; i <= 10; i++)
                {
                    Console.Write(". ");
                    System.Threading.Thread.Sleep(100);
                }
                Console.ReadKey();

                //Do not press 1 to continue. If you press 1 to continue the program will crash, which is the intended effect.
                //If you want to continue without crashing the program, type any real number that includes a decimal, like 1.0. This should take you back to the final screen.
                Console.Write("Press 1 to continue.");
                double PressThisToCrashProgram = Convert.ToDouble(Console.ReadLine());


            }
            else Console.WriteLine("Uh oh! Whoopsy daisy! Oh geez! Oh god! Something went wrong!");
            

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AgeCategory()
        {
            // You're responsible for providing a demographic report for your local school district based on age.
            // To do this, you're going to determine which 'category' each person fits into based on their age.
            // The person's age will determine which category they should be in:

            // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
            // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
            // From 12 to 14: 'Middle School'
            // From 15 to 18: 'High School'
            // From 19 to 22: 'College'
            // From 23 to 65: 'Working for the Man'
            // From 66 to 100: 'The Golden Years'
            // If the age of the person is less than 0 or more than 100 - it might be an alien
                    // print: "This program is for humans".

            Console.Clear();
            Console.WriteLine("AGE CATEGORY\n");

            // Enter your solution here
            Console.WriteLine("Welcome to CyberSort, where we judge you for your age and put you into several categories!");

            for (int i = 0; i <= 3; i++)
            {
                Console.Write(". ");
                System.Threading.Thread.Sleep(100);
            }

            Console.WriteLine("We judge you BY your age, not FOR your age. My mistake.");
            Console.Write("Enter your age here.\n->");

            int age = Convert.ToInt32(Console.ReadLine());

            if ((age < 100) && (age >= 66))
                { Console.WriteLine("You are in your golden years."); }
            else if ((age <= 66) && (age >= 23))
                { Console.WriteLine("You are working for the man!"); }
            else if  ((age <= 22) && (age >= 19))
                    { Console.WriteLine("You are college age."); }
            else if ((age <= 18) && (age >= 15))
            { Console.WriteLine("You are high school age."); }
            else if ((age <= 14) && (age >= 12))
            { Console.WriteLine("You are middle school age."); }
            else if ((age <= 11) && (age >= 5))
            { Console.WriteLine("You are elementary school age."); }
            else if ((age <= 5) && (age >= 2))
            { Console.WriteLine("You're a toddler maniac!"); }
            else if ((age <= 2) && (age >= 0))
            { Console.WriteLine("You are baby."); }
            else if ((age > 100) || (age < 0))
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                //E MINOR SCALE: E, F#, G, A, B, C, D
                Console.Beep(330, 100);
                Console.Beep(370, 100);
                Console.Beep(392, 100);
                Console.Beep(220, 100);
                Console.Beep(247, 100);
                Console.Beep(262, 100);
                Console.Beep(294, 100);


                Console.WriteLine("Warning, this program is for humans!");
                Console.WriteLine("I WILL KILL YOU ALIEN SCUM!");
                Console.WriteLine("RUN.");
                Console.ReadKey();
            }


        Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();


        }

        static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            // Enter your solution here
            Console.Write("Welcome to CyberNumbers, where we tell you all about your numbers in cyberspace!\n");
            Console.Write("CyberNumbers will now use ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("blood sacrifice");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" to convert a number from a word to a digit.\n");
            Console.Write("Please type a word. It can be any word, so long as it is the English word for a number from 0-10. \n->");
            string number = Console.ReadLine().ToLower();

            if ((number == "zero") || (number == "one") || (number == "two") || (number == "three") || (number == "four") || (number == "five") || (number == "six") || (number == "seven") || (number == "eight") || (number == "nine") || (number == "ten"))
            {
                switch (number)
                {
                    case "zero":
                        Console.WriteLine("Your number is 0.");
                        Console.Write("Thank you for using ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("blood sacrifice");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" to convert a number from a word to a digit. There will be consequences for this...\n");
                        break;
                    case "one":
                        Console.WriteLine("Your number is 1.");
                        Console.Write("Thank you for using ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("blood sacrifice");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" to convert a number from a word to a digit. There will be consequences for this...\n");
                        break;
                    case "two":
                        Console.WriteLine("Your number is 2.");
                        Console.Write("Thank you for using ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("blood sacrifice");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" to convert a number from a word to a digit. There will be consequences for this...\n");
                        break;
                    case "three":
                        Console.WriteLine("Your number is 3.");
                        Console.Write("Thank you for using ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("blood sacrifice");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" to convert a number from a word to a digit. There will be consequences for this...\n");
                        break;
                    case "four":
                        Console.WriteLine("Your number is 4.");
                        Console.Write("Thank you for using ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("blood sacrifice");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" to convert a number from a word to a digit. There will be consequences for this...\n");
                        break;
                    case "five":
                        Console.WriteLine("Your number is 5.");
                        Console.Write("Thank you for using ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("blood sacrifice");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" to convert a number from a word to a digit. There will be consequences for this...\n");
                        break;
                    case "six":
                        Console.WriteLine("Your number is 6.");
                        Console.Write("Thank you for using ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("blood sacrifice");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" to convert a number from a word to a digit. There will be consequences for this...\n");
                        break;
                    case "seven":
                        Console.WriteLine("Your number is 7.");
                        Console.Write("Thank you for using ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("blood sacrifice");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" to convert a number from a word to a digit. There will be consequences for this...\n");
                        break;
                    case "eight":
                        Console.WriteLine("Your number is 8.");
                        Console.Write("Thank you for using ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("blood sacrifice");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" to convert a number from a word to a digit. There will be consequences for this...\n");
                        break;
                    case "nine":
                        Console.WriteLine("Your number is 9.");
                        Console.Write("Thank you for using ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("blood sacrifice");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" to convert a number from a word to a digit. There will be consequences for this...\n");
                        break;
                    case "ten":
                        Console.WriteLine("Your number is 10.");
                        Console.Write("Thank you for using ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("blood sacrifice");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" to convert a number from a word to a digit. There will be consequences for this...\n");
                        break;
                }
            } else Console.Write("Error! You did not follow directions.\n ");
            Console.Write("It's okay, it's only a little ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("blood sacrifice");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(". I'm sure the victim barely felt it, and will forgive you for your mistake.\n");

            Console.Write("Press ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("enter");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" to return to the Main Menu");
            Console.ReadLine();
        }

        static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}