using Blazor.Routing;

namespace BlazorTestHarness
{
    public class Program
    {
        static void Main(string[] args)
        {
            Router.MountInElement("app");
        }
    }
}
