using System;

string room = "lobby";

while (room != "finalroom")
{
    if(room == "lobby")
{
Console.WriteLine("You are in the Lobby!");
Console.WriteLine("You have 2 doors to choose");
Console.WriteLine("a: left b: right");

string where = Console.ReadLine().ToLower();

if(where == "a"){
    Console.WriteLine("You chose the left door!");
    Console.WriteLine("You find a key to an unknown door.");
    Console.WriteLine("Do you want to pick it up?");
    Console.WriteLine("A: yes B: no");
    
    string keyanswer = Console.ReadLine().ToLower();
    int key = 0;
    
    if(keyanswer == "yes"){
        Console.WriteLine("You picked up the key!");
        key++;


    }
}
}
}
