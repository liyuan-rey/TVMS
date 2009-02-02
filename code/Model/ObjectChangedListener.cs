using System;
using System.Collections.Generic;
using System.Text;

namespace TVMS.Model
{
    public class ObjectChangedListener : IEventListener
    {
        #region "IEventListener Members"

        public void OnNotification(IEventPublisher p_publisher)
        {
            if (!p_publisher.Initializing)
            {
                p_publisher.IsDirty = true;
            }
        }

        #endregion "IEventListener Members"
    }
}
