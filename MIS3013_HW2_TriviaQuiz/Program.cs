// MIS 3013 HW2 Trivia Quiz


string outMesStr;
string userInputStr;

// Q1
string correctAnsStr="F";
string userAnsStr;
int q1ScoreInt = 0;
outMesStr = "Q1: 2+3=6? (T/F)";
Console.Write(outMesStr);
userAnsStr = Console.ReadLine();

if(userAnsStr!="T" && userAnsStr !="F")
{
    outMesStr = "You need to type in T or F! Wrong input! app exit";
    Console.WriteLine(outMesStr);
    System.Environment.Exit(0);
}

if (userAnsStr == correctAnsStr)
{
    outMesStr = "Congrat! Correct!";
    Console.WriteLine(outMesStr);
    q1ScoreInt = 1;
}
else
{
    outMesStr = "Wrong answer!";
    Console.WriteLine(outMesStr);
    q1ScoreInt = 0;
}


// Q2
correctAnsStr = "T";
int q2ScoreInt = 0;
outMesStr = "Q2: 2+3=5? (T/F)";
Console.Write(outMesStr);
userAnsStr = Console.ReadLine();

if (userAnsStr != "T" && userAnsStr != "F")
{
    outMesStr = "You need to type in T or F! Wrong input! app exit";
    Console.WriteLine(outMesStr);
    System.Environment.Exit(0);
}

if (userAnsStr == correctAnsStr)
{
    outMesStr = "Congrat! Correct!";
    Console.WriteLine(outMesStr);
    q2ScoreInt = 1;
}
else
{
    outMesStr = "Wrong answer!";
    Console.WriteLine(outMesStr);
    q2ScoreInt = 0;
}

// Q3
correctAnsStr = "F";
int q3ScoreInt = 0;
outMesStr = "Q3: 2*3=5? (T/F)";
Console.Write(outMesStr);
userAnsStr = Console.ReadLine();

if (userAnsStr != "T" && userAnsStr != "F")
{
    outMesStr = "You need to type in T or F! Wrong input! app exit";
    Console.WriteLine(outMesStr);
    System.Environment.Exit(0);
}

if (userAnsStr == correctAnsStr)
{
    outMesStr = "Congrat! Correct!";
    Console.WriteLine(outMesStr);
    q3ScoreInt = 1;
}
else
{
    outMesStr = "Wrong answer!";
    Console.WriteLine(outMesStr);
    q3ScoreInt = 0;
}

// Q4
correctAnsStr = "F";
int q4ScoreInt = 0;
outMesStr = "Q4: 4/4=0? (T/F)";
Console.Write(outMesStr);
userAnsStr = Console.ReadLine();

if (userAnsStr != "T" && userAnsStr != "F")
{
    outMesStr = "You need to type in T or F! Wrong input! app exit";
    Console.WriteLine(outMesStr);
    System.Environment.Exit(0);
}

if (userAnsStr == correctAnsStr)
{
    outMesStr = "Congrat! Correct!";
    Console.WriteLine(outMesStr);
    q4ScoreInt = 1;
}
else
{
    outMesStr = "Wrong answer!";
    Console.WriteLine(outMesStr);
    q4ScoreInt = 0;
}

// Q5
correctAnsStr = "T";
int q5ScoreInt = 0;
outMesStr = "Q5: 8/2=4? (T/F)";
Console.Write(outMesStr);
userAnsStr = Console.ReadLine();

if (userAnsStr != "T" && userAnsStr != "F")
{
    outMesStr = "You need to type in T or F! Wrong input! app exit";
    Console.WriteLine(outMesStr);
    System.Environment.Exit(0);
}

if (userAnsStr == correctAnsStr)
{
    outMesStr = "Congrat! Correct!";
    Console.WriteLine(outMesStr);
    q5ScoreInt = 1;
}
else
{
    outMesStr = "Wrong answer!";
    Console.WriteLine(outMesStr);
    q5ScoreInt = 0;
}

// summary information
double correctAnswersInt = q1ScoreInt + q2ScoreInt + q3ScoreInt + q4ScoreInt + q5ScoreInt;
double correctRatioDbl = correctAnswersInt / 5.0;
outMesStr = String.Format($"{correctAnswersInt}/5 are correct! Percentage is {correctRatioDbl:P2}");
Console.WriteLine(outMesStr);






Console.ReadLine();
