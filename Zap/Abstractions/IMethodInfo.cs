using System;
using Zap.Classes;

namespace Zap.Abstractions
{
    public interface IMethodInfo
    {
        public MethodTypes Method { get; set; }
        public string Url { get; set; }
    }
}

