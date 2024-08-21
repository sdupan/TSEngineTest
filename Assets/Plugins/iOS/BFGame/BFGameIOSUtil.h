extern "C" const char* getBundleVersion();

extern "C" void setAccessibilityType(int abType);

extern "C" const char* getKeyChainData(const char* service, const char* account);

extern "C" bool setKeyChainData(const char* service, const char* account, const char* content);

extern "C" bool deleteKeyChainData(const char* service, const char* account);

@interface BFGameIOSUtil : NSObject
@end