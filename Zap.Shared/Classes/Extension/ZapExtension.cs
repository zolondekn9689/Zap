using System;
using Zap.Shared.Models;

namespace Zap.Shared.Extension
{
    internal static class ZapExtension
    {
        internal static ZapResults Interpret(this List<Task> tasks)
        {
            var results = new ZapResults();

            foreach (var t in tasks)
            {
                var r = ((Task<ZapResults>) t).Result;

                results.ResponseTimes.AddRange(r.ResponseTimes);
                results.Messages.AddRange(r.Messages);
               
                return r;
            }

            return results;
        }


    }
}

