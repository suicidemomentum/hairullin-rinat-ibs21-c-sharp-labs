using DynamicArrayClass;

DynamicArray<int> obj1 = new(12);
obj1.Notify += DisplayMessage;
obj1.Add(1);
obj1.Add(2);
obj1.Add(3);
foreach (var item in obj1)
{
    Console.WriteLine(item);
}
DynamicArray<int> obj2 = new(obj1);
obj2.Notify += DisplayMessage;
Console.WriteLine(obj2.Length);
Console.WriteLine(obj2.Capacity);
obj2.AddRange(obj1);
Console.WriteLine(obj2.Length);
Console.WriteLine(obj2.Capacity);
obj2.Remove(1);
Console.WriteLine(obj2.Length);
Console.WriteLine(obj2.Capacity);
obj2.Insert(55, 3);
Console.WriteLine(obj2.Length);
Console.WriteLine(obj2.Capacity);
DynamicArray<int> obj3 = new(1);
obj3.Notify += DisplayMessage;
obj3.Add(1);
obj3.Add(2);
obj3.Add(3);
Console.WriteLine(obj3.Equals(obj1));

bool TestFunc(int s, int b)
{
    if (s != b) return true;
    return false;
}

void DisplayMessage(object obj, DynamicArrayEventArgs e)
{
    Console.WriteLine($"Old capacity: {e.OldCapacity}");
    Console.WriteLine($"New capacity: {e.NewCapacity}");
}