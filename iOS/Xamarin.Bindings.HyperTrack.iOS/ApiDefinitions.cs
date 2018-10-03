using System;
using CoreGraphics;
using CoreLocation;
using CoreMotion;
using Foundation;
using MapKit;
using ObjCRuntime;
using UIKit;

namespace Xamarin.Bindings.HyperTrack {
    [Static]
    partial interface Constants
    {
        // extern double HyperTrackVersionNumber;
        [Field("HyperTrackVersionNumber", "__Internal")]
        double HyperTrackVersionNumber { get; }

        // extern const unsigned char [] HyperTrackVersionString;
        [Field("HyperTrackVersionString", "__Internal")]
        IntPtr HyperTrackVersionString { get; }

    }

    // @interface HTAction : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack8HTAction")]
    [DisableDefaultCtor]
    interface HTAction
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull uniqueId;
        [Export("uniqueId")]
        string UniqueId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull collectionId;
        [Export("collectionId")]
        string CollectionId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull type;
        [Export("type")]
        string Type { get; }

        // @property (readonly, nonatomic, strong) HTUser * _Nullable user;
        [NullAllowed, Export("user", ArgumentSemantic.Strong)]
        HTUser User { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull metadata;
        [Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> Metadata { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull trackingUrl;
        [Export("trackingUrl")]
        string TrackingUrl { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull endedAnnotation;
        [Export("endedAnnotation")]
        string EndedAnnotation { get; }

        // @property (readonly, nonatomic) BOOL isAutocompleteAtExpectedPlace;
        [Export("isAutocompleteAtExpectedPlace")]
        bool IsAutocompleteAtExpectedPlace { get; }

        // @property (readonly, nonatomic) BOOL isAutocompleteAtCreation;
        [Export("isAutocompleteAtCreation")]
        bool IsAutocompleteAtCreation { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable scheduleAutoCancelAt;
        [NullAllowed, Export("scheduleAutoCancelAt", ArgumentSemantic.Copy)]
        NSDate ScheduleAutoCancelAt { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull status;
        [Export("status")]
        string Status { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable updatedAt;
        [NullAllowed, Export("updatedAt", ArgumentSemantic.Copy)]
        NSDate UpdatedAt { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable createdAt;
        [NullAllowed, Export("createdAt", ArgumentSemantic.Copy)]
        NSDate CreatedAt { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable startedAt;
        [NullAllowed, Export("startedAt", ArgumentSemantic.Copy)]
        NSDate StartedAt { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable endedAt;
        [NullAllowed, Export("endedAt", ArgumentSemantic.Copy)]
        NSDate EndedAt { get; }

        // @property (readonly, nonatomic, strong) HTPlace * _Nullable startedPlace;
        [NullAllowed, Export("startedPlace", ArgumentSemantic.Strong)]
        HTPlace StartedPlace { get; }

        // @property (readonly, nonatomic, strong) HTPlace * _Nullable completedPlace;
        [NullAllowed, Export("completedPlace", ArgumentSemantic.Strong)]
        HTPlace CompletedPlace { get; }

        // @property (readonly, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable locationTimeSeries;
        [NullAllowed, Export("locationTimeSeries")]
        string LocationTimeSeries { get; }

        // @property (readonly, nonatomic, strong) HTPlace * _Nullable expectedPlace;
        [NullAllowed, Export("expectedPlace", ArgumentSemantic.Strong)]
        HTPlace ExpectedPlace { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable expectedAt;
        [NullAllowed, Export("expectedAt", ArgumentSemantic.Copy)]
        NSDate ExpectedAt { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull arrivalStatus;
        [Export("arrivalStatus")]
        string ArrivalStatus { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable eta;
        [NullAllowed, Export("eta", ArgumentSemantic.Copy)]
        NSDate Eta { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable etaAtCreation;
        [NullAllowed, Export("etaAtCreation", ArgumentSemantic.Copy)]
        NSDate EtaAtCreation { get; }

        // @property (readonly, nonatomic) NSInteger distanceToArrival;
        [Export("distanceToArrival")]
        nint DistanceToArrival { get; }


        // @property (readonly, nonatomic, strong) HTLocation * _Nullable location;
        [NullAllowed, Export("location", ArgumentSemantic.Strong)]
        HTLocation Location { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable completedAt;
        [NullAllowed, Export("completedAt", ArgumentSemantic.Copy)]
        NSDate CompletedAt { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable expectedRoute;
        [NullAllowed, Export("expectedRoute")]
        string ExpectedRoute { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable route;
        [NullAllowed, Export("route")]
        string Route { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable completedAnnotation;
        [NullAllowed, Export("completedAnnotation", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> CompletedAnnotation { get; }

        // @property (readonly, nonatomic, strong) HTHealth * _Nullable health;
        [NullAllowed, Export("health", ArgumentSemantic.Strong)]
        HTHealth Health { get; }

        // @property (readonly, nonatomic, strong) HTActivity * _Nullable activity;
        [NullAllowed, Export("activity", ArgumentSemantic.Strong)]
        HTActivity Activity { get; }

        // -(instancetype _Nonnull)initWithDict:(NSDictionary<NSString *,id> * _Nonnull)dict __attribute__((objc_designated_initializer));
        [Export("initWithDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> dict);

        // -(NSString * _Nullable)toJson __attribute__((warn_unused_result));
        [NullAllowed, Export("toJson")]
        string ToJson { get; }

        // -(NSData * _Nullable)toJsonData __attribute__((warn_unused_result));
        [NullAllowed, Export("toJsonData")]
        NSData ToJsonData { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTAction New();
    }

    // @interface HTActionInfo : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack12HTActionInfo")]
    [DisableDefaultCtor]
    interface HTActionInfo
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull actionStatus;
        [Export("actionStatus")]
        string ActionStatus { get; }

        // -(instancetype _Nonnull)initWithActionStatus:(NSString * _Nonnull)actionStatus __attribute__((objc_designated_initializer));
        [Export("initWithActionStatus:")]
        [DesignatedInitializer]
        IntPtr Constructor(string actionStatus);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTActionInfo New();
    }

    // @interface HTActionParams : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack14HTActionParams")]
    interface HTActionParams
    {
        // @property (copy, nonatomic) NSString * _Nullable userId;
        [NullAllowed, Export("userId")]
        string UserId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable expectedPlaceId;
        [NullAllowed, Export("expectedPlaceId")]
        string ExpectedPlaceId { get; set; }

        // @property (nonatomic, strong) HTPlace * _Nullable expectedPlace;
        [NullAllowed, Export("expectedPlace", ArgumentSemantic.Strong)]
        HTPlace ExpectedPlace { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull type;
        [Export("type")]
        string Type { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull uniqueId;
        [Export("uniqueId")]
        string UniqueId { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull collectionId;
        [Export("collectionId")]
        string CollectionId { get; set; }

        // @property (nonatomic) BOOL uniqueIdAsShortCode;
        [Export("uniqueIdAsShortCode")]
        bool UniqueIdAsShortCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable expectedAt;
        [NullAllowed, Export("expectedAt")]
        string ExpectedAt { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nullable autocompleteRule;
        [NullAllowed, Export("autocompleteRule", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> AutocompleteRule { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nullable metadata;
        [NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> Metadata { get; set; }

        // -(HTActionParams * _Nonnull)setUserIdWithUserId:(NSString * _Nonnull)userId __attribute__((warn_unused_result));
        [Export("setUserIdWithUserId:")]
        HTActionParams SetUserIdWithUserId(string userId);

        // -(HTActionParams * _Nonnull)setExpectedPlaceWithExpectedPlace:(HTPlace * _Nonnull)expectedPlace __attribute__((warn_unused_result));
        [Export("setExpectedPlaceWithExpectedPlace:")]
        HTActionParams SetExpectedPlaceWithExpectedPlace(HTPlace expectedPlace);

        // -(HTActionParams * _Nonnull)setExpectedPlaceIdWithExpectedPlaceId:(NSString * _Nonnull)expectedPlaceId __attribute__((warn_unused_result));
        [Export("setExpectedPlaceIdWithExpectedPlaceId:")]
        HTActionParams SetExpectedPlaceIdWithExpectedPlaceId(string expectedPlaceId);

        // -(HTActionParams * _Nonnull)setTypeWithType:(NSString * _Nonnull)type __attribute__((warn_unused_result));
        [Export("setTypeWithType:")]
        HTActionParams SetTypeWithType(string type);

        // -(HTActionParams * _Nonnull)setUniqueIdWithUniqueId:(NSString * _Nonnull)uniqueId __attribute__((warn_unused_result));
        [Export("setUniqueIdWithUniqueId:")]
        HTActionParams SetUniqueIdWithUniqueId(string uniqueId);

        // -(HTActionParams * _Nonnull)setUniqueIdAsShortCode __attribute__((warn_unused_result));
        [Export("setUniqueIdAsShortCode")]
        HTActionParams SetUniqueIdAsShortCode { get; }

        // -(HTActionParams * _Nonnull)setExpectedAtExpectedAt:(NSString * _Nonnull)expectedAt __attribute__((warn_unused_result));
        [Export("setExpectedAtExpectedAt:")]
        HTActionParams SetExpectedAtExpectedAt(string expectedAt);

        // -(HTActionParams * _Nonnull)setAutocompleteRuleWithRule:(NSDictionary<NSString *,id> * _Nonnull)rule __attribute__((warn_unused_result));
        [Export("setAutocompleteRuleWithRule:")]
        HTActionParams SetAutocompleteRuleWithRule(NSDictionary<NSString, NSObject> rule);

        // -(HTActionParams * _Nonnull)setAutocancelAfterHours:(NSInteger)hours __attribute__((warn_unused_result));
        [Export("setAutocancelAfterHours:")]
        HTActionParams SetAutocancelAfterHours(nint hours);

        // -(HTActionParams * _Nonnull)setMetaDataWithMetadata:(NSDictionary<NSString *,id> * _Nonnull)metadata __attribute__((warn_unused_result));
        [Export("setMetaDataWithMetadata:")]
        HTActionParams SetMetaDataWithMetadata(NSDictionary<NSString, NSObject> metadata);
    }

    // @interface HyperTrack_Swift_376 (HTActionParams)
    [Category]
    [BaseType(typeof(HTActionParams))]
    interface HTActionParams_HyperTrack_Swift_376
    {
        // -(instancetype _Nonnull)initWithType:(NSString * _Nonnull)type;
       // [Export("initWithType:")]
      //  IntPtr Constructor(string type);

        // @property (readonly, getter = default, nonatomic, strong, class) HTActionParams * _Nonnull default_;
        [Static]
        [Export("default_", ArgumentSemantic.Strong)]
        HTActionParams GetDefault_();
    }

    // @interface HTActivity : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack10HTActivity")]
    [DisableDefaultCtor]
    interface HTActivity
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull userId;
        [Export("userId")]
        string UserId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable lookupId;
        [NullAllowed, Export("lookupId")]
        string LookupId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull type;
        [Export("type")]
        string Type { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable unknownReason;
        [NullAllowed, Export("unknownReason")]
        string UnknownReason { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable startedAt;
        [NullAllowed, Export("startedAt", ArgumentSemantic.Copy)]
        NSDate StartedAt { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable endedAt;
        [NullAllowed, Export("endedAt", ArgumentSemantic.Copy)]
        NSDate EndedAt { get; }

        // @property (readonly, nonatomic, strong) HTPlace * _Nullable place;
        [NullAllowed, Export("place", ArgumentSemantic.Strong)]
        HTPlace Place { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable route;
        [NullAllowed, Export("route")]
        string Route { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable locationTimeSeries;
        [NullAllowed, Export("locationTimeSeries")]
        string LocationTimeSeries { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable stepDistance;
        [NullAllowed, Export("stepDistance")]
        string StepDistance { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable createdAt;
        [NullAllowed, Export("createdAt", ArgumentSemantic.Copy)]
        NSDate CreatedAt { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable modifiedAt;
        [NullAllowed, Export("modifiedAt", ArgumentSemantic.Copy)]
        NSDate ModifiedAt { get; }

        // -(instancetype _Nonnull)initWithDict:(NSDictionary<NSString *,id> * _Nonnull)dict __attribute__((objc_designated_initializer));
        [Export("initWithDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> dict);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTActivity New();
    }

    // @protocol HTMapViewUseCase
    [Protocol, Model]
    interface HTMapViewUseCase
    {
        [Wrap("WeakMapDelegate"), Abstract]
        [NullAllowed]
        NSObject MapDelegate { get; set; }

        // @required @property (nonatomic, strong) id<HTMapUseCaseDelegate> _Nullable mapDelegate;
        [Abstract]
        [NullAllowed, Export("mapDelegate", ArgumentSemantic.Strong)]
        NSObject WeakMapDelegate { get; set; }

        // @required -(void)update;
        [Abstract]
        [Export("update")]
        void Update();

        // @required -(instancetype _Nonnull)initWithMapDelegate:(id<HTMapUseCaseDelegate> _Nullable)mapDelegate;
        [Abstract]
        [Export("initWithMapDelegate:")]
        IntPtr Constructor([NullAllowed] NSObject mapDelegate);
    }

    // @interface HTBaseUseCase : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack13HTBaseUseCase")]
    interface HTBaseUseCase
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        NSObject Delegate { get; set; }

        // @property (nonatomic, weak) id<HTBaseUseCaseDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }
    }

    // @interface HTActivitySummaryUseCase : HTBaseUseCase <HTMapViewUseCase>
    [BaseType(typeof(HTBaseUseCase), Name = "_TtC10HyperTrack24HTActivitySummaryUseCase")]
    interface HTActivitySummaryUseCase : HTBaseUseCase
    {
        [Wrap("WeakMapDelegate")]
        [NullAllowed]
        NSObject MapDelegate { get; set; }

        // @property (nonatomic, weak) id<HTMapUseCaseDelegate> _Nullable mapDelegate;
        [NullAllowed, Export("mapDelegate", ArgumentSemantic.Weak)]
        NSObject WeakMapDelegate { get; set; }

        // @property (readonly, nonatomic, strong) HTLiveTrackingUseCase * _Null_unspecified liveUC;
        [Export("liveUC", ArgumentSemantic.Strong)]
        NSObject LiveUC { get; }

        // @property (readonly, nonatomic, strong) HTPlaceLineUseCase * _Null_unspecified placelineUC;
        [Export("placelineUC", ArgumentSemantic.Strong)]
        HTPlaceLineUseCase PlacelineUC { get; }

        [Wrap("WeakActivityDelegate")]
        [NullAllowed]
        NSObject ActivityDelegate { get; set; }

        // @property (nonatomic, weak) id<HTActivitySummaryUseCaseDelegate> _Nullable activityDelegate;
        [NullAllowed, Export("activityDelegate", ArgumentSemantic.Weak)]
        NSObject WeakActivityDelegate { get; set; }

        // @property (nonatomic) BOOL isPrimaryActionHidden;
        [Export("isPrimaryActionHidden")]
        bool IsPrimaryActionHidden { get; set; }

        // -(instancetype _Nonnull)initWithMapDelegate:(id<HTMapUseCaseDelegate> _Nullable)mapDelegate;
        [Export("initWithMapDelegate:")]
        IntPtr Constructor([NullAllowed] NSObject mapDelegate);

        // -(instancetype _Nonnull)initWithLiveUseCase:(HTLiveTrackingUseCase * _Nullable)liveUseCase placelineUseCase:(HTPlaceLineUseCase * _Nullable)placelineUseCase __attribute__((objc_designated_initializer));
        [Export("initWithLiveUseCase:placelineUseCase:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] NSObject liveUseCase, [NullAllowed] NSObject placelineUseCase);

        // -(void)update;
        [Export("update")]
        void Update();

        // -(void)enabeLiveTracking;
        [Export("enabeLiveTracking")]
        void EnabeLiveTracking();
    }

    // @protocol HTUseCaseNavigationDelegate
    [Protocol, Model]
    interface HTUseCaseNavigationDelegate
    {
        // @required -(void)backClicked;
        [Abstract]
        [Export("backClicked")]
        void BackClicked();
    }

    // @interface HyperTrack_Swift_445 (HTActivitySummaryUseCase) <HTUseCaseNavigationDelegate>
    [Category]
    [BaseType(typeof(HTActivitySummaryUseCase))]
    interface HTActivitySummaryUseCase_HyperTrack_Swift_445
    {
        // -(void)backClicked;
        [Export("backClicked")]
        void BackClicked();
    }

    // @protocol HTPlaceLineUseCaseDelegate
    [Protocol, Model]
    interface HTPlaceLineUseCaseDelegate
    {
    }

    // @protocol HTBaseUseCaseDelegate
    [Protocol, Model]
    interface HTBaseUseCaseDelegate
    {
        // @required -(void)showLoader:(BOOL)show;
        [Abstract]
        [Export("showLoader:")]
        void ShowLoader(bool show);
    }

    // @protocol HTLiveTrackingUseCaseDelegate <HTBaseUseCaseDelegate>
    [Protocol, Model]
    interface HTLiveTrackingUseCaseDelegate : HTBaseUseCaseDelegate
    {
        // @required -(void)shareLiveTrackingDetails:(NSString * _Nonnull)url eta:(NSString * _Nonnull)eta;
        [Abstract]
        [Export("shareLiveTrackingDetails:eta:")]
        void ShareLiveTrackingDetails(string url, string eta);

        // @required -(void)shareLiveLocationClicked;
        [Abstract]
        [Export("shareLiveLocationClicked")]
        void ShareLiveLocationClicked();

        // @required -(void)liveTrackingEnded:(HTTrackWithTypeData * _Nonnull)type;
        [Abstract]
        [Export("liveTrackingEnded:")]
        void LiveTrackingEnded(HTTrackWithTypeData type);
    }

    // @protocol HTActivitySummaryUseCaseDelegate <HTLiveTrackingUseCaseDelegate, HTPlaceLineUseCaseDelegate>
    [Protocol, Model]
    interface HTActivitySummaryUseCaseDelegate : HTLiveTrackingUseCaseDelegate, HTPlaceLineUseCaseDelegate
    {
    }

    // @interface HTAnnotationData : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack16HTAnnotationData")]
    [DisableDefaultCtor]
    interface HTAnnotationData
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; }

        // @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
        [Export("coordinate")]
        CLLocationCoordinate2D Coordinate { get; }

        // @property (readonly, nonatomic, strong) MetaData * _Nonnull metaData;
        [Export("metaData", ArgumentSemantic.Strong)]
        NSObject MetaData { get; }

        // @property (readonly, nonatomic, strong) HTCallout * _Nullable callout;
        [NullAllowed, Export("callout", ArgumentSemantic.Strong)]
        HTCallout Callout { get; }

        // @property (readonly, nonatomic, strong) HTTimeAwarePolyline * _Nullable locationTimeSeries;
        [NullAllowed, Export("locationTimeSeries", ArgumentSemantic.Strong)]
        HTTimeAwarePolyline LocationTimeSeries { get; }

        // @property (readonly, nonatomic) BOOL isCurrentUser;
        [Export("isCurrentUser")]
        bool IsCurrentUser { get; }

        // -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id coordinate:(CLLocationCoordinate2D)coordinate metaData:(MetaData * _Nonnull)metaData callout:(HTCallout * _Nullable)callout isCurrentUser:(BOOL)isCurrentUser locationTimeSeries:(HTTimeAwarePolyline * _Nullable)locationTimeSeries __attribute__((objc_designated_initializer));
        [Export("initWithId:coordinate:metaData:callout:isCurrentUser:locationTimeSeries:")]
        [DesignatedInitializer]
        IntPtr Constructor(string id, CLLocationCoordinate2D coordinate, NSObject metaData, [NullAllowed] HTCallout callout, bool isCurrentUser, [NullAllowed] HTTimeAwarePolyline locationTimeSeries);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTAnnotationData New();
    }

    // @interface HTAppleMapsProvider : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack19HTAppleMapsProvider")]
    [DisableDefaultCtor]
    interface HTAppleMapsProvider
    {
        // @property (readonly, nonatomic, strong) UIView * _Nonnull contentView;
        [Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; }

        // @property (nonatomic) BOOL showCurrentLocation;
        [Export("showCurrentLocation")]
        bool ShowCurrentLocation { get; set; }

        [Wrap("WeakUpdatesDelegate")]
        [NullAllowed]
        NSObject UpdatesDelegate { get; set; }

        // @property (nonatomic, weak) id<HTMapViewUpdatesDelegate> _Nullable updatesDelegate;
        [NullAllowed, Export("updatesDelegate", ArgumentSemantic.Weak)]
        NSObject WeakUpdatesDelegate { get; set; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTAppleMapsProvider New();
    }

    // @interface HyperTrack_Swift_512 (HTAppleMapsProvider)
    [Category]
    [BaseType(typeof(HTAppleMapsProvider))]
    interface HTAppleMapsProvider_HyperTrack_Swift_512
    {
        // -(void)centerMapOnAllAnnotations:(BOOL)animated;
        [Export("centerMapOnAllAnnotations:")]
        void CenterMapOnAllAnnotations(bool animated);
    }

    // @interface HyperTrack_Swift_523 (HTAppleMapsProvider) <MKMapViewDelegate>
    [Category]
    [BaseType(typeof(HTAppleMapsProvider))]
    interface HTAppleMapsProvider_HyperTrack_Swift_523 
    {
        // -(void)mapView:(MKMapView * _Nonnull)mapView didUpdateUserLocation:(MKUserLocation * _Nonnull)userLocation;
        [Export("mapView:didUpdateUserLocation:")]
        void MapView(MKMapView mapView, MKUserLocation userLocation);

        // -(void)mapViewDidFinishLoadingMap:(MKMapView * _Nonnull)mapView;
        [Export("mapViewDidFinishLoadingMap:")]
        void MapViewDidFinishLoadingMap(MKMapView mapView);

        // -(MKAnnotationView * _Nullable)mapView:(MKMapView * _Nonnull)mapView viewForAnnotation:(id<MKAnnotation> _Nonnull)annotation __attribute__((warn_unused_result));
        [Export("mapView:viewForAnnotation:")]
        [return: NullAllowed]
        MKAnnotationView MapView(MKMapView mapView, MKAnnotation annotation);

        // -(MKOverlayRenderer * _Nonnull)mapView:(MKMapView * _Nonnull)mapView rendererForOverlay:(id<MKOverlay> _Nonnull)overlay __attribute__((warn_unused_result));
        [Export("mapView:rendererForOverlay:")]
        MKOverlayRenderer MapView(MKMapView mapView, MKOverlay overlay);

        // -(void)mapView:(MKMapView * _Nonnull)mapView regionWillChangeAnimated:(BOOL)animated;
        [Export("mapView:regionWillChangeAnimated:")]
        void MapView(MKMapView mapView, bool animated);
    }

    // @protocol HTMapViewDelegate
    [Protocol, Model]
    interface HTMapViewDelegate
    {
        // @required @property (nonatomic) BOOL showCurrentLocation;
        [Abstract]
        [Export("showCurrentLocation")]
        bool ShowCurrentLocation { get; set; }

        // @required -(void)cleanUp;
        [Abstract]
        [Export("cleanUp")]
        void CleanUp();

        // @required -(void)addAnnotations:(NSArray<HTAnnotationData *> * _Nonnull)data;
        [Abstract]
        [Export("addAnnotations:")]
        void AddAnnotations(HTAnnotationData[] data);

        // @required -(void)addPolyline:(NSArray<HTPolylineData *> * _Nonnull)data;
        [Abstract]
        [Export("addPolyline:")]
        void AddPolyline(HTPolylineData[] data);

        // @required -(void)addTrailingPolyline:(NSArray<HTTimeAwarePolyline *> * _Nonnull)data;
        [Abstract]
        [Export("addTrailingPolyline:")]
        void AddTrailingPolyline(HTTimeAwarePolyline[] data);

        // @required -(void)updateMapVisibleRegion:(UIEdgeInsets)insets;
        [Abstract]
        [Export("updateMapVisibleRegion:")]
        void UpdateMapVisibleRegion(UIEdgeInsets insets);

        // @required -(CLLocationCoordinate2D)getCenterCoordinates __attribute__((warn_unused_result));
        [Abstract]
        [Export("getCenterCoordinates")]
        CLLocationCoordinate2D CenterCoordinates { get; }

        // @required -(void)showCoordinates:(NSArray<NSValue *> * _Nonnull)coordinates;
        [Abstract]
        [Export("showCoordinates:")]
        void ShowCoordinates(NSValue[] coordinates);
    }

    // @protocol HTMapsProviderProtocol <HTMapViewDelegate>
    [Protocol, Model]
    interface HTMapsProviderProtocol : HTMapViewDelegate
    {
        [Wrap("WeakUpdatesDelegate"), Abstract]
        [NullAllowed]
        NSObject UpdatesDelegate { get; set; }

        // @required @property (nonatomic, strong) id<HTMapViewUpdatesDelegate> _Nullable updatesDelegate;
        [Abstract]
        [NullAllowed, Export("updatesDelegate", ArgumentSemantic.Strong)]
        NSObject WeakUpdatesDelegate { get; set; }

        // @required @property (readonly, nonatomic, strong) UIView * _Nonnull contentView;
        [Abstract]
        [Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; }

        // @required -(void)centerMapOnAllAnnotations:(BOOL)animated;
        [Abstract]
        [Export("centerMapOnAllAnnotations:")]
        void CenterMapOnAllAnnotations(bool animated);
    }

    // @interface HyperTrack_Swift_555 (HTAppleMapsProvider) <HTMapsProviderProtocol>
    [Category]
    [BaseType(typeof(HTAppleMapsProvider))]
    interface HTAppleMapsProvider_HyperTrack_Swift_555
    {
        // -(void)cleanUp;
        [Export("cleanUp")]
        void CleanUp();

        // -(void)addAnnotations:(NSArray<HTAnnotationData *> * _Nonnull)data;
        [Export("addAnnotations:")]
        void AddAnnotations(HTAnnotationData[] data);

        // -(void)addPolyline:(NSArray<HTPolylineData *> * _Nonnull)data;
        [Export("addPolyline:")]
        void AddPolyline(HTPolylineData[] data);

        // -(void)showCoordinates:(NSArray<NSValue *> * _Nonnull)coordinates;
        [Export("showCoordinates:")]
        void ShowCoordinates(NSValue[] coordinates);

        // -(void)addTrailingPolyline:(NSArray<HTTimeAwarePolyline *> * _Nonnull)data;
        [Export("addTrailingPolyline:")]
        void AddTrailingPolyline(HTTimeAwarePolyline[] data);

        // -(void)updateMapVisibleRegion:(UIEdgeInsets)insets;
        [Export("updateMapVisibleRegion:")]
        void UpdateMapVisibleRegion(UIEdgeInsets insets);

        // -(CLLocationCoordinate2D)getCenterCoordinates __attribute__((warn_unused_result));
        [Export("getCenterCoordinates")]
        CLLocationCoordinate2D GetCenterCoordinates();
    }

    // @protocol HTAuxillaryFlowDelegate
    [Protocol, Model]
    interface HTAuxillaryFlowDelegate
    {
        // @required -(void)cancelClicked;
        [Abstract]
        [Export("cancelClicked")]
        void CancelClicked();
    }

    // @interface HTBaseTrackingUseCase : HTBaseUseCase
    [BaseType(typeof(HTBaseUseCase), Name = "_TtC10HyperTrack21HTBaseTrackingUseCase")]
    [DisableDefaultCtor]
    interface HTBaseTrackingUseCase
    {
        // @property (nonatomic) double pollDuration;
        [Export("pollDuration")]
        double PollDuration { get; set; }

        // @property (readonly, nonatomic) BOOL isPollingEnabled;
        [Export("isPollingEnabled")]
        bool IsPollingEnabled { get; }

        // -(void)update;
        [Export("update")]
        void Update();

        // -(instancetype _Nonnull)initWithViewModel:(id<HTBaseTrackingViewModelProtocol> _Nullable)viewModel __attribute__((objc_designated_initializer));
        [Export("initWithViewModel:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] NSObject viewModel);

        // -(void)stop;
        [Export("stop")]
        void Stop();

        // -(void)trackActionWithType:(HTTrackWithTypeData * _Nonnull)type pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithType:pollDuration:completionHandler:")]
        void TrackActionWithType(HTTrackWithTypeData type, double pollDuration, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)trackActionWithIds:(NSArray<NSString *> * _Nonnull)ids pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithIds:pollDuration:completionHandler:")]
        void TrackActionWithIds(string[] ids, double pollDuration, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)trackActionWithCollectionId:(NSString * _Nonnull)id pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithCollectionId:pollDuration:completionHandler:")]
        void TrackActionWithCollectionId(string id, double pollDuration, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)trackActionWithUniqueId:(NSString * _Nonnull)id pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithUniqueId:pollDuration:completionHandler:")]
        void TrackActionWithUniqueId(string id, double pollDuration, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)trackActionWithShortCodes:(NSArray<NSString *> * _Nonnull)codes pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithShortCodes:pollDuration:completionHandler:")]
        void TrackActionWithShortCodes(string[] codes, double pollDuration, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTBaseTrackingUseCase New();
    }

    // @protocol HTBaseViewModelProtocol
    [Protocol, Model]
    interface HTBaseViewModelProtocol
    {
    }

    // @protocol HTBaseTrackingViewModelProtocol <HTBaseViewModelProtocol>
    [Protocol, Model]
    interface HTBaseTrackingViewModelProtocol : HTBaseViewModelProtocol
    {
        // @required -(void)completeAction:(NSString * _Nonnull)id completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
        [Abstract]
        [Export("completeAction:completionHandler:")]
        void CompleteAction(string id, [NullAllowed] Action<HTAction, HTError> completionHandler);

        // @required -(void)trackActionWithIds:(NSArray<NSString *> * _Nonnull)ids completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Abstract]
        [Export("trackActionWithIds:completionHandler:")]
        void TrackActionWithIds(string[] ids, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // @required -(void)trackActionWithCollectionId:(NSString * _Nonnull)id completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Abstract]
        [Export("trackActionWithCollectionId:completionHandler:")]
        void TrackActionWithCollectionId(string id, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // @required -(void)trackActionWithUniqueId:(NSString * _Nonnull)id completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Abstract]
        [Export("trackActionWithUniqueId:completionHandler:")]
        void TrackActionWithUniqueId(string id, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // @required -(void)trackActionWithShortCodes:(NSArray<NSString *> * _Nonnull)codes completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Abstract]
        [Export("trackActionWithShortCodes:completionHandler:")]
        void TrackActionWithShortCodes(string[] codes, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // @required -(void)addExpectedPlaceWithActionId:(NSString * _Nonnull)actionId newPlace:(HTPlace * _Nonnull)newPlace completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
        [Abstract]
        [Export("addExpectedPlaceWithActionId:newPlace:completionHandler:")]
        void AddExpectedPlaceWithActionId(string actionId, HTPlace newPlace, [NullAllowed] Action<HTAction, HTError> completionHandler);

        // @required -(void)addExpectedPlaceWithCollectionId:(NSString * _Nonnull)collectionId newPlace:(HTPlace * _Nonnull)newPlace completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
        [Abstract]
        [Export("addExpectedPlaceWithCollectionId:newPlace:completionHandler:")]
        void AddExpectedPlaceWithCollectionId(string collectionId, HTPlace newPlace, [NullAllowed] Action<HTAction, HTError> completionHandler);
    }

    // @interface HTBaseTrackingViewModel : NSObject <HTBaseTrackingViewModelProtocol>
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack23HTBaseTrackingViewModel")]
    interface HTBaseTrackingViewModel : HTBaseTrackingViewModelProtocol
    {
        // -(void)trackActionWithIds:(NSArray<NSString *> * _Nonnull)ids completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithIds:completionHandler:")]
        void TrackActionWithIds(string[] ids, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)trackActionWithCollectionId:(NSString * _Nonnull)id completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithCollectionId:completionHandler:")]
        void TrackActionWithCollectionId(string id, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)trackActionWithUniqueId:(NSString * _Nonnull)id completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithUniqueId:completionHandler:")]
        void TrackActionWithUniqueId(string id, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)trackActionWithShortCodes:(NSArray<NSString *> * _Nonnull)codes completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithShortCodes:completionHandler:")]
        void TrackActionWithShortCodes(string[] codes, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)addExpectedPlaceWithActionId:(NSString * _Nonnull)actionId newPlace:(HTPlace * _Nonnull)newPlace completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
        [Export("addExpectedPlaceWithActionId:newPlace:completionHandler:")]
        void AddExpectedPlaceWithActionId(string actionId, HTPlace newPlace, [NullAllowed] Action<HTAction, HTError> completionHandler);

        // -(void)addExpectedPlaceWithCollectionId:(NSString * _Nonnull)collectionId newPlace:(HTPlace * _Nonnull)newPlace completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
        [Export("addExpectedPlaceWithCollectionId:newPlace:completionHandler:")]
        void AddExpectedPlaceWithCollectionId(string collectionId, HTPlace newPlace, [NullAllowed] Action<HTAction, HTError> completionHandler);

        // -(void)completeAction:(NSString * _Nonnull)id completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
        [Export("completeAction:completionHandler:")]
        void CompleteAction(string id, [NullAllowed] Action<HTAction, HTError> completionHandler);
    }

    // @interface HTBaseView : UIView
    [BaseType(typeof(UIView), Name = "_TtC10HyperTrack10HTBaseView")]
    interface HTBaseView
    {
        // @property (nonatomic) BOOL enableShadow;
        [Export("enableShadow")]
        bool EnableShadow { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable dashBorderedColor;
        [NullAllowed, Export("dashBorderedColor", ArgumentSemantic.Strong)]
        UIColor DashBorderedColor { get; set; }

        // @property (nonatomic) CGFloat topCornerRadius;
        [Export("topCornerRadius")]
        nfloat TopCornerRadius { get; set; }

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @protocol HTBasicComponentProtocol
    [Protocol, Model]
    interface HTBasicComponentProtocol
    {
    }

    // @interface HTBottomViewActionData : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack22HTBottomViewActionData")]
    [DisableDefaultCtor]
    interface HTBottomViewActionData
    {
        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTBottomViewActionData New();
    }

    // @interface HTBottomViewContainer : UIView
    [BaseType(typeof(UIView), Name = "_TtC10HyperTrack21HTBottomViewContainer")]
    interface HTBottomViewContainer
    {
        // @property (nonatomic) BOOL isShadowEnabled;
        [Export("isShadowEnabled")]
        bool IsShadowEnabled { get; set; }

        // @property (nonatomic) BOOL isBlurEnabled;
        [Export("isBlurEnabled")]
        bool IsBlurEnabled { get; set; }

        // -(void)setContentView:(UIView * _Nullable)contentView;
        [Export("setContentView:")]
        void SetContentView([NullAllowed] UIView contentView);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @protocol HTBottomViewUseCaseDelegate
    [Protocol, Model]
    interface HTBottomViewUseCaseDelegate
    {
        // @required -(void)actionPerformed:(HTBottomViewActionData * _Nonnull)data;
        [Abstract]
        [Export("actionPerformed:")]
        void ActionPerformed(HTBottomViewActionData data);
    }

    // @interface HTButton : UIButton
    [BaseType(typeof(UIButton), Name = "_TtC10HyperTrack8HTButton")]
    interface HTButton
    {
        // @property (nonatomic) CGFloat topCornerRadius;
        [Export("topCornerRadius")]
        nfloat TopCornerRadius { get; set; }

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
 
    }

    // @protocol HTCalendarDelegate
    [Protocol, Model]
    interface HTCalendarDelegate
    {
        // @required -(void)didSelectDate:(NSDate * _Nonnull)date;
        [Abstract]
        [Export("didSelectDate:")]
        void DidSelectDate(NSDate date);
    }

    // @protocol HTCalendarProviderProtocol
    [Protocol, Model]
    interface HTCalendarProviderProtocol
    {
        // @required @property (readonly, nonatomic, strong) UIView * _Nonnull contentView;
        [Abstract]
        [Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; }

        // @required @property (copy, nonatomic) NSDate * _Nonnull minimumDate;
        [Abstract]
        [Export("minimumDate", ArgumentSemantic.Copy)]
        NSDate MinimumDate { get; set; }

        // @required @property (copy, nonatomic) NSDate * _Nonnull maximumDate;
        [Abstract]
        [Export("maximumDate", ArgumentSemantic.Copy)]
        NSDate MaximumDate { get; set; }

        [Wrap("WeakDelegate"), Abstract]
        [NullAllowed]
        NSObject Delegate { get; set; }

        // @required @property (nonatomic, strong) id<HTCalendarDelegate> _Nullable delegate;
        [Abstract]
        [NullAllowed, Export("delegate", ArgumentSemantic.Strong)]
        NSObject WeakDelegate { get; set; }
    }

    // @interface HTCalendarProvider : NSObject <HTCalendarProviderProtocol>
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack18HTCalendarProvider")]
    interface HTCalendarProvider : HTCalendarProviderProtocol
    {
        // @property (readonly, nonatomic, strong) UIView * _Nonnull contentView;
        [Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        NSObject Delegate { get; set; }

        // @property (nonatomic, weak) id<HTCalendarDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (copy, nonatomic) NSDate * _Nonnull minimumDate;
        [Export("minimumDate", ArgumentSemantic.Copy)]
        NSDate MinimumDate { get; set; }

        // @property (copy, nonatomic) NSDate * _Nonnull maximumDate;
        [Export("maximumDate", ArgumentSemantic.Copy)]
        NSDate MaximumDate { get; set; }
    }

    // @interface HTCallout : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack9HTCallout")]
    [DisableDefaultCtor]
    interface HTCallout
    {
        // @property (readonly, copy, nonatomic) NSArray<id<HTBasicComponentProtocol>> * _Nonnull components;
        [Export("components", ArgumentSemantic.Copy)]
        NSObject[] Components { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTCallout New();
    }

    // @interface HTCalloutView : UIStackView
    [BaseType(typeof(UIStackView), Name = "_TtC10HyperTrack13HTCalloutView")]
    interface HTCalloutView
    {
        // @property (nonatomic, strong) HTCallout * _Nullable data;
        [NullAllowed, Export("data", ArgumentSemantic.Strong)]
        HTCallout Data { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @protocol HTColorProviderProtocol
    [Protocol, Model]
    interface HTColorProviderProtocol
    {
        // @required @property (readonly, nonatomic, strong) UIColor * _Nonnull text;
        [Abstract]
        [Export("text", ArgumentSemantic.Strong)]
        UIColor Text { get; }

        // @required @property (readonly, getter = default, nonatomic, strong) UIColor * _Nonnull default_;
        [Abstract]
        [Export("default_", ArgumentSemantic.Strong)]
        UIColor Default_ { [Bind("default")] get; }

        // @required @property (readonly, nonatomic, strong) UIColor * _Nonnull primary;
        [Abstract]
        [Export("primary", ArgumentSemantic.Strong)]
        UIColor Primary { get; }

        // @required @property (readonly, nonatomic, strong) UIColor * _Nonnull secondary;
        [Abstract]
        [Export("secondary", ArgumentSemantic.Strong)]
        UIColor Secondary { get; }

        // @required @property (readonly, nonatomic, strong) UIColor * _Nonnull gray;
        [Abstract]
        [Export("gray", ArgumentSemantic.Strong)]
        UIColor Gray { get; }

        // @required @property (readonly, nonatomic, strong) UIColor * _Nonnull error;
        [Abstract]
        [Export("error", ArgumentSemantic.Strong)]
        UIColor Error { get; }

        // @required @property (readonly, nonatomic, strong) UIColor * _Nonnull brand;
        [Abstract]
        [Export("brand", ArgumentSemantic.Strong)]
        UIColor Brand { get; }

        // @required @property (readonly, nonatomic, strong) UIColor * _Nonnull positive;
        [Abstract]
        [Export("positive", ArgumentSemantic.Strong)]
        UIColor Positive { get; }

        // @required @property (readonly, nonatomic, strong) UIColor * _Nonnull dropShadow;
        [Abstract]
        [Export("dropShadow", ArgumentSemantic.Strong)]
        UIColor DropShadow { get; }

        // @required @property (readonly, nonatomic, strong) UIColor * _Nonnull errorDark;
        [Abstract]
        [Export("errorDark", ArgumentSemantic.Strong)]
        UIColor ErrorDark { get; }

        // @required @property (readonly, nonatomic, strong) UIColor * _Nonnull lightGray;
        [Abstract]
        [Export("lightGray", ArgumentSemantic.Strong)]
        UIColor LightGray { get; }
    }

    // @protocol HTComponentProtocol <HTBasicComponentProtocol>
    [Protocol, Model]
    interface HTComponentProtocol : HTBasicComponentProtocol
    {
        // @required @property (readonly, nonatomic) enum HTComponentType type;
        [Abstract]
        [Export("type")]
        HTComponentType Type { get; }
    }

    // @protocol HTDateSwitcherViewDelegate
    [Protocol, Model]
    interface HTDateSwitcherViewDelegate
    {
        // @required -(void)dateChanged:(NSDate * _Nonnull)date;
        [Abstract]
        [Export("dateChanged:")]
        void DateChanged(NSDate date);

        // @required -(void)openCalendar:(BOOL)open selectedDate:(NSDate * _Nonnull)selectedDate;
        [Abstract]
        [Export("openCalendar:selectedDate:")]
        void OpenCalendar(bool open, NSDate selectedDate);
    }

    // @interface HTDebouncer : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack11HTDebouncer")]
    [DisableDefaultCtor]
    interface HTDebouncer
    {
        // -(instancetype _Nonnull)initWithDelay:(double)delay callback:(void (^ _Nonnull)(void))callback __attribute__((objc_designated_initializer));
        [Export("initWithDelay:callback:")]
        [DesignatedInitializer]
        IntPtr Constructor(double delay, Action callback);

        // -(void)call;
        [Export("call")]
        void Call();

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTDebouncer New();
    }

    // @interface HTError : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack7HTError")]
    [DisableDefaultCtor]
    interface HTError
    {
        // @property (readonly, nonatomic) enum HTErrorCode errorCode;
        [Export("errorCode")]
        HTErrorCode ErrorCode { get; }

        // @property (copy, nonatomic) NSString * _Nonnull errorMessage;
        [Export("errorMessage")]
        string ErrorMessage { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull displayErrorMessage;
        [Export("displayErrorMessage")]
        string DisplayErrorMessage { get; }

        // -(NSString * _Nonnull)toJson __attribute__((warn_unused_result));
        [Export("toJson")]
        string ToJson { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTError New();
    }

    // @protocol HTEventsDelegate
    [Protocol, Model]
    interface HTEventsDelegate
    {
        // @required -(void)didReceiveEvent:(HyperTrackEvent * _Nonnull)event;
        [Abstract]
        [Export("didReceiveEvent:")]
        void DidReceiveEvent(HyperTrackEvent @event);

        // @required -(void)didFailWithError:(HTError * _Nonnull)error;
        [Abstract]
        [Export("didFailWithError:")]
        void DidFailWithError(HTError error);

        // @optional -(void)locationStatusChangedForAction:(HTAction * _Nonnull)action isEnabled:(BOOL)isEnabled;
        [Export("locationStatusChangedForAction:isEnabled:")]
        void LocationStatusChangedForAction(HTAction action, bool isEnabled);

        // @optional -(void)networkStatusChangedForAction:(HTAction * _Nonnull)action isConnected:(BOOL)isConnected;
        [Export("networkStatusChangedForAction:isConnected:")]
        void NetworkStatusChangedForAction(HTAction action, bool isConnected);

        // @optional -(void)actionStatusChangedForAction:(HTAction * _Nonnull)forAction toStatus:(NSString * _Nullable)toStatus;
        [Export("actionStatusChangedForAction:toStatus:")]
        void ActionStatusChangedForAction(HTAction forAction, [NullAllowed] string toStatus);

        // @optional -(void)didRefreshDataForAction:(HTAction * _Nonnull)forAction;
        [Export("didRefreshDataForAction:")]
        void DidRefreshDataForAction(HTAction forAction);

        // @optional -(void)didRefreshDataForCollectionId:(NSString * _Nonnull)forCollectionId actions:(NSArray<HTAction *> * _Nullable)actions;
        [Export("didRefreshDataForCollectionId:actions:")]
        void DidRefreshDataForCollectionId(string forCollectionId, [NullAllowed] HTAction[] actions);

        // @optional -(void)didEnterMonitoredRegionWithRegion:(CLRegion * _Nonnull)region;
        [Export("didEnterMonitoredRegionWithRegion:")]
        void DidEnterMonitoredRegionWithRegion(CLRegion region);

        // @optional -(void)didShowSummaryForAction:(HTAction * _Nonnull)forAction;
        [Export("didShowSummaryForAction:")]
        void DidShowSummaryForAction(HTAction forAction);
    }

    // @protocol HTFontProviderProtocol
    [Protocol, Model]
    interface HTFontProviderProtocol
    {
        // @required -(UIFont * _Nonnull)getFont:(enum HTSize)size weight:(enum HTFontWeight)weight __attribute__((warn_unused_result));
        [Abstract]
        [Export("getFont:weight:")]
        UIFont Weight(HTSize size, HTFontWeight weight);
    }

    // @interface HTGeoJSONLocation : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack17HTGeoJSONLocation")]
    [DisableDefaultCtor]
    interface HTGeoJSONLocation
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull type;
        [Export("type")]
        string Type { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull coordinates;
        [Export("coordinates", ArgumentSemantic.Copy)]
        NSNumber[] Coordinates { get; }

        // -(instancetype _Nonnull)initWithType:(NSString * _Nonnull)type coordinates:(CLLocationCoordinate2D)coordinates __attribute__((objc_designated_initializer));
        [Export("initWithType:coordinates:")]
        [DesignatedInitializer]
        IntPtr Constructor(string type, CLLocationCoordinate2D coordinates);

        // -(instancetype _Nullable)initWithDict:(NSDictionary<NSString *,id> * _Nonnull)dict __attribute__((objc_designated_initializer));
        [Export("initWithDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> dict);

        // -(NSDictionary<NSString *,id> * _Nonnull)toDict __attribute__((warn_unused_result));
        [Export("toDict")]
        NSDictionary<NSString, NSObject> ToDict { get; }

        // -(NSString * _Nullable)toJson __attribute__((warn_unused_result));
        [NullAllowed, Export("toJson")]
        string ToJson { get; }

        // +(HTGeoJSONLocation * _Nullable)fromDictWithDict:(NSDictionary<NSString *,id> * _Nonnull)dict __attribute__((warn_unused_result));
        [Static]
        [Export("fromDictWithDict:")]
        [return: NullAllowed]
        HTGeoJSONLocation FromDictWithDict(NSDictionary<NSString, NSObject> dict);

        // -(CLLocationCoordinate2D)toCoordinate2d __attribute__((warn_unused_result));
        [Export("toCoordinate2d")]
        CLLocationCoordinate2D ToCoordinate2d { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTGeoJSONLocation New();
    }

    // @interface HTHealth : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack8HTHealth")]
    [DisableDefaultCtor]
    interface HTHealth
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable batteryStatus;
        [NullAllowed, Export("batteryStatus")]
        string BatteryStatus { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable locationStatus;
        [NullAllowed, Export("locationStatus")]
        string LocationStatus { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable networkStatus;
        [NullAllowed, Export("networkStatus")]
        string NetworkStatus { get; }

        // -(instancetype _Nonnull)initWithDict:(NSDictionary<NSString *,id> * _Nonnull)dict __attribute__((objc_designated_initializer));
        [Export("initWithDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> dict);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTHealth New();
    }

    // @interface HTLabel : UILabel
    [BaseType(typeof(UILabel), Name = "_TtC10HyperTrack7HTLabel")]
    interface HTLabel
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
 
    }

    // @protocol HTLayerProviderProtocol
    // [Protocol, Model]
    [Protocol]
    interface HTLayerProviderProtocol
    {
        // @required @property (readonly, nonatomic) CGFloat cornerRadius;
        //[Abstract]
        [Export("cornerRadius")]
        nfloat GetCornerRadius();

        // @required @property (readonly, nonatomic) CGFloat borderWidth;
        //[Abstract]
        [Export("borderWidth")]
        nfloat GetBorderWidth();
    }

    // @protocol HTTrackingViewProviderProtocol
    [Protocol, Model]
    interface HTTrackingViewProviderProtocol
    {
        [Wrap("WeakDelegate"), Abstract]
        [NullAllowed]
        HTBottomViewUseCaseDelegate Delegate { get; set; }

        // @required @property (nonatomic, strong) id<HTBottomViewUseCaseDelegate> _Nullable delegate;
        [Abstract]
        [NullAllowed, Export("delegate", ArgumentSemantic.Strong)]
        NSObject WeakDelegate { get; set; }

        // @required @property (readonly, nonatomic, strong) UIView * _Nonnull containerView;
        [Abstract]
        [Export("containerView", ArgumentSemantic.Strong)]
        UIView ContainerView { get; }

        // @required -(void)updateData:(NSArray<id<HTComponentProtocol>> * _Nonnull)data;
        [Abstract]
        [Export("updateData:")]
        void UpdateData(NSObject[] data);

        // @required -(void)reloadData;
        [Abstract]
        [Export("reloadData")]
        void ReloadData();
    }

    // @protocol HTLiveTrackingStackViewProviderProtocol <HTTrackingViewProviderProtocol>
    [Protocol, Model]
    interface HTLiveTrackingStackViewProviderProtocol : HTTrackingViewProviderProtocol
    {
    }

    // @interface HTLiveTrackingUseCase : HTBaseTrackingUseCase <HTMapViewUseCase>
    [BaseType(typeof(HTBaseTrackingUseCase), Name = "_TtC10HyperTrack21HTLiveTrackingUseCase")]
    interface HTLiveTrackingUseCase : HTBaseTrackingUseCase
    {
        [Wrap("WeakTrackingDelegate")]
        [NullAllowed]
        NSObject TrackingDelegate { get; set; }

        // @property (nonatomic, weak) id<HTLiveTrackingUseCaseDelegate> _Nullable trackingDelegate;
        [NullAllowed, Export("trackingDelegate", ArgumentSemantic.Weak)]
        NSObject WeakTrackingDelegate { get; set; }

        [Wrap("WeakCustomizationDelegate")]
        [NullAllowed]
        NSObject CustomizationDelegate { get; set; }

        // @property (nonatomic, weak) id<HTTrackingCustomizationUseCaseDelegate> _Nullable customizationDelegate;
        [NullAllowed, Export("customizationDelegate", ArgumentSemantic.Weak)]
        NSObject WeakCustomizationDelegate { get; set; }

        // @property (nonatomic, strong) UIButton * _Nonnull primaryActionButton;
        [Export("primaryActionButton", ArgumentSemantic.Strong)]
        UIButton PrimaryActionButton { get; set; }

        // @property (nonatomic) BOOL isPrimaryActionHidden;
        [Export("isPrimaryActionHidden")]
        bool IsPrimaryActionHidden { get; set; }

        // @property (nonatomic) BOOL isBackButtonHidden;
        [Export("isBackButtonHidden")]
        bool IsBackButtonHidden { get; set; }

        // @property (nonatomic) BOOL isTrackingEnabled;
        [Export("isTrackingEnabled")]
        bool IsTrackingEnabled { get; set; }

        [Wrap("WeakNavigationDelegate")]
        [NullAllowed]
        NSObject NavigationDelegate { get; set; }

        // @property (nonatomic, weak) id<HTUseCaseNavigationDelegate> _Nullable navigationDelegate;
        [NullAllowed, Export("navigationDelegate", ArgumentSemantic.Weak)]
        NSObject WeakNavigationDelegate { get; set; }

        [Wrap("WeakMapDelegate")]
        [NullAllowed]
        NSObject MapDelegate { get; set; }

        // @property (nonatomic, strong) id<HTMapUseCaseDelegate> _Nullable mapDelegate;
        [NullAllowed, Export("mapDelegate", ArgumentSemantic.Strong)]
        NSObject WeakMapDelegate { get; set; }

        // -(void)update;
        [Export("update")]
        void Update();

        // +(instancetype _Nonnull)new;
        [Static]
        [Export("new")]
        HTLiveTrackingUseCase New();

        // -(instancetype _Nonnull)initWithMapDelegate:(id<HTMapUseCaseDelegate> _Nullable)mapDelegate;
        [Export("initWithMapDelegate:")]
        IntPtr Constructor([NullAllowed] NSObject mapDelegate);

        // -(instancetype _Nonnull)initWithViewModel:(id<HTLiveTrackingUseCaseViewModelProtocol> _Nullable)viewModel provider:(id<HTLiveTrackingStackViewProviderProtocol> _Nullable)provider __attribute__((objc_designated_initializer));
        [Export("initWithViewModel:provider:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] NSObject viewModel, [NullAllowed] NSObject provider);

        // -(void)stop;
        [Export("stop")]
        void Stop();

        // -(void)trackActionWithType:(HTTrackWithTypeData * _Nonnull)type pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithType:pollDuration:completionHandler:")]
        void TrackActionWithType(HTTrackWithTypeData type, double pollDuration, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)trackActionWithIds:(NSArray<NSString *> * _Nonnull)ids pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithIds:pollDuration:completionHandler:")]
        void TrackActionWithIds(string[] ids, double pollDuration, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)trackActionWithCollectionId:(NSString * _Nonnull)id pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithCollectionId:pollDuration:completionHandler:")]
        void TrackActionWithCollectionId(string id, double pollDuration, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)trackActionWithUniqueId:(NSString * _Nonnull)id pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithUniqueId:pollDuration:completionHandler:")]
        void TrackActionWithUniqueId(string id, double pollDuration, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)trackActionWithShortCodes:(NSArray<NSString *> * _Nonnull)codes pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithShortCodes:pollDuration:completionHandler:")]
        void TrackActionWithShortCodes(string[] codes, double pollDuration, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);
    }

    // @protocol HTUseCaseBackNavigationProtocol
    [Protocol, Model]
    interface HTUseCaseBackNavigationProtocol
    {
        // @required @property (nonatomic, strong) UIButton * _Nonnull primaryActionButton;
        [Abstract]
        [Export("primaryActionButton", ArgumentSemantic.Strong)]
        UIButton PrimaryActionButton { get; set; }

        // @required @property (nonatomic) BOOL isPrimaryActionHidden;
        [Abstract]
        [Export("isPrimaryActionHidden")]
        bool IsPrimaryActionHidden { get; set; }

        [Wrap("WeakNavigationDelegate"), Abstract]
        [NullAllowed]
        NSObject NavigationDelegate { get; set; }

        // @required @property (nonatomic, strong) id<HTUseCaseNavigationDelegate> _Nullable navigationDelegate;
        [Abstract]
        [NullAllowed, Export("navigationDelegate", ArgumentSemantic.Strong)]
        NSObject WeakNavigationDelegate { get; set; }

        // @required -(void)performActionOnButtonClick;
        [Abstract]
        [Export("performActionOnButtonClick")]
        void PerformActionOnButtonClick();
    }

    // @interface HyperTrack_Swift_952 (HTLiveTrackingUseCase) <HTUseCaseBackNavigationProtocol>
    [Category]
    [BaseType(typeof(HTLiveTrackingUseCase))]
    interface HTLiveTrackingUseCase_HyperTrack_Swift_952
    {
        // -(void)performActionOnButtonClick;
        [Export("performActionOnButtonClick")]
        void PerformActionOnButtonClick();
    }

    // @interface HyperTrack_Swift_957 (HTLiveTrackingUseCase) <HTUseCaseNavigationDelegate>
    [Category]
    [BaseType(typeof(HTLiveTrackingUseCase))]
    interface HTLiveTrackingUseCase_HyperTrack_Swift_957
    {
        // -(void)backClicked;
        [Export("backClicked")]
        void BackClicked();
    }

    // @interface HyperTrack_Swift_962 (HTLiveTrackingUseCase)
    [Category]
    [BaseType(typeof(HTLiveTrackingUseCase))]
    interface HTLiveTrackingUseCase_HyperTrack_Swift_962
    {
    }

    // @interface LiveData : NSObject
    [BaseType(typeof(NSObject), Name = "_TtCC10HyperTrack21HTLiveTrackingUseCase8LiveData")]
    [DisableDefaultCtor]
    interface LiveData
    {
        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LiveData New();
    }

    // @interface HyperTrack_Swift_973 (HTLiveTrackingUseCase) <HTBottomViewUseCaseDelegate>
    [Category]
    [BaseType(typeof(HTLiveTrackingUseCase))]
    interface HTLiveTrackingUseCase_HyperTrack_Swift_973 
    {
        // -(void)actionPerformed:(HTBottomViewActionData * _Nonnull)data;
        [Export("actionPerformed:")]
        void ActionPerformed(HTBottomViewActionData data);
    }

    // @protocol HTPlaceSelectionDelegate <HTAuxillaryFlowDelegate>
    [Protocol, Model]
    interface HTPlaceSelectionDelegate : HTAuxillaryFlowDelegate
    {
        // @required -(void)expectedPlaceSet:(HTPlace * _Nonnull)data;
        [Abstract]
        [Export("expectedPlaceSet:")]
        void ExpectedPlaceSet(HTPlace data);
    }

    // @interface HyperTrack_Swift_984 (HTLiveTrackingUseCase) <HTPlaceSelectionDelegate>
    [Category]
    [BaseType(typeof(HTLiveTrackingUseCase))]
    interface HTLiveTrackingUseCase_HyperTrack_Swift_984 
    {
        // -(void)cancelClicked;
        [Export("cancelClicked")]
        void CancelClicked();

        // -(void)expectedPlaceSet:(HTPlace * _Nonnull)data;
        [Export("expectedPlaceSet:")]
        void ExpectedPlaceSet(HTPlace data);
    }

    // @protocol HTLiveTrackingUseCaseViewModelProtocol <HTBaseTrackingViewModelProtocol>
    [Protocol, Model]
    interface HTLiveTrackingUseCaseViewModelProtocol : HTBaseTrackingViewModelProtocol
    {
        // @required @property (nonatomic, strong) TrackingInfo * _Nonnull trackingInfo;
        [Abstract]
        [Export("trackingInfo", ArgumentSemantic.Strong)]
        NSObject TrackingInfo { get; set; }

        // @required -(LiveData * _Nonnull)mapToLiveTrackingUseCaseWithActions:(NSArray<HTTrackAction *> * _Nonnull)actions __attribute__((warn_unused_result));
        [Abstract]
        [Export("mapToLiveTrackingUseCaseWithActions:")]
        LiveData MapToLiveTrackingUseCaseWithActions(HTTrackAction[] actions);

        // @required -(void)mapToLiveTrackingUseCaseWithActions:(NSArray<HTTrackAction *> * _Nonnull)actions completionHandler:(void (^ _Nonnull)(LiveData * _Nonnull))completionHandler;
        [Abstract]
        [Export("mapToLiveTrackingUseCaseWithActions:completionHandler:")]
        void MapToLiveTrackingUseCaseWithActions(HTTrackAction[] actions, Action<LiveData> completionHandler);
    }

    // @interface HTLiveTrackingUseCaseViewModel : HTBaseTrackingViewModel <HTLiveTrackingUseCaseViewModelProtocol>
    [BaseType(typeof(HTBaseTrackingViewModel), Name = "_TtC10HyperTrack30HTLiveTrackingUseCaseViewModel")]
    interface HTLiveTrackingUseCaseViewModel : HTLiveTrackingUseCaseViewModelProtocol
    {
        // @property (nonatomic, strong) TrackingInfo * _Nonnull trackingInfo;
        [Export("trackingInfo", ArgumentSemantic.Strong)]
        NSObject TrackingInfo { get; set; }

        // -(void)mapToLiveTrackingUseCaseWithActions:(NSArray<HTTrackAction *> * _Nonnull)actions completionHandler:(void (^ _Nonnull)(LiveData * _Nonnull))completionHandler;
        [Export("mapToLiveTrackingUseCaseWithActions:completionHandler:")]
        void MapToLiveTrackingUseCaseWithActions(HTTrackAction[] actions, Action<LiveData> completionHandler);

        // -(LiveData * _Nonnull)mapToLiveTrackingUseCaseWithActions:(NSArray<HTTrackAction *> * _Nonnull)actions __attribute__((warn_unused_result));
        [Export("mapToLiveTrackingUseCaseWithActions:")]
        LiveData MapToLiveTrackingUseCaseWithActions(HTTrackAction[] actions);
    }

    // @interface HTLocation : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack10HTLocation")]
    [DisableDefaultCtor]
    interface HTLocation
    {
        // @property (copy, nonatomic) NSString * _Nullable lookUpId;
        [NullAllowed, Export("lookUpId")]
        string LookUpId { get; set; }

        // @property (readonly, nonatomic, strong) HTGeoJSONLocation * _Nonnull location;
        [Export("location", ArgumentSemantic.Strong)]
        HTGeoJSONLocation Location { get; }

        // @property (readonly, nonatomic, strong) CLLocation * _Nonnull clLocation;
        [Export("clLocation", ArgumentSemantic.Strong)]
        CLLocation ClLocation { get; }

        // @property (readonly, nonatomic) CLLocationAccuracy horizontalAccuracy;
        [Export("horizontalAccuracy")]
        double HorizontalAccuracy { get; }

        // @property (readonly, nonatomic) CLLocationAccuracy verticalAccuracy;
        [Export("verticalAccuracy")]
        double VerticalAccuracy { get; }

        // @property (readonly, nonatomic) CLLocationSpeed speed;
        [Export("speed")]
        double Speed { get; }

        // @property (readonly, nonatomic) CLLocationDirection bearing;
        [Export("bearing")]
        double Bearing { get; }

        // @property (readonly, nonatomic) CLLocationDistance altitude;
        [Export("altitude")]
        double Altitude { get; }

        // @property (copy, nonatomic) NSString * _Nonnull activityLookUpId;
        [Export("activityLookUpId")]
        string ActivityLookUpId { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull provider;
        [Export("provider")]
        string Provider { get; }

        // @property (copy, nonatomic) NSDate * _Nonnull recordedAt;
        [Export("recordedAt", ArgumentSemantic.Copy)]
        NSDate RecordedAt { get; set; }

        // @property (copy, nonatomic) NSDate * _Nullable uploadTime;
        [NullAllowed, Export("uploadTime", ArgumentSemantic.Copy)]
        NSDate UploadTime { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable activityConfidence;
        [NullAllowed, Export("activityConfidence")]
        string ActivityConfidence { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable activity;
        [NullAllowed, Export("activity")]
        string Activity { get; }

        // @property (readonly, nonatomic, strong) HTGeoJSONLocation * _Nullable geojson;
        [NullAllowed, Export("geojson", ArgumentSemantic.Strong)]
        HTGeoJSONLocation Geojson { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable accuracy;
        [NullAllowed, Export("accuracy")]
        string Accuracy { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTLocation New();
    }

    // @interface HTLocationCoordinate : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack20HTLocationCoordinate")]
    [DisableDefaultCtor]
    interface HTLocationCoordinate
    {
        // @property (readonly, nonatomic) double lat;
        [Export("lat")]
        double Lat { get; }

        // @property (readonly, nonatomic) double lng;
        [Export("lng")]
        double Lng { get; }

        // -(instancetype _Nonnull)initWithLat:(double)lat lng:(double)lng __attribute__((objc_designated_initializer));
        [Export("initWithLat:lng:")]
        [DesignatedInitializer]
        IntPtr Constructor(double lat, double lng);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTLocationCoordinate New();
    }

    // @interface HTLocationSearchProvider : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack24HTLocationSearchProvider")]
    interface HTLocationSearchProvider
    {
        // @property (copy, nonatomic) NSArray<HTPlace *> * _Nonnull data;
        [Export("data", ArgumentSemantic.Copy)]
        HTPlace[] Data { get; set; }

        // @property (nonatomic, strong) HTPlace * _Nullable selectedResult;
        [NullAllowed, Export("selectedResult", ArgumentSemantic.Strong)]
        HTPlace SelectedResult { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull searchBarPlaceHolderText;
        [Export("searchBarPlaceHolderText")]
        string SearchBarPlaceHolderText { get; set; }

        // @property (nonatomic) BOOL enableCurrentLocationSelection;
        [Export("enableCurrentLocationSelection")]
        bool EnableCurrentLocationSelection { get; set; }

        // @property (nonatomic) BOOL enableChooseOnMapSelection;
        [Export("enableChooseOnMapSelection")]
        bool EnableChooseOnMapSelection { get; set; }

        // @property (readonly, nonatomic, strong) UIView * _Nonnull contentView;
        [Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; }

        // -(instancetype _Nonnull)init:(NSArray<HTPlace *> * _Nonnull)data __attribute__((objc_designated_initializer));
        [Export("init:")]
        [DesignatedInitializer]
        IntPtr Constructor(HTPlace[] data);

        // -(void)updateData:(NSArray<HTPlace *> * _Nonnull)data;
        [Export("updateData:")]
        void UpdateData(HTPlace[] data);

        // -(void)reloadData;
        [Export("reloadData")]
        void ReloadData();

        // -(void)clear;
        [Export("clear")]
        void Clear();
    }

    // @interface HyperTrack_Swift_1072 (HTLocationSearchProvider) <UITextFieldDelegate>
    [Category]
    [BaseType(typeof(HTLocationSearchProvider))]
    interface HTLocationSearchProvider_HyperTrack_Swift_1072
    {
        // -(BOOL)textFieldShouldReturn:(UITextField * _Nonnull)textField __attribute__((warn_unused_result));
        [Export("textFieldShouldReturn:")]
        bool TextFieldShouldReturn(UITextField textField);

        // -(BOOL)textField:(UITextField * _Nonnull)textField shouldChangeCharactersInRange:(NSRange)range replacementString:(NSString * _Nonnull)string __attribute__((warn_unused_result));
        [Export("textField:shouldChangeCharactersInRange:replacementString:")]
        bool TextField(UITextField textField, NSRange range, string @string);
    }

    // @interface HyperTrack_Swift_1080 (HTLocationSearchProvider) <UITableViewDataSource>
    [Category]
    [BaseType(typeof(HTLocationSearchProvider))]
    interface HTLocationSearchProvider_HyperTrack_Swift_1080 
    {
        // -(NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((warn_unused_result));
        [Export("numberOfSectionsInTableView:")]
        nint NumberOfSectionsInTableView(UITableView tableView);

        // -(NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section __attribute__((warn_unused_result));
        [Export("tableView:numberOfRowsInSection:")]
        nint TableView(UITableView tableView, nint section);

        // -(UITableViewCell * _Nonnull)tableView:(UITableView * _Nonnull)tableView cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
        [Export("tableView:cellForRowAtIndexPath:")]
        UITableViewCell TableView(UITableView tableView, NSIndexPath indexPath);
    }

    // @interface HyperTrack_Swift_1087 (HTLocationSearchProvider) <UITableViewDelegate>
    [Category]
    [BaseType(typeof(HTLocationSearchProvider))]
    interface HTLocationSearchProvider_HyperTrack_Swift_1087
    {
        // -(void)tableView:(UITableView * _Nonnull)tableView didSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:didSelectRowAtIndexPath:")]
        void TableView(UITableView tableView, NSIndexPath indexPath);

        // -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForHeaderInSection:(NSInteger)section __attribute__((warn_unused_result));
        [Export("tableView:heightForHeaderInSection:")]
        nfloat TableView(UITableView tableView, nint section);
    }

    // @protocol HTLocationUpdatesDelegate
    [Protocol, Model]
    interface HTLocationUpdatesDelegate
    {
        // @required -(void)didUpdateLocations:(NSArray<CLLocation *> * _Nonnull)locations;
        [Abstract]
        [Export("didUpdateLocations:")]
        void DidUpdateLocations(CLLocation[] locations);
    }

    // @interface HTLogger : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack8HTLogger")]
    [DisableDefaultCtor]
    interface HTLogger
    {
        // @property (readonly, nonatomic, strong, class) HTLogger * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        HTLogger Shared { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTLogger New();
    }

    // @interface HTMapContainer : UIView
    [BaseType(typeof(UIView), Name = "_TtC10HyperTrack14HTMapContainer")]
    interface HTMapContainer
    {
        // @property (nonatomic) BOOL showCurrentLocation;
        [Export("showCurrentLocation")]
        bool ShowCurrentLocation { get; set; }

        // @property (nonatomic) BOOL enableZoom;
        [Export("enableZoom")]
        bool EnableZoom { get; set; }

        // @property (nonatomic) BOOL isRecenterButtonHidden;
        [Export("isRecenterButtonHidden")]
        bool IsRecenterButtonHidden { get; set; }

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame mapProvider:(id<HTMapsProviderProtocol> _Nonnull)mapProvider __attribute__((objc_designated_initializer));
        [Export("initWithFrame:mapProvider:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame, NSObject mapProvider);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
 

        // -(void)setBottomViewWithUseCase:(id<HTMapViewUseCase> _Nonnull)useCase;
        [Export("setBottomViewWithUseCase:")]
        void SetBottomViewWithUseCase(NSObject useCase);
    }

    // @protocol HTMapViewUpdatesDelegate
    [Protocol, Model]
    interface HTMapViewUpdatesDelegate
    {
        // @required -(void)mapViewDidChangeWithCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate;
        [Abstract]
        [Export("mapViewDidChangeWithCenterCoordinate:")]
        void MapViewDidChangeWithCenterCoordinate(CLLocationCoordinate2D centerCoordinate);
    }

    // @interface HyperTrack_Swift_1133 (HTMapContainer) <HTMapViewUpdatesDelegate>
    [Category]
    [BaseType(typeof(HTMapContainer))]
    interface HTMapContainer_HyperTrack_Swift_1133 
    {
        // -(void)mapViewDidChangeWithCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate;
        [Export("mapViewDidChangeWithCenterCoordinate:")]
        void MapViewDidChangeWithCenterCoordinate(CLLocationCoordinate2D centerCoordinate);
    }

    // @protocol HTMapUseCaseDelegate <HTMapViewDelegate>
    [Protocol, Model]
    interface HTMapUseCaseDelegate : HTMapViewDelegate
    {
        // @required -(void)showErrorWithText:(NSString * _Nullable)text;
        [Abstract]
        [Export("showErrorWithText:")]
        void ShowErrorWithText([NullAllowed] string text);

        // @required -(void)setBottomView:(UIView * _Nullable)view;
        [Abstract]
        [Export("setBottomView:")]
        void SetBottomView([NullAllowed] UIView view);

        // @required -(void)setBottomView:(UIView * _Nullable)view atPosition:(enum HTSwipePosition)atPosition;
        [Abstract]
        [Export("setBottomView:atPosition:")]
        void SetBottomView([NullAllowed] UIView view, HTSwipePosition atPosition);

        // @required -(CGFloat)updateBottomViewPosition:(enum HTSwipePosition)position __attribute__((warn_unused_result));
        [Abstract]
        [Export("updateBottomViewPosition:")]
        nfloat UpdateBottomViewPosition(HTSwipePosition position);

        // @required -(void)setPrimaryAction:(UIView * _Nullable)view anchor:(enum AnchorPosition)anchor;
        [Abstract]
        [Export("setPrimaryAction:anchor:")]
        void SetPrimaryAction([NullAllowed] UIView view, AnchorPosition anchor);

        // @required -(void)setCenterFloatingView:(UIView * _Nullable)view offset:(CGPoint)offset;
        [Abstract]
        [Export("setCenterFloatingView:offset:")]
        void SetCenterFloatingView([NullAllowed] UIView view, CGPoint offset);

        // @required -(void)setMapViewUpdatesDelegate:(id<HTMapViewUpdatesDelegate> _Nullable)delegate;
        [Abstract]
        [Export("setMapViewUpdatesDelegate:")]
        void SetMapViewUpdatesDelegate([NullAllowed] NSObject @delegate);

        // @required @property (nonatomic) BOOL enableZoom;
        [Abstract]
        [Export("enableZoom")]
        bool EnableZoom { get; set; }

        // @required -(CGFloat)getBottomPadding __attribute__((warn_unused_result));
        [Abstract]
        [Export("getBottomPadding")]
        nfloat BottomPadding { get; }
    }

    // @interface HyperTrack_Swift_1157 (HTMapContainer) <HTMapUseCaseDelegate>
    [Category]
    [BaseType(typeof(HTMapContainer))]
    interface HTMapContainer_HyperTrack_Swift_1157 
    {
        // -(CGFloat)getBottomPadding __attribute__((warn_unused_result));
        [Export("getBottomPadding")]
        nfloat GetBottomPadding();
        // -(CGFloat)updateBottomViewPosition:(enum HTSwipePosition)position __attribute__((warn_unused_result));
        [Export("updateBottomViewPosition:")]
        nfloat UpdateBottomViewPosition(HTSwipePosition position);

        // -(void)setBottomView:(UIView * _Nullable)view atPosition:(enum HTSwipePosition)atPosition;
        [Export("setBottomView:atPosition:")]
        void SetBottomView([NullAllowed] UIView view, HTSwipePosition atPosition);

        // -(void)cleanUp;
        [Export("cleanUp")]
        void CleanUp();

        // -(void)addAnnotations:(NSArray<HTAnnotationData *> * _Nonnull)data;
        [Export("addAnnotations:")]
        void AddAnnotations(HTAnnotationData[] data);

        // -(void)addPolyline:(NSArray<HTPolylineData *> * _Nonnull)data;
        [Export("addPolyline:")]
        void AddPolyline(HTPolylineData[] data);

        // -(void)addTrailingPolyline:(NSArray<HTTimeAwarePolyline *> * _Nonnull)data;
        [Export("addTrailingPolyline:")]
        void AddTrailingPolyline(HTTimeAwarePolyline[] data);

        // -(void)updateMapVisibleRegion:(UIEdgeInsets)insets;
        [Export("updateMapVisibleRegion:")]
        void UpdateMapVisibleRegion(UIEdgeInsets insets);

        // -(void)setBottomView:(UIView * _Nullable)view;
        [Export("setBottomView:")]
        void SetBottomView([NullAllowed] UIView view);

        // -(void)setPrimaryAction:(UIView * _Nullable)view anchor:(enum AnchorPosition)anchor;
        [Export("setPrimaryAction:anchor:")]
        void SetPrimaryAction([NullAllowed] UIView view, AnchorPosition anchor);

        // -(void)setCenterFloatingView:(UIView * _Nullable)view offset:(CGPoint)offset;
        [Export("setCenterFloatingView:offset:")]
        void SetCenterFloatingView([NullAllowed] UIView view, CGPoint offset);

        // -(CLLocationCoordinate2D)getCenterCoordinates __attribute__((warn_unused_result));
        [Export("getCenterCoordinates")]
        CLLocationCoordinate2D GetCenterCoordinates();

        // -(void)showErrorWithText:(NSString * _Nullable)text;
        [Export("showErrorWithText:")]
        void ShowErrorWithText([NullAllowed] string text);

        // -(void)setMapViewUpdatesDelegate:(id<HTMapViewUpdatesDelegate> _Nullable)delegate;
        [Export("setMapViewUpdatesDelegate:")]
        void SetMapViewUpdatesDelegate([NullAllowed] NSObject @delegate);

        // -(void)showCoordinates:(NSArray<NSValue *> * _Nonnull)coordinates;
        [Export("showCoordinates:")]
        void ShowCoordinates(NSValue[] coordinates);
    }

    // @protocol HTMapCustomizationDelegate
    [Protocol, Model]
    interface HTMapCustomizationDelegate
    {
        // @optional -(UIImage * _Nullable)userMarkerImageWithAnnotationType:(enum HTAnnotationType)annotationType __attribute__((warn_unused_result));
        [Export("userMarkerImageWithAnnotationType:")]
        [return: NullAllowed]
        UIImage UserMarkerImageWithAnnotationType(HTAnnotationType annotationType);

        // @optional -(UIImage * _Nullable)userMarkerImageWithActionInfo:(HTActionInfo * _Nonnull)actionInfo __attribute__((warn_unused_result));
        [Export("userMarkerImageWithActionInfo:")]
        [return: NullAllowed]
        UIImage UserMarkerImageWithActionInfo(HTActionInfo actionInfo);

        // @optional -(UIImage * _Nullable)expectedPlaceMarkerImage __attribute__((warn_unused_result));
        [NullAllowed, Export("expectedPlaceMarkerImage")]
        UIImage ExpectedPlaceMarkerImage { get; }

        // @optional -(UIImage * _Nullable)expectedPlaceMarkerImageWithActionInfo:(HTActionInfo * _Nonnull)actionInfo __attribute__((warn_unused_result));
        [Export("expectedPlaceMarkerImageWithActionInfo:")]
        [return: NullAllowed]
        UIImage ExpectedPlaceMarkerImageWithActionInfo(HTActionInfo actionInfo);
    }

    // @interface HTMapData : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack9HTMapData")]
    [DisableDefaultCtor]
    interface HTMapData
    {
        // -(instancetype _Nonnull)initWithAnnotations:(NSArray<HTAnnotationData *> * _Nonnull)annotations polylines:(NSArray<HTPolylineData *> * _Nonnull)polylines __attribute__((objc_designated_initializer));
        [Export("initWithAnnotations:polylines:")]
        [DesignatedInitializer]
        IntPtr Constructor(HTAnnotationData[] annotations, HTPolylineData[] polylines);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTMapData New();
    }

    // @interface HTMapUtils : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack10HTMapUtils")]
    interface HTMapUtils
    {
        // +(CLLocationDegrees)headingFrom:(CLLocationCoordinate2D)previous next:(CLLocationCoordinate2D)next __attribute__((warn_unused_result));
        [Static]
        [Export("headingFrom:next:")]
        double HeadingFrom(CLLocationCoordinate2D previous, CLLocationCoordinate2D next);

        // +(double)radiansToDegreesWithRadians:(double)radians __attribute__((warn_unused_result));
        [Static]
        [Export("radiansToDegreesWithRadians:")]
        double RadiansToDegreesWithRadians(double radians);
    }

    // @interface HTMarkerContentView : UIView
    [BaseType(typeof(UIView), Name = "_TtC10HyperTrack19HTMarkerContentView")]
    interface HTMarkerContentView
    {
        // @property (nonatomic, strong) UIColor * _Nullable pulseColor;
        [NullAllowed, Export("pulseColor", ArgumentSemantic.Strong)]
        UIColor PulseColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable annotationImage;
        [NullAllowed, Export("annotationImage", ArgumentSemantic.Strong)]
        UIImage AnnotationImage { get; set; }

        // @property (nonatomic, strong) UIImageView * _Nullable imageView;
        [NullAllowed, Export("imageView", ArgumentSemantic.Strong)]
        UIImageView ImageView { get; set; }

        // @property (nonatomic) CGFloat scaleFactor;
        [Export("scaleFactor")]
        nfloat ScaleFactor { get; set; }

        // @property (nonatomic) double animationDuration;
        [Export("animationDuration")]
        double AnimationDuration { get; set; }

        // @property (nonatomic) double animationDelay;
        [Export("animationDelay")]
        double AnimationDelay { get; set; }

        // @property (nonatomic) CGSize size;
        [Export("size", ArgumentSemantic.Assign)]
        CGSize Size { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable annotationColor;
        [NullAllowed, Export("annotationColor", ArgumentSemantic.Strong)]
        UIColor AnnotationColor { get; set; }

        // @property (nonatomic) BOOL isPulsating;
        [Export("isPulsating")]
        bool IsPulsating { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame data:(HTAnnotationData * _Nullable)data;
        [Export("initWithFrame:data:")]
        IntPtr Constructor(CGRect frame, [NullAllowed] HTAnnotationData data);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
 
    }

    // @protocol HTMarkerImagesProviderProtocol
    [Protocol, Model]
    interface HTMarkerImagesProviderProtocol
    {
        // @required @property (nonatomic, strong) UIImage * _Nullable cycle;
        [Abstract]
        [NullAllowed, Export("cycle", ArgumentSemantic.Strong)]
        UIImage Cycle { get; set; }

        // @required @property (nonatomic, strong) UIImage * _Nullable destination;
        [Abstract]
        [NullAllowed, Export("destination", ArgumentSemantic.Strong)]
        UIImage Destination { get; set; }

        // @required @property (nonatomic, strong) UIImage * _Nullable drive;
        [Abstract]
        [NullAllowed, Export("drive", ArgumentSemantic.Strong)]
        UIImage Drive { get; set; }

        // @required @property (nonatomic, strong) UIImage * _Nullable offline;
        [Abstract]
        [NullAllowed, Export("offline", ArgumentSemantic.Strong)]
        UIImage Offline { get; set; }

        // @required @property (nonatomic, strong) UIImage * _Nullable stop;
        [Abstract]
        [NullAllowed, Export("stop", ArgumentSemantic.Strong)]
        UIImage Stop { get; set; }

        // @required @property (nonatomic, strong) UIImage * _Nullable walk;
        [Abstract]
        [NullAllowed, Export("walk", ArgumentSemantic.Strong)]
        UIImage Walk { get; set; }
    }

    // @interface HTMockLocationParams : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack20HTMockLocationParams")]
    [DisableDefaultCtor]
    interface HTMockLocationParams
    {
        // @property (readonly, nonatomic) CLLocationCoordinate2D origin;
        [Export("origin")]
        CLLocationCoordinate2D Origin { get; }

        // @property (readonly, nonatomic) CLLocationCoordinate2D destination;
        [Export("destination")]
        CLLocationCoordinate2D Destination { get; }

        // -(instancetype _Nonnull)initWithOrigin:(CLLocationCoordinate2D)origin destination:(CLLocationCoordinate2D)destination __attribute__((objc_designated_initializer));
        [Export("initWithOrigin:destination:")]
        [DesignatedInitializer]
        IntPtr Constructor(CLLocationCoordinate2D origin, CLLocationCoordinate2D destination);

        // -(instancetype _Nonnull)initWithDestination:(CLLocationCoordinate2D)destination __attribute__((objc_designated_initializer));
        [Export("initWithDestination:")]
        [DesignatedInitializer]
        IntPtr Constructor(CLLocationCoordinate2D destination);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTMockLocationParams New();
    }

    // @interface HTOrderTrackingBottomCard : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack25HTOrderTrackingBottomCard")]
    [DisableDefaultCtor]
    interface HTOrderTrackingBottomCard
    {
        // @property (readonly, copy, nonatomic) NSArray<id<HTComponentProtocol>> * _Nonnull components;
        [Export("components", ArgumentSemantic.Copy)]
        NSObject[] Components { get; }

        // -(instancetype _Nonnull)init:(NSArray<id<HTComponentProtocol>> * _Nonnull)components __attribute__((objc_designated_initializer));
        [Export("init:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSObject[] components);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTOrderTrackingBottomCard New();
    }

    // @protocol HTOrderTrackingStackViewProviderProtocol <HTTrackingViewProviderProtocol>
    [Protocol, Model]
    interface HTOrderTrackingStackViewProviderProtocol : HTTrackingViewProviderProtocol
    {
    }

    // @interface HTOrderTrackingUseCase : HTBaseTrackingUseCase <HTMapViewUseCase>
    [BaseType(typeof(HTBaseTrackingUseCase), Name = "_TtC10HyperTrack22HTOrderTrackingUseCase")]
    interface HTOrderTrackingUseCase : HTMapViewUseCase
    {
        [Wrap("WeakMapDelegate")]
        [NullAllowed]
        NSObject MapDelegate { get; set; }

        // @property (nonatomic, strong) id<HTMapUseCaseDelegate> _Nullable mapDelegate;
        [NullAllowed, Export("mapDelegate", ArgumentSemantic.Strong)]
        NSObject WeakMapDelegate { get; set; }

        // @property (readonly, nonatomic, strong) HTButton * _Null_unspecified primaryAction;
        [Export("primaryAction", ArgumentSemantic.Strong)]
        HTButton PrimaryAction { get; }

        [Wrap("WeakCustomizationDelegate")]
        [NullAllowed]
        NSObject CustomizationDelegate { get; set; }

        // @property (nonatomic, weak) id<HTTrackingCustomizationUseCaseDelegate> _Nullable customizationDelegate;
        [NullAllowed, Export("customizationDelegate", ArgumentSemantic.Weak)]
        NSObject WeakCustomizationDelegate { get; set; }

        // @property (nonatomic, strong) UIButton * _Nonnull primaryActionButton;
        [Export("primaryActionButton", ArgumentSemantic.Strong)]
        UIButton PrimaryActionButton { get; set; }

        // @property (nonatomic) BOOL isPrimaryActionHidden;
        [Export("isPrimaryActionHidden")]
        bool IsPrimaryActionHidden { get; set; }

        // @property (nonatomic) BOOL isBackButtonHidden;
        [Export("isBackButtonHidden")]
        bool IsBackButtonHidden { get; set; }

        [Wrap("WeakTrackingDelegate")]
        [NullAllowed]
        NSObject TrackingDelegate { get; set; }

        // @property (nonatomic, weak) id<HTOrderTrackingUseCaseDelegate> _Nullable trackingDelegate;
        [NullAllowed, Export("trackingDelegate", ArgumentSemantic.Weak)]
        NSObject WeakTrackingDelegate { get; set; }

        [Wrap("WeakNavigationDelegate")]
        [NullAllowed]
        NSObject NavigationDelegate { get; set; }

        // @property (nonatomic, weak) id<HTUseCaseNavigationDelegate> _Nullable navigationDelegate;
        [NullAllowed, Export("navigationDelegate", ArgumentSemantic.Weak)]
        NSObject WeakNavigationDelegate { get; set; }

        // +(instancetype _Nonnull)new;
        [Static]
        [Export("new")]
        HTOrderTrackingUseCase New();

        // -(instancetype _Nonnull)initWithMapDelegate:(id<HTMapUseCaseDelegate> _Nullable)mapDelegate;
        [Export("initWithMapDelegate:")]
        IntPtr Constructor([NullAllowed] NSObject mapDelegate);

        // -(instancetype _Nonnull)initWithViewModel:(id<HTOrderTrackingUseCaseViewModelProtocol> _Nullable)viewModel provider:(id<HTOrderTrackingStackViewProviderProtocol> _Nullable)provider __attribute__((objc_designated_initializer));
        [Export("initWithViewModel:provider:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] NSObject viewModel, [NullAllowed] NSObject provider);

        // -(void)stop;
        [Export("stop")]
        void Stop();

        // -(void)trackActionWithType:(HTTrackWithTypeData * _Nonnull)type pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithType:pollDuration:completionHandler:")]
        void TrackActionWithType(HTTrackWithTypeData type, double pollDuration, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)trackActionWithIds:(NSArray<NSString *> * _Nonnull)ids pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithIds:pollDuration:completionHandler:")]
        void TrackActionWithIds(string[] ids, double pollDuration, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)trackActionWithCollectionId:(NSString * _Nonnull)id pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithCollectionId:pollDuration:completionHandler:")]
        void TrackActionWithCollectionId(string id, double pollDuration, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)trackActionWithUniqueId:(NSString * _Nonnull)id pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithUniqueId:pollDuration:completionHandler:")]
        void TrackActionWithUniqueId(string id, double pollDuration, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)trackActionWithShortCodes:(NSArray<NSString *> * _Nonnull)codes pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("trackActionWithShortCodes:pollDuration:completionHandler:")]
        void TrackActionWithShortCodes(string[] codes, double pollDuration, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // -(void)update;
        [Export("update")]
        void Update();
    }

    // @interface HyperTrack_Swift_1298 (HTOrderTrackingUseCase) <HTUseCaseBackNavigationProtocol>
    [Category]
    [BaseType(typeof(HTOrderTrackingUseCase))]
    interface HTOrderTrackingUseCase_HyperTrack_Swift_1298 
    {
        // -(void)performActionOnButtonClick;
        [Export("performActionOnButtonClick")]
        void PerformActionOnButtonClick();
    }

    // @interface HyperTrack_Swift_1303 (HTOrderTrackingUseCase)
    [Category]
    [BaseType(typeof(HTOrderTrackingUseCase))]
    interface HTOrderTrackingUseCase_HyperTrack_Swift_1303
    {
    }

    // @interface OrderData : NSObject
    [BaseType(typeof(NSObject), Name = "_TtCC10HyperTrack22HTOrderTrackingUseCase9OrderData")]
    [DisableDefaultCtor]
    interface OrderData
    {
        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        OrderData New();
    }

    // @protocol HTOrderTrackingUseCaseDelegate <HTBaseUseCaseDelegate>
    [Protocol, Model]
    interface HTOrderTrackingUseCaseDelegate : HTBaseUseCaseDelegate
    {
        // @required -(void)placeOrderClicked;
        [Abstract]
        [Export("placeOrderClicked")]
        void PlaceOrderClicked();

        // @required -(void)orderTrackingEnded:(HTTrackWithTypeData * _Nonnull)type;
        [Abstract]
        [Export("orderTrackingEnded:")]
        void OrderTrackingEnded(HTTrackWithTypeData type);
    }

    // @protocol HTOrderTrackingUseCaseViewModelProtocol <HTBaseTrackingViewModelProtocol>
    [Protocol, Model]
    interface HTOrderTrackingUseCaseViewModelProtocol : HTBaseTrackingViewModelProtocol
    {
        // @required -(OrderData * _Nonnull)mapToTrackingUseCaseWithActions:(NSArray<HTTrackAction *> * _Nonnull)actions __attribute__((warn_unused_result));
        [Abstract]
        [Export("mapToTrackingUseCaseWithActions:")]
        OrderData MapToTrackingUseCaseWithActions(HTTrackAction[] actions);
    }

    // @interface HTOrderTrackingUseCaseViewModel : HTBaseTrackingViewModel <HTOrderTrackingUseCaseViewModelProtocol>
    [BaseType(typeof(HTBaseTrackingViewModel), Name = "_TtC10HyperTrack31HTOrderTrackingUseCaseViewModel")]
    interface HTOrderTrackingUseCaseViewModel : HTOrderTrackingUseCaseViewModelProtocol
    {
        // -(OrderData * _Nonnull)mapToTrackingUseCaseWithActions:(NSArray<HTTrackAction *> * _Nonnull)actions __attribute__((warn_unused_result));
        [Export("mapToTrackingUseCaseWithActions:")]
        OrderData MapToTrackingUseCaseWithActions(HTTrackAction[] actions);
    }

    // @protocol HTPaddingProviderProtocol
    [Protocol, Model]
    interface HTPaddingProviderProtocol
    {
        // @required @property (nonatomic) CGFloat top;
        [Abstract]
        [Export("top")]
        nfloat Top { get; set; }

        // @required @property (nonatomic) CGFloat left;
        [Abstract]
        [Export("left")]
        nfloat Left { get; set; }

        // @required @property (nonatomic) CGFloat right;
        [Abstract]
        [Export("right")]
        nfloat Right { get; set; }

        // @required @property (nonatomic) CGFloat bottom;
        [Abstract]
        [Export("bottom")]
        nfloat Bottom { get; set; }

        // @required @property (nonatomic) CGFloat verticalInterItem;
        [Abstract]
        [Export("verticalInterItem")]
        nfloat VerticalInterItem { get; set; }

        // @required @property (nonatomic) CGFloat horizontalInterItem;
        [Abstract]
        [Export("horizontalInterItem")]
        nfloat HorizontalInterItem { get; set; }

        // @required @property (readonly, getter = default, nonatomic, strong, class) id<HTPaddingProviderProtocol> _Nonnull default_;
        [Static, Abstract]
        [Export("default_", ArgumentSemantic.Strong)]
        NSObject Default_ { [Bind("default")] get; }

        // @required @property (readonly, nonatomic, strong, class) id<HTPaddingProviderProtocol> _Nonnull zero;
        [Static, Abstract]
        [Export("zero", ArgumentSemantic.Strong)]
        NSObject Zero { get; }
    }

    // @interface HTPlace : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack7HTPlace")]
    [DisableDefaultCtor]
    interface HTPlace
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; }

        // @property (readonly, nonatomic, strong) HTGeoJSONLocation * _Nullable location;
        [NullAllowed, Export("location", ArgumentSemantic.Strong)]
        HTGeoJSONLocation Location { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull address;
        [Export("address")]
        string Address { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull locality;
        [Export("locality")]
        string Locality { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull landmark;
        [Export("landmark")]
        string Landmark { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull zipCode;
        [Export("zipCode")]
        string ZipCode { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull city;
        [Export("city")]
        string City { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull state;
        [Export("state")]
        string State { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull country;
        [Export("country")]
        string Country { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull displayText;
        [Export("displayText")]
        string DisplayText { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull uniqueId;
        [Export("uniqueId")]
        string UniqueId { get; }

        // -(instancetype _Nonnull)initWithDict:(NSDictionary<NSString *,id> * _Nonnull)dict __attribute__((objc_designated_initializer));
        [Export("initWithDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> dict);

        // -(NSString * _Nonnull)getIdentifier __attribute__((warn_unused_result));
        [Export("getIdentifier")]
        string Identifier { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTPlace New();
    }

    // @interface HTPlaceBuilder : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack14HTPlaceBuilder")]
    interface HTPlaceBuilder
    {
        // -(HTPlace * _Nonnull)build __attribute__((warn_unused_result));
        [Export("build")]
        HTPlace Build { get; }

        // -(HTPlaceBuilder * _Nonnull)setId:(NSString * _Nonnull)id __attribute__((warn_unused_result));
        [Export("setId:")]
        HTPlaceBuilder SetId(string id);

        // -(HTPlaceBuilder * _Nonnull)setName:(NSString * _Nonnull)name __attribute__((warn_unused_result));
        [Export("setName:")]
        HTPlaceBuilder SetName(string name);

        // -(HTPlaceBuilder * _Nonnull)setLocation:(CLLocationCoordinate2D)coordinates __attribute__((warn_unused_result));
        [Export("setLocation:")]
        HTPlaceBuilder SetLocation(CLLocationCoordinate2D coordinates);

        // -(HTPlaceBuilder * _Nonnull)setAddress:(NSString * _Nonnull)address __attribute__((warn_unused_result));
        [Export("setAddress:")]
        HTPlaceBuilder SetAddress(string address);

        // -(HTPlaceBuilder * _Nonnull)setLandmark:(NSString * _Nonnull)landmark __attribute__((warn_unused_result));
        [Export("setLandmark:")]
        HTPlaceBuilder SetLandmark(string landmark);

        // -(HTPlaceBuilder * _Nonnull)setUniqueId:(NSString * _Nonnull)uniqueId __attribute__((warn_unused_result));
        [Export("setUniqueId:")]
        HTPlaceBuilder SetUniqueId(string uniqueId);

        // -(HTPlaceBuilder * _Nonnull)setZipCode:(NSString * _Nonnull)zipCode __attribute__((warn_unused_result));
        [Export("setZipCode:")]
        HTPlaceBuilder SetZipCode(string zipCode);

        // -(HTPlaceBuilder * _Nonnull)setCity:(NSString * _Nonnull)city __attribute__((warn_unused_result));
        [Export("setCity:")]
        HTPlaceBuilder SetCity(string city);

        // -(HTPlaceBuilder * _Nonnull)setState:(NSString * _Nonnull)state __attribute__((warn_unused_result));
        [Export("setState:")]
        HTPlaceBuilder SetState(string state);

        // -(HTPlaceBuilder * _Nonnull)setCountry:(NSString * _Nonnull)country __attribute__((warn_unused_result));
        [Export("setCountry:")]
        HTPlaceBuilder SetCountry(string country);
    }

    // @interface HTPlaceLineUseCase : HTBaseUseCase <HTMapViewUseCase>
    [BaseType(typeof(HTBaseUseCase), Name = "_TtC10HyperTrack18HTPlaceLineUseCase")]
    interface HTPlaceLineUseCase : HTMapViewUseCase
    {
        [Wrap("WeakMapDelegate")]
        [NullAllowed]
        NSObject MapDelegate { get; set; }

        // @property (nonatomic, weak) id<HTMapUseCaseDelegate> _Nullable mapDelegate;
        [NullAllowed, Export("mapDelegate", ArgumentSemantic.Weak)]
        NSObject WeakMapDelegate { get; set; }

        // @property (nonatomic, strong) UIButton * _Nonnull primaryActionButton;
        [Export("primaryActionButton", ArgumentSemantic.Strong)]
        UIButton PrimaryActionButton { get; set; }

        // @property (nonatomic) BOOL isBackButtonHidden;
        [Export("isBackButtonHidden")]
        bool IsBackButtonHidden { get; set; }

        // @property (nonatomic) BOOL isPrimaryActionHidden;
        [Export("isPrimaryActionHidden")]
        bool IsPrimaryActionHidden { get; set; }

        [Wrap("WeakNavigationDelegate")]
        [NullAllowed]
        NSObject NavigationDelegate { get; set; }

        // @property (nonatomic, weak) id<HTUseCaseNavigationDelegate> _Nullable navigationDelegate;
        [NullAllowed, Export("navigationDelegate", ArgumentSemantic.Weak)]
        NSObject WeakNavigationDelegate { get; set; }

        // -(instancetype _Nonnull)initWithMapDelegate:(id<HTMapUseCaseDelegate> _Nullable)mapDelegate;
        [Export("initWithMapDelegate:")]
        IntPtr Constructor([NullAllowed] NSObject mapDelegate);

        // -(void)update;
        [Export("update")]
        void Update();

        // -(void)setDate:(NSDate * _Nonnull)date;
        [Export("setDate:")]
        void SetDate(NSDate date);
    }

    // @interface HyperTrack_Swift_1416 (HTPlaceLineUseCase) <HTDateSwitcherViewDelegate>
    [Category]
    [BaseType(typeof(HTPlaceLineUseCase))]
    interface HTPlaceLineUseCase_HyperTrack_Swift_1416
    {
        // -(void)dateChanged:(NSDate * _Nonnull)date;
        [Export("dateChanged:")]
        void DateChanged(NSDate date);
    }

    // @interface HyperTrack_Swift_1421 (HTPlaceLineUseCase) <HTUseCaseBackNavigationProtocol>
    [Category]
    [BaseType(typeof(HTPlaceLineUseCase))]
    interface HTPlaceLineUseCase_HyperTrack_Swift_1421 
    {
        // -(void)performActionOnButtonClick;
        [Export("performActionOnButtonClick")]
        void PerformActionOnButtonClick();
    }

    // @interface HyperTrack_Swift_1426 (HTPlaceLineUseCase) <HTCalendarDelegate>
    [Category]
    [BaseType(typeof(HTPlaceLineUseCase))]
    interface HTPlaceLineUseCase_HyperTrack_Swift_1426
    {
        // -(void)didSelectDate:(NSDate * _Nonnull)date;
        [Export("didSelectDate:")]
        void DidSelectDate(NSDate date);

        // -(void)openCalendar:(BOOL)open selectedDate:(NSDate * _Nonnull)selectedDate;
        [Export("openCalendar:selectedDate:")]
        void OpenCalendar(bool open, NSDate selectedDate);
    }

    // @interface HyperTrack_Swift_1432 (HTPlaceLineUseCase)
    [Category]
    [BaseType(typeof(HTPlaceLineUseCase))]
    interface HTPlaceLineUseCase_HyperTrack_Swift_1432
    {
        // -(CGFloat)swipePosition:(enum HTSwipePosition)position __attribute__((warn_unused_result));
        [Export("swipePosition:")]
        nfloat SwipePosition(HTSwipePosition position);

        // -(void)selectedActivity:(HTActivity * _Nonnull)activity;
        [Export("selectedActivity:")]
        void SelectedActivity(HTActivity activity);
    }

    // @interface HTPlaceSelectionUseCase : NSObject <HTMapViewUseCase>
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack23HTPlaceSelectionUseCase")]
    interface HTPlaceSelectionUseCase : HTMapViewUseCase
    {
        [Wrap("WeakMapDelegate")]
        [NullAllowed]
        NSObject MapDelegate { get; set; }

        // @property (nonatomic, weak) id<HTMapUseCaseDelegate> _Nullable mapDelegate;
        [NullAllowed, Export("mapDelegate", ArgumentSemantic.Weak)]
        NSObject WeakMapDelegate { get; set; }

        [Wrap("WeakNavigationDelegate")]
        [NullAllowed]
        NSObject NavigationDelegate { get; set; }

        // @property (nonatomic, weak) id<HTUseCaseNavigationDelegate> _Nullable navigationDelegate;
        [NullAllowed, Export("navigationDelegate", ArgumentSemantic.Weak)]
        NSObject WeakNavigationDelegate { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        NSObject Delegate { get; set; }

        // @property (nonatomic, weak) id<HTPlaceSelectionDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic, strong) HTBottomViewContainer * _Null_unspecified bottomView;
        [Export("bottomView", ArgumentSemantic.Strong)]
        HTBottomViewContainer BottomView { get; }

        // @property (nonatomic, strong) UIButton * _Nonnull primaryActionButton;
        [Export("primaryActionButton", ArgumentSemantic.Strong)]
        UIButton PrimaryActionButton { get; set; }

        // @property (nonatomic) BOOL isPrimaryActionHidden;
        [Export("isPrimaryActionHidden")]
        bool IsPrimaryActionHidden { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull searchBarPlaceHolderText;
        [Export("searchBarPlaceHolderText")]
        string SearchBarPlaceHolderText { get; set; }

        // @property (nonatomic) BOOL enableCurrentLocationSelection;
        [Export("enableCurrentLocationSelection")]
        bool EnableCurrentLocationSelection { get; set; }

        // @property (nonatomic) BOOL enableChooseOnMapSelection;
        [Export("enableChooseOnMapSelection")]
        bool EnableChooseOnMapSelection { get; set; }

        // -(instancetype _Nonnull)initWithCoordinates:(CLLocationCoordinate2D)coordinates;
        [Export("initWithCoordinates:")]
        IntPtr Constructor(CLLocationCoordinate2D coordinates);

        // -(instancetype _Nonnull)initWithMapDelegate:(id<HTMapUseCaseDelegate> _Nullable)mapDelegate;
        [Export("initWithMapDelegate:")]
        IntPtr Constructor([NullAllowed] NSObject mapDelegate);

        // -(void)update;
        [Export("update")]
        void Update();
    }

    // @interface HyperTrack_Swift_1460 (HTPlaceSelectionUseCase) <HTMapViewUpdatesDelegate>
    [Category]
    [BaseType(typeof(HTPlaceSelectionUseCase))]
    interface HTPlaceSelectionUseCase_HyperTrack_Swift_1460 
    {
        // -(void)mapViewDidChangeWithCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate;
        [Export("mapViewDidChangeWithCenterCoordinate:")]
        void MapViewDidChangeWithCenterCoordinate(CLLocationCoordinate2D centerCoordinate);
    }

    // @interface HyperTrack_Swift_1465 (HTPlaceSelectionUseCase) <HTUseCaseBackNavigationProtocol>
    [Category]
    [BaseType(typeof(HTPlaceSelectionUseCase))]
    interface HTPlaceSelectionUseCase_HyperTrack_Swift_1465
    {
        // -(void)performActionOnButtonClick;
        [Export("performActionOnButtonClick")]
        void PerformActionOnButtonClick();
    }

    // @protocol HTPrimaryActionIntDelegate <HTAuxillaryFlowDelegate>
    [Protocol, Model]
    interface HTPrimaryActionIntDelegate : HTAuxillaryFlowDelegate
    {
        // @required -(void)primaryActionClicked:(NSInteger)data;
        [Abstract]
        [Export("primaryActionClicked:")]
        void PrimaryActionClicked(nint data);
    }

    // @interface HyperTrack_Swift_1476 (HTPlaceSelectionUseCase) <HTPrimaryActionIntDelegate>
    [Category]
    [BaseType(typeof(HTPlaceSelectionUseCase))]
    interface HTPlaceSelectionUseCase_HyperTrack_Swift_1476
    {
        // -(void)cancelClicked;
        [Export("cancelClicked")]
        void CancelClicked();

        // -(void)primaryActionClicked:(NSInteger)data;
        [Export("primaryActionClicked:")]
        void PrimaryActionClicked(nint data);

        // -(void)updatedQuery:(NSString * _Nonnull)query;
        [Export("updatedQuery:")]
        void UpdatedQuery(string query);
    }

    // @interface HTPlaceline : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack11HTPlaceline")]
    [DisableDefaultCtor]
    interface HTPlaceline
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable id;
        [NullAllowed, Export("id")]
        string Id { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable groupId;
        [NullAllowed, Export("groupId")]
        string GroupId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable uniqueId;
        [NullAllowed, Export("uniqueId")]
        string UniqueId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable phone;
        [NullAllowed, Export("phone")]
        string Phone { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable photo;
        [NullAllowed, Export("photo")]
        string Photo { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable availabilityStatus;
        [NullAllowed, Export("availabilityStatus")]
        string AvailabilityStatus { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable vehicleType;
        [NullAllowed, Export("vehicleType")]
        string VehicleType { get; }

        // @property (readonly, nonatomic, strong) HTGeoJSONLocation * _Nullable location;
        [NullAllowed, Export("location", ArgumentSemantic.Strong)]
        HTGeoJSONLocation Location { get; }

        // @property (readonly, nonatomic, strong) Display * _Nullable display;
        [NullAllowed, Export("display", ArgumentSemantic.Strong)]
        NSObject Display { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable createdAt;
        [NullAllowed, Export("createdAt", ArgumentSemantic.Copy)]
        NSDate CreatedAt { get; }

        // @property (readonly, copy, nonatomic) NSArray<HTActivity *> * _Nonnull placeline;
        [Export("placeline", ArgumentSemantic.Copy)]
        HTActivity[] Placeline { get; }

        // @property (readonly, nonatomic, strong) HTActivity * _Nullable activity;
        [NullAllowed, Export("activity", ArgumentSemantic.Strong)]
        HTActivity Activity { get; }

        // @property (readonly, nonatomic, strong) HTHealth * _Nullable health;
        [NullAllowed, Export("health", ArgumentSemantic.Strong)]
        HTHealth Health { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable placelineDate;
        [NullAllowed, Export("placelineDate")]
        string PlacelineDate { get; }

        // @property (readonly, copy, nonatomic) NSArray<HTAction *> * _Nonnull actions;
        [Export("actions", ArgumentSemantic.Copy)]
        HTAction[] Actions { get; }

        // -(instancetype _Nonnull)initWithDict:(NSDictionary<NSString *,id> * _Nonnull)dict __attribute__((objc_designated_initializer));
        [Export("initWithDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> dict);

        // -(NSString * _Nullable)toJson __attribute__((warn_unused_result));
        [NullAllowed, Export("toJson")]
        string ToJson { get; }

        // -(NSData * _Nullable)toJsonData __attribute__((warn_unused_result));
        [NullAllowed, Export("toJsonData")]
        NSData ToJsonData { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTPlaceline New();
    }

    // @interface HTPolylineData : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack14HTPolylineData")]
    [DisableDefaultCtor]
    interface HTPolylineData
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSValue *> * _Nonnull coordinates;
        [Export("coordinates", ArgumentSemantic.Copy)]
        NSValue[] Coordinates { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable encodedRoute;
        [NullAllowed, Export("encodedRoute")]
        string EncodedRoute { get; }

        // -(HTPolylineData * _Nonnull)addCoordinate:(CLLocationCoordinate2D)coordinate __attribute__((warn_unused_result));
        [Export("addCoordinate:")]
        HTPolylineData AddCoordinate(CLLocationCoordinate2D coordinate);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTPolylineData New();
    }

    // @interface HTProvider : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack10HTProvider")]
    interface HTProvider
    {
        // @property (nonatomic, strong, class) id<HTStyleProviderProtocol> _Nonnull style;
        [Static]
        [Export("style", ArgumentSemantic.Strong)]
        NSObject Style { get; set; }

        // @property (nonatomic, class) double animationDuration;
        [Static]
        [Export("animationDuration")]
        double AnimationDuration { get; set; }

        // @property (nonatomic, class) NSInteger numberOfPointsForAnimation;
        [Static]
        [Export("numberOfPointsForAnimation")]
        nint NumberOfPointsForAnimation { get; set; }

        // @property (nonatomic, class) double pollDuration;
        [Static]
        [Export("pollDuration")]
        double PollDuration { get; set; }

        // @property (nonatomic, class) BOOL shouldShowPulsatingMarkers;
        [Static]
        [Export("shouldShowPulsatingMarkers")]
        bool ShouldShowPulsatingMarkers { get; set; }

        // @property (nonatomic, class) BOOL shouldShowCallouts;
        [Static]
        [Export("shouldShowCallouts")]
        bool ShouldShowCallouts { get; set; }

        // @property (nonatomic, class) BOOL alwaysRotateUserMarker;
        [Static]
        [Export("alwaysRotateUserMarker")]
        bool AlwaysRotateUserMarker { get; set; }

        // @property (nonatomic, class) CGSize userMarkerSize;
        [Static]
        [Export("userMarkerSize", ArgumentSemantic.Assign)]
        CGSize UserMarkerSize { get; set; }

        // @property (nonatomic, class) CGSize destinationMarkerSize;
        [Static]
        [Export("destinationMarkerSize", ArgumentSemantic.Assign)]
        CGSize DestinationMarkerSize { get; set; }

        [Wrap("WeakMapCustomizationDelegate"), Static]
        [NullAllowed]
        NSObject MapCustomizationDelegate { get; set; }

        // @property (nonatomic, strong, class) id<HTMapCustomizationDelegate> _Nullable mapCustomizationDelegate;
        [Static]
        [NullAllowed, Export("mapCustomizationDelegate", ArgumentSemantic.Strong)]
        NSObject WeakMapCustomizationDelegate { get; set; }

        // @property (copy, nonatomic, class) NSString * _Nullable orderTrackingSummaryTitle;
        [Static]
        [NullAllowed, Export("orderTrackingSummaryTitle")]
        string OrderTrackingSummaryTitle { get; set; }
    }

    // @interface HTReusableStackView : UIStackView
    [BaseType(typeof(UIStackView), Name = "_TtC10HyperTrack19HTReusableStackView")]
    interface HTReusableStackView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

     
    }

    // @protocol HTReusableStackViewDataSource
    [Protocol, Model]
    interface HTReusableStackViewDataSource
    {
        // @required -(NSInteger)numberOfItemsIn:(HTReusableStackView * _Nonnull)stackView __attribute__((warn_unused_result));
        [Abstract]
        [Export("numberOfItemsIn:")]
        nint NumberOfItemsIn(HTReusableStackView stackView);

        // @required -(HTStackViewItem * _Nonnull)stackView:(HTReusableStackView * _Nonnull)stackView viewForRowAt:(NSInteger)index __attribute__((warn_unused_result));
        [Abstract]
        [Export("stackView:viewForRowAt:")]
        HTStackViewItem StackView(HTReusableStackView stackView, nint index);
    }

    // @protocol HTReusableStackViewDelegate
    [Protocol, Model]
    interface HTReusableStackViewDelegate
    {
    }

    // @interface HTSegment : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack9HTSegment")]
    [DisableDefaultCtor]
    interface HTSegment
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull lookupId;
        [Export("lookupId")]
        string LookupId { get; }

        // @property (copy, nonatomic) NSString * _Nonnull sessionId;
        [Export("sessionId")]
        string SessionId { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull deviceId;
        [Export("deviceId")]
        string DeviceId { get; set; }

        // @property (copy, nonatomic) NSDate * _Nonnull recordedAt;
        [Export("recordedAt", ArgumentSemantic.Copy)]
        NSDate RecordedAt { get; set; }

        // @property (copy, nonatomic) NSDate * _Nonnull startTime;
        [Export("startTime", ArgumentSemantic.Copy)]
        NSDate StartTime { get; set; }

        // @property (copy, nonatomic) NSDate * _Nullable endTime;
        [NullAllowed, Export("endTime", ArgumentSemantic.Copy)]
        NSDate EndTime { get; set; }

        // @property (copy, nonatomic) NSDate * _Nullable uploadTime;
        [NullAllowed, Export("uploadTime", ArgumentSemantic.Copy)]
        NSDate UploadTime { get; set; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTSegment New();
    }

    // @interface HTSDKActivity : HTSegment
    [BaseType(typeof(HTSegment), Name = "_TtC10HyperTrack13HTSDKActivity")]
    interface HTSDKActivity
    {
        // @property (nonatomic) NSInteger stepDistance;
        [Export("stepDistance")]
        nint StepDistance { get; set; }

        // @property (nonatomic) NSInteger stepCount;
        [Export("stepCount")]
        nint StepCount { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable experimentId;
        [NullAllowed, Export("experimentId")]
        string ExperimentId { get; set; }

        // @property (nonatomic) double confidence;
        [Export("confidence")]
        double Confidence { get; set; }

        // +(HTSDKActivity * _Nonnull)getSDKActivityFromOSActivityWithOsActivity:(CMMotionActivity * _Nonnull)osActivity __attribute__((warn_unused_result));
        [Static]
        [Export("getSDKActivityFromOSActivityWithOsActivity:")]
        HTSDKActivity GetSDKActivityFromOSActivityWithOsActivity(CMMotionActivity osActivity);

        // +(double)getConfidenceWithActivity:(CMMotionActivity * _Nonnull)activity __attribute__((warn_unused_result));
        [Static]
        [Export("getConfidenceWithActivity:")]
        double GetConfidenceWithActivity(CMMotionActivity activity);

        // -(NSDictionary<NSString *,id> * _Nonnull)toDict __attribute__((warn_unused_result));
        [Export("toDict")]
        NSDictionary<NSString, NSObject> ToDict { get; }

        // -(HTActivity * _Nonnull)toHTActivity __attribute__((warn_unused_result));
        [Export("toHTActivity")]
        HTActivity ToHTActivity { get; }
    }

    // @interface HTSDKHealth : HTSegment
    [BaseType(typeof(HTSegment), Name = "_TtC10HyperTrack11HTSDKHealth")]
    interface HTSDKHealth
    {
        // -(NSDictionary<NSString *,id> * _Nonnull)toDict __attribute__((warn_unused_result));
        [Export("toDict")]
        NSDictionary<NSString, NSObject> ToDict { get; }
    }

    // @protocol HTShareEtaViewModelProtocol <HTBaseViewModelProtocol>
    [Protocol, Model]
    interface HTShareEtaViewModelProtocol : HTBaseViewModelProtocol
    {
        // @required -(void)getAutocompleteResults:(NSString * _Nonnull)query coordinate:(CLLocationCoordinate2D)coordinate completionHandler:(void (^ _Nullable)(NSArray<HTPlace *> * _Nullable, HTError * _Nullable))completionHandler;
        [Abstract]
        [Export("getAutocompleteResults:coordinate:completionHandler:")]
        void GetAutocompleteResults(string query, CLLocationCoordinate2D coordinate, [NullAllowed] Action<HTPlace[], HTError> completionHandler);

        // @required -(void)createPlaceWithGeoJson:(HTGeoJSONLocation * _Nonnull)geoJson completionHandler:(void (^ _Nullable)(HTPlace * _Nullable, HTError * _Nullable))completionHandler;
        [Abstract]
        [Export("createPlaceWithGeoJson:completionHandler:")]
        void CreatePlaceWithGeoJson(HTGeoJSONLocation geoJson, [NullAllowed] Action<HTPlace, HTError> completionHandler);
    }

    // @interface HTShareEtaUseCaseViewModel : NSObject <HTShareEtaViewModelProtocol>
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack26HTShareEtaUseCaseViewModel")]
    interface HTShareEtaUseCaseViewModel : HTShareEtaViewModelProtocol
    {
        // -(void)getAutocompleteResults:(NSString * _Nonnull)query coordinate:(CLLocationCoordinate2D)coordinate completionHandler:(void (^ _Nullable)(NSArray<HTPlace *> * _Nullable, HTError * _Nullable))completionHandler;
        [Export("getAutocompleteResults:coordinate:completionHandler:")]
        void GetAutocompleteResults(string query, CLLocationCoordinate2D coordinate, [NullAllowed] Action<HTPlace[], HTError> completionHandler);

        // -(void)createPlaceWithGeoJson:(HTGeoJSONLocation * _Nonnull)geoJson completionHandler:(void (^ _Nullable)(HTPlace * _Nullable, HTError * _Nullable))completionHandler;
        [Export("createPlaceWithGeoJson:completionHandler:")]
        void CreatePlaceWithGeoJson(HTGeoJSONLocation geoJson, [NullAllowed] Action<HTPlace, HTError> completionHandler);
    }

    // @interface HTStackViewItem : UIView
    [BaseType(typeof(UIView), Name = "_TtC10HyperTrack15HTStackViewItem")]
    interface HTStackViewItem
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
 
    }

    // @protocol HTStyleProviderProtocol
    [Protocol, Model]
    interface HTStyleProviderProtocol
    {
        // @required @property (nonatomic, strong) id<HTColorProviderProtocol> _Nonnull colors;
        [Abstract]
        [Export("colors", ArgumentSemantic.Strong)]
        NSObject Colors { get; set; }

        // @required @property (nonatomic, strong) id<HTFontProviderProtocol> _Nonnull fonts;
        [Abstract]
        [Export("fonts", ArgumentSemantic.Strong)]
        NSObject Fonts { get; set; }

        // @required @property (nonatomic, strong) id<HTPaddingProviderProtocol> _Nonnull padding;
        [Abstract]
        [Export("padding", ArgumentSemantic.Strong)]
        NSObject Padding { get; set; }

        // @required @property (nonatomic, strong) id<HTLayerProviderProtocol> _Nonnull layer;
        [Abstract]
        [Export("layer", ArgumentSemantic.Strong)]
        NSObject Layer { get; set; }

        // @required @property (nonatomic, strong) id<HTMarkerImagesProviderProtocol> _Nonnull markerImages;
        [Abstract]
        [Export("markerImages", ArgumentSemantic.Strong)]
        NSObject MarkerImages { get; set; }
    }

    // @interface HTStyleConfig : NSObject <HTStyleProviderProtocol>
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack13HTStyleConfig")]
    interface HTStyleConfig : HTStyleProviderProtocol
    {
        // @property (nonatomic, strong) id<HTColorProviderProtocol> _Nonnull colors;
        [Export("colors", ArgumentSemantic.Strong)]
        NSObject Colors { get; set; }

        // @property (nonatomic, strong) id<HTFontProviderProtocol> _Nonnull fonts;
        [Export("fonts", ArgumentSemantic.Strong)]
        NSObject Fonts { get; set; }

        // @property (nonatomic, strong) id<HTPaddingProviderProtocol> _Nonnull padding;
        [Export("padding", ArgumentSemantic.Strong)]
        NSObject Padding { get; set; }

        // @property (nonatomic, strong) id<HTLayerProviderProtocol> _Nonnull layer;
        [Export("layer", ArgumentSemantic.Strong)]
        NSObject Layer { get; set; }

        // @property (nonatomic, strong) id<HTMarkerImagesProviderProtocol> _Nonnull markerImages;
        [Export("markerImages", ArgumentSemantic.Strong)]
        NSObject MarkerImages { get; set; }
    }

    // @protocol HTSwipeableProtocol
    [Protocol, Model]
    interface HTSwipeableProtocol
    {
        // @required @property (nonatomic) BOOL isSwipeable;
        [Abstract]
        [Export("isSwipeable")]
        bool IsSwipeable { get; set; }

        // @required @property (nonatomic) enum HTSwipePosition position;
        [Abstract]
        [Export("position", ArgumentSemantic.Assign)]
        HTSwipePosition Position { get; set; }
    }

    // @interface HTTimeAwarePolyline : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack19HTTimeAwarePolyline")]
    [DisableDefaultCtor]
    interface HTTimeAwarePolyline
    {
        // -(HTTimeAwarePolyline * _Nonnull)slice:(NSInteger)maxSize date:(NSDate * _Nonnull)date __attribute__((warn_unused_result));
        [Export("slice:date:")]
        HTTimeAwarePolyline Slice(nint maxSize, NSDate date);

        // -(HTPolylineData * _Nonnull)toPolyline __attribute__((warn_unused_result));
        [Export("toPolyline")]
        HTPolylineData ToPolyline { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTTimeAwarePolyline New();
    }

    // @interface HTTrackAction : HTAction
    [BaseType(typeof(HTAction), Name = "_TtC10HyperTrack13HTTrackAction")]
    interface HTTrackAction
    {
        // @property (readonly, nonatomic, strong) HTPlace * _Nullable place;
        [NullAllowed, Export("place", ArgumentSemantic.Strong)]
        HTPlace Place { get; }

        // -(instancetype _Nonnull)initWithDict:(NSDictionary<NSString *,id> * _Nonnull)dict __attribute__((objc_designated_initializer));
        [Export("initWithDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> dict);
    }

    // @interface HTTrackResponse : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack15HTTrackResponse")]
    [DisableDefaultCtor]
    interface HTTrackResponse
    {
        // @property (readonly, nonatomic) NSInteger count;
        [Export("count")]
        nint Count { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull next;
        [Export("next")]
        string Next { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull previous;
        [Export("previous")]
        string Previous { get; }

        // @property (readonly, copy, nonatomic) NSArray<HTTrackAction *> * _Nonnull actions;
        [Export("actions", ArgumentSemantic.Copy)]
        HTTrackAction[] Actions { get; }

        // -(instancetype _Nonnull)initWithDict:(NSDictionary<NSString *,id> * _Nonnull)dict __attribute__((objc_designated_initializer));
        [Export("initWithDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> dict);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTTrackResponse New();
    }

    // @interface HTTrackWithTypeData : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack19HTTrackWithTypeData")]
    [DisableDefaultCtor]
    interface HTTrackWithTypeData
    {
        // -(instancetype _Nonnull)initWithIds:(NSArray<NSString *> * _Nonnull)ids type:(enum HTTrackWithType)type __attribute__((objc_designated_initializer));
        [Export("initWithIds:type:")]
        [DesignatedInitializer]
        IntPtr Constructor(string[] ids, HTTrackWithType type);

        // -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id type:(enum HTTrackWithType)type __attribute__((objc_designated_initializer));
        [Export("initWithId:type:")]
        [DesignatedInitializer]
        IntPtr Constructor(string id, HTTrackWithType type);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTTrackWithTypeData New();
    }

    // @protocol HTTrackingCustomizationUseCaseDelegate
    [Protocol, Model]
    interface HTTrackingCustomizationUseCaseDelegate
    {
        // @required -(BOOL)handleTrackingResponse:(NSArray<HTAction *> * _Nullable)actions error:(HTError * _Nullable)error mapDelegate:(id<HTMapUseCaseDelegate> _Nullable)mapDelegate __attribute__((warn_unused_result));
        [Abstract]
        [Export("handleTrackingResponse:error:mapDelegate:")]
        bool Error([NullAllowed] HTAction[] actions, [NullAllowed] HTError error, [NullAllowed] NSObject mapDelegate);
    }

    // @interface HTUser : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack6HTUser")]
    [DisableDefaultCtor]
    interface HTUser
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable groupId;
        [NullAllowed, Export("groupId")]
        string GroupId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable uniqueId;
        [NullAllowed, Export("uniqueId")]
        string UniqueId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable availabilityStatus;
        [NullAllowed, Export("availabilityStatus")]
        string AvailabilityStatus { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable vehicleType;
        [NullAllowed, Export("vehicleType")]
        string VehicleType { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable lastOnlineAt;
        [NullAllowed, Export("lastOnlineAt", ArgumentSemantic.Copy)]
        NSDate LastOnlineAt { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable createdAt;
        [NullAllowed, Export("createdAt", ArgumentSemantic.Copy)]
        NSDate CreatedAt { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable modifiedAt;
        [NullAllowed, Export("modifiedAt", ArgumentSemantic.Copy)]
        NSDate ModifiedAt { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable segmentStatus;
        [NullAllowed, Export("segmentStatus")]
        string SegmentStatus { get; }

        // @property (readonly, nonatomic, strong) Display * _Nullable display;
        [NullAllowed, Export("display", ArgumentSemantic.Strong)]
        NSObject Display { get; }

        // @property (readonly, nonatomic) BOOL isTracking;
        [Export("isTracking")]
        bool IsTracking { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable phone;
        [NullAllowed, Export("phone")]
        string Phone { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable photo;
        [NullAllowed, Export("photo")]
        string Photo { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable lastHeartbeatAt;
        [NullAllowed, Export("lastHeartbeatAt", ArgumentSemantic.Copy)]
        NSDate LastHeartbeatAt { get; }

        // @property (readonly, nonatomic, strong) HTLocation * _Nullable lastLocation;
        [NullAllowed, Export("lastLocation", ArgumentSemantic.Strong)]
        HTLocation LastLocation { get; }

        // @property (readonly, nonatomic) BOOL isConnected;
        [Export("isConnected")]
        bool IsConnected { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable locationStatus;
        [NullAllowed, Export("locationStatus")]
        string LocationStatus { get; }

        // -(instancetype _Nonnull)initWithDict:(NSDictionary<NSString *,id> * _Nonnull)dict __attribute__((objc_designated_initializer));
        [Export("initWithDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> dict);

        // -(NSString * _Nullable)toJson __attribute__((warn_unused_result));
        [NullAllowed, Export("toJson")]
        string ToJson { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTUser New();
    }

    // @interface HTUserInfoView : HTStackViewItem
    [BaseType(typeof(HTStackViewItem), Name = "_TtC10HyperTrack14HTUserInfoView")]
    interface HTUserInfoView
    {
        // @property (readonly, nonatomic, strong) UIImageView * _Null_unspecified imageView;
        [Export("imageView", ArgumentSemantic.Strong)]
        UIImageView ImageView { get; }

        // @property (readonly, nonatomic, strong) HTLabel * _Null_unspecified titleLabel;
        [Export("titleLabel", ArgumentSemantic.Strong)]
        HTLabel TitleLabel { get; }

        // @property (readonly, nonatomic, strong) HTLabel * _Null_unspecified descriptionLabel;
        [Export("descriptionLabel", ArgumentSemantic.Strong)]
        HTLabel DescriptionLabel { get; }

        // @property (readonly, nonatomic, strong) HTButton * _Null_unspecified actionButton;
        [Export("actionButton", ArgumentSemantic.Strong)]
        HTButton ActionButton { get; }

        // @property (nonatomic, strong) HTBottomViewActionData * _Null_unspecified actionType;
        [Export("actionType", ArgumentSemantic.Strong)]
        HTBottomViewActionData ActionType { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull titleText;
        [Export("titleText")]
        string TitleText { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull descriptionText;
        [Export("descriptionText")]
        string DescriptionText { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable image;
        [NullAllowed, Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable imageUrl;
        [NullAllowed, Export("imageUrl")]
        string ImageUrl { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull actionButtonText;
        [Export("actionButtonText")]
        string ActionButtonText { get; set; }

        // @property (nonatomic, strong) id<HTPaddingProviderProtocol> _Nonnull padding;
        [Export("padding", ArgumentSemantic.Strong)]
        NSObject Padding { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame padding:(id<HTPaddingProviderProtocol> _Nonnull)padding;
        [Export("initWithFrame:padding:")]
        IntPtr Constructor(CGRect frame, NSObject padding);
         
    }

    // @interface HTUserTrackingBottomCard : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack24HTUserTrackingBottomCard")]
    [DisableDefaultCtor]
    interface HTUserTrackingBottomCard
    {
        // @property (readonly, copy, nonatomic) NSArray<id<HTComponentProtocol>> * _Nonnull components;
        [Export("components", ArgumentSemantic.Copy)]
        NSObject[] Components { get; }

        // -(instancetype _Nonnull)init:(NSArray<id<HTComponentProtocol>> * _Nonnull)components __attribute__((objc_designated_initializer));
        [Export("init:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSObject[] components);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HTUserTrackingBottomCard New();
    }

    // @interface HyperTrack : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack10HyperTrack")]
    interface HyperTrack
    {
        // +(void)initialize:(NSString * _Nonnull)publishableKey;
        [Static]
        [Export("initialize:")]
        void Initialize(string publishableKey);

        // +(NSString * _Nullable)getPublishableKey __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("getPublishableKey")]
        string PublishableKey { get; }

        // +(void)resumeTracking;
        [Static]
        [Export("resumeTracking")]
        void ResumeTracking();

        // +(void)resumeTrackingWithCompletionHandler:(void (^ _Nonnull)(HTError * _Nullable))completionHandler;
        [Static]
        [Export("resumeTrackingWithCompletionHandler:")]
        void ResumeTrackingWithCompletionHandler(Action<HTError> completionHandler);

        // +(NSString * _Nullable)getUserId __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("getUserId")]
        string UserId { get; }

        // @property (readonly, nonatomic, class) BOOL isTracking;
        [Static]
        [Export("isTracking")]
        bool IsTracking { get; }

        // +(void)getCurrentLocationWithCompletionHandler:(void (^ _Nonnull)(CLLocation * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("getCurrentLocationWithCompletionHandler:")]
        void GetCurrentLocationWithCompletionHandler(Action<CLLocation, HTError> completionHandler);

        // +(void)getOrCreateUserWithName:(NSString * _Nonnull)name phone:(NSString * _Nonnull)phone uniqueId:(NSString * _Nonnull)uniqueId completionHandler:(void (^ _Nonnull)(HTUser * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("getOrCreateUserWithName:phone:uniqueId:completionHandler:")]
        void GetOrCreateUserWithName(string name, string phone, string uniqueId, Action<HTUser, HTError> completionHandler);

        // +(void)getUserWithId:(NSString * _Nonnull)id completionHandler:(void (^ _Nonnull)(HTUser * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("getUserWithId:completionHandler:")]
        void GetUserWithId(string id, Action<HTUser, HTError> completionHandler);

        // +(void)getOrCreateUserWithName:(NSString * _Nonnull)name phone:(NSString * _Nonnull)phone uniqueId:(NSString * _Nonnull)uniqueId photo:(UIImage * _Nullable)photo completionHandler:(void (^ _Nonnull)(HTUser * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("getOrCreateUserWithName:phone:uniqueId:photo:completionHandler:")]
        void GetOrCreateUserWithName(string name, string phone, string uniqueId, [NullAllowed] UIImage photo, Action<HTUser, HTError> completionHandler);

        // +(void)updateUserWithName:(NSString * _Nonnull)name phone:(NSString * _Nullable)phone uniqueId:(NSString * _Nullable)uniqueId photo:(UIImage * _Nullable)photo completionHandler:(void (^ _Nonnull)(HTUser * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("updateUserWithName:phone:uniqueId:photo:completionHandler:")]
        void UpdateUserWithName(string name, [NullAllowed] string phone, [NullAllowed] string uniqueId, [NullAllowed] UIImage photo, Action<HTUser, HTError> completionHandler);

        // +(void)createAction:(HTActionParams * _Nonnull)actionParams :(void (^ _Nonnull)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("createAction::")]
        void CreateAction(HTActionParams actionParams, Action<HTAction, HTError> completionHandler);

        // +(void)getActionForActionId:(NSString * _Nonnull)actionId completionHandler:(void (^ _Nonnull)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("getActionForActionId:completionHandler:")]
        void GetActionForActionId(string actionId, Action<HTAction, HTError> completionHandler);

        // +(void)getActionsForCollectionId:(NSString * _Nonnull)collectionId completionHandler:(void (^ _Nonnull)(NSArray<HTAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("getActionsForCollectionId:completionHandler:")]
        void GetActionsForCollectionId(string collectionId, Action<HTAction[], HTError> completionHandler);

        // +(void)getActionsForUniqueId:(NSString * _Nonnull)uniqueId :(void (^ _Nonnull)(NSArray<HTAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("getActionsForUniqueId::")]
        void GetActionsForUniqueId(string uniqueId, Action<HTAction[], HTError> completionHandler);

        // +(void)getActionsForShortCode:(NSString * _Nonnull)shortCode :(void (^ _Nonnull)(NSArray<HTAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("getActionsForShortCode::")]
        void GetActionsForShortCode(string shortCode, Action<HTAction[], HTError> completionHandler);

        // +(void)trackActionForActionId:(NSString * _Nonnull)actionId completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("trackActionForActionId:completionHandler:")]
        void TrackActionForActionId(string actionId, [NullAllowed] Action<HTAction, HTError> completionHandler);

        // +(void)trackActionForShortCode:(NSString * _Nonnull)shortCode completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("trackActionForShortCode:completionHandler:")]
        void TrackActionForShortCode(string shortCode, [NullAllowed] Action<HTAction, HTError> completionHandler);

        // +(void)trackActionForUniqueId:(NSString * _Nonnull)uniqueId completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("trackActionForUniqueId:completionHandler:")]
        void TrackActionForUniqueId(string uniqueId, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // +(void)trackActionForCollectionId:(NSString * _Nonnull)collectionId completionHandler:(void (^ _Nullable)(NSArray<HTTrackAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("trackActionForCollectionId:completionHandler:")]
        void TrackActionForCollectionId(string collectionId, [NullAllowed] Action<HTTrackAction[], HTError> completionHandler);

        // +(void)completeAction:(NSString * _Nonnull)actionId;
        [Static]
        [Export("completeAction:")]
        void CompleteAction(string actionId);

        // +(void)completeActionInSync:(NSString * _Nonnull)actionId completionHandler:(void (^ _Nonnull)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("completeActionInSync:completionHandler:")]
        void CompleteActionInSync(string actionId, Action<HTAction, HTError> completionHandler);

        // +(void)completeActionWithUniqueIdInSync:(NSString * _Nonnull)uniqueId completionHandler:(void (^ _Nonnull)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("completeActionWithUniqueIdInSync:completionHandler:")]
        void CompleteActionWithUniqueIdInSync(string uniqueId, Action<HTAction, HTError> completionHandler);

        // +(void)pauseTracking;
        [Static]
        [Export("pauseTracking")]
        void PauseTracking();

        // +(void)createMockAction:(HTLocationCoordinate * _Nullable)origin :(HTLocationCoordinate * _Nullable)destination :(HTActionParams * _Nonnull)params completionHandler:(void (^ _Nonnull)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("createMockAction:::completionHandler:")]
        void CreateMockAction([NullAllowed] HTLocationCoordinate origin, [NullAllowed] HTLocationCoordinate destination, HTActionParams @params, Action<HTAction, HTError> completionHandler);

        // +(void)completeMockActionWithActionId:(NSString * _Nullable)actionId completionHandler:(void (^ _Nonnull)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("completeMockActionWithActionId:completionHandler:")]
        void CompleteMockActionWithActionId([NullAllowed] string actionId, Action<HTAction, HTError> completionHandler);

        // +(CLAuthorizationStatus)locationAuthorizationStatus __attribute__((warn_unused_result));
        [Static]
        [Export("locationAuthorizationStatus")]
        CLAuthorizationStatus LocationAuthorizationStatus { get; }

        // +(void)requestAlwaysLocationAuthorizationWithCompletionHandler:(void (^ _Nonnull)(BOOL))completionHandler;
        [Static]
        [Export("requestAlwaysLocationAuthorizationWithCompletionHandler:")]
        void RequestAlwaysLocationAuthorizationWithCompletionHandler(Action<bool> completionHandler);

        // +(void)motionAuthorizationStatusWithCompletionHandler:(void (^ _Nonnull)(BOOL))completionHandler;
        [Static]
        [Export("motionAuthorizationStatusWithCompletionHandler:")]
        void MotionAuthorizationStatusWithCompletionHandler(Action<bool> completionHandler);

        // +(BOOL)isActivityAvailable __attribute__((warn_unused_result));
        [Static]
        [Export("isActivityAvailable")]
        bool IsActivityAvailable { get; }

        // +(void)requestMotionAuthorization;
        [Static]
        [Export("requestMotionAuthorization")]
        void RequestMotionAuthorization();

        // +(BOOL)locationServicesEnabled __attribute__((warn_unused_result));
        [Static]
        [Export("locationServicesEnabled")]
        bool LocationServicesEnabled { get; }

        // +(void)requestLocationServices;
        [Static]
        [Export("requestLocationServices")]
        void RequestLocationServices();

        // +(void)registerForNotifications;
        [Static]
        [Export("registerForNotifications")]
        void RegisterForNotifications();

        // +(void)didRegisterForRemoteNotificationsWithDeviceTokenWithDeviceToken:(NSData * _Nonnull)deviceToken;
        [Static]
        [Export("didRegisterForRemoteNotificationsWithDeviceTokenWithDeviceToken:")]
        void DidRegisterForRemoteNotificationsWithDeviceTokenWithDeviceToken(NSData deviceToken);

        // +(void)didFailToRegisterForRemoteNotificationsWithErrorWithError:(NSError * _Nonnull)error;
        [Static]
        [Export("didFailToRegisterForRemoteNotificationsWithErrorWithError:")]
        void DidFailToRegisterForRemoteNotificationsWithErrorWithError(NSError error);

        // +(void)didReceiveRemoteNotificationWithUserInfo:(NSDictionary * _Nonnull)userInfo;
        [Static]
        [Export("didReceiveRemoteNotificationWithUserInfo:")]
        void DidReceiveRemoteNotificationWithUserInfo(NSDictionary userInfo);

        // +(BOOL)isHyperTrackNotificationWithUserInfo:(NSDictionary * _Nonnull)userInfo __attribute__((warn_unused_result));
        [Static]
        [Export("isHyperTrackNotificationWithUserInfo:")]
        bool IsHyperTrackNotificationWithUserInfo(NSDictionary userInfo);

        // +(void)getPlacelineWithDate:(NSDate * _Nullable)date userId:(NSString * _Nullable)userId completionHandler:(void (^ _Nonnull)(HTPlaceline * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("getPlacelineWithDate:userId:completionHandler:")]
        void GetPlacelineWithDate([NullAllowed] NSDate date, [NullAllowed] string userId, Action<HTPlaceline, HTError> completionHandler);

        // +(void)enableConsoleLogging;
        [Static]
        [Export("enableConsoleLogging")]
        void EnableConsoleLogging();

        // +(void)setEventsDelegateWithEventDelegate:(id<HTEventsDelegate> _Nonnull)eventDelegate;
        [Static]
        [Export("setEventsDelegateWithEventDelegate:")]
        void SetEventsDelegateWithEventDelegate(NSObject eventDelegate);

        // +(void)setGeofenceAtPlaceWithPlace:(HTPlace * _Nonnull)place radius:(CLLocationDistance)radius identifier:(NSString * _Nonnull)identifier;
        [Static]
        [Export("setGeofenceAtPlaceWithPlace:radius:identifier:")]
        void SetGeofenceAtPlaceWithPlace(HTPlace place, double radius, string identifier);

        // +(CLLocation * _Nullable)getCurrentLocation __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("getCurrentLocation")]
        CLLocation CurrentLocation { get; }

        // +(HTActivity * _Nullable)getCurrentActivity __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("getCurrentActivity")]
        HTActivity CurrentActivity { get; }

        // +(void)getPendingActionsWithCompletionHandler:(void (^ _Nonnull)(NSArray<HTAction *> * _Nullable, HTError * _Nullable))completionHandler;
        [Static]
        [Export("getPendingActionsWithCompletionHandler:")]
        void GetPendingActionsWithCompletionHandler(Action<HTAction[], HTError> completionHandler);

        // +(void)setLocationUpdatesDelegate:(id<HTLocationUpdatesDelegate> _Nullable)delegate;
        [Static]
        [Export("setLocationUpdatesDelegate:")]
        void SetLocationUpdatesDelegate([NullAllowed] NSObject @delegate);
    }

    // @interface HyperTrackEvent : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack15HyperTrackEvent")]
    [DisableDefaultCtor]
    interface HyperTrackEvent
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull userId;
        [Export("userId")]
        string UserId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull sessionId;
        [Export("sessionId")]
        string SessionId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull deviceId;
        [Export("deviceId")]
        string DeviceId { get; }

        // @property (copy, nonatomic) NSDate * _Nonnull recordedAt;
        [Export("recordedAt", ArgumentSemantic.Copy)]
        NSDate RecordedAt { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull activityLookUpId;
        [Export("activityLookUpId")]
        string ActivityLookUpId { get; }

        // @property (copy, nonatomic) NSString * _Nonnull locationLookUpId;
        [Export("locationLookUpId")]
        string LocationLookUpId { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull healthLookUpId;
        [Export("healthLookUpId")]
        string HealthLookUpId { get; }

        // @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull data;
        [Export("data", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> Data { get; set; }

        // -(HTSDKActivity * _Nullable)getActivity __attribute__((warn_unused_result));
        [NullAllowed, Export("getActivity")]
        HTSDKActivity Activity { get; }

        // -(HTLocation * _Nullable)getLocation __attribute__((warn_unused_result));
        [NullAllowed, Export("getLocation")]
        HTLocation Location { get; }

        // -(HTSDKHealth * _Nullable)getHealth __attribute__((warn_unused_result));
        [NullAllowed, Export("getHealth")]
        HTSDKHealth Health { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        HyperTrackEvent New();
    }

    // @interface LocationService : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack15LocationService")]
    interface LocationService
    {
    }

    // @interface HyperTrack_Swift_2046 (LocationService)
    [Category]
    [BaseType(typeof(LocationService))]
    interface LocationService_HyperTrack_Swift_2046
    {
        // -(void)start;
        [Export("start")]
        void Start();

        // -(void)stop;
        [Export("stop")]
        void Stop();
    }

    // @interface HyperTrack_Swift_2054 (LocationService) <CLLocationManagerDelegate>
    [Category]
    [BaseType(typeof(LocationService))]
    interface LocationService_HyperTrack_Swift_2054
    {
        // -(void)locationManager:(CLLocationManager * _Nonnull)manager didChangeAuthorizationStatus:(CLAuthorizationStatus)status;
        [Export("locationManager:didChangeAuthorizationStatus:")]
        void LocationManager(CLLocationManager manager, CLAuthorizationStatus status);

        // -(void)locationManager:(CLLocationManager * _Nonnull)manager didUpdateLocations:(NSArray<CLLocation *> * _Nonnull)locations;
        [Export("locationManager:didUpdateLocations:")]
        void LocationManager(CLLocationManager manager, CLLocation[] locations);

        // -(void)locationManager:(CLLocationManager * _Nonnull)manager didUpdateHeading:(CLHeading * _Nonnull)newHeading;
        [Export("locationManager:didUpdateHeading:")]
        void LocationManager(CLLocationManager manager, CLHeading newHeading);
    }

    // @interface PolylineUtils : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10HyperTrack13PolylineUtils")]
    interface PolylineUtils
    {
        // +(NSArray<NSValue *> * _Nullable)decodePolyline:(NSString * _Nonnull)encodedPolyline precision:(double)precision __attribute__((warn_unused_result));
        [Static]
        [Export("decodePolyline:precision:")]
        [return: NullAllowed]
        NSValue[] DecodePolyline(string encodedPolyline, double precision);

        // +(NSArray<CLLocation *> * _Nullable)decodePolylineToCLLocations:(NSString * _Nonnull)encodedPolyline precision:(double)precision __attribute__((warn_unused_result));
        [Static]
        [Export("decodePolylineToCLLocations:precision:")]
        [return: NullAllowed]
        CLLocation[] DecodePolylineToCLLocations(string encodedPolyline, double precision);
    }

    // @interface HyperTrack_Swift_2075 (UIFont)
    [Category]
    [BaseType(typeof(UIFont))]
    interface UIFont_HyperTrack_Swift_2075
    {
    }

    // @interface HyperTrack_Swift_2096 (UIImage)
    [Category]
    [BaseType(typeof(UIImage))]
    interface UIImage_HyperTrack_Swift_2096
    {
        // +(UIImage * _Nullable)getImageFromHTBundleWithNamed:(NSString * _Nonnull)named __attribute__((warn_unused_result));
        [Static]
        [Export("getImageFromHTBundleWithNamed:")]
        [return: NullAllowed]
        UIImage GetImageFromHTBundleWithNamed(string named);
    }

    // @interface HyperTrack_Swift_2111 (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_HyperTrack_Swift_2111
    {
        // -(void)edges:(UIEdgeInsets)padding;
        [Export("edges:")]
        void Edges(UIEdgeInsets padding);
    }

}
