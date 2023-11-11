public class Menu
    {
        private Journal journal;
        private PromptsGenerator promptsGenerator;

        public Menu(Journal journal, PromptsGenerator promptsGenerator)
        {
            this.journal = journal;
            this.promptsGenerator = promptsGenerator;
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry for a randon question");
            Console.WriteLine("2. Add a text entry about anything new you want to share");
            Console.WriteLine("3. Display the journal");
            Console.WriteLine("4. Save the journal to a file");
            Console.WriteLine("5. Load the journal from a file");
            Console.WriteLine("6. Exit");
        }

        public void HandleUserInput()
        {
            string userInput = GetValidInput("Enter your choice: ");

            switch (userInput)
            {
                case "1":
                    string prompt = promptsGenerator.GetRandomPrompt();
                    string response = GetValidInput($"{prompt}: ");
                    Entry entry = new Entry( DateTime.Now, prompt, response);
                    journal.AddEntry(entry);
                    break;
                case "2":
                    Console.Write("Enter your text: ");
                    string userText = Console.ReadLine();
                    Entry textEntry = new Entry(DateTime.Now, "Custom Text", userText);
                    journal.AddEntry(textEntry);
                    break;
                    /*case 2 was made to add new text without the need of questions, so when you feel like sharing
                    new moments, you don't need a question*/
                case "3":
                    journal.DisplayEntries();
                    break;
                case "4":
                    string saveFilename = GetValidInput("Enter a filename to save the journal to: ");
                    journal.SaveToFile(saveFilename);
                    break;
                case "5":
                    string loadFilename = GetValidInput("Enter a filename to load the journal from: ");
                    journal.LoadFromFile(loadFilename);
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }
        }

        private string GetValidInput(string prompt)
        {
            string userInput;
            do
            {
                Console.Write(prompt);
                userInput = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(userInput));

            return userInput;
        }
    }