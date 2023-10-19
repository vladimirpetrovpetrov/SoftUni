namespace Cards;

public class Card
{
    private string spades = "\u2660";
    private string hearts = "\u2665";
    private string diamonds = "\u2666";
    private string clubs = "\u2663";

    private string face;
    private string suit;

    public Card(string face, string suit)
    {
        Face = face;
        Suit = suit;
    }

    public string Face
    {
        get { return face; }
        set
        {
            List<string> validFaces = new List<string>()
                {
                    "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
                    "J", "Q", "K", "A"
                };

            if (!validFaces.Contains(value.ToString()))
            {
                throw new ArgumentException("Invalid card!");
            }

            face = value;
        }
    }
    public string Suit
    {

        get { return suit; }

        set 
        { 
            if(value.ToString() == "S")
            {
                this.suit = spades;
            }
            else if (value.ToString() == "H")
            {
                this.suit = hearts;
            }
            else if (value.ToString() == "D")
            {
                this.suit = diamonds;
            }
            else if (value.ToString() == "C")
            {
                this.suit = clubs;
            }
            else
            {
                throw new ArgumentException("Invalid card!");
            }
        }
    }
    public override string ToString()
    {
        return $"[{face}{suit}]";
    }
}
