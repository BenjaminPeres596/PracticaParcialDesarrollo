namespace Servicios
{
    public class OperacionesServicio : IOperacionesServicio
    {
        public Task<int> Suma(int Numero1, int Numero2)
        {
            var resultado = Numero1 + Numero2;
            return Task.FromResult(resultado);
        }
    }
}