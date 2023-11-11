public class Journal
    {
        private List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public void DisplayEntries()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine("Date: " + entry.Date);
                Console.WriteLine("Prompt: " + entry.Prompt);
                Console.WriteLine("Response: " + entry.Response);
                Console.WriteLine();
            }
        }

        public void SaveToFile(string filename)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, filename);

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Entry entry in entries)
                    {
                        writer.WriteLine(entry.Prompt);
                        writer.WriteLine(entry.Response);
                        writer.WriteLine(entry.Date);
                    }
                }
                Console.WriteLine("Journal saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving journal: {ex.Message}");
            }
        }

        public void LoadFromFile(string filename)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, filename);

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    entries = new List<Entry>();
                    while (!reader.EndOfStream)
                    {
                        string prompt = reader.ReadLine();
                        string response = reader.ReadLine();
                        DateTime date = DateTime.Parse(reader.ReadLine());

                        Entry entry = new Entry(date, prompt, response);
                        entries.Add(entry);
                    }
                }
                Console.WriteLine("Journal loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading journal: {ex.Message}");
            }
        }
    }