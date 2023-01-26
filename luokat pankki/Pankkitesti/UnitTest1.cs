using Pankki;
{
    [TestClass]
    public class Pankkitilitesti
    {
        [TestMethod]
        public void TestMethod1()
        {
            double alkusaldo = 11.99;
            double ottoSumma = 4.55;
           double oletettu = 7.44;

            Pankkitili pt = new Pankki.Pankkitili("Jaakko Tarvainen", alkusaldo);
            pt.Otto(ottoSumma):
                Asset.AreEqual(oletettu, pt.Saldo, 0.001, "jossakin m‰tt‰‰");
        }
    }
}