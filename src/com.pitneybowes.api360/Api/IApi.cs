using System.Net.Http;

namespace com.pitneybowes.api360.Api
{
    /// <summary>
    /// Any Api client
    /// </summary>
    public interface IApi
    {
        /// <summary>
        /// The HttpClient
        /// </summary>
        HttpClient HttpClient { get; }
    }
}