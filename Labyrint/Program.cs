using System;

string room = "lobby";
int key = 0;

while (room != "finalroom")
{
    if (room == "lobby" && key == 1)
    {
        Console.WriteLine("You're back in the lobby!");
        Console.WriteLine("A third door has appeared!");
        Console.WriteLine("Where do you want to go?");
        Console.WriteLine("A: Left B: Right C: 3rd door");

        string wherelast = Console.ReadLine().ToLower(); ;

        if (wherelast == "c")
        {
            room = "finalroom";
            Console.WriteLine("Press ENTER to go to the final room!");
        }
        else if (wherelast == "a" || wherelast == "b")
        {
            Console.WriteLine("The door is locked try another one!");
            room = "lobby";
        }
    }
    else if (room == "lobby")
    {
        Console.WriteLine("You are in the Lobby!");
        Console.WriteLine("You have 2 doors to choose");
        Console.WriteLine("a: left b: right");
    }
    string where = Console.ReadLine().ToLower();

    if (where == "a")
    {
        room = "leftroom";

    }
    else if (where == "b")
    {
        room = "rightroom";
    }
    if (room == "leftroom")
    {
        Console.WriteLine("You're now in the left room!");
        Console.WriteLine("There is a small table in the middle of the room with a key.");
        Console.WriteLine("Press ENTER to collect the key");
        Console.ReadLine();
        Console.WriteLine("You collected it and keep it in your pocket.");
        key++;
        Console.WriteLine(" ");
        Console.WriteLine("There is nothing else important in here.");
        Console.WriteLine("Press ENTER to go to the lobby!");
        Console.ReadLine();
        room = "lobby";
    }
    else if (room == "rightroom")
    {
        Console.WriteLine("You went in to the right room!");
        Console.WriteLine("There is nothing in here!");
        Console.WriteLine("Press enter to Go back to the looby.");
        Console.ReadLine();
        room = "lobby";
    }
}

if (room == "finalroom")
{
    Console.WriteLine("Welcome to the FINAL ROOOM!");
    Console.WriteLine("You did it, you WON!");
    Console.ReadLine();
}

