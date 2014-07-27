using System.Collections;
using System.Collections.Generic;

namespace CardGame.Business
{
    public class Cards : ICards
    {
        readonly IList<ICard> _cards = new List<ICard>();

        public int Count { get { return _cards.Count; } } 

        public ICard this[int index]
        {
            get { return _cards[index]; }
            set { _cards[index] = value; }
        }

        public void Add(ICard card)
        {
            _cards.Add(card);
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            return _cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}