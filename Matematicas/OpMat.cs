namespace Matematicas
{
    public class OpMat : IOpMat
    {
        public int Sumar(int PrimerEntero, int SegundoEntero)
        {
            return PrimerEntero + SegundoEntero;
        }

        public int Multiplicar (int PrimerNumero, int SegundoNumero)
        {
            return PrimerNumero * SegundoNumero;
        }
    }
}