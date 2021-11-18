﻿using Moq;
using NUnit.Framework;
using Reservas.Models;
using Reservas.Models.Map;
using Reservas.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias.TestCategoriaPlato
{
    public class ServiceTestCategoria
    {
        private Mock<ReservasDbContext> mockContex;

        [SetUp]
        public void SetUp()
        {
            mockContex = ApplicationMockContext.getListaCategoriaContextMock();
        }

        [Test]
        public void testReturnListaCategoriasCaso01()
        {

            var categoriaRepository = new CategoriaPlatoService(mockContex.Object);
            var categoria = categoriaRepository.getLista();

            Assert.IsNotNull(categoria);
        }

        [Test]
        public void testReturnCategoriaIdCaso02()
        {

            var categoriaRepository = new CategoriaPlatoService(mockContex.Object);
            var categoria = categoriaRepository.getCategoria(2);

            Assert.AreEqual("Prueba 2", categoria.NombreCategoria);
        }


        

    }
}