using System;
using System.Collections.Generic;
using System.Text;

namespace TVMS.Model
{
    public interface IEventListener
    {
        void OnNotification(IEventPublisher p_publisher);
    }
}
