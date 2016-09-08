using EulerLab.Core.Problems;
using NUnit.Framework;

namespace EulerLab.Tests
{
    [TestFixture]
    public class Problem18Tests
    {
        [Test]
        public void WeCanCreateABinaryTree()
        {
            var tree = new BinaryTree<int>(1);
            tree.Left = new BinaryTree<int>(2) { Left = new BinaryTree<int>(4), Right = new BinaryTree<int>(5) };
            tree.Right = new BinaryTree<int>(3) { Left = new BinaryTree<int>(6), Right = new BinaryTree<int>(7) };

            Assert.That(tree, Is.Not.Null);
            Assert.That(tree.Value, Is.EqualTo(1));
            Assert.That(tree.Left, Is.Not.Null);
            Assert.That(tree.Right, Is.Not.Null);
        }
    }
}
