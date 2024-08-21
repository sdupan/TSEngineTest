@UTGGameDataModel(1)
export class TestModelB extends UTGBaseModel {

    public static init(): void {
        super.init();
        console.log("TestModelB init...");
    }

    public static clear(): void {
        console.log("TestModelB clear...");
    }
}