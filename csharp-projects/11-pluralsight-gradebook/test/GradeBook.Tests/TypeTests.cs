using System.Reflection;
using System.Security.AccessControl;
using System;
using Xunit;

namespace GradeBook.Tests
{

    // Delegate definition
    public delegate string WriteLogDelegate(string logMessage);
                // ^ describe what a method looks like and name of the delegate
                // ^ method output type   ^ method input type

  public class TypeTests
    {
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log;

            // New `WriteLogDelegate` is initialized and references `ReturnMessage` method
            // log = new WriteLogDelegate(ReturnMessage);   // Longhand
            log = ReturnMessage;                            // Shorthand

            var result = log("Hello!");
            Assert.Equal("Hello!", result);
        }

        int count = 0;

        // Only has to match return type and parameter type of delegate
        string ReturnMessage(string message)
        {
            count++;
            return message;
        }

        string IncrementCount(string message)
        {
            count++;
            return message;
        }

        [Fact]
        public void WriteLogDelegateCanPointToMethodWithMulticast()
        {
            count = 0;
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage; // Confused about this and the line above
            log += IncrementCount;

            var result = log("Hello!");
            Assert.Equal("Hello!", result);
            Assert.Equal(3, count);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");
            // `book1` references `GetBook("Book 1")`
            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        [Fact]
        public void CSharpIsPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetNameByRef(ref book1, "New Name");
            
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetNameByRef(ref Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        [Fact]
        public void CSharpIsPassByOutRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetNameByOutRef(out book1, "New Name");
            
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetNameByOutRef(out Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");
            
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // Assert.Equal("Book 1", book1.Name);
            // Assert.Equal("Book 1", book2.Name);
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Korra";
            MakeReferenceUppercase(name);
            var upper = MakeUppercase(name);

            Assert.Equal("Korra", name);
            Assert.Equal("KORRA", upper);
        }

        private void MakeReferenceUppercase(string parameter)
        {
            parameter.ToUpper();
        }
        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }
    }
}