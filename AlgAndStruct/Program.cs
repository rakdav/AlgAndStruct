HashSet<string> states = new HashSet<string>();
states.Add("qwerty");
states.Add("Cvinuskin");
states.Add("qwerty");
foreach (var i in states) 
{
    Console.WriteLine(i.GetHashCode());
    Console.WriteLine(i); 
}
SortedSet<int> sort = new SortedSet<int>();
sort.Add(1);
sort.Add(2);
sort.Add(4);
sort.Add(1);
sort.Add(3);
sort.Add(4);
sort.Add(5);
foreach (var i in sort)
{
    Console.WriteLine(i);
}
