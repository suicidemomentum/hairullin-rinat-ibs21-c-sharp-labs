using DynamicArrayClass;

DynamicArray<int> obj1 = new(12);
obj1.Notify += DisplayMessage;
obj1.PrintArray();
obj1.Add(1);
obj1.PrintArray();
obj1.Add(2);
obj1.PrintArray();
obj1.Add(3);
obj1.PrintArray();
foreach (var item in obj1)
{
    Console.WriteLine(item);
}
DynamicArray<int> obj2 = new(obj1);
Console.WriteLine(obj2.Length);
Console.WriteLine(obj2.Capacity);
obj2.PrintArray();
obj2.AddRange(obj1);
Console.WriteLine(obj2.Length);
Console.WriteLine(obj2.Capacity);
obj2.PrintArray();
obj2.Remove(1, TestFunc);
obj2.PrintArray();
Console.WriteLine(obj2.Length);
Console.WriteLine(obj2.Capacity);
obj2.Insert(55, 3);
obj2.PrintArray();
Console.WriteLine(obj2.Length);
Console.WriteLine(obj2.Capacity);
DynamicArray<int> obj3 = new(1);
obj3.Add(1);
obj3.Add(2);
obj3.Add(3);
obj3.PrintArray();
Console.WriteLine(obj3.Equals(obj1));

bool TestFunc(int s, int b)
{
    if (s != b) return true;
    return false;
}

void DisplayMessage(Object obj, DynamicArrayEventArgs e)
{
    Console.WriteLine($"Old capacity: {e.OldCapacity}");
    Console.WriteLine($"New capacity: {e.NewCapacity}");
}