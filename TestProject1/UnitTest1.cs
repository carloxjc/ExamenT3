using ExamenT3.Controllers;
using ExamenT3.Models;
using ExamenT3.repositorio;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        private Mock<NotaInterface> notaMock;

        [SetUp]
        public void setup()
        {
            notaMock = new Mock<NotaInterface>();
        }

        [Test]
        public void LSITA_DE_NOTAS()
        {
            notaMock.Setup(a => a.getListaDeNotas()).Returns(new List<Notas>());

            var controller = new NotaController(notaMock.Object);


            var resultado = controller.Index();

            Assert.IsInstanceOf<ViewResult>(resultado);

        }

        [Test]
        public void CREAR_NOTAS()
        {

            var controller = new NotaController(notaMock.Object);


            var resultado = controller.Create("HOLA LOCO MUNDO ", " ;-;") as RedirectToActionResult;

            Assert.IsInstanceOf<RedirectToActionResult>(resultado);

        }

        [Test]
        public void EDITAR_NOTAS()
        {

            var controller = new NotaController(notaMock.Object);


            var resultado = controller.Editar("Prueba 1"," contenido de prueba",2) as RedirectToActionResult;

            Assert.IsInstanceOf<RedirectToActionResult>(resultado);

        }

        [Test]
        public void ELIMINAR_NOTAS()
        {

            var controller = new NotaController(notaMock.Object);


            var resultado = controller.Eliminar( 2) as RedirectToActionResult;

            Assert.IsInstanceOf<RedirectToActionResult>(resultado);

        }
    }
}
