namespace CardGame.Business
{
    public class Card : ICard
    {
        public IFace Face { get; private set; }
        public ISuite Suite { get; private set; }

        public Card(IFace face, ISuite suite)
        {
            Face = face;
            Suite = suite;
        }
    }
}