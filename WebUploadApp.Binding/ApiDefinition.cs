using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace WebUploadApp.Binding
{
    [Static]
   // [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const GCDWebServerRequestAttribute_RegexCaptures;
        [Field("GCDWebServerRequestAttribute_RegexCaptures", "__Internal")]
        NSString GCDWebServerRequestAttribute_RegexCaptures { get; }
        // extern NSString *const GCDWebServerOption_Port;
        [Field("GCDWebServerOption_Port", "__Internal")]
        NSString GCDWebServerOption_Port { get; }

        // extern NSString *const GCDWebServerOption_BonjourName;
        [Field("GCDWebServerOption_BonjourName", "__Internal")]
        NSString GCDWebServerOption_BonjourName { get; }

        // extern NSString *const GCDWebServerOption_BonjourType;
        [Field("GCDWebServerOption_BonjourType", "__Internal")]
        NSString GCDWebServerOption_BonjourType { get; }

        // extern NSString *const GCDWebServerOption_BindToLocalhost;
        [Field("GCDWebServerOption_BindToLocalhost", "__Internal")]
        NSString GCDWebServerOption_BindToLocalhost { get; }

        // extern NSString *const GCDWebServerOption_MaxPendingConnections;
        [Field("GCDWebServerOption_MaxPendingConnections", "__Internal")]
        NSString GCDWebServerOption_MaxPendingConnections { get; }

        // extern NSString *const GCDWebServerOption_ServerName;
        [Field("GCDWebServerOption_ServerName", "__Internal")]
        NSString GCDWebServerOption_ServerName { get; }

        // extern NSString *const GCDWebServerOption_AuthenticationMethod;
        [Field("GCDWebServerOption_AuthenticationMethod", "__Internal")]
        NSString GCDWebServerOption_AuthenticationMethod { get; }

        // extern NSString *const GCDWebServerOption_AuthenticationRealm;
        [Field("GCDWebServerOption_AuthenticationRealm", "__Internal")]
        NSString GCDWebServerOption_AuthenticationRealm { get; }

        // extern NSString *const GCDWebServerOption_AuthenticationAccounts;
        [Field("GCDWebServerOption_AuthenticationAccounts", "__Internal")]
        NSString GCDWebServerOption_AuthenticationAccounts { get; }

        // extern NSString *const GCDWebServerOption_ConnectionClass;
        [Field("GCDWebServerOption_ConnectionClass", "__Internal")]
        NSString GCDWebServerOption_ConnectionClass { get; }

        // extern NSString *const GCDWebServerOption_AutomaticallyMapHEADToGET;
        [Field("GCDWebServerOption_AutomaticallyMapHEADToGET", "__Internal")]
        NSString GCDWebServerOption_AutomaticallyMapHEADToGET { get; }

        // extern NSString *const GCDWebServerOption_ConnectedStateCoalescingInterval;
        [Field("GCDWebServerOption_ConnectedStateCoalescingInterval", "__Internal")]
        NSString GCDWebServerOption_ConnectedStateCoalescingInterval { get; }

        // extern NSString *const GCDWebServerOption_AutomaticallySuspendInBackground;
        [Field("GCDWebServerOption_AutomaticallySuspendInBackground", "__Internal")]
        NSString GCDWebServerOption_AutomaticallySuspendInBackground { get; }

        // extern NSString *const GCDWebServerAuthenticationMethod_Basic;
        [Field("GCDWebServerAuthenticationMethod_Basic", "__Internal")]
        NSString GCDWebServerAuthenticationMethod_Basic { get; }

        // extern NSString *const GCDWebServerAuthenticationMethod_DigestAccess;
        [Field("GCDWebServerAuthenticationMethod_DigestAccess", "__Internal")]
        NSString GCDWebServerAuthenticationMethod_DigestAccess { get; }
    }

    // @protocol GCDWebServerBodyWriter <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface GCDWebServerBodyWriter
    {
        // @required -(BOOL)open:(NSError **)error;
        [Abstract]
        [Export("open:")]
        bool Open(out NSError error);

        // @required -(BOOL)writeData:(NSData *)data error:(NSError **)error;
        [Abstract]
        [Export("writeData:error:")]
        bool WriteData(NSData data, out NSError error);

        // @required -(BOOL)close:(NSError **)error;
        [Abstract]
        [Export("close:")]
        bool Close(out NSError error);
    }

    // @interface GCDWebServerRequest : NSObject <GCDWebServerBodyWriter>
    [BaseType(typeof(NSObject))]
    interface GCDWebServerRequest : GCDWebServerBodyWriter
    {
        // @property (readonly, nonatomic) NSString * method;
        [Export("method")]
        string Method { get; }

        // @property (readonly, nonatomic) NSURL * URL;
        [Export("URL")]
        NSUrl URL { get; }

        // @property (readonly, nonatomic) NSDictionary * headers;
        [Export("headers")]
        NSDictionary Headers { get; }

        // @property (readonly, nonatomic) NSString * path;
        [Export("path")]
        string Path { get; }

        // @property (readonly, nonatomic) NSDictionary * query;
        [Export("query")]
        NSDictionary Query { get; }

        // @property (readonly, nonatomic) NSString * contentType;
        [Export("contentType")]
        string ContentType { get; }

        // @property (readonly, nonatomic) NSUInteger contentLength;
        [Export("contentLength")]
        nuint ContentLength { get; }

        // @property (readonly, nonatomic) NSDate * ifModifiedSince;
        [Export("ifModifiedSince")]
        NSDate IfModifiedSince { get; }

        // @property (readonly, nonatomic) NSString * ifNoneMatch;
        [Export("ifNoneMatch")]
        string IfNoneMatch { get; }

        // @property (readonly, nonatomic) NSRange byteRange;
        [Export("byteRange")]
        NSRange ByteRange { get; }

        // @property (readonly, nonatomic) BOOL acceptsGzipContentEncoding;
        [Export("acceptsGzipContentEncoding")]
        bool AcceptsGzipContentEncoding { get; }

        // -(instancetype)initWithMethod:(NSString *)method url:(NSURL *)url headers:(NSDictionary *)headers path:(NSString *)path query:(NSDictionary *)query;
        [Export("initWithMethod:url:headers:path:query:")]
        IntPtr Constructor(string method, NSUrl url, NSDictionary headers, string path, NSDictionary query);

        // -(BOOL)hasBody;
        [Export("hasBody")]
       // [Verify(MethodToProperty)]
        bool HasBody { get; }

        // -(BOOL)hasByteRange;
        [Export("hasByteRange")]
       // [Verify(MethodToProperty)]
        bool HasByteRange { get; }

        // -(id)attributeForKey:(NSString *)key;
        [Export("attributeForKey:")]
        NSObject AttributeForKey(string key);
    }

    // typedef void (^GCDWebServerBodyReaderCompletionBlock)(NSData *, NSError *);
    delegate void GCDWebServerBodyReaderCompletionBlock(NSData arg0, NSError arg1);

    // @protocol GCDWebServerBodyReader <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface GCDWebServerBodyReader
    {
        // @required -(BOOL)open:(NSError **)error;
        [Abstract]
        [Export("open:")]
        bool Open(out NSError error);

        // @required -(NSData *)readData:(NSError **)error;
        [Abstract]
        [Export("readData:")]
        NSData ReadData(out NSError error);

        // @required -(void)close;
        [Abstract]
        [Export("close")]
        void Close();

        // @optional -(void)asyncReadDataWithCompletion:(GCDWebServerBodyReaderCompletionBlock)block;
        [Export("asyncReadDataWithCompletion:")]
        void AsyncReadDataWithCompletion(GCDWebServerBodyReaderCompletionBlock block);
    }

    // @interface GCDWebServerResponse : NSObject <GCDWebServerBodyReader>
    [BaseType(typeof(NSObject))]
    interface GCDWebServerResponse : GCDWebServerBodyReader
    {
        // @property (copy, nonatomic) NSString * contentType;
        [Export("contentType")]
        string ContentType { get; set; }

        // @property (nonatomic) NSUInteger contentLength;
        [Export("contentLength")]
        nuint ContentLength { get; set; }

        // @property (nonatomic) NSInteger statusCode;
        [Export("statusCode")]
        nint StatusCode { get; set; }

        // @property (nonatomic) NSUInteger cacheControlMaxAge;
        [Export("cacheControlMaxAge")]
        nuint CacheControlMaxAge { get; set; }

        // @property (retain, nonatomic) NSDate * lastModifiedDate;
        [Export("lastModifiedDate", ArgumentSemantic.Retain)]
        NSDate LastModifiedDate { get; set; }

        // @property (copy, nonatomic) NSString * eTag;
        [Export("eTag")]
        string ETag { get; set; }

        // @property (getter = isGZipContentEncodingEnabled, nonatomic) BOOL gzipContentEncodingEnabled;
        [Export("gzipContentEncodingEnabled")]
        bool GzipContentEncodingEnabled { [Bind("isGZipContentEncodingEnabled")] get; set; }

        // +(instancetype)response;
        [Static]
        [Export("response")]
        GCDWebServerResponse Response();

        // -(void)setValue:(NSString *)value forAdditionalHeader:(NSString *)header;
        [Export("setValue:forAdditionalHeader:")]
        void SetValue(string value, string header);

        // -(BOOL)hasBody;
        [Export("hasBody")]
        //[Verify(MethodToProperty)]
        bool HasBody { get; }
    }

    // @interface Extensions (GCDWebServerResponse)
    [Category]
    [BaseType(typeof(GCDWebServerResponse))]
    interface GCDWebServerResponse_Extensions
    {
        // +(instancetype)responseWithStatusCode:(NSInteger)statusCode;
        [Static]
        [Export("responseWithStatusCode:")]
        GCDWebServerResponse ResponseWithStatusCode(nint statusCode);

        // +(instancetype)responseWithRedirect:(NSURL *)location permanent:(BOOL)permanent;
        [Static]
        [Export("responseWithRedirect:permanent:")]
        GCDWebServerResponse ResponseWithRedirect(NSUrl location, bool permanent);
        //[Static]
        // -(instancetype)initWithStatusCode:(NSInteger)statusCode;
        
        [Export("initWithStatusCode:")]
        IntPtr InitWithStatusCode(nint statusCode);
        //[Static]
        // -(instancetype)initWithRedirect:(NSURL *)location permanent:(BOOL)permanent;
        [Export("initWithRedirect:permanent:")]
        IntPtr InitWithRedirect(NSUrl location, bool permanent);
    }

    // typedef GCDWebServerRequest * (^GCDWebServerMatchBlock)(NSString *, NSURL *, NSDictionary *, NSString *, NSDictionary *);
    delegate GCDWebServerRequest GCDWebServerMatchBlock(string arg0, NSUrl arg1, NSDictionary arg2, string arg3, NSDictionary arg4);

    // typedef GCDWebServerResponse * (^GCDWebServerProcessBlock)(GCDWebServerRequest *);
    delegate GCDWebServerResponse GCDWebServerProcessBlock(GCDWebServerRequest arg0);

    // typedef void (^GCDWebServerCompletionBlock)(GCDWebServerResponse *);
    delegate void GCDWebServerCompletionBlock(GCDWebServerResponse arg0);

    // typedef void (^GCDWebServerAsyncProcessBlock)(GCDWebServerRequest *, GCDWebServerCompletionBlock);
    delegate void GCDWebServerAsyncProcessBlock(GCDWebServerRequest arg0, GCDWebServerCompletionBlock arg1);

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //}

    // @protocol GCDWebServerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface GCDWebServerDelegate
    {
        // @optional -(void)webServerDidStart:(GCDWebServer *)server;
        [Export("webServerDidStart:")]
        void WebServerDidStart(GCDWebServer server);

        // @optional -(void)webServerDidCompleteBonjourRegistration:(GCDWebServer *)server;
        [Export("webServerDidCompleteBonjourRegistration:")]
        void WebServerDidCompleteBonjourRegistration(GCDWebServer server);

        // @optional -(void)webServerDidConnect:(GCDWebServer *)server;
        [Export("webServerDidConnect:")]
        void WebServerDidConnect(GCDWebServer server);

        // @optional -(void)webServerDidDisconnect:(GCDWebServer *)server;
        [Export("webServerDidDisconnect:")]
        void WebServerDidDisconnect(GCDWebServer server);

        // @optional -(void)webServerDidStop:(GCDWebServer *)server;
        [Export("webServerDidStop:")]
        void WebServerDidStop(GCDWebServer server);
    }

    // @interface GCDWebServer : NSObject
    [BaseType(typeof(NSObject))]
    interface GCDWebServer
    {
        [Wrap("WeakDelegate")]
        GCDWebServerDelegate Delegate { get; set; }

        // @property (assign, nonatomic) id<GCDWebServerDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, getter = isRunning, nonatomic) BOOL running;
        [Export("running")]
        bool Running { [Bind("isRunning")] get; }

        // @property (readonly, nonatomic) NSUInteger port;
        [Export("port")]
        nuint Port { get; }

        // @property (readonly, nonatomic) NSString * bonjourName;
        [Export("bonjourName")]
        string BonjourName { get; }

        // @property (readonly, nonatomic) NSString * bonjourType;
        [Export("bonjourType")]
        string BonjourType { get; }

        // -(void)addHandlerWithMatchBlock:(GCDWebServerMatchBlock)matchBlock processBlock:(GCDWebServerProcessBlock)processBlock;
        [Export("addHandlerWithMatchBlock:processBlock:")]
        void AddHandlerWithMatchBlock(GCDWebServerMatchBlock matchBlock, GCDWebServerProcessBlock processBlock);

        // -(void)addHandlerWithMatchBlock:(GCDWebServerMatchBlock)matchBlock asyncProcessBlock:(GCDWebServerAsyncProcessBlock)processBlock;
        [Export("addHandlerWithMatchBlock:asyncProcessBlock:")]
        void AddHandlerWithMatchBlock(GCDWebServerMatchBlock matchBlock, GCDWebServerAsyncProcessBlock processBlock);

        // -(void)removeAllHandlers;
        [Export("removeAllHandlers")]
        void RemoveAllHandlers();

        // -(BOOL)startWithOptions:(NSDictionary *)options error:(NSError **)error;
        [Export("startWithOptions:error:")]
        bool StartWithOptions(NSDictionary options, out NSError error);

        // -(void)stop;
        [Export("stop")]
        void Stop();
    }

    // @interface Extensions (GCDWebServer)
    [Category]
    [BaseType(typeof(GCDWebServer))]
    public interface GCDWebServer_Extensions
    {
        [Static]
        // @property (readonly, nonatomic) NSURL * serverURL;
        [Export("serverURL")]
        NSUrl ServerURL { get; }
        [Static]
        // @property (readonly, nonatomic) NSURL * bonjourServerURL;
        [Export("bonjourServerURL")]
        NSUrl BonjourServerURL { get; }
        [Static]
        // -(BOOL)start;
        [Export("start")]
       // [Verify(MethodToProperty)]
        bool Start { get; }

        // -(BOOL)startWithPort:(NSUInteger)port bonjourName:(NSString *)name;
        [Export("startWithPort:bonjourName:")]
        bool StartWithPort(nuint port, string name);
    }

    // @interface Handlers (GCDWebServer)
    [Category]
    [BaseType(typeof(GCDWebServer))]
    interface GCDWebServer_Handlers
    {
        // -(void)addDefaultHandlerForMethod:(NSString *)method requestClass:(Class)aClass processBlock:(GCDWebServerProcessBlock)block;
        [Export("addDefaultHandlerForMethod:requestClass:processBlock:")]
        void AddDefaultHandlerForMethod(string method, Class aClass, GCDWebServerProcessBlock block);

        // -(void)addDefaultHandlerForMethod:(NSString *)method requestClass:(Class)aClass asyncProcessBlock:(GCDWebServerAsyncProcessBlock)block;
        [Export("addDefaultHandlerForMethod:requestClass:asyncProcessBlock:")]
        void AddDefaultHandlerForMethod(string method, Class aClass, GCDWebServerAsyncProcessBlock block);

        // -(void)addHandlerForMethod:(NSString *)method path:(NSString *)path requestClass:(Class)aClass processBlock:(GCDWebServerProcessBlock)block;
        [Export("addHandlerForMethod:path:requestClass:processBlock:")]
        void AddHandlerForMethod(string method, string path, Class aClass, GCDWebServerProcessBlock block);

        // -(void)addHandlerForMethod:(NSString *)method path:(NSString *)path requestClass:(Class)aClass asyncProcessBlock:(GCDWebServerAsyncProcessBlock)block;
        [Export("addHandlerForMethod:path:requestClass:asyncProcessBlock:")]
        void AddHandlerForMethod(string method, string path, Class aClass, GCDWebServerAsyncProcessBlock block);

        // -(void)addHandlerForMethod:(NSString *)method pathRegex:(NSString *)regex requestClass:(Class)aClass processBlock:(GCDWebServerProcessBlock)block;
        [Export("addHandlerForMethod:pathRegex:requestClass:processBlock:")]
        void AddHandlerForMethodBlock(string method, string regex, Class aClass, GCDWebServerProcessBlock block);

        // -(void)addHandlerForMethod:(NSString *)method pathRegex:(NSString *)regex requestClass:(Class)aClass asyncProcessBlock:(GCDWebServerAsyncProcessBlock)block;
        [Export("addHandlerForMethod:pathRegex:requestClass:asyncProcessBlock:")]
        void AddHandlerForMethodAsyncBlock(string method, string regex, Class aClass, GCDWebServerAsyncProcessBlock block);
    }

    // @interface GETHandlers (GCDWebServer)
    [Category]
    [BaseType(typeof(GCDWebServer))]
    interface GCDWebServer_GETHandlers
    {
        // -(void)addGETHandlerForPath:(NSString *)path staticData:(NSData *)staticData contentType:(NSString *)contentType cacheAge:(NSUInteger)cacheAge;
        [Export("addGETHandlerForPath:staticData:contentType:cacheAge:")]
        void AddGETHandlerForPath(string path, NSData staticData, string contentType, nuint cacheAge);

        // -(void)addGETHandlerForPath:(NSString *)path filePath:(NSString *)filePath isAttachment:(BOOL)isAttachment cacheAge:(NSUInteger)cacheAge allowRangeRequests:(BOOL)allowRangeRequests;
        [Export("addGETHandlerForPath:filePath:isAttachment:cacheAge:allowRangeRequests:")]
        void AddGETHandlerForPath(string path, string filePath, bool isAttachment, nuint cacheAge, bool allowRangeRequests);

        // -(void)addGETHandlerForBasePath:(NSString *)basePath directoryPath:(NSString *)directoryPath indexFilename:(NSString *)indexFilename cacheAge:(NSUInteger)cacheAge allowRangeRequests:(BOOL)allowRangeRequests;
        [Export("addGETHandlerForBasePath:directoryPath:indexFilename:cacheAge:allowRangeRequests:")]
        void AddGETHandlerForBasePath(string basePath, string directoryPath, string indexFilename, nuint cacheAge, bool allowRangeRequests);
    }

    // @interface Logging (GCDWebServer)
    [Category]
    [BaseType(typeof(GCDWebServer))]
    interface GCDWebServer_Logging
    {
        // +(void)setLogLevel:(int)level;
        [Static]
        [Export("setLogLevel:")]
        void SetLogLevel(int level);

        // -(void)logVerbose:(NSString *)format, ... __attribute__((format(NSString, 1, 2)));
        [Internal]
        [Export("logVerbose:", IsVariadic = true)]
        void LogVerbose(string format, IntPtr varArgs);

        // -(void)logInfo:(NSString *)format, ... __attribute__((format(NSString, 1, 2)));
        [Internal]
        [Export("logInfo:", IsVariadic = true)]
        void LogInfo(string format, IntPtr varArgs);

        // -(void)logWarning:(NSString *)format, ... __attribute__((format(NSString, 1, 2)));
        [Internal]
        [Export("logWarning:", IsVariadic = true)]
        void LogWarning(string format, IntPtr varArgs);

        // -(void)logError:(NSString *)format, ... __attribute__((format(NSString, 1, 2)));
        [Internal]
        [Export("logError:", IsVariadic = true)]
        void LogError(string format, IntPtr varArgs);

        // -(void)logException:(NSException *)exception;
        [Export("logException:")]
        void LogException(NSException exception);
    }

    // @protocol GCDWebUploaderDelegate <GCDWebServerDelegate>
    [Protocol, Model]
    [BaseType(typeof(GCDWebServerDelegate))]
    interface GCDWebUploaderDelegate 
    {
        // @optional -(void)webUploader:(GCDWebUploader *)uploader didDownloadFileAtPath:(NSString *)path;
        [Export("webUploader:didDownloadFileAtPath:")]
        void DidDownloadFileAtPath(GCDWebUploader uploader, string path);

        // @optional -(void)webUploader:(GCDWebUploader *)uploader didUploadFileAtPath:(NSString *)path;
        [Export("webUploader:didUploadFileAtPath:")]
        void DidUploadFileAtPath(GCDWebUploader uploader, string path);

        // @optional -(void)webUploader:(GCDWebUploader *)uploader didMoveItemFromPath:(NSString *)fromPath toPath:(NSString *)toPath;
        [Export("webUploader:didMoveItemFromPath:toPath:")]
        void DidMoveItemFromPath(GCDWebUploader uploader, string fromPath, string toPath);

        // @optional -(void)webUploader:(GCDWebUploader *)uploader didDeleteItemAtPath:(NSString *)path;
        [Export("webUploader:didDeleteItemAtPath:")]
        void DidDeleteItemAtPath(GCDWebUploader uploader, string path);

        // @optional -(void)webUploader:(GCDWebUploader *)uploader didCreateDirectoryAtPath:(NSString *)path;
        [Export("webUploader:didCreateDirectoryAtPath:")]
        void DidCreateDirectoryAtPath(GCDWebUploader uploader, string path);
    }

    // @interface GCDWebUploader : GCDWebServer
    [BaseType(typeof(GCDWebServer))]
    interface GCDWebUploader
    {
        // @property (readonly, nonatomic) NSString * uploadDirectory;
        [Export("uploadDirectory")]
        string UploadDirectory { get; }

        [Wrap("WeakDelegate")]
        GCDWebUploaderDelegate Delegate { get; set; }

        // @property (assign, nonatomic) id<GCDWebUploaderDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        // @property (copy, nonatomic) NSArray * allowedFileExtensions;
        [Export("allowedFileExtensions", ArgumentSemantic.Copy)]
       // [Verify(StronglyTypedNSArray)]
        NSObject[] AllowedFileExtensions { get; set; }

        // @property (nonatomic) BOOL allowHiddenItems;
        [Export("allowHiddenItems")]
        bool AllowHiddenItems { get; set; }

        // @property (copy, nonatomic) NSString * title;
        [Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * header;
        [Export("header")]
        string Header { get; set; }

        // @property (copy, nonatomic) NSString * prologue;
        [Export("prologue")]
        string Prologue { get; set; }

        // @property (copy, nonatomic) NSString * epilogue;
        [Export("epilogue")]
        string Epilogue { get; set; }

        // @property (copy, nonatomic) NSString * footer;
        [Export("footer")]
        string Footer { get; set; }

        // -(instancetype)initWithUploadDirectory:(NSString *)path;
        [Export("initWithUploadDirectory:")]
        IntPtr initWithUploadDirectory(string path);
    }

    // @interface Subclassing (GCDWebUploader)
    [Category]
    [BaseType(typeof(GCDWebUploader))]
    interface GCDWebUploader_Subclassing
    {
        // -(BOOL)shouldUploadFileAtPath:(NSString *)path withTemporaryFile:(NSString *)tempPath;
        [Export("shouldUploadFileAtPath:withTemporaryFile:")]
        bool ShouldUploadFileAtPath(string path, string tempPath);

        // -(BOOL)shouldMoveItemFromPath:(NSString *)fromPath toPath:(NSString *)toPath;
        [Export("shouldMoveItemFromPath:toPath:")]
        bool ShouldMoveItemFromPath(string fromPath, string toPath);

        // -(BOOL)shouldDeleteItemAtPath:(NSString *)path;
        [Export("shouldDeleteItemAtPath:")]
        bool ShouldDeleteItemAtPath(string path);

        // -(BOOL)shouldCreateDirectoryAtPath:(NSString *)path;
        [Export("shouldCreateDirectoryAtPath:")]
        bool ShouldCreateDirectoryAtPath(string path);
    }
}
