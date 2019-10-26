using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalLayer.Interfaces
{
    public interface ContainerUpdater
    {
        void containerUpdate();
        void fillContainer(List<Money> list);
    }
}
