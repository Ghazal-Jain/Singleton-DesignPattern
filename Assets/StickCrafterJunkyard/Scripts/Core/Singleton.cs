/*
    This is the simplistic approach to implement
    Singleton Design Pattern in C#
 */

// Singleton class
public class Singleton
{
    // Static variable that holds ONE instance of class Singleton
    private static Singleton uniqueInstance;

    // OTHER VARIABLES

    // Private constructor: Only Singleton can instantiate the class
    private Singleton() { }

    // getInstance() method instantiates the Singleton class 
    // Also returns the instance of the class
    public static Singleton getInstance()
    {
        // Check to see if any instance exists, if not then one is created
        if (uniqueInstance == null)
        {
            uniqueInstance = new Singleton();
        }
        return uniqueInstance;
    }

    // OTHER METHODS
}
