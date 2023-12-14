using NMS.Leo.Metadata;

namespace NMS.Leo.Typed.Core.Correct.Token.ValueTokens
{
    internal class ValueStringEnumToken<TEnum> : ValueStringEnumToken
    {
        public ValueStringEnumToken(LeoMember member, bool caseSensitive) : base(member, typeof(TEnum), caseSensitive) { }
    }
}