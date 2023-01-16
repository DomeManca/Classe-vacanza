using Borelli_Autobus;
namespace TestBorelli
{
    public class UnitTest1
    {
        Autobus a;
        [Fact]
        public void Test1()
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.Partenza();
            Assert.True(a.Fermo==false);
        }
        [Fact]
        public void Test2()
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.Partenza();
            a.Fermata();
            Assert.True(a.Fermo == true);
        }
        [Fact]
        public void Test3a()
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.Fermata();
            a.SalitaPasseggeri(20);
            Assert.True(a.Passeggeri == 20);
        }
        [Fact]
        public void Test3b()
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.Partenza();
            Assert.Throws<Exception>(() => a.SalitaPasseggeri(20));
        }
        [Fact]
        public void Test3c()
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.Fermata();
            Assert.Throws<Exception>(() => a.SalitaPasseggeri(70));
        }
        [Fact]
        public void Test3d()
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.Deposita();
            Assert.Throws<Exception>(() => a.SalitaPasseggeri(20));
        }
        [Fact]
        public void Test3e()
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.Fermata();
            Assert.Throws<Exception>(() => a.SalitaPasseggeri(-20));
        }
        [Fact]
        public void Test3f()//?? ERRORE: si possono far salire 0 persone
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.Fermata();
            a.SalitaPasseggeri(0);
            Assert.True(a.Passeggeri == 0);
        }
        [Fact]
        public void Test4a()
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.Fermata();
            a.SalitaPasseggeri(20);
            a.DiscesaPasseggeri(10);
            Assert.True(a.Passeggeri == 10);
        }
        [Fact]
        public void Test4b()
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.SalitaPasseggeri(20);
            a.Partenza();
             
        }
        [Fact]
        public void Test4c()
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.Fermata();
            a.SalitaPasseggeri(20);
            Assert.Throws<Exception>(() => a.DiscesaPasseggeri(40));
        }
        [Fact]
        public void Test4d()
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.SalitaPasseggeri(20);
            a.Deposita();
            Assert.Throws<Exception>(() => a.DiscesaPasseggeri(10));
        }
        [Fact]
        public void Test4e()
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.Fermata();
            a.SalitaPasseggeri(20);
            a.DiscesaPasseggeri(20);
            Assert.True(a.Passeggeri == 0);
        }
        [Fact]
        public void Test4f()//?? ERRORE: si possono far scendere 0 persone
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.Fermata();
            a.SalitaPasseggeri(10);
            a.DiscesaPasseggeri(0);
            Assert.True(a.Passeggeri == 10);
        }
        [Fact]
        public void Test5a()
        {
            Autobus b = new Autobus("b123", "BB420XD", "Volkswagen", 52);
            b.SalitaPasseggeri(20);
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.SalitaPasseggeri(20);
            a.SpostaPasseggeri(b);
            Assert.True(b.Passeggeri == 40);
        }
        [Fact]
        public void Test5b()
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            Autobus b = null;
            a.SalitaPasseggeri(20);
            Assert.Throws<Exception>(() => a.SpostaPasseggeri(b));
        }
        [Fact]
        public void Test5c()
        {
            Autobus b = new Autobus("b123", "BB420XD", "Volkswagen", 52);
            b.SalitaPasseggeri(50);
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.SalitaPasseggeri(20);
            Assert.Throws<Exception>(() => a.SpostaPasseggeri(b));
        }
        [Fact]
        public void Test5d()//ERRORE
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.SalitaPasseggeri(20);
            a.SpostaPasseggeri(a);
            Assert.True(a.Passeggeri == 20);
        }
        [Fact]
        public void Test5e()
        {
            Autobus b = new Autobus("b123", "BB420XD", "Volkswagen", 52);
            b.SalitaPasseggeri(20);
            b.Partenza();
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.SalitaPasseggeri(20);
            Assert.Throws<Exception>(() => a.SpostaPasseggeri(b));
        }
        [Fact]
        public void Test5f()
        {
            Autobus b = new Autobus("b123", "BB420XD", "Volkswagen", 52);
            b.SalitaPasseggeri(20);
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.SalitaPasseggeri(20);
            a.Partenza();
            Assert.Throws<Exception>(() => a.SpostaPasseggeri(b));
        }
        [Fact]
        public void Test6()
        {
            a = new Autobus("a123", "AA420XD", "Volkswagen", 52);
            a.Deposita();
            Assert.True(a.InDeposito == true);
        }
    }
}