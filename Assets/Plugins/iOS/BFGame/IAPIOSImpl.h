#import <Foundation/Foundation.h>

extern "C" int iap_init();

extern "C" int iap_requestProduct(const char* productId);

extern "C" int iap_buyProduct(const char* productId, const char* ext0, const char* ext1);

extern "C" int iap_queryOrders();

extern "C" int iap_confirmOrder(const char* token);

NS_ASSUME_NONNULL_BEGIN

@interface IAPIOSImpl : NSObject

+ (IAPIOSImpl *)sharedInstance;

// 校验该设备是否可以支付
+ (BOOL)canMakePayments;

// 通过产品id获取产品信息
// - Parameter productsId: 产品id
// - Parameter success: success
// - Parameter fail: fail
- (int)requestProductsId:(NSString *)productsId;

- (int)buyProduct:(NSString *)productId ext0:(NSString *)ext0 ext1:(NSString *)ext1;

- (int)restoreOrders;

- (int)confirmOrder:(NSString *)token;

@end

NS_ASSUME_NONNULL_END