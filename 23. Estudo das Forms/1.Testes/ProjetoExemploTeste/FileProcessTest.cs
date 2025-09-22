using _1.Testes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.IO;

namespace ProjetoExemploTeste
{

    [TestClass]
    public class FileProcessTest
    {
        private string _Arquivo = @"D:\\Arquivos\\documento.pdf\";
        private string _Log = @"D:\\Arquivos\\Log.txt\";
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            if (TestContext.TestName == "FileNameDoesExists")
            {
                if(!string.IsNullOrEmpty(_Log))
                {
                    File.Create(_Log).Close();
                    TestContext.Write($"Criando Arquivo {_Log}");
                    File.AppendAllText(_Log, "Mais texto");
                }
            }
        }
        [TestCleanup]
        public void TestCleanup()
        {
            if (TestContext.TestName == "FileNameDoesExists")
            {
                if (!string.IsNullOrEmpty(_Log))
                {
                    TestContext.Write($"Deletando Arquivo {_Log}");
                    File.Delete(_Log);

                }
            }
        }

        [TestMethod]
        [Description("Testando se um arquivo existe")]
        [Owner("Romário")]
        public void FileNameDoesExists()
        {

            FileProcess fp = new FileProcess();
            TestContext.WriteLine("Instanciando");
            bool fromCall;

            fromCall = fp.FileExists(_Arquivo);

            Assert.IsTrue(fromCall);
        }
        [TestMethod]
        [Description("Se não existir")]
        [Owner("Laura")]
        public void FileNameDoesNotExists()
        {

            FileProcess fp = new FileProcess();

            bool fromCall;

            fromCall = fp.FileExists(_Arquivo);

            Assert.IsFalse(fromCall);
        }
        [TestMethod]
        [Description("Exception")]
        [Owner("Vitor")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEMpty_ThrowArgumentNullException()
        {
            FileProcess fp = new FileProcess();

            fp.FileExists("");
        }

        [TestMethod]
        public void FileNameNullOrEMpty_ThrowArgumentNullException_UsingTry()
        {
            FileProcess fp = new FileProcess();

            try
            {
                fp.FileExists("");
            }
            catch (Exception)
            {
                //Teste foi um sucesso
                return;
            }

            Assert.Fail("Falha esperada");
        }
    }
}
