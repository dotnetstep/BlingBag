using System;
using Machine.Specifications;

namespace BlingBag.Specs
{
    public abstract class given_an_action_event_initializer_context : given_an_initializer_context<Action<object>>
    {
        Establish master_context = () =>
            {
                Action<object> handleEvent = x => EventsHandled.Add(x);
                MockedBlingConfigurator.Setup(x => x.HandleEvent).Returns(handleEvent);
            };
    }
}