using NMS.Leo.Typed.Core.Correct.Conditions;

namespace NMS.Leo.Typed.Core.Correct.Token
{
    internal interface IConditionToken : IToken
    {
        ConditionOps Ops { get; }
    }
}