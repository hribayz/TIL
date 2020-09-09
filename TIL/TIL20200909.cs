// TIL that Delegate.Remove() has a -= alias.
// Both ways are valid.
// Since EventHandler is 
// delegate void EventHandler(object sender, EventArgs e)
// both ways also work for events.


using System;
using System.Collections.Generic;
using System.Text;

namespace TIL
{
    delegate void VoidDelegate();
    delegate string StringDelegate(int intInput);

    class TIL20200909
    {
        private VoidDelegate vd;
        private StringDelegate sd;
        private event EventHandler _event;

        public void TIL()
        {
            vd += Do;
            vd -= Do;

            sd += Do;
            sd -= Do;

            VoidDelegate doDelegate = Do;
            Delegate.Remove(vd, doDelegate);

            StringDelegate stringDelegate = Do;
            Delegate.Remove(sd, stringDelegate);

            _event += TIL20200909__event;
            _event -= TIL20200909__event;

            EventHandler eh = TIL20200909__event;
            Delegate.Remove(_event, eh);
        }

        private void TIL20200909__event(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Do()
        {

        }
        public string Do(int input)
        {
            return input.ToString();
        }
    }
}
