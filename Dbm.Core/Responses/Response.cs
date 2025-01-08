using System.Text.Json.Serialization;

namespace Dbm.Core.Responses
{
    public class Response<T>
    {
        public T? Data { get; set; }    
        public string Message { get; set; } = string.Empty;
        [JsonIgnore]
        public bool IsSuccess => _code is >= 200 and <= 299;

        private readonly int _code;

        [JsonConstructor]
        public Response() => _code = Configuration.DefaultStatusCode;
        public Response(T? data, string message, int code = Configuration.DefaultStatusCode)
        {
            Data = data;
            Message = message;
            _code = code;
        }
    }
}
