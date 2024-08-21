using System;

public class IAPManager
{
    public static Action<string> ReceiveProductCallback;
    public static Action<string> ProductBuyCallback;
    public static Action<string> QueryPurchasesCallback;
    public static Action<string> ConsumeCallback;
    public static Action<string> IAPError;
}