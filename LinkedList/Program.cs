using System;
using System.Collections.Generic; //Namespace needed for LinkedList

public class Program
{
    public static void Main()
    {
        LinkedList<string> months = new LinkedList<string>(); //creating the linkedlist
        months.AddLast("March"); //last node
        months.AddFirst("January"); //first node

        var march = months.Find("March"); //assigning node March as var march

        months.AddBefore(march, "February"); //adding to node before march
        months.AddAfter(march, "April"); //adding node to after march 

        foreach (string month in months) //writing out the linkedlist node by node
        {
            Console.WriteLine(month);
        }
        Console.ReadLine(); // this so far was the example, we can do this again by using seasons.

        LinkedList<string> seasons = new LinkedList<string>();
        seasons.AddFirst("Spring");
        seasons.AddLast("Fall");

        var fall = seasons.Find("Fall");

        seasons.AddAfter(fall,"Winter");
        seasons.AddBefore(fall, "Summer");

        foreach (string season in seasons) //Now we can display all four seasons 
        {
            Console.WriteLine(season);
        }
        Console.WriteLine("These are your four seasons");
        Console.ReadLine();

        seasons.Remove(fall); // If for whatever reason you wanted to remove a season, your result would now be

        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }
        Console.ReadLine();
    } 
}