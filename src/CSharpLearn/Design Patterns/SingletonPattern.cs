namespace CSharpLearn.DesignPatterns;

/*
 * Singleton Pattern
 * The most loved and hated pattern.
 * 
 * DI = Dependency Injection
 * 
 * Personally, I think this pattern should be avoided whenever possible.
 * For most situations, you can use DI and achieve a much cleaner solution.
 * Below are my thoughts about this pattern.
 * 
 * 1) How Its Used
 * The frustrating part is not the singleton istelf, bout how its used. See the ABadWayToUseSingletons below.
 * When the class is large, and you are wanting to use it by itself. Say to unit test, or maybe just to use its function 
 * in a because its in a library. When a classes dependices are not required for object creation (via the constructor), then 
 * there is a chance the class is not setup correclty. For example, what if to init this object; it required the singleton. But you
 * did not know you need to call init on the singleton to set it up.
 * 
 * 2) Singleton and Initilization
 * Becase singletons are created on static constructor (or thats how I do it); it means there no 
 * good solution for configuring the singleton on init. Typically you will need a main class; that then calls Singelton.Init() 
 * or similar to actually configure the singleton the way you want. Therefore, using singletons as manager that performs functions based on
 * a state is not good.
 * 
 * 3) .Net Generic Hosts with Singleton DI
 * This will be discussed in another section; but I have found this useful. I would create a class that simply holds variables for state syncing
 * between workrs. Then set it upas a singleton with .net generic hosts and have it injected into each worker.
 * See .... for an example on this.
 * 
 * 4) Unity and Singletons
 * Unity (as well as other frameworks like WPF) dont allow you to have proper DI. So most people end up doing the singleton manager
 * via an instance on a game object in the scene (Awake() singleton = this for example). For WPF you just simply cannot DI things
 * like user controls and such. Because the UI is made from a markup language and created vis XAML. You can create properties for the control,
 * but those are not DI. So injecting something like a logger as a dependency to a UI control is not easy. Therefore taking away the only
 * acceptable solution for singletons this far.
 * 
 * Singletons are very very frustrating when it comes to Unity because with large scale projects, you end up in singleton hell. 
 * Where all these managers depend on each other and now to test a single prefab for a new feature, your test scene needs every game manager
 * in the whole game to execute. Which depending on the architecture of the game; can be quite the pain.
*/

/// <summary>
/// 
/// </summary>
public class SingletonPattern
{
    /// <summary>
    /// The static reference. I use Instance or Shared.
    /// </summary>
    public static SingletonPattern Instance;

    /// <summary>
    /// Static constructor
    /// </summary>
    static SingletonPattern()
    {
        Instance = new SingletonPattern();
    }

    public void Init(bool someConfiguration)
    {

    }
}

public class ABadWayToUseSingletons
{
    // I see people create init, setup, load, etc... all methods to "init" an object.
    public void Init()
    {
        // A hidden depenecy to the singleton.
        SingletonPattern.Instance.ToString();
    }
}

public class ABetterWayToUseSingletons
{
    private readonly SingletonPattern _singletonPattern;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="singletonPattern">A clear reliance on the singleton object.</param>
    public ABetterWayToUseSingletons(SingletonPattern singletonPattern)
    {
        _singletonPattern = singletonPattern;
    }

    public void Init()
    {
        _singletonPattern.ToString();
    }
}