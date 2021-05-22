using System;
using Xunit;

namespace GradeBook.Tests
{

    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {

        int count = 0;

        [Fact]
        public void GetBookReturnsTwoDifferentBooks()
        {
            InMemoryBook book1 = getBook("Book 1");
            InMemoryBook book2 = getBook("Book 2");
            
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            InMemoryBook book1 = getBook("Book 1");
            InMemoryBook book2 = book1;

            Assert.Same(book1, book2);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            InMemoryBook book1 = getBook("Book 1");
            setName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            InMemoryBook book1 = new InMemoryBook("Book 1");
            getBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        [Fact]
        public void CSharpCanPassByValue()
        {
            InMemoryBook book1 = new InMemoryBook("Book 1");
            getBookSetName(ref book1, "New Name");
            
            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            int x = getInt();
            setInt(ref x);

            Assert.Equal(42, x);
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "matti";
            string upper = MakeUpperCase(name);

            Assert.Equal("matti", name);
            Assert.Equal("MATTI", upper);
        }

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount;
            string result = log("Hello!");
            Assert.Equal(3, count);
        }

        private string IncrementCount(string message)
        {
            count++;
            return message.ToLower();
        }

        private string ReturnMessage(string message)
        {
            count++;
            return message;
        }

        private string MakeUpperCase(string name)
        {
            return name.ToUpper();
        }

        private void setInt(ref int x)
        {
            x = 42;
        }

        private int getInt()
        {
            return 3;
        }

        private void getBookSetName(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        private void getBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
            book.Name = name;
        }

        private void setName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        private InMemoryBook getBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
