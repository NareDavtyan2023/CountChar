namespace CountChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strFisrt;
            char charcount;
            int Count = 0;
            Console.Write(  "Input text: ");
            strFisrt= Console.ReadLine();
            Console.WriteLine(  "Count:");
            charcount = Convert.ToChar(strFisrt);
            Console.WriteLine("Count is:");
            foreach(char chr in strFisrt)
            {
                if(chr==charcount)
                {
                    Count++;
                }
            }
            Console.Write(Count);
        }
       
    }
}