namespace TestProject_For_A2Task2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AAccounts selectedAcc = new AAccounts();
            CalculateInterest( selectedAcc);
        }
    }
}