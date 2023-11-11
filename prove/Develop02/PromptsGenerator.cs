public class PromptsGenerator
    {
        private List<string> prompts;

        public PromptsGenerator()
        {
            prompts = new List<string>()
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of God in my life today?",
                "What was the strongest emotion I felt today?",
                "If I could do one thing over today, what would it be?"
            };
        }

        public string GetRandomPrompt()
        {
            return prompts[new Random().Next(prompts.Count)];
        }
    }