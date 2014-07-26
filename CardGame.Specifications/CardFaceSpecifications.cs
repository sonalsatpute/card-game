using CardGame.Business;
using Machine.Specifications;

namespace CardGame.Specifications
{
    public class CardFaceSpecifications
    {
        public class when_face_creted
        {
            private Establish context = () => _face = new Face("Ace", 1);

            It should_have_not_null_name = () =>  _face.Name.ShouldNotBeNull();
            It should_not_have_empty_name = () => _face.Name.ShouldNotBeEmpty();
            It should_have_value_greater_than_zero = () => _face.Value.ShouldBeGreaterThan(0);

            private static IFace _face;
        }
    }
}
