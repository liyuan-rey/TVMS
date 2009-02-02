using System;
using System.Collections.Generic;
using System.Text;

namespace TVMS.Model
{
    public abstract class ModelObject : Publisher
    {
        private ObjectChangedListener m_listener = new ObjectChangedListener();

        public ModelObject()
        {
            this.RegisterListener<IEventListener>(m_listener);
        }
    }
}
