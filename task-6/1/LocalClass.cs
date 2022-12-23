namespace LocalUtils
{
    public static class LocalClass
    {
        public static Queue<int> FillQueue(int n)
        {
            Queue<int> circle = new Queue<int>();

            for (int i = 1; i <= n; i++)
            {
                circle.Enqueue(i);
            }

            return circle;
        }

        public static List<int> StrikingOutEverySecond(Queue<int> circle)
        {
            List<int> list = new List<int>();

            while (circle.Count > 1)
            {
                circle.Enqueue(circle.Dequeue());
                list.Add(circle.Dequeue());
            }

            return list;
        }
    }
}
