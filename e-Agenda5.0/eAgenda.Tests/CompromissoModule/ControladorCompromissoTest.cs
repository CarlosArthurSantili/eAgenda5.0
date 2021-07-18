using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using FluentAssertions;
using eAgenda.Controladores.ContatoModule;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class ControladorCompromissoTest
    {
        ControladorCompromisso controladorCompromisso = null;
        ControladorContato controladorContato = null;

        public ControladorCompromissoTest()
        {
            LimparTabelas();
            controladorCompromisso = new ControladorCompromisso();
            controladorContato = new ControladorContato();
        }

        [TestCleanup()]
        public void LimparTabelas()
        {
            Db.Update("DELETE FROM TBCOMPROMISSO");
            Db.Update("DELETE FROM TBCONTATO");
        }

        [TestMethod]
        public void DeveInserir_CompromissoSemContato()
        {
            //arrange
            Compromisso novoCompromisso = new Compromisso("assunto", "local", "link", Convert.ToDateTime("12/12/2020"), Convert.ToDateTime("13:00").TimeOfDay, Convert.ToDateTime("14:00").TimeOfDay, null);

            //action
            controladorCompromisso.InserirNovo(novoCompromisso);

            //assert
            Compromisso compromissoEncontrada = controladorCompromisso.SelecionarPorId(novoCompromisso.Id);
            compromissoEncontrada.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveInserir_CompromissoComContato()
        {
            //arrange
            Contato novoContato = new Contato("NOME", "email@email.com", "999888777", "empresa", "cargo");
            controladorContato.InserirNovo(novoContato);

            Compromisso novoCompromisso = new Compromisso("assunto", "local", "link", new DateTime(2020,10,10), new TimeSpan(13,00,00), new TimeSpan(14, 00, 00), novoContato);

            //action
            controladorCompromisso.InserirNovo(novoCompromisso);

            //assert
            Compromisso compromissoEncontrada = controladorCompromisso.SelecionarPorId(novoCompromisso.Id);
            compromissoEncontrada.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveNaoInserir_UmCompromissoHorarioOcupado()
        {
            //arrange
            Compromisso compromissoComparavel = new Compromisso("assunto", "local", "link", Convert.ToDateTime("12/12/2020"), Convert.ToDateTime("13:00").TimeOfDay, Convert.ToDateTime("15:00").TimeOfDay, null);
            controladorCompromisso.InserirNovo(compromissoComparavel);
            Compromisso compromisso1 = new Compromisso("assunto1", "local1", "link1", Convert.ToDateTime("12/12/2020"), Convert.ToDateTime("14:00").TimeOfDay, Convert.ToDateTime("16:00").TimeOfDay, null);
            Compromisso compromisso2 = new Compromisso("assunto1", "local1", "link1", Convert.ToDateTime("12/12/2020"), Convert.ToDateTime("12:00").TimeOfDay, Convert.ToDateTime("14:00").TimeOfDay, null);
            Compromisso compromisso3 = new Compromisso("assunto1", "local1", "link1", Convert.ToDateTime("12/12/2020"), Convert.ToDateTime("11:00").TimeOfDay, Convert.ToDateTime("17:00").TimeOfDay, null);

            //action
            string resultado1 = controladorCompromisso.InserirNovo(compromisso1);
            string resultado2 = controladorCompromisso.InserirNovo(compromisso2);
            string resultado3 = controladorCompromisso.InserirNovo(compromisso3);


            //assert
            resultado1.Should().Be("Nesta data e horário já tem um compromisso agendado");
            resultado2.Should().Be("Nesta data e horário já tem um compromisso agendado");
            resultado3.Should().Be("Nesta data e horário já tem um compromisso agendado");
        }

        [TestMethod]
        public void DeveEditar_UmCompromisso()
        {
            //arrange
            Compromisso compromisso = new Compromisso("assunto", "local", "link", Convert.ToDateTime("12/12/2020"), Convert.ToDateTime("13:00").TimeOfDay, Convert.ToDateTime("14:00").TimeOfDay, null);
            controladorCompromisso.InserirNovo(compromisso);

            Compromisso novoCompromisso = new Compromisso("assunto2", "local2", "link2", Convert.ToDateTime("12/12/2022"), Convert.ToDateTime("15:00").TimeOfDay, Convert.ToDateTime("16:00").TimeOfDay, null);
            


            //action
            controladorCompromisso.Editar(compromisso.Id, novoCompromisso);


            //assert
            Compromisso compromissoEncontrada = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoEncontrada.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveNaoEditar_UmCompromissoHorarioOcupado()
        {
            //arrange
            Compromisso compromisso = new Compromisso("assunto1", "local1", "link1", Convert.ToDateTime("12/12/2022"), Convert.ToDateTime("13:00").TimeOfDay, Convert.ToDateTime("16:00").TimeOfDay, null);
            controladorCompromisso.InserirNovo(compromisso);

            Compromisso novoCompromisso = new Compromisso("assunto2", "local2", "link2", Convert.ToDateTime("12/12/2022"), Convert.ToDateTime("14:00").TimeOfDay, Convert.ToDateTime("16:00").TimeOfDay, null);

            //action
            string resultado = controladorCompromisso.Editar(compromisso.Id, novoCompromisso);


            //assert
            resultado.Should().Be("Nesta data e horário já tem um compromisso agendado");
        }

        [TestMethod]
        public void DeveExcluir_UmCompromisso()
        {
            //arrange            
            Compromisso compromisso = new Compromisso("assunto", "local", "link", Convert.ToDateTime("12/12/2020"), Convert.ToDateTime("13:00").TimeOfDay, Convert.ToDateTime("13:00").TimeOfDay, null);
            controladorCompromisso.InserirNovo(compromisso);

            //action            
            controladorCompromisso.Excluir(compromisso.Id);

            //assert
            Compromisso compromissoEncontrada = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoEncontrada.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_Compromisso_PorId()
        {
            //arrange
            Compromisso compromisso = new Compromisso("assunto", "local", "link", new DateTime(2022,10,10), new TimeSpan(13,00,00), new TimeSpan(14, 00, 00), null);
            controladorCompromisso.InserirNovo(compromisso);

            //action
            Compromisso compromissoEncontrada = controladorCompromisso.SelecionarPorId(compromisso.Id);

            //assert
            compromissoEncontrada.Should().Be(compromisso);
        }

        [TestMethod]
        public void DeveSelecionar_TodosCompromissos()
        {
            //arrange
            Compromisso t1 = new Compromisso("assunto1", "local", "link", Convert.ToDateTime("12/12/2020"), Convert.ToDateTime("13:00").TimeOfDay, Convert.ToDateTime("13:00").TimeOfDay, null);
            controladorCompromisso.InserirNovo(t1);

            Compromisso t2 = new Compromisso("assunto2", "local", "link", Convert.ToDateTime("12/12/2021"), Convert.ToDateTime("13:00").TimeOfDay, Convert.ToDateTime("13:00").TimeOfDay, null);
            controladorCompromisso.InserirNovo(t2);

            Compromisso t3 = new Compromisso("assunto3", "local", "link", Convert.ToDateTime("12/12/2022"), Convert.ToDateTime("13:00").TimeOfDay, Convert.ToDateTime("13:00").TimeOfDay, null);
            controladorCompromisso.InserirNovo(t3);


            //action
            var compromissos = controladorCompromisso.SelecionarTodos();

            //assert
            compromissos.Should().HaveCount(3);
            compromissos[0].Assunto.Should().Be("assunto1");
            compromissos[1].Assunto.Should().Be("assunto2");
            compromissos[2].Assunto.Should().Be("assunto3");
        }

        [TestMethod]
        public void DeveSelecionar_CompromissosFuturos()
        {
            //arrange
            Compromisso t1 = new Compromisso("assunto1", "local", "link", Convert.ToDateTime("12/12/2020"), Convert.ToDateTime("13:00").TimeOfDay, Convert.ToDateTime("13:00").TimeOfDay, null);
            controladorCompromisso.InserirNovo(t1);

            Compromisso t2 = new Compromisso("assunto2", "local", "link", Convert.ToDateTime("12/12/2022"), Convert.ToDateTime("13:00").TimeOfDay, Convert.ToDateTime("13:00").TimeOfDay, null);
            controladorCompromisso.InserirNovo(t2);

            Compromisso t3 = new Compromisso("assunto3", "local", "link", Convert.ToDateTime("12/12/2023"), Convert.ToDateTime("13:00").TimeOfDay, Convert.ToDateTime("13:00").TimeOfDay, null);
            controladorCompromisso.InserirNovo(t3);

            //action
            var compromissos = controladorCompromisso.SelecionarCompromissosFuturos(DateTime.Now, DateTime.MaxValue);

            //assert
            compromissos.Should().HaveCount(2);
            compromissos[0].Assunto.Should().Be("assunto2");
            compromissos[1].Assunto.Should().Be("assunto3");
        }

        [TestMethod]
        public void DeveSelecionar_CompromissosPassados()
        {
            //arrange
            Compromisso t1 = new Compromisso("assunto1", "local", "link", Convert.ToDateTime("12/12/2020"), Convert.ToDateTime("13:00").TimeOfDay, Convert.ToDateTime("13:00").TimeOfDay, null);
            controladorCompromisso.InserirNovo(t1);

            Compromisso t2 = new Compromisso("assunto2", "local", "link", Convert.ToDateTime("12/12/2022"), Convert.ToDateTime("13:00").TimeOfDay, Convert.ToDateTime("13:00").TimeOfDay, null);
            controladorCompromisso.InserirNovo(t2);

            Compromisso t3 = new Compromisso("assunto3", "local", "link", Convert.ToDateTime("12/12/2023"), Convert.ToDateTime("13:00").TimeOfDay, Convert.ToDateTime("13:00").TimeOfDay, null);
            controladorCompromisso.InserirNovo(t3);

            //action
            var compromissos = controladorCompromisso.SelecionarCompromissosPassados(DateTime.Now);

            //assert
            compromissos.Should().HaveCount(1);
            compromissos[0].Assunto.Should().Be("assunto1");
        }
    }
}
