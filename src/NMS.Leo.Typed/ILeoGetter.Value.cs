namespace NMS.Leo.Typed
{
    public interface ILeoValueGetter
    {
        object Value { get; }

        object HostedInstance { get; }
    }

    public interface ILeoValueGetter<out T>
    {
        object Value { get; }

        T HostedInstance { get; }
    }

    public interface ILeoValueGetter<out T, out TVal>
    {
        TVal Value { get; }

        T HostedInstance { get; }
    }
}