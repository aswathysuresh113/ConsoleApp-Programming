using System;
using System.Diagnostics.Contracts;

public class Deck
{
    public List<Card> Cards = new List<Card>();
    public void CreateDeck()
    {
        for (int i = 0; i < 52; i++)
        {
            Card.Suites suite = (Card.Suites)(Math.Floor((decimal)i / 13));
            int val = i % 13 + 2;
            Cards.Add(new Card(val, suite));
        }
    }

    public void PrintDeck()
    {
        foreach (Card card in this.Cards)
        {
            Console.WriteLine(card.Name);
        }
    }

    public void Random()
    {

        var random = new Random();
        int index = random.Next(0, Cards.Count);

        {
            Console.WriteLine($"Your Random Card is {index}");
        }

    }
    public void Shuffle()
    {
        for (var i = Cards.Count - 1; i > 0; i--)
        {
            var temp = Cards[i];
            var random = new Random();
            var index = random.Next(0, i + 1);
            Cards[i] = Cards[index];
            Cards[index] = temp;
            
          Console.WriteLine($"Your Shuffled Card is {Cards[index]}");
            
        }
    }
   // public void SortedList()
    //{
     //   var sorted = Cards
     //.GroupBy(l => l.Suite)
     //.OrderByDescending(g => g.Count())
    // .SelectMany(g => g.OrderByDescending(c => c.Value));

   // }
}
    