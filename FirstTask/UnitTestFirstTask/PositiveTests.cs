using FirstTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFirstTask
{
    [TestClass]
    public class PositiveTests
    {
        [TestMethod]
        public void CorrectAdd()
        {
            string[] arguments = {"5,5" ,"2,2"};
            var vectorCollections = new VectorCollections(arguments);
            var vectorA = vectorCollections.getVectorByIndex(0);
            var vectorB = vectorCollections.getVectorByIndex(1);
            var vectorResult = vectorA.Add(vectorB);
            Assert.AreEqual(vectorResult.ToString(), "[7,7]");
        }
        [TestMethod]
        public void CorrectDot()
        {
            string[] arguments = {"5,5", "2,2"};
            var vectorCollections = new VectorCollections(arguments);
            var vectorA = vectorCollections.getVectorByIndex(0);
            var vectorB = vectorCollections.getVectorByIndex(1);
            var vectorResult = vectorA.DotProduct(vectorB);
            Assert.AreEqual(vectorResult.ToString(), "20");
        }
        [TestMethod]
        public void CorrectLength()
        {
            string[] arguments = { "5,5", "2,2" };
            var vectorCollections = new VectorCollections(arguments);
            var vectorA = vectorCollections.getVectorByIndex(0);
            Assert.AreEqual(vectorA.Length, 2);
        }
        [TestMethod]
        public void IsertMoreVectors()
        {
            string[] arguments = { "5,5", "2,2", "8,1", "9,8", "10,2" };
            var vectorCollections = new VectorCollections(arguments);
            var vectorA = vectorCollections.getVectorByIndex(0);
            var vectorB = vectorCollections.getVectorByIndex(1);
            var vectorC = vectorCollections.getVectorByIndex(2);
            Assert.AreEqual(vectorC.ToString(), "[8,1]");
        }

        [TestMethod]
        public void CompleteValuesVectorWhitZero()
        {
            string[] arguments = { "5,5", "2,2", "8" };
            var vectorCollections = new VectorCollections(arguments);
            var vectorA = vectorCollections.getVectorByIndex(0);
            var vectorB = vectorCollections.getVectorByIndex(1);
            var vectorC = vectorCollections.getVectorByIndex(2);
            Assert.AreEqual(vectorC.ToString(), "[8,0]");
        }
        [TestMethod]
        public void InsertOneVectorInArgs()
        {
            string[] arguments = { "2,5" };
            var vectorCollections = new VectorCollections(arguments);
            var vectorA = vectorCollections.getVectorByIndex(0);
            Assert.AreEqual(vectorA.ToString(), "[2,5]");
        }

    }
}
