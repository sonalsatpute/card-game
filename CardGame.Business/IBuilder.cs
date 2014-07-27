namespace CardGame.Business
{
    public interface IBuilder
    {
        Cards Build(ISuite suite);
    }
}
