using System;
using CompositeTutorial.Components;

namespace CompositeTutorial
{
    /// <summary>
    /// Program class ------ Client
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Create the structure
            Directory compositeTutorialDirectory = new Directory("CompositeTutorial");
            
            Directory componentsDirectory = new Directory("ComponentsDirectory");
            componentsDirectory.Add(new File("FileSystemItem.cs", 30));
            componentsDirectory.Add(new File("File.cs", 10));
            componentsDirectory.Add(new File("Directory.cs", 10));
            
            compositeTutorialDirectory.Add(componentsDirectory);
            compositeTutorialDirectory.Add(new File("Program.cs", 50));

            //Get size
            Console.WriteLine(componentsDirectory.GetSize());
        }
    }
}
