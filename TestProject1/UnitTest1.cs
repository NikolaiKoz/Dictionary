using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBuscarEdadDeJose()
        {
            // Arrange
            Dictionary<string, int> personas = new Dictionary<string, int>();
            personas.Add("Jose", 25);
            personas.Add("María", 30);
            personas.Add("Belen", 20);
            personas.Add("Giuliano", 35);

            // Act
            int edad;
            bool existe = personas.TryGetValue("Jose", out edad);

            // Assert
            Assert.IsTrue(existe);
            Assert.AreEqual(25, edad);
        }

        [TestMethod]
        public void TestBuscarEdadDeBelen()
        {
            Dictionary<string, int> personas = new Dictionary<string, int>();
            personas.Add("Jose", 25);
            personas.Add("María", 30);
            personas.Add("Belen", 20);
            personas.Add("Giuliano", 35);

            int edad;
            bool existe = personas.TryGetValue("Ana", out edad);

            Assert.IsFalse(existe);
            Assert.AreEqual(default(int), edad);
        }

        [TestMethod]
        public void TestAddElement()
        {
            Dictionary<string, int> personas = new Dictionary<string, int>();
            personas.Add("Juan", 25);
            personas.Add("María", 30);

            Assert.AreEqual(2, personas.Count);

            // Añadimos un nuevo elemento
            personas.Add("Pedro", 20);

            Assert.AreEqual(3, personas.Count);
        }

        [TestMethod]
        public void TestRemoveElement()
        {
            Dictionary<string, int> personas = new Dictionary<string, int>();
            personas.Add("Juan", 25);
            personas.Add("María", 30);
            personas.Add("Pedro", 20);

            Assert.AreEqual(3, personas.Count);

            // Removemos un elemento existente
            bool removido = personas.Remove("María");

            Assert.IsTrue(removido);
            Assert.AreEqual(2, personas.Count);

            // Tratamos de remover un elemento que no existe
            removido = personas.Remove("Ana");

            Assert.IsFalse(removido);
            Assert.AreEqual(2, personas.Count);
        }

        [TestMethod]
        public void TestClearDictionary()
        {
            Dictionary<string, int> personas = new Dictionary<string, int>();
            personas.Add("Juan", 25);
            personas.Add("María", 30);
            personas.Add("Pedro", 20);

            Assert.AreEqual(3, personas.Count);

            // Limpiamos el diccionario
            personas.Clear();

            Assert.AreEqual(0, personas.Count);
        }

    }
}