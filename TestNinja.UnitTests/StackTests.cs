using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Stack<string>();
        }

        // my solutions
        [Test]
        public void Push_WhenGivenNullObject_ThrowsArgumentNullException()
        {
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Pop_WhenPoppingAnEmptyList_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_WhenCalled_ReturnsExpectedValue()
        {
            _stack.Push("a");
            _stack.Push("b");

            var result = _stack.Pop();

            Assert.That(result, Is.EqualTo("b"));
        }

        [Test]
        public void Peek_WhenPeekingInAnEmptyList_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_WhenCalled_ReturnsExpectedValue()
        {
            _stack.Push("a");
            _stack.Push("b");

            var result = _stack.Peek();

            Assert.That(result, Is.EqualTo("b"));
        }

        // from mosh
        [Test]
        public void Push_WhenGivenCorrectParameter_ValueIsAdded()
        {
            _stack.Push("a");

            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_Returns0()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_WhenCalled_LowersStackCount()
        {
            _stack.Push("a");
            _stack.Pop();

            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Peek_WhenCalled_DoesNotRemoveItemFromStack()
        {
            _stack.Push("a");

            _stack.Peek();

            Assert.That(_stack.Count, Is.EqualTo(1));
        }
    }
}
