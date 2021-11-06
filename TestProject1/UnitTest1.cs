using ExamenT3.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
        }
        [Test]
        public void GetIndexIsOk()
        {

            //var IBancoServicesMock = new Mock<IBancoServices>();
            //var IValidacionServiceMock = new Mock<IValidacionService>();

            var home = new NotaController();

            var result = home.Index() as ViewResult;


            //Assert.IsInstanceOfType<ViewResult>(result);
             Assert.IsInstanceOf<ViewResult>(result);


        }
    }
}
