using System;
using CardGame.Business.Suite;

namespace CardGame.Business
{
    public class Builder : IBuilder
    {
        public ICards Build(ISuite suite)
        {
            ICards cards = new Cards {new Card(new Face("Ace", 1), suite)};

            for (int index = 1; index <= 10; index++)
            {
                IFace face = new Face(Convert.ToString(index), index);
                cards.Add(new Card(face, suite));
            }

            cards.Add(new Card(new Face("Jack",11), suite));
            cards.Add(new Card(new Face("Queen", 12), suite));
            cards.Add(new Card(new Face("King", 13), suite));

            return cards;
        }
    }
}