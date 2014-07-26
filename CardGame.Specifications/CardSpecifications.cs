﻿using System.Configuration;
using CardGame.Business;
using Machine.Fakes;
using Machine.Specifications;

namespace CardGame.Specifications
{
    class CardSpecifications
    {
        class when_card_create : WithFakes
        {
            private Establish context = () =>
            {
                IFace face = An<IFace>();
                ISuite suite = An<ISuite>();

                _card = new Card(face, suite);
            };

            It should_have_face = () => _card.Face.ShouldNotBeNull();
            It should_have_suite = () => _card.Suite.ShouldNotBeNull();


            private static ICard _card;
        }
    }
}
