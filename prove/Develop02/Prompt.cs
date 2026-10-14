public class Prompts
{
    string _textPrompts = "PromptsFile.txt";

    List<string> prompt_list = new List<string>();

    public void _MakePrompts()
    {
        string[] lines = System.IO.File.ReadAllLines(_textPrompts);
        foreach (string prompt in lines)
        {
            prompt_list.Add(prompt);
        }
    }
    public string _RandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(prompt_list.Count);
        // Console.WriteLine(prompt_list[index]);
        return prompt_list[index];
    }
}