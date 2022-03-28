//Introduction\\
string start, restart;
int selectionResult;
string Easy, Medium, Hard;

Console.BackgroundColor = ConsoleColor.Cyan;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Hi There, \n This is a Te Reo Maori (Maori Language) quiz.This is a multichoise quiz but before starting with the quiz you have read the rules!!");
Console.WriteLine("ELIGIBILITY FOR PARTICIPATING IN THIS QUIZ: The Quiz is open to people (the Participants) anywhere in the world who have completed the age of 10 years. \n BINDING AGREEMENT: In order to enter the Quiz, entrant must accept the official rules.\n The Rules Consist Of: \n (i) You shall not copy the answers \n (ii) you must be over 10 years old. \n (iii) The Participant should read this agreement carefully prior to entry to ensure that he/she understands and agrees, because these Rules form a legally binding agreement with respect to this Quiz.\n (iv) The Quiz will consist of 10 questions for the participants to answer for each level. \n (v) A participant must agree with this terms for the Quiz and complete the Quiz within 5 minutes.");



//QUIZ Level selection\\



start = Console.ReadLine();
while (start.ToLower() != "s")
{
    Console.WriteLine("Please Type 'S' To Start The QUIZ: ");
    start = Console.ReadLine();
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n1. Easy");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("2. Medium");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("3. Hard");
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Please type the level you would like to do just typing '1, 2 or 3' ");
while (!int.TryParse(Console.ReadLine(), out selectionResult) || selectionResult <= 0 || selectionResult >= 4)
{
    Console.Write("\nPlease enter a valid level: ");
}
int LevelEasy, score = 0;



//Level Easy\\
string answer;
if (selectionResult == 1)
{
    Console.WriteLine("You have choosen lavel 'Easy'");
    Console.WriteLine("Question 1 \n How to say 'Hello' in Māori?");
    Console.WriteLine("\n a) Ka Kite \n b) Tino Pai \n c) Tumeke \n d) Kia Ora ");
    answer = Console.ReadLine();
    if (answer == "D" || answer == "d")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\n Question 2 \n Kei te pēhea koe means?");
    Console.WriteLine("\n a) Goodbye \n b) How are you \n c) come in \n d) Im hungry");
    answer = Console.ReadLine();
    if (answer == "B" || answer == "b")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 3 \n Ata mārie means..");
    Console.WriteLine("\n a) Good night \n b) Good morning \n c) hello \n d) Goodbye");
    answer = Console.ReadLine();
    if (answer == "B" || answer == "b")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 4 \n Pō mārie means 'good - night' what does Pō stand for?");
    Console.WriteLine("\n a) night \n b) morning \n c) day \n d) month");
    answer = Console.ReadLine();
    if (answer == "A" || answer == "a")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 5 \n Kau mau te wehi! means..");
    Console.WriteLine("\n a) bad \n b) not bad \n c) silly \n d) fantastic");
    answer = Console.ReadLine();
    if (answer == "D" || answer == "d")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 6 \n 'Ata Mārie e hoa' what does e hoa mean?");
    Console.WriteLine("\n a) enemy \n b) person \n c) friend \n d) mother");
    answer = Console.ReadLine();
    if (answer == "C" || answer == "c")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 7 \n Tahi, Rua, Toru, Wha..... what is the next number in te reo?");
    Console.WriteLine("\n a) Rima \n b) Ono \n c) Whitu \n d) Waru ");
    answer = Console.ReadLine();
    if (answer == "A" || answer == "a")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 8 \n 'Kai' stands for");
    Console.WriteLine("\n a) drink \n b) food \n c) fork \n d) plate ");
    answer = Console.ReadLine();
    if (answer == "B" || answer == "b")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 9 \n Haere rā means...");
    Console.WriteLine("\n a) good bye \n b) hello \n c) when \n d) where");
    answer = Console.ReadLine();
    if (answer == "A" || answer == "a")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 10 \n What is the English word for Kahurangi?");
    Console.WriteLine("\n a) Green \n b) Red \n c) Bliue \n d) Yellow ");
    answer = Console.ReadLine();
    if (answer == "C" || answer == "c")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else



    {
        Console.WriteLine("Incorrect");
    }
    Console.WriteLine($"Your score is {score}/10");
}
//Level Medium\\
Console.ForegroundColor = ConsoleColor.DarkYellow;
if (selectionResult == 2)
{
    Console.WriteLine("You have choosen level 'Medium'");
    Console.WriteLine("Question 1 \n 2,4,6,8 in te reo maori is");
    Console.WriteLine("\n rua, whā, ono, waru. \n b) tahi, toru, rima, whitu. \n c) rua, whā, whitu, waru. \n d) tahi, rua, toru, whā. ");
    answer = Console.ReadLine();
    if (answer == "A" || answer == "a")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\n Question 2 \n What is the English for Turituri?");
    Console.WriteLine("\n a) Turn around. \n b) Wait \n c) Quit \n d) Quite");
    answer = Console.ReadLine();
    if (answer == "C" || answer == "c")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 3 \n Ata mārie means..");
    Console.WriteLine("\n a) Good night \n b) Good morning \n c) hello \n d) Goodbye");
    answer = Console.ReadLine();
    if (answer == "B" || answer == "b")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 4 \n Pō mārie means 'good - night' what does Pō stand for?");
    Console.WriteLine("\n a) night \n b) morning \n c) day \n d) month");
    answer = Console.ReadLine();
    if (answer == "A" || answer == "a")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 5 \n Kau mau te wehi! means..");
    Console.WriteLine("\n a) bad \n b) not bad \n c) silly \n d) fantastic");
    answer = Console.ReadLine();
    if (answer == "D" || answer == "d")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 6 \n 'Ata Mārie e hoa' what does e hoa mean?");
    Console.WriteLine("\n a) enemy \n b) person \n c) friend \n d) mother");
    answer = Console.ReadLine();
    if (answer == "C" || answer == "c")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 7 \n Tahi, Rua, Toru, Wha..... what is the next number in te reo?");
    Console.WriteLine("\n a) Rima \n b) Ono \n c) Whitu \n d) Waru ");
    answer = Console.ReadLine();
    if (answer == "A" || answer == "a")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 8 \n 'Kai' stands for");
    Console.WriteLine("\n a) drink \n b) food \n c) fork \n d) plate ");
    answer = Console.ReadLine();
    if (answer == "B" || answer == "b")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 9 \n Haere rā means...");
    Console.WriteLine("\n a) good bye \n b) hello \n c) when \n d) where");
    answer = Console.ReadLine();
    if (answer == "A" || answer == "a")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 10 \n What is the English word for Kahurangi?");
    Console.WriteLine("\n a) Green \n b) Red \n c) Bliue \n d) Yellow ");
    answer = Console.ReadLine();
    if (answer == "C" || answer == "c")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else



    {
        Console.WriteLine("Incorrect");
    }
    Console.WriteLine($"Your score is {score}/10");
}
//Level Hard\\
Console.ForegroundColor = ConsoleColor.Red;
if (selectionResult == 3)
{
    Console.WriteLine("You have choosen level 'Hard'");
    Console.WriteLine("Question 1 \n How to say 'Hello' in Māori?");
    Console.WriteLine("\n a) Ka Kite \n b) Tino Pai \n c) Tumeke \n d) Kia Ora ");
    answer = Console.ReadLine();
    if (answer == "D" || answer == "d")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\n Question 2 \n Kei te pēhea koe means?");
    Console.WriteLine("\n a) Goodbye \n b) How are you \n c) come in \n d) Im hungry");
    answer = Console.ReadLine();
    if (answer == "B" || answer == "b")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 3 \n Ata mārie means..");
    Console.WriteLine("\n a) Good night \n b) Good morning \n c) hello \n d) Goodbye");
    answer = Console.ReadLine();
    if (answer == "B" || answer == "b")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 4 \n Pō mārie means 'good - night' what does Pō stand for?");
    Console.WriteLine("\n a) night \n b) morning \n c) day \n d) month");
    answer = Console.ReadLine();
    if (answer == "A" || answer == "a")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 5 \n Kau mau te wehi! means..");
    Console.WriteLine("\n a) bad \n b) not bad \n c) silly \n d) fantastic");
    answer = Console.ReadLine();
    if (answer == "D" || answer == "d")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 6 \n 'Ata Mārie e hoa' what does e hoa mean?");
    Console.WriteLine("\n a) enemy \n b) person \n c) friend \n d) mother");
    answer = Console.ReadLine();
    if (answer == "C" || answer == "c")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 7 \n Tahi, Rua, Toru, Wha..... what is the next number in te reo?");
    Console.WriteLine("\n a) Rima \n b) Ono \n c) Whitu \n d) Waru ");
    answer = Console.ReadLine();
    if (answer == "A" || answer == "a")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 8 \n 'Kai' stands for");
    Console.WriteLine("\n a) drink \n b) food \n c) fork \n d) plate ");
    answer = Console.ReadLine();
    if (answer == "B" || answer == "b")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 9 \n Haere rā means...");
    Console.WriteLine("\n a) good bye \n b) hello \n c) when \n d) where");
    answer = Console.ReadLine();
    if (answer == "A" || answer == "a")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("\nQuestion 10 \n What is the English word for Kahurangi?");
    Console.WriteLine("\n a) Green \n b) Red \n c) Bliue \n d) Yellow ");
    answer = Console.ReadLine();
    if (answer == "C" || answer == "c")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else



    {
        Console.WriteLine("Incorrect");
    }
    Console.WriteLine($"Your score is {score}/10");
}