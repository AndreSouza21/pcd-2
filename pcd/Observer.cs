using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcd
{
    public interface Observer
    {
        void Update(Subject s, string tipoDado);
    }
}
