using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjetoDeTeste
{
    [TestClass]
    public class CaixaEletronicoTeste
    {
        private CaixaEletrônico caixaEletrônico;

        [TestInitialize]
        public void InicializarTeste()
        {
            this.caixaEletrônico = new CaixaEletrônico();
        }

        [TestMethod]
        public void Saldo_do_caixa_eletrônico_deve_iniciar_com_zero()
        {
            Assert.AreEqual(0, caixaEletrônico.Saldo);
        }

        [TestMethod]
        public void Quando_depositar_20_saldo_retorna_20()
        {
            caixaEletrônico.Depositar(20);

            Assert.AreEqual(20, caixaEletrônico.Saldo);
        }

        [TestMethod]
        public void Quando_depositar_10_e_depois_depositar_30_saldo_retorna_40()
        {
            caixaEletrônico.Depositar(10);
            caixaEletrônico.Depositar(30);

            Assert.AreEqual(40, caixaEletrônico.Saldo);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_depositar_valores_negativos_deve_lançar_exception()
        {
            caixaEletrônico.Depositar(-30);
        }

        [TestMethod]
        public void Quando_sacar_10_e_no_caixa_tiver_25_saldo_retorna_15()
        {
            caixaEletrônico.Depositar(25);

            caixaEletrônico.Sacar(10);

            Assert.AreEqual(15, caixaEletrônico.Saldo);
        }

        [TestMethod]
        public void Quando_sacar_50_e_no_caixa_tiver_70_saldo_retorna_20()
        {
            caixaEletrônico.Depositar(70);

            caixaEletrônico.Sacar(50);

            Assert.AreEqual(20, caixaEletrônico.Saldo);
        }
    }
}
