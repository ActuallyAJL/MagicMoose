using System;
using System.Collections.Generic;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Magic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  M A G I C !");
    MooseSays("I really am magic");
    MoosePrompt();
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

void MoosePrompt()
{
    MooseSays("Ask now, and ye shall recieve...a randomly generated answer");
    string userQuestion = Console.ReadLine().ToLower();
    if (userQuestion != "")
    {
        getRandomAnswer();
        promptRepeat();
    }
}

void promptRepeat()
{
    Console.WriteLine("Do you have another question? Y/N");
    string res = Console.ReadLine().ToLower();
    while (res != "y" && res != "n")
    {
        Console.Write($"You must type either y or n. Do you even C#?");
        res = Console.ReadLine().ToLower();
    }

    if (res == "y")
    {
        MoosePrompt();
    }
}

void getRandomAnswer()
{
    List<String> answerList = new List<string>()
    {
        "As I see it, yes.",
        "Ask again later.",
        "Cannot predict now.",
        "Concentrate and ask again.",
        "Don’t count on it.",
        "It is certain.",
        "It is decidedly so.",
        "Most likely.",
        "My reply is no.",
        "My sources say no.",
        "Outlook not so good.",
        "Outlook good.",
        "Reply hazy, try again.",
        "Signs point to yes.",
        "Very doubtful.",
        "Without a doubt.",
        "Yes.",
        "Yes -- definitely.",
        "You may rely on it."
    };
    Random r = new Random();
    int thisRand = r.Next(0, 19);
    // Console.WriteLine(thisRand);
    Console.WriteLine(answerList[thisRand]);
}