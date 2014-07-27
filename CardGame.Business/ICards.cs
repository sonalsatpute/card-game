using System.Collections.Generic;

namespace CardGame.Business
{
    public interface ICards : IEnumerable<ICard>
    {
        ICard this[int index] { get; set; }
        int Count { get; }
        void Add(ICard card);
    }
}