using System;
using System.Collections.Generic;
using System.Text;

namespace TVMS.Model
{
    public abstract class Publisher : IEventPublisher
    {
        private delegate void m_eventHandler(IEventPublisher p_publisher);
        private event m_eventHandler m_event;

        #region "IEventPublisher Implementation"

        public void RegisterListener<T>(T p_listener) where T : IEventListener
        {
            m_event += new m_eventHandler(p_listener.OnNotification);
        }
        
        public void UnregisterListener<T>(T p_listener) where T : IEventListener
        {
            m_event -= new m_eventHandler(p_listener.OnNotification);
        }
        
        public void NotifyListeners()
        {
            if (m_event != null)
                m_event(this);
        }
        
        protected bool m_isDirty = false;
        public bool IsDirty
        {
            get { return m_isDirty; }
            set { m_isDirty = value; }
        }
        
        protected bool m_initializing = true;
        public bool Initializing
        {
            get { return m_initializing; }
            set { m_initializing = value; }
        
        }

        protected bool m_isNew = false;
        public bool IsNew
        {
            get { return m_isNew; }
            set { m_isNew = true; }
        }
        
        #endregion "IEventPublisher Implementation"
    }
}
