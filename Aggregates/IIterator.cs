namespace Assi1.Aggregates
{
    //Interface for HeavyObjectIterator
    public interface IIterator<out HeavyObject>
    {
        HeavyObject First();
        void Next();
        bool IsDone();
        HeavyObject CurrentItem();
    }
}