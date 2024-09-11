namespace Beancounter.Datastructures;

public class LazyAsync<T>
{
    private readonly Lazy<Task<T>> lazyTask;

    public LazyAsync(Func<Task<T>> taskFactory)
    {
        lazyTask = new Lazy<Task<T>>(() => Task.Run(taskFactory));
    }
    public Task<T> Value => lazyTask.Value;
}