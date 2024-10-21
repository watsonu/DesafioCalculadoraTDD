using System;
using System.Collections.Generic;
using Xunit;
using CalculadoraApp;

namespace CalculadoraTests
{
    public class CalculadoraTests
    {
        [Fact]
        public void DeveSomarDoisNumeros()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Somar(5.5, 3.3);

            // Assert
            Assert.Equal(8.8, resultado, 1);
        }

        [Fact]
        public void DeveSubtrairDoisNumeros()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Subtrair(5.5, 3.3);

            // Assert
            Assert.Equal(2.2, resultado, 1);
        }

        [Fact]
        public void DeveMultiplicarDoisNumeros()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Multiplicar(5.5, 3.3);

            // Assert
            Assert.Equal(18.15, resultado, 2);
        }

        [Fact]
        public void DeveDividirDoisNumeros()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Dividir(6.6, 3.3);

            // Assert
            Assert.Equal(2.0, resultado, 1);
        }

        [Fact]
        public void DeveLancarExcecaoParaDivisaoPorZero()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(6.6, 0));
        }

        [Fact]
        public void DeveRegistrarHistoricoDeOperacoes()
        {
            // Arrange
            var calculadora = new Calculadora();
            calculadora.Somar(1, 1);
            calculadora.Subtrair(5, 3);
            calculadora.Multiplicar(2, 2);
            calculadora.Dividir(10, 2);

            // Act
            var historico = calculadora.ObterHistorico();

            // Assert
            Assert.Equal(4, historico.Count);
            Assert.Contains("Somar: 1 + 1 = 2", historico);
            Assert.Contains("Subtrair: 5 - 3 = 2", historico);
            Assert.Contains("Multiplicar: 2 * 2 = 4", historico);
            Assert.Contains("Dividir: 10 / 2 = 5", historico);
        }
    }
}
