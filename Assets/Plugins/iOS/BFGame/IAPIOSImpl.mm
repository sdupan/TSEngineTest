#import "IAPIOSImpl.h"
#import "BFGameCommon.h"
#import <StoreKit/StoreKit.h>
#include "UnityInterface.h"

void sendMessage2Unity(const char* name, NSString* msg) {
    UnitySendMessage("GameEntry", name, makeStringCopy([msg UTF8String]));
}

void sendReceiveProductCallback(NSString* msg) {
    sendMessage2Unity("ReceiveProductCallback", msg);
}

void sendProductBuyCallback(NSString* msg) {
    sendMessage2Unity("ProductBuyCallback", msg);
}

void sendQueryPurchasesCallback(NSString* msg) {
    sendMessage2Unity("QueryPurchasesCallback", msg);
}

void sendConsumeCallback(NSString* msg) {
    sendMessage2Unity("ConsumeCallback", msg);
}

void sendIAPError(NSString* msg) {
    sendMessage2Unity("IAPError", msg);
}

@interface IAPIOSImpl()<SKProductsRequestDelegate, SKRequestDelegate, SKPaymentTransactionObserver>
@property (nonatomic, copy) NSString *productsId;
@property (nonatomic, copy) SKMutablePayment *skProductInfo;
@property (nonatomic, strong, nonnull) NSMutableDictionary *orderDict;
@property BOOL isRestore;
@end

@implementation IAPIOSImpl

static IAPIOSImpl *sharedManager = nil;
static dispatch_once_t onceToken;
+ (IAPIOSImpl *)sharedInstance {
    dispatch_once(&onceToken, ^{
        sharedManager = [[[self class] alloc] init];
    });
    return sharedManager;
}

// 初始化
- (instancetype)init {
    if (self = [super init]) {
        [[SKPaymentQueue defaultQueue] addTransactionObserver:self];
    }
    
    self.isRestore = false;
    self.orderDict = [[NSMutableDictionary alloc] init];
    return self;
}

// 销毁
- (void)dealloc {
    onceToken = 0;
    [[SKPaymentQueue defaultQueue] removeTransactionObserver:self];
    NSLog(@"[IAPIOSImpl] - dealloc: %s", __func__);
    sharedManager = nil;
}

// 校验该设备是否可以支付
+ (BOOL)canMakePayments {
    return [SKPaymentQueue canMakePayments];
}

// 通过产品id获取产品信息
- (int)requestProductsId:(NSString *)productsId {
    self.productsId = productsId;
    if (![SKPaymentQueue canMakePayments]) {
        sendIAPError(@"[IAPIOSImpl] - requestProductsId: IAP is not supported at this device");
        return -1;
    }

    NSLog(@"[IAPIOSImpl] - requestProductsId: canMakePayments");
    NSSet *identifiers = [NSSet setWithObjects:productsId, nil];
    SKProductsRequest *productsRequest = [[SKProductsRequest alloc] initWithProductIdentifiers:identifiers];
    productsRequest.delegate = self;
    [productsRequest start];
    return 0;
}

- (int)buyProduct:(NSString *)productId ext0:(NSString *)ext0 ext1:(NSString *)ext1 {
    if(self.skProductInfo != nil) {
        self.productsId = productId;
        [[SKPaymentQueue defaultQueue] addPayment:self.skProductInfo];
        return 0;
    }
    else {
        NSLog(@"[IAPIOSImpl] - buyProduct: product not found: %@", productId);
        return -2;
    }
}

- (int)restoreOrders {
    self.isRestore = true;
    NSLog(@"[IAPIOSImpl] - restoreOrders begin");
    [[SKPaymentQueue defaultQueue] restoreCompletedTransactions];
    return 0;
}

- (int)confirmOrder:(NSString *)token {
    NSLog(@"[IAPIOSImpl] - confirmOrder: %@", token);
    SKPaymentTransaction *transaction = [self.orderDict objectForKey:token];
    if(transaction) {
        [[SKPaymentQueue defaultQueue] finishTransaction:transaction];
        NSString *pKey = transaction.transactionIdentifier;
        [self.orderDict removeObjectForKey:pKey];
    }
    return 0;
}

