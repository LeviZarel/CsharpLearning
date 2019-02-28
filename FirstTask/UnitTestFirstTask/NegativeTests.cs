using FirstTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestFirstTask
{
    [TestClass]
    public class NegativeTests
    {
        [TestMethod]
        public void FailedAdd()
        {
            string[] arguments = { "5,5", "2,2" };
            var vectorCollections = new VectorCollections(arguments);
            var vectorA = vectorCollections.getVectorByIndex(0);
            var vectorB = vectorCollections.getVectorByIndex(1);
            var vectorResult = vectorA.Add(vectorB);
            Assert.AreEqual(vectorResult.ToString(), "[7,5]");
        }
        [TestMethod]
        public void FaileDotProduct()
        {
            string[] arguments = { "5,5", "2,2" };
            var vectorCollections = new VectorCollections(arguments);
            var vectorA = vectorCollections.getVectorByIndex(0);
            var vectorB = vectorCollections.getVectorByIndex(1);
            var vectorResult = vectorA.DotProduct(vectorB);
            Assert.AreEqual(vectorResult.ToString(), "25");
        }
        [TestMethod]
        public void InvalidArgumentVector3D()
        {
            string[] arguments = { "5,5", "2,2,4" };
            Assert.ThrowsException<ArgumentException>(() => new VectorCollections(arguments));
        }
        [TestMethod]
        public void InvalidArgumentVector4D()
        {
            string[] arguments = { "5,5", "1,2,3,4" };
            Assert.ThrowsException<ArgumentException>( () => new VectorCollections(arguments));
        }
        [TestMethod]
        public void InsertDiferentVectorsAnd3D()
        {
            string[] arguments = { "5,5", "1,2,", "2,3,6" };
            Assert.ThrowsException<ArgumentException>(() => new VectorCollections(arguments));
        }
        [TestMethod]
        public void VectorToStringFailed()
        {
            string[] arguments = { "5,5", "1,2" };
            var vectorCollections = new VectorCollections(arguments);
            var vectorA = vectorCollections.getVectorByIndex(0);
            Assert.AreEqual(vectorA.ToString(), "[5,55]");
        }
        [TestMethod]
        public void FailedVectorLength()
        {
            string[] arguments = { "5,5", "1,2" };
            var vectorCollections = new VectorCollections(arguments);
            var vectorA = vectorCollections.getVectorByIndex(0);
            Assert.AreEqual(vectorA.Length, 3);
        }
    }
}
