using System;
using System.Net;
using System.Text;

namespace Zap.Shared.Models
{
    public class ZapResults
    {
        public List<double> ResponseTimes { get; } = new List<double>();

        public readonly List<HttpResponseMessage> Messages = new List<HttpResponseMessage>();


        public override string ToString()
        {
            var builder = new StringBuilder();

            if (ResponseTimes.Count != Messages.Count)
                return builder.Append("Unable to read to string because the " +
                    "ResponseTime and Messages field in ZapResults do not match count size").ToString();

            for (int index = 0; index < Messages.Count; index++)
            {
                builder.AppendLine($"");
            }

            return builder.ToString();

        }
    }
}

