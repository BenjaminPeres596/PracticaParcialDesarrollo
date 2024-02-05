using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematicas
{
    public interface IOpMat
    {
        int Sumar(int PrimerEntero, int SegundoEntero);
        int Multiplicar(int PrimerNumero, int SegundoNumero);
    }
}
