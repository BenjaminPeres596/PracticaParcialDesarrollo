using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface IOperacionesServicio
    {
        Task<int> Suma(int Numero1, int Numero2);
    }
}
