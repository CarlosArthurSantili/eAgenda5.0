using eAgenda.Dominio.CompromissoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class CompromissoTest
    {
        [TestMethod]
        public void DeveValidar_Compromisso()
        {
            //arrange
            Compromisso compromisso = new Compromisso("assunto", "local", "link", Convert.ToDateTime("12/12/2020"), Convert.ToDateTime("13:00").TimeOfDay, Convert.ToDateTime("13:00").TimeOfDay, null);

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            var resultadoEsperado = "ESTA_VALIDO";
            resultadoValidacao.Should().Be(resultadoEsperado);
        }

        [TestMethod]
        public void DeveValidar_MultiplosCampos()
        {
            //arrange
            Compromisso compromisso = new Compromisso("assunto", "local", "link", DateTime.MinValue, TimeSpan.MinValue, TimeSpan.MinValue, null);

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            var resultadoEsperado = "O campo Data é obrigatório"
                + Environment.NewLine
                + "O campo Hora Início é obrigatório"
                + Environment.NewLine
                + "O campo Hora Término é obrigatório";
            resultadoValidacao.Should().Be(resultadoEsperado);
        }

        [TestMethod]
        public void DeveValidar_Assunto()
        {
            //arrange
            Compromisso compromisso = new Compromisso("", "local", "link", Convert.ToDateTime("12/12/2022"), TimeSpan.Zero, TimeSpan.Zero, null);

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            var resultadoEsperado =
                "O campo Assunto é obrigatório";
            resultadoValidacao.Should().Be(resultadoEsperado);
        }

        [TestMethod]
        public void DeveValidar_Data()
        {
            //arrange
            Compromisso compromisso = new Compromisso("assunto", "local", "link", DateTime.MinValue, new TimeSpan(13,00,00), new TimeSpan(14, 00, 00), null);

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            var resultadoEsperado = "O campo Data é obrigatório";
            resultadoValidacao.Should().Be(resultadoEsperado);
        }

        [TestMethod]
        public void DeveValidar_HoraInicio()
        {
            //arrange
            Compromisso compromisso = new Compromisso("assunto", "local", "link", new DateTime(2022,10,10), TimeSpan.MinValue, new TimeSpan(14, 00, 00), null);

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            var resultadoEsperado = "O campo Hora Início é obrigatório";
            resultadoValidacao.Should().Be(resultadoEsperado);
        }

        [TestMethod]
        public void DeveValidar_HoraTermino()
        {
            //arrange
            Compromisso compromisso = new Compromisso("assunto", "local", "link", new DateTime(2022, 10, 10), new TimeSpan(14, 00, 00), TimeSpan.MinValue, null);

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            var resultadoEsperado = "O campo Hora Término é obrigatório";
            resultadoValidacao.Should().Be(resultadoEsperado);
        }
    }
}
