#import "BFGameIOSUtil.h"
#import "SAMKeychain/SAMKeychain.h"
#import "BFGameCommon.h"

extern "C" {

    const char * getBundleVersion() {
        NSDictionary *infoDictionary = [[NSBundle mainBundle] infoDictionary];
        NSString *version = [infoDictionary objectForKey:@"CFBundleShortVersionString"];
        return makeStringCopy([version UTF8String]);
    }

    void setAccessibilityType(int abType){
        switch(abType) {
            case 1:
                [SAMKeychain setAccessibilityType:kSecAttrAccessibleWhenUnlocked];
                break;
            case 2:
                [SAMKeychain setAccessibilityType:kSecAttrAccessibleAfterFirstUnlock];
                break;
            case 3:
                [SAMKeychain setAccessibilityType:kSecAttrAccessibleWhenPasscodeSetThisDeviceOnly];
                break;
            case 4:
                [SAMKeychain setAccessibilityType:kSecAttrAccessibleWhenUnlockedThisDeviceOnly];
                break;
            case 5:
                [SAMKeychain setAccessibilityType:kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly];
                break;
            default:
                break;
        }
    }

    const char* getKeyChainData(const char* service, const char* account) {
        NSString *sStr = [[NSString alloc] initWithUTF8String:service];
        NSString *aStr = [[NSString alloc] initWithUTF8String:account];
        NSString *data = [SAMKeychain passwordForService:sStr account:aStr];
        if(data == NULL) {
            return NULL;
        }
        
        return makeStringCopy([data UTF8String]);
    }

    bool setKeyChainData(const char* service, const char* account, const char* content) {
        NSString *sStr = [[NSString alloc] initWithUTF8String:service];
        NSString *aStr = [[NSString alloc] initWithUTF8String:account];
        NSString *cStr = [[NSString alloc] initWithUTF8String:content];
        return [SAMKeychain setPassword:cStr forService:sStr account:aStr];
    }

    bool deleteKeyChainData(const char* service, const char* account) {
        NSString *sStr = [[NSString alloc] initWithUTF8String:service];
        NSString *aStr = [[NSString alloc] initWithUTF8String:account];
        return [SAMKeychain deletePasswordForService:sStr account:aStr];
    }
}

