namespace DependencyInjectionTest
{
    public class TestService : ITestService
    {
        private readonly string _text;

        public TestService(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }
    }
}
