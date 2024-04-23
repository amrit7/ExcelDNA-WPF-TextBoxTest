using ExcelDna.Integration;
using WpfApp1;

namespace ExcelDNATest
{
    public static class MyFunctions
    {
        [ExcelFunction(Description = ".NET Function")]
        public static string SayHello(string name)
        {
            var frm = new MainWindow();
            frm.Show();

            return "Hello " + name;
        }
    }
}
