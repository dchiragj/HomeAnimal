using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace CommandResults
{
    public class BaseResult
    {
        public static bool IsInDebuggingMode { get; set; }
        public bool IsSuccess
         => (ResponseStatusCode == HttpStatusCode.OK || ResponseStatusCode == HttpStatusCode.Created || ResponseStatusCode == HttpStatusCode.Accepted);

        public string Message { get; set; }

        public IList<string> Errors { get; set; }

        [JsonIgnore]
        public HttpStatusCode ResponseStatusCode { get; set; } = HttpStatusCode.OK;

        public void AddExceptionLog(Exception ex)
        {
            if (ResponseStatusCode == HttpStatusCode.OK)
                ResponseStatusCode = HttpStatusCode.BadRequest;

            // It is really bad idea to show exceptions in production.
            if (!IsInDebuggingMode) return;

            if (Errors == null) // Initialize if needed
                Errors = new List<string>();

            Errors.Add(ex.Message);
            if (ex.InnerException != null)
                AddExceptionLog(ex.InnerException);
        }
    }
}
