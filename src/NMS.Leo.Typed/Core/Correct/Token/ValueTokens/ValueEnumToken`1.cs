using NMS.Leo.Metadata;

namespace NMS.Leo.Typed.Core.Correct.Token.ValueTokens
{
    internal class ValueEnumToken<TEnum> : ValueEnumToken
    {
        public ValueEnumToken(LeoMember member) : base(member, typeof(TEnum)) { }
    }
}