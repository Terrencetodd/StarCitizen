using System;
using System.Net.Http;

namespace NSW.StarCitizen.Tools.Update
{
    public class GitHubRequestLimitExceedException : HttpRequestException
    {
        public DateTime ResetLimitTime { get; }

        public GitHubRequestLimitExceedException(string message, DateTime resetLimitTime)
            : base(message)
        {
            ResetLimitTime = resetLimitTime;
        }
    }
}
