using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.ResponseObjects
{
    internal class ApiResponseObject<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }

        [JsonProperty("pagination")]
        public ApiResponsePagination Pagination { get; set; }
    }
}