namespace SearchTask2
{
    internal class Program
    {
        static void ExceptionString(string str)
        {
            str = str.ToLower();
            bool b = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'y')
                {
                    b = false;
                }
            }
            if (b == true)
            {
                throw new Exception("your string does not have vowels");
            }

        }
        static void Main(string[] args)
        {
            string str;
            try
            {

                Console.Write("Enter your string : ");
                str = (Console.ReadLine());
                ExceptionString(str);
                Console.WriteLine(str);

            }
            catch(Exception e) 
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
