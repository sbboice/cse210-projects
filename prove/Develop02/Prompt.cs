public class Prompt
{
    private List<string> promptList = new List<string>{
        "What movie character would you choose to be your parent, and why?",
        "If you could only repeat words said by one person, who would you want to be echoing?",
        "When you have cereal, do you have more cereal than milk, or more milk than cereal?",
        "If you had to choose a random object to use as a bookmark, what would you choose?",
        "If you could commit one crime, what would you choose?",
        "What is the worst pickup line you've ever heard?",
        "At what age do you think is funniest?",
        "What is the funniest excuse to get out of homework?",
        "Who would play the main character in a movie about your life?",
        "How would you spend your last day on earth?",
        "What is the strangest thing you've ever eaten?",
        "What decade would you choose to live in for one day?",
        "What is your favorite scent and why?",
        "What planet would you choose to visit?",
        "What would the world be like if cell phones were never invented?",
        "What is a challenge you faced today, and how did you overcome it?",
        "Who is someone you look up to, and why?",
    };

    private string prompt;

    public string GivePrompt()
    {
        Random random = new Random();
        prompt = promptList[random.Next(1, promptList.Count)];
        return prompt;
    }

}