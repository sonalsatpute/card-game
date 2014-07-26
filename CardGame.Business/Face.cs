namespace CardGame.Business
{
    public class Face : IFace
    {
        public string Name { get; private set; }
        public int Value { get; private set; }

        public Face(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}