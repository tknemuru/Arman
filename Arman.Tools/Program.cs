using System;

namespace Arman.Tools
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new SkeletonSourceGenerator().Execute(args[0], args);
                Console.WriteLine("Generate done.");
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
