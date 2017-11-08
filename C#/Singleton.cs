using System;

namespace designPatterns
{
    // A Singleton is a class that can only have one instance.
    class Singleton
    {
        // Class data is inaccessible from outside the class
        private static Singleton instance;
        private static string phrase;

        // Constructor class is inaccessible from outside the class
        private Singleton()
        {
        }

        // Create a new instance only if one does not currently exist
        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        // Assign a string to the private "phrase" data member
        public void text(string inStr)
        {
            if (instance != null)
            {
                phrase = inStr;
            }
        }

        // Print the Singleton's "phrase"
        public void print()
        {
            if (phrase != null)
            {
                Console.WriteLine("{0}", phrase);
            }
        }
    }

    class Progam
	{
		static void Main()
		{
            // Test singleton class
            // The line below, when uncommented, will not compile
            // due to the constructor's protection.
            //Singleton s1 = new Singleton();

            // Test getInstance, print, and text methods
            Singleton s1 = Singleton.getInstance();
            s1.print();
            s1.text("Text for s1");
            s1.print();

            // Check if there is only one instance
            Singleton s2 = Singleton.getInstance();
            s2.text("Text for s2");
            s2.print();
            s1.print();
		}
	}
}