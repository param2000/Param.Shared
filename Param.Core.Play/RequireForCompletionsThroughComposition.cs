using System;

namespace Param.Shared.Core.Play
{
    public class RequireForCompletionsThroughComposition
    {
        private readonly RequiredFor<RequiredForCompletnessBase> _requiredFor;

        public RequireForCompletionsThroughComposition(RequiredFor<RequiredForCompletnessBase> requiredFor)
        {
            if (requiredFor == null) throw new ArgumentNullException("requiredFor");
            _requiredFor = requiredFor;
            
        }
        public int MinValue { get { return int.MinValue; }}
        public int MaxValue { get { return _requiredFor.All.Count; } }
        public int CurrentValue { get { return _requiredFor.Failed.Count; } }
    }
}
