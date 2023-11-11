using System;
using System.Collections.Generic;
using System.IO;

class Program
    {
        static void Main()
        {
            Journal journal = new Journal();
            PromptsGenerator promptsGenerator = new PromptsGenerator();
            Menu menu = new Menu(journal, promptsGenerator);

            while (true)
            {
                menu.DisplayMenu();
                menu.HandleUserInput();
            }
        }
    }  

public class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(DateTime date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }
}