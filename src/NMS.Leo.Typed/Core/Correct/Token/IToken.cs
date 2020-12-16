namespace NMS.Leo.Typed.Core.Correct.Token
{
    internal interface IToken
    {
        string TokenName { get; }

        TokenClass TokenClass { get; }
    }
}