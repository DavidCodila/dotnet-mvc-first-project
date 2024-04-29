using FirstMVCProject.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstMVCProjectTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestAddOne()
    {
        AdderModel am = new AdderModel(1);
        Assert.AreEqual(2, am.Number);
    }
}