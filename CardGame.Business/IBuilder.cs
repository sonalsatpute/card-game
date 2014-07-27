using CardGame.Business.Suite;

namespace CardGame.Business
{
    public interface IBuilder
    {
        ICards Build(ISuite suite);
    }
}
