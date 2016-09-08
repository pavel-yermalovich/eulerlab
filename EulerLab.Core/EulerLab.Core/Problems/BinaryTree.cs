namespace EulerLab.Core.Problems
{
    public class BinaryTree<T>
    {
        public BinaryTree(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public BinaryTree<T> Left { get; set; }
        public BinaryTree<T> Right { get; set; } 
    }
}
