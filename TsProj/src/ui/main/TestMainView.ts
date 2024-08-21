export class TestMainView extends UTGEngine.BaseView {

    protected _edit: CS.FairyGUI.GTextInput;

    constructor() {
        super("Base", "Main");
    }

    protected _onUILoaded(): void {
        super._onUILoaded();
        CS.FairyGUI.GRoot.inst.AddChild(this._view);

        this._edit = this._view.GetChild("edit").asTextInput;
        this._edit.editable = false;

        let btn = this._view.GetChild("get").asButton;
        btn.onClick.Set(this._onClickGet.bind(this));

        btn = this._view.GetChild("del").asButton;
        btn.onClick.Set(this._onClickDelete.bind(this));

        btn = this._view.GetChild("set").asButton;
        btn.onClick.Set(this._onClickSet.bind(this));
    }

    protected _onClickGet(): void {
        let result = CS.UnityTSGame.BFGameOSUtil.GetKeyChainContent("__test__key__");
        this._edit.text += "GetKeyChainContent-->:" + result + "\n";
    }

    protected _onClickDelete(): void {
        let result = CS.UnityTSGame.BFGameOSUtil.deleteKeyChainContent("__test__key__");
        this._edit.text += "DeleteKeyChainContent-->:" + result + "\n";
    }

    protected _onClickSet(): void {
        let result = CS.UnityTSGame.BFGameOSUtil.SetKeyChainContent("__test__key__", "elcfebdkwroonzbksocopapibqdiobuw");
        this._edit.text += "SetKeyChainContent-->:" + result + "\n";
    }
}