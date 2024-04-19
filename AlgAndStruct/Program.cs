//HashSet<string> states = new HashSet<string>();
//states.Add("qwerty");
//states.Add("Cvinuskin");
//states.Add("qwerty");
//foreach (var i in states) 
//{
//    Console.WriteLine(i.GetHashCode());
//    Console.WriteLine(i); 
//}
//SortedSet<int> sort = new SortedSet<int>();
//sort.Add(1);
//sort.Add(2);
//sort.Add(4);
//sort.Add(1);
//sort.Add(3);
//sort.Add(4);
//sort.Add(5);
//foreach (var i in sort)
//{
//    Console.WriteLine(i);
//}

using AlgAndStruct;

var binaryTree = new BinaryTree<int>();

binaryTree.Add(8);
binaryTree.Add(3);
binaryTree.Add(10);
binaryTree.Add(1);
binaryTree.Add(6);
binaryTree.Add(4);
binaryTree.Add(7);
binaryTree.Add(14);
binaryTree.Add(16);

binaryTree.PrintTree();

Console.WriteLine(new string('-', 40));
binaryTree.Remove(3);
binaryTree.PrintTree();

Console.WriteLine(new string('-', 40));
binaryTree.Remove(8);
binaryTree.PrintTree();






