namespace Assi1.Aggregates
{
    public interface IIterator<out HeavyObject>
    {
        HeavyObject First();
        void Next();
        bool IsDone();
        HeavyObject CurrentItem();
    }
}