using System;
using System.Security.AccessControl;
using System.Security.Cryptography;
using CardGame.Business;
using CardGame.Business.Suite;
using Machine.Fakes;
using Machine.Specifications;

namespace CardGame.Specifications
{
    class CardBuilderSpecifications
    {
        public class when_building_cards_suite : WithFakes
        {
            Establish context = () => _builder = new Builder();

            Because of = () =>
            {
                _suite = An<ISuite>();
                _suite.WhenToldTo(x => x.Name).Return("FakeName");
                _suite.WhenToldTo(x => x.Weight).Return(0);

                _cards = _builder.Build(_suite);
            };

            It all_cards_should_be_of_same_suite = () => _cards.ShouldContain(card => (card.Suite.Equals(_suite)));
            It should_have_ace_at_first_possion = () => ShouldEqualAce(_cards[0].Face);
            It should_have_normal_face_from_2nd_to_10th_possion = () => ShouldBeNormalCards();
            It should_have_jack_at_11th_possion = () => ShoulEqualJack(_cards[11].Face);
            It should_have_queen_at_12th_possion = () => ShouldEqualQueen(_cards[12].Face);
            It should_have_king_at_13th_possion = () => ShoulEqualKing(_cards[13].Face);

            static void ShoulEqualKing(IFace face)
            {
                face.Name.ShouldEqual("King");
                face.Value.ShouldEqual(13);
            }


            static void ShouldEqualQueen(IFace face)
            {
                face.Name.ShouldEqual("Queen");
                face.Value.ShouldEqual(12);
            }

            static void ShoulEqualJack(IFace face)
            {
                face.Name.ShouldEqual("Jack");
                face.Value.ShouldEqual(11);
            }

            static void ShouldBeNormalCards()
            {
                for (int index = 1; index <= 10; index++)
                {
                    _cards[index].Face.Name.ShouldEqual(Convert.ToString(index));
                    _cards[index].Face.Value.ShouldEqual(index);
                }
            }

            static void ShouldEqualAce(IFace face)
            {
                face.Name.ShouldEqual("Ace");
                face.Value.ShouldEqual(1);
            }


            static ICards _cards;
            static ISuite _suite;
            static IBuilder _builder;
        }

        public class when_building_diamond_card_suite
        {
            Establish constext = () => _builder = new Builder();

            Because of = () => _cards = _builder.Build(new Diamond());

            It all_cards_should_be_diamond = () => ShouldHaveOnlyDiamondCards();

            static void ShouldHaveOnlyDiamondCards()
            {
                foreach (ICard card in _cards)
                {
                    card.Suite.ShouldBeOfExactType<Diamond>();
                }
            }

            static ICards _cards;
            static Builder _builder;
        }

        public class when_building_heart_card_suite
        {
            Establish context = () => _builder = new Builder();

            Because of = () => _cards = _builder.Build(new Heard());

            It all_cards_should_be_of_heart = () => ShouldHaveOnlyHeartCards();

            static void ShouldHaveOnlyHeartCards()
            {
                foreach (ICard card in _cards)
                {
                    card.Suite.ShouldBeOfExactType<Heard>();
                }
            }

            static IBuilder _builder;
            static ICards _cards;
        }

        public class when_building_clud_card_suite
        {
            Establish context = () => _builder = new Builder();

            Because of = () => _cards = _builder.Build(new Club());

            It all_cards_should_be_of_heart = () => ShouldHaveOnlyHeartCards();

            static void ShouldHaveOnlyHeartCards()
            {
                foreach (ICard card in _cards)
                {
                    card.Suite.ShouldBeOfExactType<Club>();
                }
            }

            static IBuilder _builder;
            static ICards _cards;
        }

        public class when_building_spade_card_suite
        {
            Establish context = () => _builder = new Builder();

            Because of = () => _cards = _builder.Build(new Spade());

            It all_cards_should_be_of_heart = () => ShouldHaveOnlyHeartCards();

            static void ShouldHaveOnlyHeartCards()
            {
                foreach (ICard card in _cards)
                {
                    card.Suite.ShouldBeOfExactType<Spade>();
                }
            }

            static IBuilder _builder;
            static ICards _cards;
        }
    }
}
