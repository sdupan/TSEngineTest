#import "BFGameCommon.h"

char* makeStringCopy(const char* str) {
    if (str == NULL)
        return "";

    size_t len = strlen(str) + 1;
    char* res = (char*)malloc(len);
    memset(res, 0, len);
    strcpy(res, str);
    return res;
}