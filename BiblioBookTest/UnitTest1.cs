using BiblioBook;

namespace BiblioBookTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
                Assert.AreEqual(5, Form1.personnames().Result.Count);
        }
        [TestMethod]
        public void TestMethod2()
        {
        List<string> booklist = new List<string>() { "����������� \"�����\"", "������ \"������� ���������\"", "��������� \"�����\"", "������� \"����� � ���\"" };
            CollectionAssert.AreEqual(booklist, Form1.booklist().Result);
        }
    }
}