﻿using System.Collections.Generic;
using NMS.Leo.Metadata;

namespace NMS.Leo.Typed.Core.Correct.Token.ValueTokens
{
    internal class ValueInToken : ValueToken
    {
        // ReSharper disable once InconsistentNaming
        public const string NAME = "ValueInToken";

        private readonly ICollection<object> _objects;

        public ValueInToken(LeoMember member, ICollection<object> objects) : base(member)
        {
            _objects = objects ?? System.Array.Empty<object>();
        }

        public override CorrectValueOps Ops => CorrectValueOps.In;

        public override string TokenName => NAME;

        public override bool MutuallyExclusive => false;

        public override int[] MutuallyExclusiveFlags => NoMutuallyExclusiveFlags;

        public override CorrectVerifyVal ValidValue(object value)
        {
            var val = new CorrectVerifyVal {NameOfExecutedRule = NAME};

            if (!_objects.Contains(value))
            {
                UpdateVal(val, value);
            }

            return val;
        }

        private void UpdateVal(CorrectVerifyVal val, object obj)
        {
            val.IsSuccess = false;
            val.VerifiedValue = obj;
            val.ErrorMessage = MergeMessage("The value is not contained in the given value array or collection.");
        }

        public override string ToString() => NAME;
    }
}