namespace CSharpLearn.Architecture;

// I usually use the MSFT ILogger
interface ILogger
{
    void Log(string message);
}
struct MyData
{
    public int Id;
    public string Name;
    public string Description;

    public override string ToString()
    {
        return $"{Id}-{Name}-{Description}";
    }
}

// I also do interface abstraction for things like this.
interface IDataCache
{
    void Add(MyData data);
    void Clear();
    MyData Get(int id);
    void Remove(MyData data);
    void Update(MyData data);
}

/// <summary>
/// A class showing an example simple implemenation of a data cache
/// </summary>
internal class MyDataCache : IDataCache
{
    private readonly Dictionary<int, MyData> _dataCache;
    private readonly ILogger _logger;

    public MyDataCache(ILogger logger)
    {
        _dataCache = new Dictionary<int, MyData>();
        _logger = logger;
    }

    public void Add(MyData data)
    {
        if (_dataCache.ContainsKey(data.Id) == false)
        {
            _dataCache.Add(data.Id, data);
            _logger.Log($"Added Data: {data}");
        }
    }

    public void Clear()
    {
        _dataCache.Clear();
    }

    public MyData Get(int id)
    {
        _dataCache.TryGetValue(id, out var data);

        if (data.Id == 0)
            throw new ArgumentException($"The id {id} does not exist in the cache.");

        return data;
    }

    public void Remove(MyData data)
    {
        if (_dataCache.ContainsKey(data.Id) == true)
        {
            _dataCache.Remove(data.Id);
            _logger.Log($"Removed Data: {data}");
        }
    }

    public void Update(MyData data)
    {
        if (_dataCache.ContainsKey(data.Id) == true)
        {
            _dataCache[data.Id] = data;
            _logger.Log($"Updated Data: {data}");
        }
        else
        {
            Add(data);
            _logger.Log($"Update was called when record does not exist. Added Data: {data}");
        }
    }
}

/*
 * What is a data cache?
 * I have needed to store configuraitons of things in memory in key/value style alot.
 * The solution you use is entirely dependend on your needs.
 * 
 * For simple solutions where you just need to keep a few thousand records or less in memory. And its access is single threaded. A solution like this works.
 * For multi threaded solutions, you could implement a concurrent dictionary. However.....
 * 
 * In my opinion. If you are to the point of needed multi threaded solutions; something like Redis might be better.
 * Say I am building an ASP.Net API where each controller needs to interact with some configuraiton data to decide how the API call should act.
 * And I need it to be fast. Real fast. So I want it in memory. But each controller is async and will fight each other for access to data cache.
 * Redis is an awesome in memory DB that can scale up alot better than a custom concurrent dictionary solution. https://redis.io/
 * 
 * Important components of a data cache?
 * - Have an interface that represents the data cache.
 * - Always have logging.
 * - Always use a dictionary or similar hashed solution.
 * - Typically dont try catch in the cache. Let what is calling the code handle exceptions.
 * 
 * Where to house the cache?
 * Inject it as a singleton with .net generic host. for example: services.AddSingleton<IDataCache, MyDataCache>();
 * Then you can DI the cache into whatever object you need to.
 * 
 * If that cannot be done; then throw it in a static class, singleton, or whatever. Because caches are typically accessed across many parts of 
 * the program. Just dont program the data cache to be inherently a singleton or static. Let the app using the cache decide how it needs to be housed.
*/