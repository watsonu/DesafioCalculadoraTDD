using System.Collections.Generic;

namespace CalculadoraApp
{
    public class Calculadora
    {
        private List<string> _historico;

        public Calculadora()
        {
            _historico = new List<string>();
        }

        public double Somar(double a, double b)
        {
            double resultado = a + b;
            _historico.Add($"Somar: {a} + {b} = {resultado}");
            return resultado;
        }

        public double Subtrair(double a, double b)
        {
            double resultado = a - b;
            _historico.Add($"Subtrair: {a} - {b} = {resultado}");
            return resultado;
        }

        public double Multiplicar(double a, double b)
        {
            double resultado = a * b;
            _historico.Add($"Multiplicar: {a} * {b} = {resultado}");
            return resultado;
        }

        public double Dividir(double a, double b)
        {
            if (b == 0)
                throw new System.DivideByZeroException("Divisão por zero não é permitida.");

            double resultado = a / b;
            _historico.Add($"Dividir: {a} / {b} = {resultado}");
            return resultado;
        }

        public List<string> ObterHistorico()
        {
            return new List<string>(_historico);
        }
    }
}
