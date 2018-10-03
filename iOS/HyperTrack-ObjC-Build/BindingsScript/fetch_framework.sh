sharpie bind ../DerivedData/HyperTrackObjC/Build/Products/Release-iphoneos/HyperTrack/HyperTrack.framework/Headers/HyperTrack-Swift.h 

cp -rf ../DerivedData/HyperTrackObjC/Build/Products/Release-iphoneos/HyperTrack/HyperTrack.framework HyperTrack.framework
lipo -create ../DerivedData/HyperTrackObjC/Build/Products/Release-iphoneos/HyperTrack/HyperTrack.framework/HyperTrack ../DerivedData/HyperTrackObjC/Build/Products/Release-iphonesimulator/HyperTrack/HyperTrack.framework/HyperTrack -output HyperTrack.framework/HyperTrack
cp -rf ../DerivedData/HyperTrackObjC/Build/Products/Release-iphonesimulator/HyperTrack/HyperTrack.framework/Modules/HyperTrack.swiftmodule/ HyperTrack.framework/Modules/HyperTrack.swiftmodule/

cp -rf ../DerivedData/HyperTrackObjC/Build/Products/Release-iphoneos/Alamofire/Alamofire.framework Alamofire.framework
lipo -create ../DerivedData/HyperTrackObjC/Build/Products/Release-iphoneos/Alamofire/Alamofire.framework/Alamofire ../DerivedData/HyperTrackObjC/Build/Products/Release-iphonesimulator/Alamofire/Alamofire.framework/Alamofire -output Alamofire.framework/Alamofire 
cp -rf ../DerivedData/HyperTrackObjC/Build/Products/Release-iphonesimulator/Alamofire/Alamofire.framework/Modules/ Alamofire.framework/Modules/

cp -rf ../DerivedData/HyperTrackObjC/Build/Products/Release-iphoneos/CocoaLumberjack/CocoaLumberjack.framework CocoaLumberjack.framework
lipo -create ../DerivedData/HyperTrackObjC/Build/Products/Release-iphoneos/CocoaLumberjack/CocoaLumberjack.framework/CocoaLumberjack ../DerivedData/HyperTrackObjC/Build/Products/Release-iphonesimulator/CocoaLumberjack/CocoaLumberjack.framework/CocoaLumberjack -output CocoaLumberjack.framework/CocoaLumberjack 
cp -rf ../DerivedData/HyperTrackObjC/Build/Products/Release-iphonesimulator/CocoaLumberjack/CocoaLumberjack.framework/Modules/ CocoaLumberjack.framework/Modules/

cp -rf ../DerivedData/HyperTrackObjC/Build/Products/Release-iphoneos/GzipSwift/Gzip.framework Gzip.framework
lipo -create ../DerivedData/HyperTrackObjC/Build/Products/Release-iphoneos/GzipSwift/Gzip.framework/Gzip ../DerivedData/HyperTrackObjC/Build/Products/Release-iphonesimulator/GzipSwift/Gzip.framework/Gzip -output Gzip.framework/Gzip 
cp -rf ../DerivedData/HyperTrackObjC/Build/Products/Release-iphonesimulator/GzipSwift/Gzip.framework/Modules/Gzip.swiftmodule/ Gzip.framework/Modules/Gzip.swiftmodule/

cp -rf ../DerivedData/HyperTrackObjC/Build/Products/Release-iphoneos/SQLite.swift/SQLite.framework SQLite.framework
lipo -create ../DerivedData/HyperTrackObjC/Build/Products/Release-iphoneos/SQLite.swift/SQLite.framework/SQLite ../DerivedData/HyperTrackObjC/Build/Products/Release-iphonesimulator/SQLite.swift/SQLite.framework/SQLite -output SQLite.framework/SQLite 
cp -rf ../DerivedData/HyperTrackObjC/Build/Products/Release-iphonesimulator/SQLite.swift/SQLite.framework/Modules/SQLite.swiftmodule/ SQLite.framework/Modules/SQLite.swiftmodule/
