using NUnit.Framework;

namespace banque_simple
{
    [TestFixture]
    public class CompteTest 
    
    {
        private Compte compte;

        [SetUp]
        public void setUp() {
            compte = new Compte(4526456, 1000.00, @"pipo@pipo.com");

        }

        [Test]
        public void testGetNumero()
        {
            //setUp();
            long num = compte.Numero;
            Assert.AreEqual(4526456, num);
        }

        [Test]
        public void testSetNumero()
        {
            compte.Numero = 123456789;
            long num = compte.Numero;
            Assert.AreEqual(123456789, num);
        }
        [Test]
        public void testGetSolde()
        {
            Assert.AreEqual(1000.00, compte.Solde);

        }
        [Test]
        public void testSetSolde()
        {
            compte.Solde = 2000.00;
            Assert.AreEqual(2000.00, compte.Solde);
        }
        [Test]
        public void testGetRefClient()
        {
            Assert.AreEqual("pipo@pipo.com", compte.ReferenceClient);
        }
        [Test]
        public void testSetRefClient()
        {
            compte.ReferenceClient = "demo@demo.com";
            Assert.AreEqual("demo@demo.com", compte.ReferenceClient);
        }

        [Test]
        public void testCompte()
        {
            // test du constructeur sans parametre
            Compte compte = new Compte();
            Assert.IsNotNull(compte);
        }

        [Test]
        public void testCompteParam()
        {
            // test du constructeur sans parametre
            Compte compte = new Compte(12345678,5000.00,"demo@demo.com");
            Assert.AreEqual(12345678, compte.Numero);
            Assert.AreEqual(5000.00, compte.Solde);
            Assert.AreEqual("demo@demo.com", compte.ReferenceClient);
        }


    }




}
