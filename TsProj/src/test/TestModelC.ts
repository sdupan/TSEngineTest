@UTGGameDataModel(2)
export class TestModelC extends UTGBaseModel {

    public static init(): void {
        super.init();
        console.log("TestModelC init...");
    }

    public static clear(): void {
        console.log("TestModelC clear...");
    }
}