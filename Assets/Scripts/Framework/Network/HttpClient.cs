using System.Threading.Tasks;
using UnityEngine.Networking;

namespace UnityTSGame
{
    public class HttpClient
    {

        public static async Task<UnityWebRequest> Get(string url, int timeout = 10)
        {
            UnityWebRequest request = UnityWebRequest.Get(url);
            if(timeout > 0)
            {
                request.timeout = timeout;
            }

            request.SendWebRequest();
            while (!request.isDone)
            {
                await Task.Delay(50);
            }

            return request;
        }

        public static async Task<UnityWebRequest> Post(string url, string formdata, int timeout = 10, string contentType = "application/json")
        {
            UnityWebRequest post = UnityWebRequest.Post(url, formdata, contentType);
            if(timeout > 0)
            {
                post.timeout = timeout;
            }

            post.SendWebRequest();
            while (!post.isDone)
            {
                await Task.Delay(50);
            }

            return post;
        }

        public static async Task<string> Post2(string url, string formdata, int timeout = 10, string contentType = "application/json")
        {
            var post = await Post(url, formdata, timeout, contentType);

            if (post.result == UnityWebRequest.Result.ProtocolError || post.result == UnityWebRequest.Result.ConnectionError || post.responseCode != 200)
            {
                UnityEngine.Debug.Log("[HttpClient] - Post Error -->" + url + "  " + formdata + "  " + post.result.ToString() + "  " + post.responseCode);
                return null;
            }

            return post.downloadHandler.text;
        }
    }
}
