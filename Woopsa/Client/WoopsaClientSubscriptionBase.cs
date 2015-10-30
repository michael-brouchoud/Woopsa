﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woopsa
{
    internal abstract class WoopsaClientSubscriptionChannelBase
    {
        public event EventHandler<WoopsaNotificationsEventArgs> ValueChange;

        protected virtual void DoValueChanged(IWoopsaNotifications notifications)
        {
            if (ValueChange != null)
            {
                ValueChange(this, new WoopsaNotificationsEventArgs(notifications));
            }
        }

        public abstract void Register(string path);

        public abstract void Register(string path, TimeSpan monitorInterval, TimeSpan publishInterval);

        public abstract bool Unregister(string path);
    }
}
