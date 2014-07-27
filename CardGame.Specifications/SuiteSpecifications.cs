using System.Runtime.InteropServices;
using CardGame.Business;
using CardGame.Business.Suite;
using Machine.Specifications;

namespace CardGame.Specifications
{
    class SuiteSpecifications
    {
        class when_diamond_card_suite_created
        {
            Establish context = () => _suite = new Diamond();

            It should_have_name_as_d = () => _suite.Name.ShouldEqual("D");
            It should_have_weight_as_4 = () => _suite.Weight.ShouldEqual(4);

            static ISuite _suite;
        }

        class when_heart_card_suite_created
        {
            Establish constext = () => _suite = new Heard();

            It should_have_name_as_h = () => _suite.Name.ShouldEqual("H");
            It should_have_weight_as_3 = () => _suite.Weight.ShouldEqual(3);

            static ISuite _suite;
        }

        class when_club_card_suite_created
        {
            Establish context = () => _suite = new Club();

            It should_have_name_as_c = () => _suite.Name.ShouldEqual("C");
            It should_have_weight_as_2 = () => _suite.Weight.ShouldEqual(2);

            static ISuite _suite;
        }

        class when_spade_card_suite_created
        {
            Establish context = () => _suite = new Spade();

            It should_have_name_as_s = () => _suite.Name.ShouldEqual("S");
            It should_have_weight_as_1 = () => _suite.Weight.ShouldEqual(1);

            static ISuite _suite;
        }
    }
}