#pragma mark - SKProductsRequestDelegate
/// 获取商品信息代理回调
- (void)productsRequest:(SKProductsRequest *)request didReceiveResponse:(SKProductsResponse *)response {
    NSLog(@"[IAPIOSImpl] - productsRequest: products request received response");
    NSArray *products = [NSArray arrayWithArray:response.products];
    NSArray *invalidProductIdentifiers = [NSArray arrayWithArray:response.invalidProductIdentifiers];
    
    /// 获取可购买产品id
    self.skProductInfo = nil;
    if (products.count > 0) {
        for (SKProduct *product in products) {
            NSLog(@"[IAPIOSImpl] - productsRequest - didReceiveResponse: purchasable product id: %@", product.productIdentifier);
            //[self addPayment:product];
            if(self.productsId != nil && [self.productsId isEqualToString:product.productIdentifier]) {
                self.skProductInfo = [SKMutablePayment paymentWithProduct:product];
            }
        }
    }
    else {
        /// 获取不到产品则手动添加产品到购买队列（确保苹果后台已配置相应产品id）
        self.skProductInfo = [[SKMutablePayment alloc] init];
        self.skProductInfo.productIdentifier = self.productsId;
        self.skProductInfo.quantity = 1;
    }

    NSMutableDictionary *mulDic = [[NSMutableDictionary alloc] init];
    if(self.skProductInfo != nil) {
        [mulDic setValue:[NSNumber numberWithInt:1] forKey:@"type"];
        [mulDic setValue:self.productsId forKey:@"productId"];
        [mulDic setValue:[NSNumber numberWithInteger:self.skProductInfo.quantity] forKey:@"quantity"];
        [mulDic setValue:[NSNumber numberWithBool:self.skProductInfo.simulatesAskToBuyInSandbox] forKey:@"simulatesAskToBuyInSandbox"];
        if(self.skProductInfo.applicationUsername != nil) {
            [mulDic setValue:self.skProductInfo.applicationUsername forKey:@"applicationUsername"];
        }
        if(self.skProductInfo.requestData != nil) {
            [mulDic setValue:[[NSString alloc] initWithData:self.skProductInfo.requestData encoding:NSUTF8StringEncoding] forKey:@"requestData"];
        }
    }
    else {
        [mulDic setValue:0 forKey:@"type"];
    }

    NSData *jsonData = [NSJSONSerialization dataWithJSONObject:mulDic options:kNilOptions error:nil];
    sendReceiveProductCallback([[NSString alloc] initWithData:jsonData encoding:NSUTF8StringEncoding]);

    /// 无效的产品id
    [invalidProductIdentifiers enumerateObjectsUsingBlock:^(NSString *invalid, NSUInteger idx, BOOL *stop) {
        NSLog(@"[IAPIOSImpl] - productsRequest - didReceiveResponse: invalid product id: %@", invalid);
    }];
}

#pragma mark - SKRequestDelegate
- (void)requestDidFinish:(SKRequest *)request {
    NSLog(@"[IAPIOSImpl] - requestDidFinish: %s", __func__);
}

- (void)request:(SKRequest *)request didFailWithError:(NSError *)error {
    NSLog(@"[IAPIOSImpl] - didFailWithError: %s error userInfos: %@", __func__, error.userInfo);
    sendIAPError([NSString stringWithFormat:@"[IAPIOSImpl] - didFailWithError - %@", error.localizedDescription]);
}

#pragma mark - SKPaymentTransactionObserver
- (void)paymentQueue:(SKPaymentQueue *)queue updatedTransactions:(NSArray *)transactions {
    for (SKPaymentTransaction *transaction in transactions) {
        switch (transaction.transactionState) {
            case SKPaymentTransactionStatePurchased: { /// 交易成功
                NSLog(@"[IAPIOSImpl] - updatedTransactions:【IAP Result】======= SUCCESS    %ld", transaction.transactionState);
                [self transactionSucceed:transaction];
            }
                break;
            case SKPaymentTransactionStateFailed: { /// 交易失败
                NSLog(@"[IAPIOSImpl] - updatedTransactions:【IAP Result】======= FAIL    %ld", transaction.transactionState);
                [self transactionFailed:transaction];
            }
                break;
            case SKPaymentTransactionStatePurchasing: { /// 商品添加进列表
                NSLog(@"[IAPIOSImpl] - updatedTransactions:【IAP Result】======= Add product to list    %ld", transaction.transactionState);
            }
                break;
            case SKPaymentTransactionStateRestored: { /// 已购买过该商品
                NSLog(@"[IAPIOSImpl] - updatedTransactions:【IAP Result】======= Product has been buyed    %ld", transaction.transactionState);
                [self transactionFailed:transaction];
            }
                break;
            case SKPaymentTransactionStateDeferred: { /// 交易延迟
                NSLog(@"[IAPIOSImpl] - updatedTransactions:【IAP Result】======= Transaction Delayed    %ld", transaction.transactionState);
                [self transactionFailed:transaction];
            }
                break;
            default: {
                [self transactionFailed:transaction];
            }
                break;
        }
    }
}

