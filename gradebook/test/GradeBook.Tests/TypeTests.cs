using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetBookReturnsTwoDifferentBooks()
        {
            Book book1 = getBook("Book 1");
            Book book2 = getBook("Book 2");
            
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            Book book1 = getBook("Book 1");
            Book book2 = book1;

            Assert.Same(book1, book2);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            Book book1 = getBook("Book 1");
            setName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            Book book1 = new Book("Book 1");
            getBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        [Fact]
        public void CSharpCanPassByValue()
        {
            Book book1 = new Book("Book 1");
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

        private void setInt(ref int x)
        {
            x = 42;
        }

        private int getInt()
        {
            return 3;
        }

        private void getBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        private void getBookSetName(Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        private void setName(Book book, string name)
        {
            book.Name = name;
        }

        private Book getBook(string name)
        {
            return new Book(name);
        }
    }
}
