namespace Validot.Testing
{
    public sealed class TestFailedException : ValidotException
    {
        public TestFailedException(string message)
            : base(message)
        {
        }
    }
}