// Sent when transactions are removed from the queue (via finishTransaction:).
- (void)paymentQueue:(SKPaymentQueue *)queue removedTransactions:(NSArray<SKPaymentTransaction *> *)transactions {
    NSLog(@"[IAPIOSImpl] - removedTransactions");
    NSMutableDictionary *mulDic = [[NSMutableDictionary alloc] init];
    [mulDic setValue:[NSNumber numberWithInt:1] forKey:@"type"];
    if(transactions) {
        NSMutableArray *mulArr = [[NSMutableArray alloc] init];
        for (SKPaymentTransaction *transaction in transactions) {
            NSLog(@"[IAPIOSImpl] - removedTransactions---> %@", transaction.transactionIdentifier);
            if(transaction.transactionIdentifier) {
                NSMutableDictionary *dict = [[NSMutableDictionary alloc] init];
                [dict setValue:transaction.transactionIdentifier forKey:@"transactionIdentifier"];
                NSData *dictData = [NSJSONSerialization dataWithJSONObject:dict options:kNilOptions error:nil];
                [mulArr addObject:[[NSString alloc] initWithData:dictData encoding:NSUTF8StringEncoding]];
                
                [self.orderDict removeObjectForKey:transaction.transactionIdentifier];
            }
        }

        [mulDic setValue:mulArr forKey:@"productInfo"];
    }
    
    NSData *jsonData = [NSJSONSerialization dataWithJSONObject:mulDic options:kNilOptions error:nil];
    sendConsumeCallback([[NSString alloc] initWithData:jsonData encoding:NSUTF8StringEncoding]);
}

/// 交易结束-成功
- (void)transactionSucceed:(SKPaymentTransaction *)transaction {
    // 监听购买结果，当失败和成功时代码中要调用如下代码:
    // 该方法通知苹果支付队列该交易已完成，不然就会已发起相同 ID 的商品购买就会有此项目将免费恢复的提示。
    // 等待发奖后再确认完成订单
    // [[SKPaymentQueue defaultQueue] finishTransaction:transaction];
    
    NSMutableDictionary *mulDic = [[NSMutableDictionary alloc] init];
    [mulDic setValue:transaction.transactionIdentifier forKey:@"transactionIdentifier"];
    [mulDic setValue:[NSNumber numberWithInt:1] forKey:@"type"];
    if(transaction.payment != nil) {
        if(transaction.payment.productIdentifier) {
            [mulDic setValue:transaction.payment.productIdentifier forKey:@"productId"];
        }
        if(transaction.payment.applicationUsername) {
            [mulDic setValue:transaction.payment.applicationUsername forKey:@"applicationUsername"];
        }
        
        [mulDic setValue:[NSNumber numberWithInteger:transaction.payment.quantity] forKey:@"quantity"];
        [mulDic setValue:[NSNumber numberWithBool:transaction.payment.simulatesAskToBuyInSandbox] forKey:@"simulatesAskToBuyInSandbox"];
    }
    
    [self.orderDict setValue:transaction forKey:transaction.transactionIdentifier];

    NSData *jsonData = [NSJSONSerialization dataWithJSONObject:mulDic options:kNilOptions error:nil];
    sendProductBuyCallback([[NSString alloc] initWithData:jsonData encoding:NSUTF8StringEncoding]);
}

/// 交易失败
- (void)transactionFailed:(SKPaymentTransaction *)transaction {
    NSMutableDictionary *mulDic = [[NSMutableDictionary alloc] init];
    [mulDic setValue:transaction.transactionIdentifier forKey:@"transactionIdentifier"];
    [mulDic setValue:transaction.error.localizedDescription forKey:@"localizedDescription"];
    [mulDic setValue:[NSNumber numberWithLong:transaction.error.code] forKey:@"code"];
    if(transaction.payment != nil) {
        if(transaction.payment.productIdentifier) {
            [mulDic setValue:transaction.payment.productIdentifier forKey:@"productId"];
        }
        if(transaction.payment.applicationUsername) {
            [mulDic setValue:transaction.payment.applicationUsername forKey:@"applicationUsername"];
        }
        
        [mulDic setValue:[NSNumber numberWithInteger:transaction.payment.quantity] forKey:@"quantity"];
        [mulDic setValue:[NSNumber numberWithBool:transaction.payment.simulatesAskToBuyInSandbox] forKey:@"simulatesAskToBuyInSandbox"];
    }
    
    if (transaction.error.code == SKErrorPaymentCancelled){
        NSLog(@"[IAPIOSImpl] - transactionFailed: IAP has been canceled");
        [mulDic setValue:[NSNumber numberWithInt:2] forKey:@"type"];
    }
    else {
        [mulDic setValue:[NSNumber numberWithInt:3] forKey:@"type"];
    }

    NSLog(@"[IAPIOSImpl] - transactionFailed: IAP Failed, transactionIdentifier: %@ code:%li msg:%@", transaction.transactionIdentifier, (long)transaction.error.code, transaction.error.localizedDescription);
    [[SKPaymentQueue defaultQueue] finishTransaction:transaction];

    NSData *jsonData = [NSJSONSerialization dataWithJSONObject:mulDic options:kNilOptions error:nil];
    sendProductBuyCallback([[NSString alloc] initWithData:jsonData encoding:NSUTF8StringEncoding]);
}

