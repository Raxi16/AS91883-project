//Introduction\\
string start;
string again;
int selectionResult;
Console.BackgroundColor = ConsoleColor.White;
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
Restart:
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\n1. Easy");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("2. Medium");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("3. Hard");
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Please type the level you would like to start by just typing '1, 2 or 3' ");
while (!int.TryParse(Console.ReadLine(), out selectionResult) || selectionResult <= 0 || selectionResult >= 4)
{
    Console.Write("\nPlease enter a valid level: ");
}
int score = 0;
//Level Easy\\
string answer;
if (selectionResult == 1)
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("You have choosen lavel 'Easy'");
    Console.Clear();
    Console.WriteLine("Question 1 \n How to say 'Hello' in Māori?");
    Console.WriteLine("\n a) Ka Kite \n b) Tino Pai \n c) Tumeke \n d) Kia Ora ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\n Question 2 \n Kei te pēhea koe means?");
    Console.WriteLine("\n a) Goodbye \n b) How are you \n c) come in \n d) Im hungry");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 3 \n Ata mārie means..");
    Console.WriteLine("\n a) Good night \n b) Good morning \n c) hello \n d) Goodbye");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 4 \n Pō mārie means 'good - night' what does Pō stand for?");
    Console.WriteLine("\n a) night \n b) morning \n c) day \n d) month");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.Clear();
    Console.WriteLine("\nQuestion 5 \n Kau mau te wehi! means..");
    Console.WriteLine("\n a) bad \n b) not bad \n c) silly \n d) fantastic");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 6 \n 'Ata Mārie e hoa' what does e hoa mean?");
    Console.WriteLine("\n a) enemy \n b) person \n c) friend \n d) mother");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 7 \n Tahi, Rua, Toru, Wha..... what is the next number in te reo?");
    Console.WriteLine("\n a) Rima \n b) Ono \n c) Whitu \n d) Waru ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 8 \n 'Kai' stands for");
    Console.WriteLine("\n a) drink \n b) food \n c) fork \n d) plate ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 9 \n Haere rā means...");
    Console.WriteLine("\n a) good bye \n b) hello \n c) when \n d) where");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 10 \n What is the English word for Kahurangi?");
    Console.WriteLine("\n a) Green \n b) Red \n c) Blue \n d) Yellow ");
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
    Console.Clear();
    Console.WriteLine($"Your score is {score}/10");
    Console.WriteLine("If you want to take the quiz again Please type 'Y' for yes and any other key to exit.");
    again = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (again == "Y" || again == "y")
    {
        goto Restart;
    }
}
//Level Medium\\
if (selectionResult == 2)
{
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("You have choosen level 'Medium'");
    Console.Clear();
    Console.WriteLine("Question 1 \n 2,4,6,8 in te reo maori is");
    Console.WriteLine("\n a) rua, whā, ono, waru. \n b) tahi, toru, rima, whitu. \n c) rua, whā, whitu, waru. \n d) tahi, rua, toru, whā. ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\n Question 2 \n What is the English for Turituri?");
    Console.WriteLine("\n a) Turn around. \n b) Wait \n c) Quit \n d) Quite");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 3 \n Tekau mā whā means");
    Console.WriteLine("\n a) 44 \n b) 40 \n c) 4 \n d) 14");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 4 \n What is the word in te reo for 'and'?");
    Console.WriteLine("\n a) me \n b) and \n c) no \n d) te ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 5 \n what is the word for Yellow in te reo?");
    Console.WriteLine("\n a) Kowhai \n b) Kikirangi \n c) Kahurangi \n d) Pango ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 6 \n How many people would I be talking to if I said Tena Koe?");
    Console.WriteLine("\n a) 1 \n b) 2 \n c) 3 \n d) 3 or more ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 7 \n Wait is... means in te reo maori?");
    Console.WriteLine("\n a) Turituri \n b) Patai \n c) Tatao \n d) Taihoa ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 8 \n Which of these is not a positive statement?");
    Console.WriteLine("\n a) Tino Pai \n b) Ka rawe \n c) Rārangi mai \n d) Tino pai rawa atu ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 9 \n What does pukapuka mean?");
    Console.WriteLine("\n a) Paper \n b) Book \n c) Pencil \n d) Bread ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 10 \n What is the Maori word for river?");
    Console.WriteLine("\n a) Maunga \n b) Awa \n c) Moana \n d) Roto ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine($"Your score is {score}/10");
    Console.WriteLine("If you want to take the quiz again Please type 'Y' for yes and any other key to exit.");
    again = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (again == "Y" || again == "y")
    {
        goto Restart;
    }
}
//Level Hard\\
if (selectionResult == 3)
{
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("You have choosen level 'Hard'");
    Console.WriteLine("Question 1 \n What is the Maori word for New Zealand?");
    Console.WriteLine("\n a) Mangakino \n b) Atiamuri \n c) Onetangi \n d) Aotearoa ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\n Question 2 \n What does Mōrena mean?");
    Console.WriteLine("\n a) Good afternoon \n b) Good evening \n c) Good night \n d) Good morning ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 3 \n 'Aotearoa' translates to:");
    Console.WriteLine("\n a) The three sheep \n b) Land of the long white cloud \n c) Maui's Fish \n d) Tāmaki Makaurau ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 4 \n The word 'aroha' means...");
    Console.WriteLine("\n a) No \n b) Run \n c) Love \n d) Laugh ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 5 \n What is the Maori name for food cooked in the ground?");
    Console.WriteLine("\n a) Huge \n b) Hum \n c) Haggis \n d) Hangi ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 6 \n 'Totara' is a type of...");
    Console.WriteLine("\n a) Fish \n b) Car \n c) Colour \n d) Tree ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 7 \n The Maori name for fantail is...");
    Console.WriteLine("\n a) Pīwakawaka \n b) Kea \n c) Tui \n d) Takahē ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 8 \n If someone says they are feeling 'hoha' what do they mean?");
    Console.WriteLine("\n a) They are bored \n b) They are hungry \n c) They are tired \n d) They are sleepy ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 9 \n What is the job of the macron? ā, ē, ō, ū");
    Console.WriteLine("\n a) Used as a full stop \n b) To lengthen the vowel sound \n c) To show surprise \n d) To shorten the vowel sound ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("\nQuestion 10 \n What does kei te pēhea koe mean?");
    Console.WriteLine("\n a) How are you? \n b) What is your name? \n c) What day is it today? \n d) What's the time ");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "A" || answer == "a")
    {
        Console.WriteLine("Correct");
        ++score;
    }
    else
    {
        Console.WriteLine("Incorrect");
    }
    Console.Clear();
    Console.WriteLine($"Your score is {score}/10");
    Console.WriteLine("If you want to take the quiz again Please type 'Y' for yes and any other key to exit.");
    again = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (again == "Y" || again == "y")
    {
        goto Restart;
    }
}