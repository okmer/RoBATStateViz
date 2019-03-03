using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoBATStateViz.Helpers
{
    public static class TimeSpanExtensions
    {
        public static string ToPrettyString(this TimeSpan span)
        {

            if (span == TimeSpan.Zero) return "0 minutes";

            var sb = new StringBuilder();
            if (span.Days > 0) sb.AppendFormat($"{span.Days} day{(span.Days > 1 ? "s" : String.Empty)} ");
            if (span.Hours > 0) sb.AppendFormat($"{span.Hours} hour{(span.Hours > 1 ? "s" : String.Empty)} ");
            if (span.Minutes > 0) sb.AppendFormat($"{span.Minutes} minute{(span.Minutes > 1 ? "s" : String.Empty)} ");
            if (span.Seconds > 0) sb.AppendFormat($"{span.Seconds} second{(span.Seconds > 1 ? "s" : String.Empty)} ");
            return sb.ToString();
        }

        public static string ToCompactPrettyString(this TimeSpan span)
        {

            if (span == TimeSpan.Zero) return "0:0:0";

            var sb = new StringBuilder();
            if (span.Days > 0) sb.AppendFormat($"{span.Days} day{(span.Days > 1 ? "s" : String.Empty)} ");

            sb.AppendFormat($"{span.Hours.ToString("D2")}h:{span.Minutes.ToString("D2")}m:{span.Seconds.ToString("D2")}s");
            return sb.ToString();
        }
    }
}
