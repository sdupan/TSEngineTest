import "unity_ts_engine";

import { $promise } from "puerts";
import { TestMainView } from "./ui/main/TestMainView";

class GameEntry extends UTGEngine.GameMain {

    constructor() {
        super();
    }

    protected async _onUTGEngineInited() {
        
    }

    protected async _onSDKinit() {
        
    }

    protected _onGameStart() {
        this._startup();
    }

    protected async _startup() {
        await $promise(CS.UnityTSGame.ResourceManager.PreloadGUIPkgBytes("fairygui"));
        await $promise(CS.UnityTSGame.ResourceManager.PreloadPublicUITextures("public_ui"));

        new TestMainView();
    }
}

// 游戏入口
new GameEntry();