using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTest
    {

        [Fact]
        public void CSharpIsPassByReference()
        {
            var bookOne = GetBook("New Book One");
            GetBookSetName(ref bookOne, "New Name");
            Assert.Equal("New Name", bookOne.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var bookOne = GetBook("New Book One");
            GetBookSetName(bookOne, "New Name");
            Assert.Equal("New Book One", bookOne.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
            // Below like is not required
            book.Name = name;
        }

        [Fact]
        public void Test()
        {
            // Arrange
            var bookOne = GetBook("New Book One");
            var bookTwo = GetBook("New Book Two");

            Assert.Equal("New Book One", bookOne.Name);
            Assert.Equal("New Book Two", bookTwo.Name);

        }

        [Fact]
        public void TwoVarsReferenceSameObject()
        {
            // Arrange
            var bookOne = GetBook("New Book One");
            var bookTwo = bookOne;

            Assert.Same(bookOne, bookTwo);
            Assert.True(object.ReferenceEquals(bookOne, bookTwo));
            Assert.Equal("New Book One", bookOne.Name);
            Assert.Equal("New Book One", bookTwo.Name);

        }

        [Fact]
        public void SetNameFromReference()
        {
            var bookOne = GetBook("New Book One");
            SetName(bookOne, "New Name One");
            Assert.Equal("New Name One", bookOne.Name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bookOne"></param>
        /// <param name="v"></param>
        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
