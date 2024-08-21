namespace UnityTSGame
{
    public class NetworkUtils
    {
        public static bool CheckNetworkAvailable()
        {
            UnityEngine.Debug.Log("[NetworkUtils] - Network state-->" + UnityEngine.Application.internetReachability.ToString());
            return UnityEngine.Application.internetReachability != UnityEngine.NetworkReachability.NotReachable;
        }
    }
}