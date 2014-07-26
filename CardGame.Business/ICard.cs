namespace CardGame.Business
{
    public interface ICard
    {
        IFace Face { get; }
        ISuite Suite { get; }
    }
}
