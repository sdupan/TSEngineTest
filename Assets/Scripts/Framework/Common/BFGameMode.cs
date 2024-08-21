namespace UnityTSGame
{
    public enum BF_GAME_MODE
    {
        // 开发模式（不带SDK）
        DEVELOP_MODE_NO_SDK = 0,
        // 开发模式
        DEVELOP_MODE = 1,
        // 线上测试模式
        ONLINE_TEST_MODE = 2,
        // 正式环境
        RELEASE_MODE = 3
    }

    public class BFGameMode
    {
        public static BF_GAME_MODE GAME_MODE = BF_GAME_MODE.DEVELOP_MODE;

        public static void Init()
        {
            #if BFGAME_DEVELOP_NO_SDK_MODE
                BFGameMode.GAME_MODE = BF_GAME_MODE.DEVELOP_MODE_NO_SDK;
            #endif

            #if BFGAME_ONLINE_TEST_MODE
                BFGameMode.GAME_MODE = BF_GAME_MODE.ONLINE_TEST_MODE;
            #endif

            #if BFGAME_RELEASE_MODE
                BFGameMode.GAME_MODE = BF_GAME_MODE.RELEASE_MODE;
            #endif

            UnityEngine.Debug.Log("[Engine] - BFGameMode " + BFGameMode.GAME_MODE);
        }
    }
}