using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightGame
{
    public static class EventHandlerExtentions
    {
        public static void Raise(this EventHandler @event, object sender, EventArgs e)
        {
            var handler = @event;
            if (handler != null)
                handler(sender, e);
        }

        public static void Raise<T>(this EventHandler<T> @event, object sender, T e)
            where T : EventArgs
        {
            var handler = @event;
            if (handler != null)
                handler(sender, e);
        }
    }
}
