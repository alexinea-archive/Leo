namespace NMS.Leo.Typed
{
    public interface ILeoValueSetter
    {
        void Value(object value);

        object HostedInstance { get; }
    }

    public interface ILeoValueSetter<out T>
    {
        void Value(object value);

        T HostedInstance { get; }
    }

    public interface ILeoValueSetter<out T, in TVal>
    {
        void Value(TVal value);

        T HostedInstance { get; }
    }
}