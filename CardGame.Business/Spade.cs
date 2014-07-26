using System.CodeDom;

namespace CardGame.Business
{
    public class Spade : ISuite
    {
        public string Name { get { return "S"; } }
        public int Weight { get { return 1; } }
    }
}
