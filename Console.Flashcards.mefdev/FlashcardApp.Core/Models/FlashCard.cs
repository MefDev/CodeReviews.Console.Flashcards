namespace FlashcardApp.Core.Models;

public class Flashcard
{
    public int Id { get; set; }
    public Stack Stack { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }

    public Flashcard()
    {

    }
}
