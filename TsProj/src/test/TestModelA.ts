@UTGGameDataModel(3)
export class TestModelA extends UTGBaseModel {

    public static init(): void {
        super.init();
        console.log("TestModelA init...");
    }

    public static clear(): void {
        console.log("TestModelA clear...");
    }
}