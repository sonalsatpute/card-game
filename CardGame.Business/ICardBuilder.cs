namespace CardGame.Business
{
    public interface ICardBuilder
    {
        Cards Build(ISuite suite);
    }

    public class Cards
    {
    }
}
