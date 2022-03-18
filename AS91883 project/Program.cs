//Introduction\\
string start;
int selections, selectionResult;
string Easy, Medium, Hard;
Console.WriteLine("Hi There, \n This is a Te Reo Maori (Maori Language) quiz.This is a multichoise quiz but before starting with the quiz you have read the rules!!");
Console.WriteLine("ELIGIBILITY FOR PARTICIPATING IN THIS QUIZ: The Quiz is open to people (the Participants) anywhere in the world who have completed the age of 10 years. \n BINDING AGREEMENT: In order to enter the Quiz, entrant must accept the official rules.\n The Rules Consist Of: \n (i) You shall not copy the answers \n (ii) you must be over 10 years old. \n (iii) The Participant should read this agreement carefully prior to entry to ensure that he/she understands and agrees, because these Rules form a legally binding agreement with respect to this Quiz.\n (iv) The Quiz will consist of 10 questions for the participants to answer for each level. \n (v) A participant must agree with this terms for the Quiz and complete the Quiz within 5 minutes.");

//QUIZ Level selection\\

start = Console.ReadLine();
while (start.ToLower() != "s")
{
    Console.WriteLine("Please Type 'S' To Start The QUIZ: ");
    start = Console.ReadLine();
}
Console.WriteLine("\n1. Easy");
Console.WriteLine("2. Medium");
Console.WriteLine("3. Hard");
Console.WriteLine("Please type the level you would like to do just typing '1, 2 or 3' ");
while (!int.TryParse(Console.ReadLine(), out selectionResult) || selectionResult <= 0 || selectionResult >= 4)
{
    Console.Write("\nPlease enter a valid level only: ");
}
switch (selectionResult)
{
    case 1:
        Console.WriteLine("You have slected Level Easy");
        Console.WriteLine("This Level will have 10 Basic questions about Te Reo Maori.");
        break;

    case 2:
        Console.WriteLine("You have slected Level Medium");
        break;

    case 3:
        Console.WriteLine("You have slected Level Hard");
        break;
}
//Level Easy\\


