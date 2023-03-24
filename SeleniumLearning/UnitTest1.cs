namespace SeleniumLearning
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Setup method Execution");
        }


        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("This is test 1");
        }

        [TearDown]
        public void CloseBrowser()
        {
            TestContext.Progress.WriteLine("tear down method");
        }


    }
}