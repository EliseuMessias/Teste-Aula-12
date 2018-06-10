using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teste_Aula_12;

namespace Teste
{
    [TestClass]
    public class UnitTest1
    {
        Aluno a1 = new Aluno();
        Aluno a2 = new Aluno();
        Aluno a3 = new Aluno();

        #region Idade
        [TestMethod]
        public void Idade1()
        {
            a1.Nascimento = new DateTime(1990, 04, 01);

            Assert.IsTrue(a1.Idade() > 0);
        }
        [TestMethod]
        public void Idade2()
        {
            a2.Nascimento = new DateTime(2020, 01, 01);

            Assert.IsTrue(a2.Idade() > 0);
        }
        [TestMethod]
        public void Idade3()
        {
            a3.Nascimento = new DateTime(1986, 03, 12);

            Assert.IsTrue(a3.Idade() > 0);
        }
        #endregion

        #region Nome
        [TestMethod]
        public void nome1()
        {
            a1.Nome = "Felipe";
            a1.Snome = "Vozgeral Çanca";

            Assert.IsTrue(a1.validarNome() != 0);
        }
        [TestMethod]
        public void nome2()
        {
            a2.Nome = "Alin@";
            a2.Snome = "Branca";

            Assert.IsTrue(a2.validarNome() != 0);
        }
        [TestMethod]
        public void nome3()
        {
            a3.Nome = "Alfredo";
            a3.Snome = "Sella III";

            Assert.IsTrue(a3.validarNome() != 0);
        }
        #endregion

        #region nome completo
        [TestMethod]
        public void nomeC1()
        {
            a1.Nome = "Felipe";
            a1.Snome = "Vozgeral Çanca";

            Assert.AreEqual((a1.Nome + " " + a1.Snome), a1.nomeCompleto());
        }
        [TestMethod]
        public void nomeC2()
        {
            a2.Nome = "Alin@";
            a2.Snome = "Branca";

            Assert.AreEqual((a2.Nome + " " + a2.Snome), a2.nomeCompleto());
        }
        [TestMethod]
        public void nomeC3()
        {
            a3.Nome = "Alfredo";
            a3.Snome = "Sella III";

            Assert.AreEqual((a3.Nome + "" + a3.Snome), a3.nomeCompleto());
        }
        #endregion

        #region erro validação
        [TestMethod]
        public void erro1()
        {
            a1.Nome = "Felipe";
            a1.Snome = "Vozgeral Çanca";
            a1.validarNome();
            Assert.AreEqual("NO ERROR", a1.erroValidacao(a1.validarNome()));
        }
        [TestMethod]
        public void erro2()
        {
            a2.Nascimento = new DateTime(2020, 01, 01);

            a2.Idade();
            Assert.AreEqual("ERROR", a2.erroValidacao(a2.Idade()));
        }
        [TestMethod]
        public void erro3()
        {
            a3.Nome = "Alfredo";
            a3.Snome = "Sella III";

            a3.validarNome();
            Assert.AreEqual("NO ERROR", a3.erroValidacao(a3.validarNome()));
        }
        #endregion
    }
}
