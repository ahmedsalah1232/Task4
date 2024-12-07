namespace SearchTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            bool d = true;
            try
            {
                do
                {
                    int n;
                    Console.Write("Enter your element : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (list.Count == 0)
                    {
                        list.Add(n);
                    }
                    else
                    {
                        for(int i = 0;i<list.Count;i++)
                        {
                            if (list[i] == n)
                            {
                                d=false;
                                throw new DuplicateWaitObjectException();
                            }
                        }
                    }
                    list.Add(n);
                } while (d == true);
            }
            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
