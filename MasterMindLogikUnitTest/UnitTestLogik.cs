using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterMindLogik;

namespace MasterMindLogikUnitTest
{
    [TestClass]
    public class UnitTestLogik
    {
        [TestMethod]
        public void IndexGetroffen()
        {
            int[] test = Logik.SpielLogik(new[] { 1, 2, 3, 4 }, new[] { 1, 0, 0, 0 });
            CollectionAssert.AreEqual(new[] { -1, 0, 0, 0 }, test);
        }

        [TestMethod]
        public void ZahlGetroffen()
        {
            int[] test = Logik.SpielLogik(new[] { 1, 2, 3, 4 }, new[] { 0, 1, 0, 0 });
            CollectionAssert.AreEqual(new[] { -2, 0, 0, 0 }, test);
        }

        [TestMethod]
        public void DoppeltIndexTreffer()
        {
            int[] test = Logik.SpielLogik(new[] { 1, 2, 3, 4 }, new[] { 0, 0, 3, 4 });
            CollectionAssert.AreEqual(new[] { -1, -1, 0, 0 }, test);
        }

        [TestMethod]
        public void DoppeltZahlTreffer()
        {
            int[] test = Logik.SpielLogik(new[] { 1, 2, 3, 4 }, new[] { 3, 4, 0, 0 });
            CollectionAssert.AreEqual(new[] { -2, -2, 0, 0 }, test);
        }

        [TestMethod]
        public void ZahlUndIndexVonDoppelterZahl()
        {
            int[] test = Logik.SpielLogik(new[] { 1, 1, 2, 3 }, new[] { 1, 0, 1, 0 });
            CollectionAssert.AreEqual(new[] { -1, -2, 0, 0 }, test);
        }

        [TestMethod]
        public void ZahlUndIndexVonTripelZahl()
        {
            int[] test = Logik.SpielLogik(new[] { 1, 1, 2, 1 }, new[] { 1, 0, 1, 0 });
            CollectionAssert.AreEqual(new[] { -1, -2, 0, 0 }, test);
        }

        [TestMethod]
        public void DoppeltIndexUndZahl()
        {
            int[] test = Logik.SpielLogik(new[] { 0, 1, 1, 2 }, new[] { 0, 1, 2, 3 });
            CollectionAssert.AreEqual(new[] { -1, -1, -2, 0 }, test);
        }

        [TestMethod]
        public void DoppeltZahlUndIndex()
        {
            int[] test = Logik.SpielLogik(new[] { 0, 1, 1, 2 }, new[] { 1, 0, 1, 3 });
            CollectionAssert.AreEqual(new[] { -1, -2, -2, 0 }, test);
        }

        [TestMethod]
        public void VierZahlen()
        {
            int[] test = Logik.SpielLogik(new[] { 0, 1, 2, 3 }, new[] { 1, 0, 3, 2 });
            CollectionAssert.AreEqual(new[] { -2, -2, -2, -2 }, test);
        }

        [TestMethod]
        public void Gewonnen()
        {
            int[] test = Logik.SpielLogik(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 });
            CollectionAssert.AreEqual(new[] { -1, -1, -1, -1 }, test);
        }

        [TestMethod]
        public void Verloren()
        {
            int[] test = Logik.SpielLogik(new[] { 1, 2, 3, 4 }, new[] { 9, 8, 7, 6 });
            CollectionAssert.AreEqual(new[] { 0, 0, 0, 0 }, test);
        }
    }
}