// Sent when an error is encountered while adding transactions from the user's purchase history back to the queue.
- (void)paymentQueue:(SKPaymentQueue *)queue restoreCompletedTransactionsFailedWithError:(NSError *)error {
    NSLog(@"[IAPIOSImpl] - restoreCompletedTransactionsFailedWithError");
    NSMutableDictionary *mulDic = [[NSMutableDictionary alloc] init];
    [mulDic setValue:[NSNumber numberWithInt:2] forKey:@"type"];
    if(error) {
        [mulDic setValue:error.localizedDescription forKey:@"error"];
    }
    
    NSData *jsonData = [NSJSONSerialization dataWithJSONObject:mulDic options:kNilOptions error:nil];
    sendQueryPurchasesCallback([[NSString alloc] initWithData:jsonData encoding:NSUTF8StringEncoding]);
}

// Sent when all transactions from the user's purchase history have successfully been added back to the queue.
- (void)paymentQueueRestoreCompletedTransactionsFinished:(SKPaymentQueue *)queue {
    NSLog(@"[IAPIOSImpl] - paymentQueueRestoreCompletedTransactionsFinished");
    NSArray<SKPaymentTransaction *>* transactions = queue.transactions;
    NSMutableDictionary *mulDic = [[NSMutableDictionary alloc] init];
    [mulDic setValue:[NSNumber numberWithInt:1] forKey:@"type"];
    if(transactions) {
        NSMutableArray *mulArr = [[NSMutableArray alloc] init];
        for (SKPaymentTransaction *transaction in transactions) {
            if(transaction.transactionState != SKPaymentTransactionStatePurchasing) {
                NSMutableDictionary *dict = [[NSMutableDictionary alloc] init];
                [dict setValue:transaction.transactionIdentifier forKey:@"transactionIdentifier"];
                [dict setValue:[NSNumber numberWithInteger:transaction.transactionState] forKey:@"transactionState"];
                if(transaction.error) {
                    [dict setValue:transaction.error.localizedDescription forKey:@"localizedDescription"];
                    [dict setValue:[NSNumber numberWithLong:transaction.error.code] forKey:@"code"];
                }
                if(transaction.transactionDate) {
                    NSDateFormatter *dateFormatter = [[NSDateFormatter alloc] init];
                    [dict setValue:[dateFormatter stringFromDate:transaction.transactionDate] forKey:@"transactionDate"];
                }
                NSData *dictData = [NSJSONSerialization dataWithJSONObject:dict options:kNilOptions error:nil];
                [mulArr addObject:[[NSString alloc] initWithData:dictData encoding:NSUTF8StringEncoding]];
                
                [self.orderDict setValue:transaction forKey:transaction.transactionIdentifier];
            }
        }

        [mulDic setValue:mulArr forKey:@"productInfo"];
    }
    
    NSData *jsonData = [NSJSONSerialization dataWithJSONObject:mulDic options:kNilOptions error:nil];
    sendQueryPurchasesCallback([[NSString alloc] initWithData:jsonData encoding:NSUTF8StringEncoding]);
    self.isRestore = false;
}

@end

extern "C" {

    int iap_init() {
        return [IAPIOSImpl canMakePayments] ? 0 : -1;
    }

    int iap_requestProduct(const char* productId) {
        NSString* str1 = [NSString stringWithCString:productId encoding:NSUTF8StringEncoding];
        return [[IAPIOSImpl sharedInstance] requestProductsId:str1];
    }

    int iap_buyProduct(const char* productId, const char* ext0, const char* ext1) {
        NSString* pid = [NSString stringWithCString:productId encoding:NSUTF8StringEncoding];
        NSString* str1 = [NSString stringWithCString:ext0 encoding:NSUTF8StringEncoding];
        NSString* str2 = [NSString stringWithCString:ext1 encoding:NSUTF8StringEncoding];
        return [[IAPIOSImpl sharedInstance] buyProduct:pid ext0:str1 ext1:str2];
    }

    int iap_queryOrders() {
        return [[IAPIOSImpl sharedInstance] restoreOrders];
    }

    int iap_confirmOrder(const char* token) {
        NSString* str1 = [NSString stringWithCString:token encoding:NSUTF8StringEncoding];
        return [[IAPIOSImpl sharedInstance] confirmOrder:str1];
    }
}
