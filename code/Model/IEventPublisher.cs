using System;
using System.Collections.Generic;
using System.Text;

namespace TVMS.Model
{
    public interface IEventPublisher
    {
        void RegisterListener<T>(T p_listener) where T : IEventListener;
        void UnregisterListener<T>(T p_listener) where T : IEventListener;
        void NotifyListeners();
        bool IsDirty {get; set;}
        bool Initializing { get; set;}
    }
}
