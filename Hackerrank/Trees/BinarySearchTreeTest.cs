namespace Hackerrank.Trees
{
    public class BinarySearchTreeTest
    {
        public void TestBinarySearchTree()
        {
            var bst = new BinarySearchTree();

            bst.Add(10);
            bst.Add(2);
            bst.Add(5);
            bst.Add(11);
            bst.Add(9);
            bst.Add(13);

            bst.Remove(5);
            var node = bst.Find(13);
            System.Console.WriteLine($"Item 13 Found, Parent: {node.Parent.CurrentNode.Value}");
            
            foreach (var item in bst.GetAllNodes())
            {
                System.Console.WriteLine(item.CurrentNode.Value);
            }
        }
    }
}