using System.Runtime.InteropServices;

namespace UnityTSGame
{
    public class IAPIOSImpl
    {
#if UNITY_IOS
        [DllImport("__Internal")]
        private static extern int iap_init(string key);

        [DllImport("__Internal")]
        private static extern int iap_requestProduct(string productId);

        [DllImport("__Internal")]
        private static extern int iap_buyProduct(string productId, string ext0, string ext1);

        [DllImport("__Internal")]
        private static extern int iap_queryOrders();

        [DllImport("__Internal")]
        private static extern int iap_confirmOrder(string token);
#endif

        public static int IAP_Init(string key)
        {
#if UNITY_IOS
            return iap_init(key);
#else
            return -1;
#endif
        }

        public static int IAP_RequestProduct(string productId)
        {
#if UNITY_IOS
            return iap_requestProduct(productId);
#else
            return -1;
#endif
        }

        public static int IAP_BuyProduct(string productId, string ext0, string ext1)
        {
#if UNITY_IOS
            return iap_buyProduct(productId, ext0, ext1);
#else
            return -1;
#endif
        }

        public static int IAP_QueryOrders()
        {
#if UNITY_IOS
            return iap_queryOrders();
#else
            return -1;
#endif
        }

        public static int IAP_ConfirmOrder(string token)
        {
#if UNITY_IOS
            return iap_confirmOrder(token);
#else
            return -1;
#endif
        }
    }
}