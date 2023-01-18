using System;

public class Deck
{

    private Card[] deck;
    private int currentCard;
    private const int numCards = 52;
    private Random ranNum;

	public Deck()
	{
        string[] faces = {"14", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" };
        string[] suits = {"H", "C", "D", "S"};
        deck = new Card[numCards];
        currentCard = 0;
        ranNum = new Random();
        for(int count = 0; count<deck.Length; count++)
        {
            deck[count] = new Card(faces[count % 13], suits[count / 13]);
        }
	}

    public void Shuffle()
    {
        currentCard = 0;
        for (int first = 0; first < deck.Length; first++)
        {
            int second = ranNum.Next(numCards);
            Card temp = deck[first];
            deck[first] = deck[second];
            deck[second] = temp;
        }
    }

    public void Shuffle2()
    {
        currentCard = 0;
        for (int first = 0; first < deck.Length-1; first++)
        {
            for(int second = first+1; second < deck.Length; second++)
            {
                if(Int32.Parse(deck[first].face)< Int32.Parse(deck[second].face))
                {
                    Card temp = deck[first];
                    deck[first] = deck[second];
                    deck[second] = temp;
                }
            }
        }
    }

    public void Shuffle3()
    {
        currentCard = 0;
        for (int first = 0; first < deck.Length - 1; first++)
        {
            for (int second = first + 1; second < deck.Length; second++)
            {
                if (Int32.Parse(deck[first].face) > Int32.Parse(deck[second].face))
                {
                    Card temp = deck[first];
                    deck[first] = deck[second];
                    deck[second] = temp;
                }
            }
        }
    }

    public Card DealCard()
    {
        if (currentCard < deck.Length)
            return deck[currentCard++];
        else
            return null;
    }


}
