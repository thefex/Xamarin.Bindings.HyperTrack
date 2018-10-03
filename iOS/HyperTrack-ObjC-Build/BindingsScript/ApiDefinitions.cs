using System;
using CoreLocation;
using Foundation;
using HyperTrack;
using MapKit;
using ObjCRuntime;

// @interface HTAction
[DisableDefaultCtor]
interface HTAction
{
	// @property (readonly, copy, nonatomic) int * _Nonnull uniqueId;
	[Export ("uniqueId", ArgumentSemantic.Copy)]
	unsafe int* UniqueId { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull collectionId;
	[Export ("collectionId", ArgumentSemantic.Copy)]
	unsafe int* CollectionId { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull type;
	[Export ("type", ArgumentSemantic.Copy)]
	unsafe int* Type { get; }

	// @property (readonly, nonatomic, strong) HTUser * _Nullable user;
	[NullAllowed, Export ("user", ArgumentSemantic.Strong)]
	HTUser User { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull id;
	[Export ("id", ArgumentSemantic.Copy)]
	unsafe int* Id { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull trackingUrl;
	[Export ("trackingUrl", ArgumentSemantic.Copy)]
	unsafe int* TrackingUrl { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull endedAnnotation;
	[Export ("endedAnnotation", ArgumentSemantic.Copy)]
	unsafe int* EndedAnnotation { get; }

	// @property (readonly, nonatomic) int isAutocompleteAtExpectedPlace;
	[Export ("isAutocompleteAtExpectedPlace")]
	int IsAutocompleteAtExpectedPlace { get; }

	// @property (readonly, nonatomic) int isAutocompleteAtCreation;
	[Export ("isAutocompleteAtCreation")]
	int IsAutocompleteAtCreation { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable scheduleAutoCancelAt;
	[NullAllowed, Export ("scheduleAutoCancelAt", ArgumentSemantic.Copy)]
	unsafe int* ScheduleAutoCancelAt { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull status;
	[Export ("status", ArgumentSemantic.Copy)]
	unsafe int* Status { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable updatedAt;
	[NullAllowed, Export ("updatedAt", ArgumentSemantic.Copy)]
	unsafe int* UpdatedAt { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable createdAt;
	[NullAllowed, Export ("createdAt", ArgumentSemantic.Copy)]
	unsafe int* CreatedAt { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable startedAt;
	[NullAllowed, Export ("startedAt", ArgumentSemantic.Copy)]
	unsafe int* StartedAt { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable endedAt;
	[NullAllowed, Export ("endedAt", ArgumentSemantic.Copy)]
	unsafe int* EndedAt { get; }

	// @property (readonly, nonatomic, strong) HTPlace * _Nullable startedPlace;
	[NullAllowed, Export ("startedPlace", ArgumentSemantic.Strong)]
	HTPlace StartedPlace { get; }

	// @property (readonly, nonatomic, strong) HTPlace * _Nullable completedPlace;
	[NullAllowed, Export ("completedPlace", ArgumentSemantic.Strong)]
	HTPlace CompletedPlace { get; }

	// @property (readonly, nonatomic) int distance;
	[Export ("distance")]
	int Distance { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable locationTimeSeries;
	[NullAllowed, Export ("locationTimeSeries", ArgumentSemantic.Copy)]
	unsafe int* LocationTimeSeries { get; }

	// @property (readonly, nonatomic, strong) HTPlace * _Nullable expectedPlace;
	[NullAllowed, Export ("expectedPlace", ArgumentSemantic.Strong)]
	HTPlace ExpectedPlace { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable expectedAt;
	[NullAllowed, Export ("expectedAt", ArgumentSemantic.Copy)]
	unsafe int* ExpectedAt { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull arrivalStatus;
	[Export ("arrivalStatus", ArgumentSemantic.Copy)]
	unsafe int* ArrivalStatus { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable eta;
	[NullAllowed, Export ("eta", ArgumentSemantic.Copy)]
	unsafe int* Eta { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable etaAtCreation;
	[NullAllowed, Export ("etaAtCreation", ArgumentSemantic.Copy)]
	unsafe int* EtaAtCreation { get; }

	// @property (readonly, nonatomic) int distanceToArrival;
	[Export ("distanceToArrival")]
	int DistanceToArrival { get; }

	// @property (readonly, nonatomic, strong) Display * _Nullable display;
	[NullAllowed, Export ("display", ArgumentSemantic.Strong)]
	Display Display { get; }

	// @property (readonly, nonatomic, strong) HTLocation * _Nullable location;
	[NullAllowed, Export ("location", ArgumentSemantic.Strong)]
	HTLocation Location { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable completedAt;
	[NullAllowed, Export ("completedAt", ArgumentSemantic.Copy)]
	unsafe int* CompletedAt { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable expectedRoute;
	[NullAllowed, Export ("expectedRoute", ArgumentSemantic.Copy)]
	unsafe int* ExpectedRoute { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable route;
	[NullAllowed, Export ("route", ArgumentSemantic.Copy)]
	unsafe int* Route { get; }

	// @property (readonly, nonatomic, strong) HTHealth * _Nullable health;
	[NullAllowed, Export ("health", ArgumentSemantic.Strong)]
	HTHealth Health { get; }

	// @property (readonly, nonatomic, strong) HTActivity * _Nullable activity;
	[NullAllowed, Export ("activity", ArgumentSemantic.Strong)]
	HTActivity Activity { get; }

	// -(instancetype _Nonnull)initWithDict:(id)dict __attribute__((objc_designated_initializer));
	[Export ("initWithDict:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject dict);

	// -(id)toJson __attribute__((warn_unused_result));
	[Export ("toJson")]
	[Verify (MethodToProperty)]
	NSObject ToJson { get; }

	// -(id)toJsonData __attribute__((warn_unused_result));
	[Export ("toJsonData")]
	[Verify (MethodToProperty)]
	NSObject ToJsonData { get; }

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTAction New ();
}

// @interface HTActionInfo
[DisableDefaultCtor]
interface HTActionInfo
{
	// @property (readonly, copy, nonatomic) int * _Nonnull actionStatus;
	[Export ("actionStatus", ArgumentSemantic.Copy)]
	unsafe int* ActionStatus { get; }

	// -(instancetype _Nonnull)initWithActionStatus:(id)actionStatus __attribute__((objc_designated_initializer));
	[Export ("initWithActionStatus:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject actionStatus);

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTActionInfo New ();
}

// @interface HTActionParams
interface HTActionParams
{
	// @property (copy, nonatomic) int * _Nullable userId;
	[NullAllowed, Export ("userId", ArgumentSemantic.Copy)]
	unsafe int* UserId { get; set; }

	// @property (copy, nonatomic) int * _Nullable expectedPlaceId;
	[NullAllowed, Export ("expectedPlaceId", ArgumentSemantic.Copy)]
	unsafe int* ExpectedPlaceId { get; set; }

	// @property (nonatomic, strong) HTPlace * _Nullable expectedPlace;
	[NullAllowed, Export ("expectedPlace", ArgumentSemantic.Strong)]
	HTPlace ExpectedPlace { get; set; }

	// @property (copy, nonatomic) int * _Nonnull type;
	[Export ("type", ArgumentSemantic.Copy)]
	unsafe int* Type { get; set; }

	// @property (copy, nonatomic) int * _Nonnull uniqueId;
	[Export ("uniqueId", ArgumentSemantic.Copy)]
	unsafe int* UniqueId { get; set; }

	// @property (copy, nonatomic) int * _Nonnull collectionId;
	[Export ("collectionId", ArgumentSemantic.Copy)]
	unsafe int* CollectionId { get; set; }

	// @property (nonatomic) int uniqueIdAsShortCode;
	[Export ("uniqueIdAsShortCode")]
	int UniqueIdAsShortCode { get; set; }

	// @property (copy, nonatomic) int * _Nullable expectedAt;
	[NullAllowed, Export ("expectedAt", ArgumentSemantic.Copy)]
	unsafe int* ExpectedAt { get; set; }

	// -(HTActionParams * _Nonnull)setUserIdWithUserId:(id)userId __attribute__((warn_unused_result));
	[Export ("setUserIdWithUserId:")]
	HTActionParams SetUserIdWithUserId (NSObject userId);

	// -(HTActionParams * _Nonnull)setExpectedPlaceWithExpectedPlace:(HTPlace * _Nonnull)expectedPlace __attribute__((warn_unused_result));
	[Export ("setExpectedPlaceWithExpectedPlace:")]
	HTActionParams SetExpectedPlaceWithExpectedPlace (HTPlace expectedPlace);

	// -(HTActionParams * _Nonnull)setExpectedPlaceIdWithExpectedPlaceId:(id)expectedPlaceId __attribute__((warn_unused_result));
	[Export ("setExpectedPlaceIdWithExpectedPlaceId:")]
	HTActionParams SetExpectedPlaceIdWithExpectedPlaceId (NSObject expectedPlaceId);

	// -(HTActionParams * _Nonnull)setTypeWithType:(id)type __attribute__((warn_unused_result));
	[Export ("setTypeWithType:")]
	HTActionParams SetTypeWithType (NSObject type);

	// -(HTActionParams * _Nonnull)setUniqueIdWithUniqueId:(id)uniqueId __attribute__((warn_unused_result));
	[Export ("setUniqueIdWithUniqueId:")]
	HTActionParams SetUniqueIdWithUniqueId (NSObject uniqueId);

	// -(HTActionParams * _Nonnull)setUniqueIdAsShortCode __attribute__((warn_unused_result));
	[Export ("setUniqueIdAsShortCode")]
	[Verify (MethodToProperty)]
	HTActionParams SetUniqueIdAsShortCode { get; }

	// -(HTActionParams * _Nonnull)setExpectedAtExpectedAt:(id)expectedAt __attribute__((warn_unused_result));
	[Export ("setExpectedAtExpectedAt:")]
	HTActionParams SetExpectedAtExpectedAt (NSObject expectedAt);

	// -(HTActionParams * _Nonnull)setAutocompleteRuleWithRule:(id)rule __attribute__((warn_unused_result));
	[Export ("setAutocompleteRuleWithRule:")]
	HTActionParams SetAutocompleteRuleWithRule (NSObject rule);

	// -(HTActionParams * _Nonnull)setAutocancelAfterHours:(id)hours __attribute__((warn_unused_result));
	[Export ("setAutocancelAfterHours:")]
	HTActionParams SetAutocancelAfterHours (NSObject hours);

	// -(HTActionParams * _Nonnull)setMetaDataWithMetadata:(id)metadata __attribute__((warn_unused_result));
	[Export ("setMetaDataWithMetadata:")]
	HTActionParams SetMetaDataWithMetadata (NSObject metadata);
}

// @interface HyperTrack_Swift_376 (HTActionParams)
[Category]
[BaseType (typeof(HTActionParams))]
interface HTActionParams_HyperTrack_Swift_376
{
	// -(instancetype _Nonnull)initWithType:(id)type;
	[Export ("initWithType:")]
	IntPtr Constructor (NSObject type);

	// @property (readonly, getter = default, nonatomic, strong, class) HTActionParams * _Nonnull default_;
	[Static]
	[Export ("default_", ArgumentSemantic.Strong)]
	HTActionParams Default_ { [Bind ("default")] get; }
}

// @interface HTActivity
[DisableDefaultCtor]
interface HTActivity
{
	// @property (readonly, copy, nonatomic) int * _Nonnull id;
	[Export ("id", ArgumentSemantic.Copy)]
	unsafe int* Id { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull userId;
	[Export ("userId", ArgumentSemantic.Copy)]
	unsafe int* UserId { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable lookupId;
	[NullAllowed, Export ("lookupId", ArgumentSemantic.Copy)]
	unsafe int* LookupId { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull type;
	[Export ("type", ArgumentSemantic.Copy)]
	unsafe int* Type { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable unknownReason;
	[NullAllowed, Export ("unknownReason", ArgumentSemantic.Copy)]
	unsafe int* UnknownReason { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable startedAt;
	[NullAllowed, Export ("startedAt", ArgumentSemantic.Copy)]
	unsafe int* StartedAt { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable endedAt;
	[NullAllowed, Export ("endedAt", ArgumentSemantic.Copy)]
	unsafe int* EndedAt { get; }

	// @property (readonly, nonatomic, strong) HTPlace * _Nullable place;
	[NullAllowed, Export ("place", ArgumentSemantic.Strong)]
	HTPlace Place { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable route;
	[NullAllowed, Export ("route", ArgumentSemantic.Copy)]
	unsafe int* Route { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable locationTimeSeries;
	[NullAllowed, Export ("locationTimeSeries", ArgumentSemantic.Copy)]
	unsafe int* LocationTimeSeries { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable stepDistance;
	[NullAllowed, Export ("stepDistance", ArgumentSemantic.Copy)]
	unsafe int* StepDistance { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable createdAt;
	[NullAllowed, Export ("createdAt", ArgumentSemantic.Copy)]
	unsafe int* CreatedAt { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable modifiedAt;
	[NullAllowed, Export ("modifiedAt", ArgumentSemantic.Copy)]
	unsafe int* ModifiedAt { get; }

	// -(instancetype _Nonnull)initWithDict:(id)dict __attribute__((objc_designated_initializer));
	[Export ("initWithDict:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject dict);

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTActivity New ();
}

// @protocol HTMapViewUseCase
[Protocol, Model]
interface HTMapViewUseCase
{
	[Wrap ("WeakMapDelegate"), Abstract]
	[NullAllowed]
	HTMapUseCaseDelegate MapDelegate { get; set; }

	// @required @property (nonatomic, strong) id<HTMapUseCaseDelegate> _Nullable mapDelegate;
	[Abstract]
	[NullAllowed, Export ("mapDelegate", ArgumentSemantic.Strong)]
	NSObject WeakMapDelegate { get; set; }

	// @required -(void)update;
	[Abstract]
	[Export ("update")]
	void Update ();

	// @required -(instancetype _Nonnull)initWithMapDelegate:(id<HTMapUseCaseDelegate> _Nullable)mapDelegate;
	[Abstract]
	[Export ("initWithMapDelegate:")]
	IntPtr Constructor ([NullAllowed] HTMapUseCaseDelegate mapDelegate);
}

// @interface HTBaseUseCase
interface HTBaseUseCase
{
	[Wrap ("WeakDelegate")]
	[NullAllowed]
	HTBaseUseCaseDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<HTBaseUseCaseDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }
}

// @interface HTActivitySummaryUseCase : HTBaseUseCase <HTMapViewUseCase>
[BaseType (typeof(HTBaseUseCase))]
interface HTActivitySummaryUseCase : IHTMapViewUseCase
{
	[Wrap ("WeakMapDelegate")]
	[NullAllowed]
	HTMapUseCaseDelegate MapDelegate { get; set; }

	// @property (nonatomic, weak) id<HTMapUseCaseDelegate> _Nullable mapDelegate;
	[NullAllowed, Export ("mapDelegate", ArgumentSemantic.Weak)]
	NSObject WeakMapDelegate { get; set; }

	// @property (readonly, nonatomic, strong) HTLiveTrackingUseCase * _Null_unspecified liveUC;
	[Export ("liveUC", ArgumentSemantic.Strong)]
	HTLiveTrackingUseCase LiveUC { get; }

	// @property (readonly, nonatomic, strong) HTPlaceLineUseCase * _Null_unspecified placelineUC;
	[Export ("placelineUC", ArgumentSemantic.Strong)]
	HTPlaceLineUseCase PlacelineUC { get; }

	[Wrap ("WeakActivityDelegate")]
	[NullAllowed]
	HTActivitySummaryUseCaseDelegate ActivityDelegate { get; set; }

	// @property (nonatomic, weak) id<HTActivitySummaryUseCaseDelegate> _Nullable activityDelegate;
	[NullAllowed, Export ("activityDelegate", ArgumentSemantic.Weak)]
	NSObject WeakActivityDelegate { get; set; }

	// @property (nonatomic) int isPrimaryActionHidden;
	[Export ("isPrimaryActionHidden")]
	int IsPrimaryActionHidden { get; set; }

	// -(instancetype _Nonnull)initWithMapDelegate:(id<HTMapUseCaseDelegate> _Nullable)mapDelegate;
	[Export ("initWithMapDelegate:")]
	IntPtr Constructor ([NullAllowed] HTMapUseCaseDelegate mapDelegate);

	// -(instancetype _Nonnull)initWithLiveUseCase:(HTLiveTrackingUseCase * _Nullable)liveUseCase placelineUseCase:(HTPlaceLineUseCase * _Nullable)placelineUseCase __attribute__((objc_designated_initializer));
	[Export ("initWithLiveUseCase:placelineUseCase:")]
	[DesignatedInitializer]
	IntPtr Constructor ([NullAllowed] HTLiveTrackingUseCase liveUseCase, [NullAllowed] HTPlaceLineUseCase placelineUseCase);

	// -(void)update;
	[Export ("update")]
	void Update ();

	// -(void)enabeLiveTracking;
	[Export ("enabeLiveTracking")]
	void EnabeLiveTracking ();
}

// @protocol HTUseCaseNavigationDelegate
[Protocol, Model]
interface HTUseCaseNavigationDelegate
{
	// @required -(void)backClicked;
	[Abstract]
	[Export ("backClicked")]
	void BackClicked ();
}

// @interface HyperTrack_Swift_445 (HTActivitySummaryUseCase) <HTUseCaseNavigationDelegate>
[Category]
[BaseType (typeof(HTActivitySummaryUseCase))]
interface HTActivitySummaryUseCase_HyperTrack_Swift_445 : IHTUseCaseNavigationDelegate
{
	// -(void)backClicked;
	[Export ("backClicked")]
	void BackClicked ();
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
	// @required -(void)showLoader:(id)show;
	[Abstract]
	[Export ("showLoader:")]
	void ShowLoader (NSObject show);
}

// @protocol HTLiveTrackingUseCaseDelegate <HTBaseUseCaseDelegate>
[Protocol, Model]
interface HTLiveTrackingUseCaseDelegate : IHTBaseUseCaseDelegate
{
	// @required -(void)shareLiveTrackingDetails:(id)url eta:(id)eta;
	[Abstract]
	[Export ("shareLiveTrackingDetails:eta:")]
	void ShareLiveTrackingDetails (NSObject url, NSObject eta);

	// @required -(void)shareLiveLocationClicked;
	[Abstract]
	[Export ("shareLiveLocationClicked")]
	void ShareLiveLocationClicked ();

	// @required -(void)liveTrackingEnded:(HTTrackWithTypeData * _Nonnull)type;
	[Abstract]
	[Export ("liveTrackingEnded:")]
	void LiveTrackingEnded (HTTrackWithTypeData type);
}

// @protocol HTActivitySummaryUseCaseDelegate <HTLiveTrackingUseCaseDelegate, HTPlaceLineUseCaseDelegate>
[Protocol, Model]
interface HTActivitySummaryUseCaseDelegate : IHTLiveTrackingUseCaseDelegate, IHTPlaceLineUseCaseDelegate
{
}

// @interface HTAnnotationData
[DisableDefaultCtor]
interface HTAnnotationData
{
	// @property (readonly, copy, nonatomic) int * _Nonnull id;
	[Export ("id", ArgumentSemantic.Copy)]
	unsafe int* Id { get; }

	// @property (readonly, nonatomic) int coordinate;
	[Export ("coordinate")]
	int Coordinate { get; }

	// @property (readonly, nonatomic, strong) MetaData * _Nonnull metaData;
	[Export ("metaData", ArgumentSemantic.Strong)]
	MetaData MetaData { get; }

	// @property (readonly, nonatomic, strong) HTCallout * _Nullable callout;
	[NullAllowed, Export ("callout", ArgumentSemantic.Strong)]
	HTCallout Callout { get; }

	// @property (readonly, nonatomic, strong) HTTimeAwarePolyline * _Nullable locationTimeSeries;
	[NullAllowed, Export ("locationTimeSeries", ArgumentSemantic.Strong)]
	HTTimeAwarePolyline LocationTimeSeries { get; }

	// @property (readonly, nonatomic) int isCurrentUser;
	[Export ("isCurrentUser")]
	int IsCurrentUser { get; }

	// -(instancetype _Nonnull)initWithId:(id)id coordinate:(id)coordinate metaData:(MetaData * _Nonnull)metaData callout:(HTCallout * _Nullable)callout isCurrentUser:(id)isCurrentUser locationTimeSeries:(HTTimeAwarePolyline * _Nullable)locationTimeSeries __attribute__((objc_designated_initializer));
	[Export ("initWithId:coordinate:metaData:callout:isCurrentUser:locationTimeSeries:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject id, NSObject coordinate, MetaData metaData, [NullAllowed] HTCallout callout, NSObject isCurrentUser, [NullAllowed] HTTimeAwarePolyline locationTimeSeries);

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTAnnotationData New ();
}

// @interface HTAppleMapsProvider
[DisableDefaultCtor]
interface HTAppleMapsProvider
{
	// @property (readonly, nonatomic, strong) UIView * _Nonnull contentView;
	[Export ("contentView", ArgumentSemantic.Strong)]
	UIView ContentView { get; }

	// @property (nonatomic) int showCurrentLocation;
	[Export ("showCurrentLocation")]
	int ShowCurrentLocation { get; set; }

	[Wrap ("WeakUpdatesDelegate")]
	[NullAllowed]
	HTMapViewUpdatesDelegate UpdatesDelegate { get; set; }

	// @property (nonatomic, weak) id<HTMapViewUpdatesDelegate> _Nullable updatesDelegate;
	[NullAllowed, Export ("updatesDelegate", ArgumentSemantic.Weak)]
	NSObject WeakUpdatesDelegate { get; set; }

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTAppleMapsProvider New ();
}

// @interface HyperTrack_Swift_512 (HTAppleMapsProvider)
[Category]
[BaseType (typeof(HTAppleMapsProvider))]
interface HTAppleMapsProvider_HyperTrack_Swift_512
{
	// -(void)centerMapOnAllAnnotations:(id)animated;
	[Export ("centerMapOnAllAnnotations:")]
	void CenterMapOnAllAnnotations (NSObject animated);
}

// @interface HyperTrack_Swift_523 (HTAppleMapsProvider)
[Category]
[BaseType (typeof(HTAppleMapsProvider))]
interface HTAppleMapsProvider_HyperTrack_Swift_523
{
	// -(void)mapView:(MKMapView * _Nonnull)mapView didUpdateUserLocation:(MKUserLocation * _Nonnull)userLocation;
	[Export ("mapView:didUpdateUserLocation:")]
	void MapView (MKMapView mapView, MKUserLocation userLocation);

	// -(void)mapViewDidFinishLoadingMap:(MKMapView * _Nonnull)mapView;
	[Export ("mapViewDidFinishLoadingMap:")]
	void MapViewDidFinishLoadingMap (MKMapView mapView);

	// -(MKAnnotationView * _Nullable)mapView:(MKMapView * _Nonnull)mapView viewForAnnotation:(id<MKAnnotation> _Nonnull)annotation __attribute__((warn_unused_result));
	[Export ("mapView:viewForAnnotation:")]
	[return: NullAllowed]
	MKAnnotationView MapView (MKMapView mapView, MKAnnotation annotation);

	// -(MKOverlayRenderer * _Nonnull)mapView:(MKMapView * _Nonnull)mapView rendererForOverlay:(id<MKOverlay> _Nonnull)overlay __attribute__((warn_unused_result));
	[Export ("mapView:rendererForOverlay:")]
	MKOverlayRenderer MapView (MKMapView mapView, MKOverlay overlay);

	// -(void)mapView:(MKMapView * _Nonnull)mapView regionWillChangeAnimated:(id)animated;
	[Export ("mapView:regionWillChangeAnimated:")]
	void MapView (MKMapView mapView, NSObject animated);

	// -(void)mapView:(MKMapView * _Nonnull)mapView regionDidChangeAnimated:(id)animated;
	[Export ("mapView:regionDidChangeAnimated:")]
	void MapView (MKMapView mapView, NSObject animated);
}

// @protocol HTMapViewDelegate
[Protocol, Model]
interface HTMapViewDelegate
{
	// @required @property (nonatomic) int showCurrentLocation;
	[Abstract]
	[Export ("showCurrentLocation")]
	int ShowCurrentLocation { get; set; }

	// @required -(void)cleanUp;
	[Abstract]
	[Export ("cleanUp")]
	void CleanUp ();

	// @required -(void)addAnnotations:(id)data;
	[Abstract]
	[Export ("addAnnotations:")]
	void AddAnnotations (NSObject data);

	// @required -(void)addPolyline:(id)data;
	[Abstract]
	[Export ("addPolyline:")]
	void AddPolyline (NSObject data);

	// @required -(void)addTrailingPolyline:(id)data;
	[Abstract]
	[Export ("addTrailingPolyline:")]
	void AddTrailingPolyline (NSObject data);

	// @required -(void)updateMapVisibleRegion:(id)insets;
	[Abstract]
	[Export ("updateMapVisibleRegion:")]
	void UpdateMapVisibleRegion (NSObject insets);

	// @required -(id)getCenterCoordinates __attribute__((warn_unused_result));
	[Abstract]
	[Export ("getCenterCoordinates")]
	[Verify (MethodToProperty)]
	NSObject CenterCoordinates { get; }

	// @required -(void)showCoordinates:(id)coordinates;
	[Abstract]
	[Export ("showCoordinates:")]
	void ShowCoordinates (NSObject coordinates);
}

// @protocol HTMapsProviderProtocol <HTMapViewDelegate>
[Protocol, Model]
interface HTMapsProviderProtocol : IHTMapViewDelegate
{
	[Wrap ("WeakUpdatesDelegate"), Abstract]
	[NullAllowed]
	HTMapViewUpdatesDelegate UpdatesDelegate { get; set; }

	// @required @property (nonatomic, strong) id<HTMapViewUpdatesDelegate> _Nullable updatesDelegate;
	[Abstract]
	[NullAllowed, Export ("updatesDelegate", ArgumentSemantic.Strong)]
	NSObject WeakUpdatesDelegate { get; set; }

	// @required @property (readonly, nonatomic, strong) UIView * _Nonnull contentView;
	[Abstract]
	[Export ("contentView", ArgumentSemantic.Strong)]
	UIView ContentView { get; }

	// @required -(void)centerMapOnAllAnnotations:(id)animated;
	[Abstract]
	[Export ("centerMapOnAllAnnotations:")]
	void CenterMapOnAllAnnotations (NSObject animated);
}

// @interface HyperTrack_Swift_555 (HTAppleMapsProvider) <HTMapsProviderProtocol>
[Category]
[BaseType (typeof(HTAppleMapsProvider))]
interface HTAppleMapsProvider_HyperTrack_Swift_555 : IHTMapsProviderProtocol
{
	// -(void)cleanUp;
	[Export ("cleanUp")]
	void CleanUp ();

	// -(void)addAnnotations:(id)data;
	[Export ("addAnnotations:")]
	void AddAnnotations (NSObject data);

	// -(void)addPolyline:(id)data;
	[Export ("addPolyline:")]
	void AddPolyline (NSObject data);

	// -(void)showCoordinates:(id)coordinates;
	[Export ("showCoordinates:")]
	void ShowCoordinates (NSObject coordinates);

	// -(void)addTrailingPolyline:(id)data;
	[Export ("addTrailingPolyline:")]
	void AddTrailingPolyline (NSObject data);

	// -(void)updateMapVisibleRegion:(id)insets;
	[Export ("updateMapVisibleRegion:")]
	void UpdateMapVisibleRegion (NSObject insets);

	// -(id)getCenterCoordinates __attribute__((warn_unused_result));
	[Export ("getCenterCoordinates")]
	[Verify (MethodToProperty)]
	NSObject CenterCoordinates { get; }
}

// @protocol HTAuxillaryFlowDelegate
[Protocol, Model]
interface HTAuxillaryFlowDelegate
{
	// @required -(void)cancelClicked;
	[Abstract]
	[Export ("cancelClicked")]
	void CancelClicked ();
}

// @interface HTBaseTrackingUseCase : HTBaseUseCase
[BaseType (typeof(HTBaseUseCase))]
[DisableDefaultCtor]
interface HTBaseTrackingUseCase
{
	// @property (nonatomic) double pollDuration;
	[Export ("pollDuration")]
	double PollDuration { get; set; }

	// @property (readonly, nonatomic) int isPollingEnabled;
	[Export ("isPollingEnabled")]
	int IsPollingEnabled { get; }

	// -(void)update;
	[Export ("update")]
	void Update ();

	// -(instancetype _Nonnull)initWithViewModel:(id<HTBaseTrackingViewModelProtocol> _Nullable)viewModel __attribute__((objc_designated_initializer));
	[Export ("initWithViewModel:")]
	[DesignatedInitializer]
	IntPtr Constructor ([NullAllowed] HTBaseTrackingViewModelProtocol viewModel);

	// -(void)stop;
	[Export ("stop")]
	void Stop ();

	// -(void)trackActionWithType:(HTTrackWithTypeData * _Nonnull)type pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithType:pollDuration:completionHandler:")]
	void TrackActionWithType (HTTrackWithTypeData type, double pollDuration, [NullAllowed] Action<int> completionHandler);

	// -(void)trackActionWithIds:(id)ids pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithIds:pollDuration:completionHandler:")]
	void TrackActionWithIds (NSObject ids, double pollDuration, [NullAllowed] Action<int> completionHandler);

	// -(void)trackActionWithCollectionId:(id)id pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithCollectionId:pollDuration:completionHandler:")]
	void TrackActionWithCollectionId (NSObject id, double pollDuration, [NullAllowed] Action<int> completionHandler);

	// -(void)trackActionWithUniqueId:(id)id pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithUniqueId:pollDuration:completionHandler:")]
	void TrackActionWithUniqueId (NSObject id, double pollDuration, [NullAllowed] Action<int> completionHandler);

	// -(void)trackActionWithShortCodes:(id)codes pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithShortCodes:pollDuration:completionHandler:")]
	void TrackActionWithShortCodes (NSObject codes, double pollDuration, [NullAllowed] Action<int> completionHandler);

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTBaseTrackingUseCase New ();
}

// @protocol HTBaseViewModelProtocol
[Protocol, Model]
interface HTBaseViewModelProtocol
{
}

// @protocol HTBaseTrackingViewModelProtocol <HTBaseViewModelProtocol>
[Protocol, Model]
interface HTBaseTrackingViewModelProtocol : IHTBaseViewModelProtocol
{
	// @required -(void)completeAction:(id)id completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
	[Abstract]
	[Export ("completeAction:completionHandler:")]
	void CompleteAction (NSObject id, [NullAllowed] Action<HTAction, HTError> completionHandler);

	// @required -(void)trackActionWithIds:(id)ids completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Abstract]
	[Export ("trackActionWithIds:completionHandler:")]
	void TrackActionWithIds (NSObject ids, [NullAllowed] Action<int> completionHandler);

	// @required -(void)trackActionWithCollectionId:(id)id completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Abstract]
	[Export ("trackActionWithCollectionId:completionHandler:")]
	void TrackActionWithCollectionId (NSObject id, [NullAllowed] Action<int> completionHandler);

	// @required -(void)trackActionWithUniqueId:(id)id completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Abstract]
	[Export ("trackActionWithUniqueId:completionHandler:")]
	void TrackActionWithUniqueId (NSObject id, [NullAllowed] Action<int> completionHandler);

	// @required -(void)trackActionWithShortCodes:(id)codes completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Abstract]
	[Export ("trackActionWithShortCodes:completionHandler:")]
	void TrackActionWithShortCodes (NSObject codes, [NullAllowed] Action<int> completionHandler);

	// @required -(void)addExpectedPlaceWithActionId:(id)actionId newPlace:(HTPlace * _Nonnull)newPlace completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
	[Abstract]
	[Export ("addExpectedPlaceWithActionId:newPlace:completionHandler:")]
	void AddExpectedPlaceWithActionId (NSObject actionId, HTPlace newPlace, [NullAllowed] Action<HTAction, HTError> completionHandler);

	// @required -(void)addExpectedPlaceWithCollectionId:(id)collectionId newPlace:(HTPlace * _Nonnull)newPlace completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
	[Abstract]
	[Export ("addExpectedPlaceWithCollectionId:newPlace:completionHandler:")]
	void AddExpectedPlaceWithCollectionId (NSObject collectionId, HTPlace newPlace, [NullAllowed] Action<HTAction, HTError> completionHandler);
}

// @interface HTBaseTrackingViewModel <HTBaseTrackingViewModelProtocol>
interface HTBaseTrackingViewModel : IHTBaseTrackingViewModelProtocol
{
	// -(void)trackActionWithIds:(id)ids completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithIds:completionHandler:")]
	void TrackActionWithIds (NSObject ids, [NullAllowed] Action<int> completionHandler);

	// -(void)trackActionWithCollectionId:(id)id completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithCollectionId:completionHandler:")]
	void TrackActionWithCollectionId (NSObject id, [NullAllowed] Action<int> completionHandler);

	// -(void)trackActionWithUniqueId:(id)id completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithUniqueId:completionHandler:")]
	void TrackActionWithUniqueId (NSObject id, [NullAllowed] Action<int> completionHandler);

	// -(void)trackActionWithShortCodes:(id)codes completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithShortCodes:completionHandler:")]
	void TrackActionWithShortCodes (NSObject codes, [NullAllowed] Action<int> completionHandler);

	// -(void)addExpectedPlaceWithActionId:(id)actionId newPlace:(HTPlace * _Nonnull)newPlace completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
	[Export ("addExpectedPlaceWithActionId:newPlace:completionHandler:")]
	void AddExpectedPlaceWithActionId (NSObject actionId, HTPlace newPlace, [NullAllowed] Action<HTAction, HTError> completionHandler);

	// -(void)addExpectedPlaceWithCollectionId:(id)collectionId newPlace:(HTPlace * _Nonnull)newPlace completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
	[Export ("addExpectedPlaceWithCollectionId:newPlace:completionHandler:")]
	void AddExpectedPlaceWithCollectionId (NSObject collectionId, HTPlace newPlace, [NullAllowed] Action<HTAction, HTError> completionHandler);

	// -(void)completeAction:(id)id completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
	[Export ("completeAction:completionHandler:")]
	void CompleteAction (NSObject id, [NullAllowed] Action<HTAction, HTError> completionHandler);
}

// @interface HTBaseView
interface HTBaseView
{
	// @property (nonatomic) int enableShadow;
	[Export ("enableShadow")]
	int EnableShadow { get; set; }

	// @property (nonatomic, strong) UIColor * _Nullable dashBorderedColor;
	[NullAllowed, Export ("dashBorderedColor", ArgumentSemantic.Strong)]
	UIColor DashBorderedColor { get; set; }

	// @property (nonatomic) int topCornerRadius;
	[Export ("topCornerRadius")]
	int TopCornerRadius { get; set; }

	// -(void)layoutSubviews;
	[Export ("layoutSubviews")]
	void LayoutSubviews ();

	// -(instancetype _Nonnull)initWithFrame:(id)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject frame);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);
}

// @protocol HTBasicComponentProtocol
[Protocol, Model]
interface HTBasicComponentProtocol
{
}

// @interface HTBottomViewActionData
[DisableDefaultCtor]
interface HTBottomViewActionData
{
	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTBottomViewActionData New ();
}

// @interface HTBottomViewContainer
interface HTBottomViewContainer
{
	// @property (nonatomic) int isShadowEnabled;
	[Export ("isShadowEnabled")]
	int IsShadowEnabled { get; set; }

	// @property (nonatomic) int isBlurEnabled;
	[Export ("isBlurEnabled")]
	int IsBlurEnabled { get; set; }

	// -(void)setContentView:(UIView * _Nullable)contentView;
	[Export ("setContentView:")]
	void SetContentView ([NullAllowed] UIView contentView);

	// -(instancetype _Nonnull)initWithFrame:(id)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject frame);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);
}

// @protocol HTBottomViewUseCaseDelegate
[Protocol, Model]
interface HTBottomViewUseCaseDelegate
{
	// @required -(void)actionPerformed:(HTBottomViewActionData * _Nonnull)data;
	[Abstract]
	[Export ("actionPerformed:")]
	void ActionPerformed (HTBottomViewActionData data);
}

// @interface HTButton
interface HTButton
{
	// @property (nonatomic) int topCornerRadius;
	[Export ("topCornerRadius")]
	int TopCornerRadius { get; set; }

	// -(void)layoutSubviews;
	[Export ("layoutSubviews")]
	void LayoutSubviews ();

	// -(instancetype _Nonnull)initWithFrame:(id)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject frame);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);
}

// @protocol HTCalendarDelegate
[Protocol, Model]
interface HTCalendarDelegate
{
	// @required -(void)didSelectDate:(id)date;
	[Abstract]
	[Export ("didSelectDate:")]
	void DidSelectDate (NSObject date);
}

// @protocol HTCalendarProviderProtocol
[Protocol, Model]
interface HTCalendarProviderProtocol
{
	// @required @property (readonly, nonatomic, strong) UIView * _Nonnull contentView;
	[Abstract]
	[Export ("contentView", ArgumentSemantic.Strong)]
	UIView ContentView { get; }

	// @required @property (copy, nonatomic) int * _Nonnull minimumDate;
	[Abstract]
	[Export ("minimumDate", ArgumentSemantic.Copy)]
	unsafe int* MinimumDate { get; set; }

	// @required @property (copy, nonatomic) int * _Nonnull maximumDate;
	[Abstract]
	[Export ("maximumDate", ArgumentSemantic.Copy)]
	unsafe int* MaximumDate { get; set; }

	[Wrap ("WeakDelegate"), Abstract]
	[NullAllowed]
	HTCalendarDelegate Delegate { get; set; }

	// @required @property (nonatomic, strong) id<HTCalendarDelegate> _Nullable delegate;
	[Abstract]
	[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
	NSObject WeakDelegate { get; set; }
}

// @interface HTCalendarProvider <HTCalendarProviderProtocol>
interface HTCalendarProvider : IHTCalendarProviderProtocol
{
	// @property (readonly, nonatomic, strong) UIView * _Nonnull contentView;
	[Export ("contentView", ArgumentSemantic.Strong)]
	UIView ContentView { get; }

	[Wrap ("WeakDelegate")]
	[NullAllowed]
	HTCalendarDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<HTCalendarDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @property (copy, nonatomic) int * _Nonnull minimumDate;
	[Export ("minimumDate", ArgumentSemantic.Copy)]
	unsafe int* MinimumDate { get; set; }

	// @property (copy, nonatomic) int * _Nonnull maximumDate;
	[Export ("maximumDate", ArgumentSemantic.Copy)]
	unsafe int* MaximumDate { get; set; }
}

// @interface HTCallout
[DisableDefaultCtor]
interface HTCallout
{
	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTCallout New ();
}

// @interface HTCalloutView
interface HTCalloutView
{
	// @property (nonatomic, strong) HTCallout * _Nullable data;
	[NullAllowed, Export ("data", ArgumentSemantic.Strong)]
	HTCallout Data { get; set; }

	// -(instancetype _Nonnull)initWithFrame:(id)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject frame);

	// -(instancetype _Nonnull)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder coder);
}

// @protocol HTColorProviderProtocol
[Protocol, Model]
interface HTColorProviderProtocol
{
	// @required @property (readonly, nonatomic, strong) UIColor * _Nonnull text;
	[Abstract]
	[Export ("text", ArgumentSemantic.Strong)]
	UIColor Text { get; }

	// @required @property (readonly, getter = default, nonatomic, strong) UIColor * _Nonnull default_;
	[Abstract]
	[Export ("default_", ArgumentSemantic.Strong)]
	UIColor Default_ { [Bind ("default")] get; }

	// @required @property (readonly, nonatomic, strong) UIColor * _Nonnull primary;
	[Abstract]
	[Export ("primary", ArgumentSemantic.Strong)]
	UIColor Primary { get; }

	// @required @property (readonly, nonatomic, strong) UIColor * _Nonnull secondary;
	[Abstract]
	[Export ("secondary", ArgumentSemantic.Strong)]
	UIColor Secondary { get; }

	// @required @property (readonly, nonatomic, strong) UIColor * _Nonnull gray;
	[Abstract]
	[Export ("gray", ArgumentSemantic.Strong)]
	UIColor Gray { get; }

	// @required @property (readonly, nonatomic, strong) UIColor * _Nonnull error;
	[Abstract]
	[Export ("error", ArgumentSemantic.Strong)]
	UIColor Error { get; }

	// @required @property (readonly, nonatomic, strong) UIColor * _Nonnull brand;
	[Abstract]
	[Export ("brand", ArgumentSemantic.Strong)]
	UIColor Brand { get; }

	// @required @property (readonly, nonatomic, strong) UIColor * _Nonnull positive;
	[Abstract]
	[Export ("positive", ArgumentSemantic.Strong)]
	UIColor Positive { get; }

	// @required @property (readonly, nonatomic, strong) UIColor * _Nonnull dropShadow;
	[Abstract]
	[Export ("dropShadow", ArgumentSemantic.Strong)]
	UIColor DropShadow { get; }

	// @required @property (readonly, nonatomic, strong) UIColor * _Nonnull errorDark;
	[Abstract]
	[Export ("errorDark", ArgumentSemantic.Strong)]
	UIColor ErrorDark { get; }

	// @required @property (readonly, nonatomic, strong) UIColor * _Nonnull lightGray;
	[Abstract]
	[Export ("lightGray", ArgumentSemantic.Strong)]
	UIColor LightGray { get; }
}

// @protocol HTComponentProtocol <HTBasicComponentProtocol>
[Protocol, Model]
interface HTComponentProtocol : IHTBasicComponentProtocol
{
	// @required @property (readonly, nonatomic) enum HTComponentType type;
	[Abstract]
	[Export ("type")]
	HTComponentType Type { get; }
}

// @protocol HTDateSwitcherViewDelegate
[Protocol, Model]
interface HTDateSwitcherViewDelegate
{
	// @required -(void)dateChanged:(id)date;
	[Abstract]
	[Export ("dateChanged:")]
	void DateChanged (NSObject date);

	// @required -(void)openCalendar:(id)open selectedDate:(id)selectedDate;
	[Abstract]
	[Export ("openCalendar:selectedDate:")]
	void OpenCalendar (NSObject open, NSObject selectedDate);
}

// @interface HTDebouncer
[DisableDefaultCtor]
interface HTDebouncer
{
	// -(instancetype _Nonnull)initWithDelay:(double)delay callback:(void (^ _Nonnull)(void))callback __attribute__((objc_designated_initializer));
	[Export ("initWithDelay:callback:")]
	[DesignatedInitializer]
	IntPtr Constructor (double delay, Action callback);

	// -(void)call;
	[Export ("call")]
	void Call ();

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTDebouncer New ();
}

// @interface HTError
[DisableDefaultCtor]
interface HTError
{
	// @property (readonly, nonatomic) enum HTErrorCode errorCode;
	[Export ("errorCode")]
	HTErrorCode ErrorCode { get; }

	// @property (copy, nonatomic) int * _Nonnull errorMessage;
	[Export ("errorMessage", ArgumentSemantic.Copy)]
	unsafe int* ErrorMessage { get; set; }

	// @property (readonly, copy, nonatomic) int * _Nonnull displayErrorMessage;
	[Export ("displayErrorMessage", ArgumentSemantic.Copy)]
	unsafe int* DisplayErrorMessage { get; }

	// -(id)toJson __attribute__((warn_unused_result));
	[Export ("toJson")]
	[Verify (MethodToProperty)]
	NSObject ToJson { get; }

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTError New ();
}

// @protocol HTEventsDelegate
[Protocol, Model]
interface HTEventsDelegate
{
	// @required -(void)didReceiveEvent:(HyperTrackEvent * _Nonnull)event;
	[Abstract]
	[Export ("didReceiveEvent:")]
	void DidReceiveEvent (HyperTrackEvent @event);

	// @required -(void)didFailWithError:(HTError * _Nonnull)error;
	[Abstract]
	[Export ("didFailWithError:")]
	void DidFailWithError (HTError error);

	// @optional -(void)locationStatusChangedForAction:(HTAction * _Nonnull)action isEnabled:(id)isEnabled;
	[Export ("locationStatusChangedForAction:isEnabled:")]
	void LocationStatusChangedForAction (HTAction action, NSObject isEnabled);

	// @optional -(void)networkStatusChangedForAction:(HTAction * _Nonnull)action isConnected:(id)isConnected;
	[Export ("networkStatusChangedForAction:isConnected:")]
	void NetworkStatusChangedForAction (HTAction action, NSObject isConnected);

	// @optional -(void)actionStatusChangedForAction:(HTAction * _Nonnull)forAction toStatus:(id)toStatus;
	[Export ("actionStatusChangedForAction:toStatus:")]
	void ActionStatusChangedForAction (HTAction forAction, NSObject toStatus);

	// @optional -(void)didRefreshDataForAction:(HTAction * _Nonnull)forAction;
	[Export ("didRefreshDataForAction:")]
	void DidRefreshDataForAction (HTAction forAction);

	// @optional -(void)didRefreshDataForCollectionId:(id)forCollectionId actions:(id)actions;
	[Export ("didRefreshDataForCollectionId:actions:")]
	void DidRefreshDataForCollectionId (NSObject forCollectionId, NSObject actions);

	// @optional -(void)didEnterMonitoredRegionWithRegion:(CLRegion * _Nonnull)region;
	[Export ("didEnterMonitoredRegionWithRegion:")]
	void DidEnterMonitoredRegionWithRegion (CLRegion region);

	// @optional -(void)didShowSummaryForAction:(HTAction * _Nonnull)forAction;
	[Export ("didShowSummaryForAction:")]
	void DidShowSummaryForAction (HTAction forAction);
}

// @protocol HTFontProviderProtocol
[Protocol, Model]
interface HTFontProviderProtocol
{
	// @required -(UIFont * _Nonnull)getFont:(enum HTSize)size weight:(enum HTFontWeight)weight __attribute__((warn_unused_result));
	[Abstract]
	[Export ("getFont:weight:")]
	UIFont Weight (HTSize size, HTFontWeight weight);
}

// @interface HTGeoJSONLocation
[DisableDefaultCtor]
interface HTGeoJSONLocation
{
	// @property (readonly, copy, nonatomic) int * _Nonnull type;
	[Export ("type", ArgumentSemantic.Copy)]
	unsafe int* Type { get; }

	// -(instancetype _Nonnull)initWithType:(id)type coordinates:(id)coordinates __attribute__((objc_designated_initializer));
	[Export ("initWithType:coordinates:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject type, NSObject coordinates);

	// -(instancetype _Nullable)initWithDict:(id)dict __attribute__((objc_designated_initializer));
	[Export ("initWithDict:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject dict);

	// -(id)toDict __attribute__((warn_unused_result));
	[Export ("toDict")]
	[Verify (MethodToProperty)]
	NSObject ToDict { get; }

	// -(id)toJson __attribute__((warn_unused_result));
	[Export ("toJson")]
	[Verify (MethodToProperty)]
	NSObject ToJson { get; }

	// +(HTGeoJSONLocation * _Nullable)fromDictWithDict:(id)dict __attribute__((warn_unused_result));
	[Static]
	[Export ("fromDictWithDict:")]
	[return: NullAllowed]
	HTGeoJSONLocation FromDictWithDict (NSObject dict);

	// -(id)toCoordinate2d __attribute__((warn_unused_result));
	[Export ("toCoordinate2d")]
	[Verify (MethodToProperty)]
	NSObject ToCoordinate2d { get; }

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTGeoJSONLocation New ();
}

// @interface HTHealth
[DisableDefaultCtor]
interface HTHealth
{
	// @property (readonly, copy, nonatomic) int * _Nullable batteryStatus;
	[NullAllowed, Export ("batteryStatus", ArgumentSemantic.Copy)]
	unsafe int* BatteryStatus { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable locationStatus;
	[NullAllowed, Export ("locationStatus", ArgumentSemantic.Copy)]
	unsafe int* LocationStatus { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable networkStatus;
	[NullAllowed, Export ("networkStatus", ArgumentSemantic.Copy)]
	unsafe int* NetworkStatus { get; }

	// -(instancetype _Nonnull)initWithDict:(id)dict __attribute__((objc_designated_initializer));
	[Export ("initWithDict:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject dict);

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTHealth New ();
}

// @interface HTLabel
interface HTLabel
{
	// -(instancetype _Nonnull)initWithFrame:(id)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject frame);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);
}

// @protocol HTLayerProviderProtocol
[Protocol, Model]
interface HTLayerProviderProtocol
{
	// @required @property (readonly, nonatomic) int cornerRadius;
	[Abstract]
	[Export ("cornerRadius")]
	int CornerRadius { get; }

	// @required @property (readonly, nonatomic) int borderWidth;
	[Abstract]
	[Export ("borderWidth")]
	int BorderWidth { get; }
}

// @protocol HTTrackingViewProviderProtocol
[Protocol, Model]
interface HTTrackingViewProviderProtocol
{
	[Wrap ("WeakDelegate"), Abstract]
	[NullAllowed]
	HTBottomViewUseCaseDelegate Delegate { get; set; }

	// @required @property (nonatomic, strong) id<HTBottomViewUseCaseDelegate> _Nullable delegate;
	[Abstract]
	[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
	NSObject WeakDelegate { get; set; }

	// @required @property (readonly, nonatomic, strong) UIView * _Nonnull containerView;
	[Abstract]
	[Export ("containerView", ArgumentSemantic.Strong)]
	UIView ContainerView { get; }

	// @required -(void)updateData:(id)data;
	[Abstract]
	[Export ("updateData:")]
	void UpdateData (NSObject data);

	// @required -(void)reloadData;
	[Abstract]
	[Export ("reloadData")]
	void ReloadData ();
}

// @protocol HTLiveTrackingStackViewProviderProtocol <HTTrackingViewProviderProtocol>
[Protocol, Model]
interface HTLiveTrackingStackViewProviderProtocol : IHTTrackingViewProviderProtocol
{
}

// @interface HTLiveTrackingUseCase : HTBaseTrackingUseCase <HTMapViewUseCase>
[BaseType (typeof(HTBaseTrackingUseCase))]
interface HTLiveTrackingUseCase : IHTMapViewUseCase
{
	[Wrap ("WeakTrackingDelegate")]
	[NullAllowed]
	HTLiveTrackingUseCaseDelegate TrackingDelegate { get; set; }

	// @property (nonatomic, weak) id<HTLiveTrackingUseCaseDelegate> _Nullable trackingDelegate;
	[NullAllowed, Export ("trackingDelegate", ArgumentSemantic.Weak)]
	NSObject WeakTrackingDelegate { get; set; }

	[Wrap ("WeakCustomizationDelegate")]
	[NullAllowed]
	HTTrackingCustomizationUseCaseDelegate CustomizationDelegate { get; set; }

	// @property (nonatomic, weak) id<HTTrackingCustomizationUseCaseDelegate> _Nullable customizationDelegate;
	[NullAllowed, Export ("customizationDelegate", ArgumentSemantic.Weak)]
	NSObject WeakCustomizationDelegate { get; set; }

	// @property (nonatomic, strong) int * _Nonnull primaryActionButton;
	[Export ("primaryActionButton", ArgumentSemantic.Strong)]
	unsafe int* PrimaryActionButton { get; set; }

	// @property (nonatomic) int isPrimaryActionHidden;
	[Export ("isPrimaryActionHidden")]
	int IsPrimaryActionHidden { get; set; }

	// @property (nonatomic) int isBackButtonHidden;
	[Export ("isBackButtonHidden")]
	int IsBackButtonHidden { get; set; }

	// @property (nonatomic) int isTrackingEnabled;
	[Export ("isTrackingEnabled")]
	int IsTrackingEnabled { get; set; }

	[Wrap ("WeakNavigationDelegate")]
	[NullAllowed]
	HTUseCaseNavigationDelegate NavigationDelegate { get; set; }

	// @property (nonatomic, weak) id<HTUseCaseNavigationDelegate> _Nullable navigationDelegate;
	[NullAllowed, Export ("navigationDelegate", ArgumentSemantic.Weak)]
	NSObject WeakNavigationDelegate { get; set; }

	[Wrap ("WeakMapDelegate")]
	[NullAllowed]
	HTMapUseCaseDelegate MapDelegate { get; set; }

	// @property (nonatomic, strong) id<HTMapUseCaseDelegate> _Nullable mapDelegate;
	[NullAllowed, Export ("mapDelegate", ArgumentSemantic.Strong)]
	NSObject WeakMapDelegate { get; set; }

	// -(void)update;
	[Export ("update")]
	void Update ();

	// +(instancetype _Nonnull)new;
	[Static]
	[Export ("new")]
	HTLiveTrackingUseCase New ();

	// -(instancetype _Nonnull)initWithMapDelegate:(id<HTMapUseCaseDelegate> _Nullable)mapDelegate;
	[Export ("initWithMapDelegate:")]
	IntPtr Constructor ([NullAllowed] HTMapUseCaseDelegate mapDelegate);

	// -(instancetype _Nonnull)initWithViewModel:(id<HTLiveTrackingUseCaseViewModelProtocol> _Nullable)viewModel provider:(id<HTLiveTrackingStackViewProviderProtocol> _Nullable)provider __attribute__((objc_designated_initializer));
	[Export ("initWithViewModel:provider:")]
	[DesignatedInitializer]
	IntPtr Constructor ([NullAllowed] HTLiveTrackingUseCaseViewModelProtocol viewModel, [NullAllowed] HTLiveTrackingStackViewProviderProtocol provider);

	// -(void)stop;
	[Export ("stop")]
	void Stop ();

	// -(void)trackActionWithType:(HTTrackWithTypeData * _Nonnull)type pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithType:pollDuration:completionHandler:")]
	void TrackActionWithType (HTTrackWithTypeData type, double pollDuration, [NullAllowed] Action<int> completionHandler);

	// -(void)trackActionWithIds:(id)ids pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithIds:pollDuration:completionHandler:")]
	void TrackActionWithIds (NSObject ids, double pollDuration, [NullAllowed] Action<int> completionHandler);

	// -(void)trackActionWithCollectionId:(id)id pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithCollectionId:pollDuration:completionHandler:")]
	void TrackActionWithCollectionId (NSObject id, double pollDuration, [NullAllowed] Action<int> completionHandler);

	// -(void)trackActionWithUniqueId:(id)id pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithUniqueId:pollDuration:completionHandler:")]
	void TrackActionWithUniqueId (NSObject id, double pollDuration, [NullAllowed] Action<int> completionHandler);

	// -(void)trackActionWithShortCodes:(id)codes pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithShortCodes:pollDuration:completionHandler:")]
	void TrackActionWithShortCodes (NSObject codes, double pollDuration, [NullAllowed] Action<int> completionHandler);
}

// @protocol HTUseCaseBackNavigationProtocol
[Protocol, Model]
interface HTUseCaseBackNavigationProtocol
{
	// @required @property (nonatomic, strong) int * _Nonnull primaryActionButton;
	[Abstract]
	[Export ("primaryActionButton", ArgumentSemantic.Strong)]
	unsafe int* PrimaryActionButton { get; set; }

	// @required @property (nonatomic) int isPrimaryActionHidden;
	[Abstract]
	[Export ("isPrimaryActionHidden")]
	int IsPrimaryActionHidden { get; set; }

	[Wrap ("WeakNavigationDelegate"), Abstract]
	[NullAllowed]
	HTUseCaseNavigationDelegate NavigationDelegate { get; set; }

	// @required @property (nonatomic, strong) id<HTUseCaseNavigationDelegate> _Nullable navigationDelegate;
	[Abstract]
	[NullAllowed, Export ("navigationDelegate", ArgumentSemantic.Strong)]
	NSObject WeakNavigationDelegate { get; set; }

	// @required -(void)performActionOnButtonClick;
	[Abstract]
	[Export ("performActionOnButtonClick")]
	void PerformActionOnButtonClick ();
}

// @interface HyperTrack_Swift_952 (HTLiveTrackingUseCase) <HTUseCaseBackNavigationProtocol>
[Category]
[BaseType (typeof(HTLiveTrackingUseCase))]
interface HTLiveTrackingUseCase_HyperTrack_Swift_952 : IHTUseCaseBackNavigationProtocol
{
	// -(void)performActionOnButtonClick;
	[Export ("performActionOnButtonClick")]
	void PerformActionOnButtonClick ();
}

// @interface HyperTrack_Swift_957 (HTLiveTrackingUseCase) <HTUseCaseNavigationDelegate>
[Category]
[BaseType (typeof(HTLiveTrackingUseCase))]
interface HTLiveTrackingUseCase_HyperTrack_Swift_957 : IHTUseCaseNavigationDelegate
{
	// -(void)backClicked;
	[Export ("backClicked")]
	void BackClicked ();
}

// @interface HyperTrack_Swift_962 (HTLiveTrackingUseCase)
[Category]
[BaseType (typeof(HTLiveTrackingUseCase))]
interface HTLiveTrackingUseCase_HyperTrack_Swift_962
{
}

// @interface LiveData
[DisableDefaultCtor]
interface LiveData
{
	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	LiveData New ();
}

// @interface HyperTrack_Swift_973 (HTLiveTrackingUseCase) <HTBottomViewUseCaseDelegate>
[Category]
[BaseType (typeof(HTLiveTrackingUseCase))]
interface HTLiveTrackingUseCase_HyperTrack_Swift_973 : IHTBottomViewUseCaseDelegate
{
	// -(void)actionPerformed:(HTBottomViewActionData * _Nonnull)data;
	[Export ("actionPerformed:")]
	void ActionPerformed (HTBottomViewActionData data);
}

// @protocol HTPlaceSelectionDelegate <HTAuxillaryFlowDelegate>
[Protocol, Model]
interface HTPlaceSelectionDelegate : IHTAuxillaryFlowDelegate
{
	// @required -(void)expectedPlaceSet:(HTPlace * _Nonnull)data;
	[Abstract]
	[Export ("expectedPlaceSet:")]
	void ExpectedPlaceSet (HTPlace data);
}

// @interface HyperTrack_Swift_984 (HTLiveTrackingUseCase) <HTPlaceSelectionDelegate>
[Category]
[BaseType (typeof(HTLiveTrackingUseCase))]
interface HTLiveTrackingUseCase_HyperTrack_Swift_984 : IHTPlaceSelectionDelegate
{
	// -(void)cancelClicked;
	[Export ("cancelClicked")]
	void CancelClicked ();

	// -(void)expectedPlaceSet:(HTPlace * _Nonnull)data;
	[Export ("expectedPlaceSet:")]
	void ExpectedPlaceSet (HTPlace data);
}

// @protocol HTLiveTrackingUseCaseViewModelProtocol <HTBaseTrackingViewModelProtocol>
[Protocol, Model]
interface HTLiveTrackingUseCaseViewModelProtocol : IHTBaseTrackingViewModelProtocol
{
	// @required @property (nonatomic, strong) TrackingInfo * _Nonnull trackingInfo;
	[Abstract]
	[Export ("trackingInfo", ArgumentSemantic.Strong)]
	TrackingInfo TrackingInfo { get; set; }

	// @required -(LiveData * _Nonnull)mapToLiveTrackingUseCaseWithActions:(id)actions __attribute__((warn_unused_result));
	[Abstract]
	[Export ("mapToLiveTrackingUseCaseWithActions:")]
	LiveData MapToLiveTrackingUseCaseWithActions (NSObject actions);

	// @required -(void)mapToLiveTrackingUseCaseWithActions:(id)actions completionHandler:(void (^ _Nonnull)(LiveData * _Nonnull))completionHandler;
	[Abstract]
	[Export ("mapToLiveTrackingUseCaseWithActions:completionHandler:")]
	void MapToLiveTrackingUseCaseWithActions (NSObject actions, Action<LiveData> completionHandler);
}

// @interface HTLiveTrackingUseCaseViewModel : HTBaseTrackingViewModel <HTLiveTrackingUseCaseViewModelProtocol>
[BaseType (typeof(HTBaseTrackingViewModel))]
interface HTLiveTrackingUseCaseViewModel : IHTLiveTrackingUseCaseViewModelProtocol
{
	// @property (nonatomic, strong) TrackingInfo * _Nonnull trackingInfo;
	[Export ("trackingInfo", ArgumentSemantic.Strong)]
	TrackingInfo TrackingInfo { get; set; }

	// -(void)mapToLiveTrackingUseCaseWithActions:(id)actions completionHandler:(void (^ _Nonnull)(LiveData * _Nonnull))completionHandler;
	[Export ("mapToLiveTrackingUseCaseWithActions:completionHandler:")]
	void MapToLiveTrackingUseCaseWithActions (NSObject actions, Action<LiveData> completionHandler);

	// -(LiveData * _Nonnull)mapToLiveTrackingUseCaseWithActions:(id)actions __attribute__((warn_unused_result));
	[Export ("mapToLiveTrackingUseCaseWithActions:")]
	LiveData MapToLiveTrackingUseCaseWithActions (NSObject actions);
}

// @interface HTLocation
[DisableDefaultCtor]
interface HTLocation
{
	// @property (copy, nonatomic) int * _Nullable lookUpId;
	[NullAllowed, Export ("lookUpId", ArgumentSemantic.Copy)]
	unsafe int* LookUpId { get; set; }

	// @property (readonly, nonatomic, strong) HTGeoJSONLocation * _Nonnull location;
	[Export ("location", ArgumentSemantic.Strong)]
	HTGeoJSONLocation Location { get; }

	// @property (readonly, nonatomic, strong) CLLocation * _Nonnull clLocation;
	[Export ("clLocation", ArgumentSemantic.Strong)]
	CLLocation ClLocation { get; }

	// @property (readonly, nonatomic) int horizontalAccuracy;
	[Export ("horizontalAccuracy")]
	int HorizontalAccuracy { get; }

	// @property (readonly, nonatomic) int verticalAccuracy;
	[Export ("verticalAccuracy")]
	int VerticalAccuracy { get; }

	// @property (readonly, nonatomic) int speed;
	[Export ("speed")]
	int Speed { get; }

	// @property (readonly, nonatomic) int bearing;
	[Export ("bearing")]
	int Bearing { get; }

	// @property (readonly, nonatomic) int altitude;
	[Export ("altitude")]
	int Altitude { get; }

	// @property (copy, nonatomic) int * _Nonnull activityLookUpId;
	[Export ("activityLookUpId", ArgumentSemantic.Copy)]
	unsafe int* ActivityLookUpId { get; set; }

	// @property (readonly, copy, nonatomic) int * _Nonnull provider;
	[Export ("provider", ArgumentSemantic.Copy)]
	unsafe int* Provider { get; }

	// @property (copy, nonatomic) int * _Nonnull recordedAt;
	[Export ("recordedAt", ArgumentSemantic.Copy)]
	unsafe int* RecordedAt { get; set; }

	// @property (copy, nonatomic) int * _Nullable uploadTime;
	[NullAllowed, Export ("uploadTime", ArgumentSemantic.Copy)]
	unsafe int* UploadTime { get; set; }

	// @property (readonly, copy, nonatomic) int * _Nullable activityConfidence;
	[NullAllowed, Export ("activityConfidence", ArgumentSemantic.Copy)]
	unsafe int* ActivityConfidence { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable activity;
	[NullAllowed, Export ("activity", ArgumentSemantic.Copy)]
	unsafe int* Activity { get; }

	// @property (readonly, nonatomic, strong) HTGeoJSONLocation * _Nullable geojson;
	[NullAllowed, Export ("geojson", ArgumentSemantic.Strong)]
	HTGeoJSONLocation Geojson { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable accuracy;
	[NullAllowed, Export ("accuracy", ArgumentSemantic.Copy)]
	unsafe int* Accuracy { get; }

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTLocation New ();
}

// @interface HTLocationCoordinate
[DisableDefaultCtor]
interface HTLocationCoordinate
{
	// @property (readonly, nonatomic) double lat;
	[Export ("lat")]
	double Lat { get; }

	// @property (readonly, nonatomic) double lng;
	[Export ("lng")]
	double Lng { get; }

	// -(instancetype _Nonnull)initWithLat:(double)lat lng:(double)lng __attribute__((objc_designated_initializer));
	[Export ("initWithLat:lng:")]
	[DesignatedInitializer]
	IntPtr Constructor (double lat, double lng);

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTLocationCoordinate New ();
}

// @interface HTLocationSearchProvider
interface HTLocationSearchProvider
{
	// @property (nonatomic, strong) HTPlace * _Nullable selectedResult;
	[NullAllowed, Export ("selectedResult", ArgumentSemantic.Strong)]
	HTPlace SelectedResult { get; set; }

	// @property (copy, nonatomic) int * _Nonnull searchBarPlaceHolderText;
	[Export ("searchBarPlaceHolderText", ArgumentSemantic.Copy)]
	unsafe int* SearchBarPlaceHolderText { get; set; }

	// @property (nonatomic) int enableCurrentLocationSelection;
	[Export ("enableCurrentLocationSelection")]
	int EnableCurrentLocationSelection { get; set; }

	// @property (nonatomic) int enableChooseOnMapSelection;
	[Export ("enableChooseOnMapSelection")]
	int EnableChooseOnMapSelection { get; set; }

	// @property (readonly, nonatomic, strong) UIView * _Nonnull contentView;
	[Export ("contentView", ArgumentSemantic.Strong)]
	UIView ContentView { get; }

	// -(instancetype _Nonnull)init:(id)data __attribute__((objc_designated_initializer));
	[Export ("init:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject data);

	// -(void)updateData:(id)data;
	[Export ("updateData:")]
	void UpdateData (NSObject data);

	// -(void)reloadData;
	[Export ("reloadData")]
	void ReloadData ();

	// -(void)clear;
	[Export ("clear")]
	void Clear ();
}

// @interface HyperTrack_Swift_1072 (HTLocationSearchProvider)
[Category]
[BaseType (typeof(HTLocationSearchProvider))]
interface HTLocationSearchProvider_HyperTrack_Swift_1072
{
	// -(id)textFieldShouldReturn:(UITextField * _Nonnull)textField __attribute__((warn_unused_result));
	[Export ("textFieldShouldReturn:")]
	NSObject TextFieldShouldReturn (UITextField textField);

	// -(id)textField:(UITextField * _Nonnull)textField shouldChangeCharactersInRange:(id)range replacementString:(id)string __attribute__((warn_unused_result));
	[Export ("textField:shouldChangeCharactersInRange:replacementString:")]
	NSObject TextField (UITextField textField, NSObject range, NSObject @string);
}

// @interface HyperTrack_Swift_1080 (HTLocationSearchProvider)
[Category]
[BaseType (typeof(HTLocationSearchProvider))]
interface HTLocationSearchProvider_HyperTrack_Swift_1080
{
	// -(id)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((warn_unused_result));
	[Export ("numberOfSectionsInTableView:")]
	NSObject NumberOfSectionsInTableView (UITableView tableView);

	// -(id)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(id)section __attribute__((warn_unused_result));
	[Export ("tableView:numberOfRowsInSection:")]
	NSObject TableView (UITableView tableView, NSObject section);

	// -(UITableViewCell * _Nonnull)tableView:(UITableView * _Nonnull)tableView cellForRowAtIndexPath:(id)indexPath __attribute__((warn_unused_result));
	[Export ("tableView:cellForRowAtIndexPath:")]
	UITableViewCell TableView (UITableView tableView, NSObject indexPath);
}

// @interface HyperTrack_Swift_1087 (HTLocationSearchProvider)
[Category]
[BaseType (typeof(HTLocationSearchProvider))]
interface HTLocationSearchProvider_HyperTrack_Swift_1087
{
	// -(void)tableView:(UITableView * _Nonnull)tableView didSelectRowAtIndexPath:(id)indexPath;
	[Export ("tableView:didSelectRowAtIndexPath:")]
	void TableView (UITableView tableView, NSObject indexPath);

	// -(id)tableView:(UITableView * _Nonnull)tableView heightForRowAtIndexPath:(id)indexPath __attribute__((warn_unused_result));
	[Export ("tableView:heightForRowAtIndexPath:")]
	NSObject TableView (UITableView tableView, NSObject indexPath);

	// -(id)tableView:(UITableView * _Nonnull)tableView heightForHeaderInSection:(id)section __attribute__((warn_unused_result));
	[Export ("tableView:heightForHeaderInSection:")]
	NSObject TableView (UITableView tableView, NSObject section);

	// -(id)tableView:(UITableView * _Nonnull)tableView heightForFooterInSection:(id)section __attribute__((warn_unused_result));
	[Export ("tableView:heightForFooterInSection:")]
	NSObject TableView (UITableView tableView, NSObject section);
}

// @protocol HTLocationUpdatesDelegate
[Protocol, Model]
interface HTLocationUpdatesDelegate
{
	// @required -(void)didUpdateLocations:(id)locations;
	[Abstract]
	[Export ("didUpdateLocations:")]
	void DidUpdateLocations (NSObject locations);
}

// @interface HTLogger
[DisableDefaultCtor]
interface HTLogger
{
	// @property (readonly, nonatomic, strong, class) HTLogger * _Nonnull shared;
	[Static]
	[Export ("shared", ArgumentSemantic.Strong)]
	HTLogger Shared { get; }

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTLogger New ();
}

// @interface HTMapContainer
interface HTMapContainer
{
	// @property (nonatomic) int showCurrentLocation;
	[Export ("showCurrentLocation")]
	int ShowCurrentLocation { get; set; }

	// @property (nonatomic) int enableZoom;
	[Export ("enableZoom")]
	int EnableZoom { get; set; }

	// @property (nonatomic) int isRecenterButtonHidden;
	[Export ("isRecenterButtonHidden")]
	int IsRecenterButtonHidden { get; set; }

	// -(void)layoutSubviews;
	[Export ("layoutSubviews")]
	void LayoutSubviews ();

	// -(instancetype _Nonnull)initWithFrame:(id)frame mapProvider:(id<HTMapsProviderProtocol> _Nonnull)mapProvider __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:mapProvider:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject frame, HTMapsProviderProtocol mapProvider);

	// -(instancetype _Nonnull)initWithFrame:(id)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject frame);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);

	// -(void)setBottomViewWithUseCase:(id<HTMapViewUseCase> _Nonnull)useCase;
	[Export ("setBottomViewWithUseCase:")]
	void SetBottomViewWithUseCase (HTMapViewUseCase useCase);
}

// @protocol HTMapViewUpdatesDelegate
[Protocol, Model]
interface HTMapViewUpdatesDelegate
{
	// @required -(void)mapViewDidChangeWithCenterCoordinate:(id)centerCoordinate;
	[Abstract]
	[Export ("mapViewDidChangeWithCenterCoordinate:")]
	void MapViewDidChangeWithCenterCoordinate (NSObject centerCoordinate);
}

// @interface HyperTrack_Swift_1133 (HTMapContainer) <HTMapViewUpdatesDelegate>
[Category]
[BaseType (typeof(HTMapContainer))]
interface HTMapContainer_HyperTrack_Swift_1133 : IHTMapViewUpdatesDelegate
{
	// -(void)mapViewDidChangeWithCenterCoordinate:(id)centerCoordinate;
	[Export ("mapViewDidChangeWithCenterCoordinate:")]
	void MapViewDidChangeWithCenterCoordinate (NSObject centerCoordinate);
}

// @protocol HTMapUseCaseDelegate <HTMapViewDelegate>
[Protocol, Model]
interface HTMapUseCaseDelegate : IHTMapViewDelegate
{
	// @required -(void)showErrorWithText:(id)text;
	[Abstract]
	[Export ("showErrorWithText:")]
	void ShowErrorWithText (NSObject text);

	// @required -(void)setBottomView:(UIView * _Nullable)view;
	[Abstract]
	[Export ("setBottomView:")]
	void SetBottomView ([NullAllowed] UIView view);

	// @required -(void)setBottomView:(UIView * _Nullable)view atPosition:(enum HTSwipePosition)atPosition;
	[Abstract]
	[Export ("setBottomView:atPosition:")]
	void SetBottomView ([NullAllowed] UIView view, HTSwipePosition atPosition);

	// @required -(id)updateBottomViewPosition:(enum HTSwipePosition)position __attribute__((warn_unused_result));
	[Abstract]
	[Export ("updateBottomViewPosition:")]
	NSObject UpdateBottomViewPosition (HTSwipePosition position);

	// @required -(void)setPrimaryAction:(UIView * _Nullable)view anchor:(enum AnchorPosition)anchor;
	[Abstract]
	[Export ("setPrimaryAction:anchor:")]
	void SetPrimaryAction ([NullAllowed] UIView view, AnchorPosition anchor);

	// @required -(void)setCenterFloatingView:(UIView * _Nullable)view offset:(id)offset;
	[Abstract]
	[Export ("setCenterFloatingView:offset:")]
	void SetCenterFloatingView ([NullAllowed] UIView view, NSObject offset);

	// @required -(void)setMapViewUpdatesDelegate:(id<HTMapViewUpdatesDelegate> _Nullable)delegate;
	[Abstract]
	[Export ("setMapViewUpdatesDelegate:")]
	void SetMapViewUpdatesDelegate ([NullAllowed] HTMapViewUpdatesDelegate @delegate);

	// @required @property (nonatomic) int enableZoom;
	[Abstract]
	[Export ("enableZoom")]
	int EnableZoom { get; set; }

	// @required -(id)getBottomPadding __attribute__((warn_unused_result));
	[Abstract]
	[Export ("getBottomPadding")]
	[Verify (MethodToProperty)]
	NSObject BottomPadding { get; }
}

// @interface HyperTrack_Swift_1157 (HTMapContainer) <HTMapUseCaseDelegate>
[Category]
[BaseType (typeof(HTMapContainer))]
interface HTMapContainer_HyperTrack_Swift_1157 : IHTMapUseCaseDelegate
{
	// -(id)getBottomPadding __attribute__((warn_unused_result));
	[Export ("getBottomPadding")]
	[Verify (MethodToProperty)]
	NSObject BottomPadding { get; }

	// -(id)updateBottomViewPosition:(enum HTSwipePosition)position __attribute__((warn_unused_result));
	[Export ("updateBottomViewPosition:")]
	NSObject UpdateBottomViewPosition (HTSwipePosition position);

	// -(void)setBottomView:(UIView * _Nullable)view atPosition:(enum HTSwipePosition)atPosition;
	[Export ("setBottomView:atPosition:")]
	void SetBottomView ([NullAllowed] UIView view, HTSwipePosition atPosition);

	// -(void)cleanUp;
	[Export ("cleanUp")]
	void CleanUp ();

	// -(void)addAnnotations:(id)data;
	[Export ("addAnnotations:")]
	void AddAnnotations (NSObject data);

	// -(void)addPolyline:(id)data;
	[Export ("addPolyline:")]
	void AddPolyline (NSObject data);

	// -(void)addTrailingPolyline:(id)data;
	[Export ("addTrailingPolyline:")]
	void AddTrailingPolyline (NSObject data);

	// -(void)updateMapVisibleRegion:(id)insets;
	[Export ("updateMapVisibleRegion:")]
	void UpdateMapVisibleRegion (NSObject insets);

	// -(void)setBottomView:(UIView * _Nullable)view;
	[Export ("setBottomView:")]
	void SetBottomView ([NullAllowed] UIView view);

	// -(void)setPrimaryAction:(UIView * _Nullable)view anchor:(enum AnchorPosition)anchor;
	[Export ("setPrimaryAction:anchor:")]
	void SetPrimaryAction ([NullAllowed] UIView view, AnchorPosition anchor);

	// -(void)setCenterFloatingView:(UIView * _Nullable)view offset:(id)offset;
	[Export ("setCenterFloatingView:offset:")]
	void SetCenterFloatingView ([NullAllowed] UIView view, NSObject offset);

	// -(id)getCenterCoordinates __attribute__((warn_unused_result));
	[Export ("getCenterCoordinates")]
	[Verify (MethodToProperty)]
	NSObject CenterCoordinates { get; }

	// -(void)showErrorWithText:(id)text;
	[Export ("showErrorWithText:")]
	void ShowErrorWithText (NSObject text);

	// -(void)setMapViewUpdatesDelegate:(id<HTMapViewUpdatesDelegate> _Nullable)delegate;
	[Export ("setMapViewUpdatesDelegate:")]
	void SetMapViewUpdatesDelegate ([NullAllowed] HTMapViewUpdatesDelegate @delegate);

	// -(void)showCoordinates:(id)coordinates;
	[Export ("showCoordinates:")]
	void ShowCoordinates (NSObject coordinates);
}

// @protocol HTMapCustomizationDelegate
[Protocol, Model]
interface HTMapCustomizationDelegate
{
	// @optional -(UIImage * _Nullable)userMarkerImageWithAnnotationType:(enum HTAnnotationType)annotationType __attribute__((warn_unused_result));
	[Export ("userMarkerImageWithAnnotationType:")]
	[return: NullAllowed]
	UIImage UserMarkerImageWithAnnotationType (HTAnnotationType annotationType);

	// @optional -(UIImage * _Nullable)userMarkerImageWithActionInfo:(HTActionInfo * _Nonnull)actionInfo __attribute__((warn_unused_result));
	[Export ("userMarkerImageWithActionInfo:")]
	[return: NullAllowed]
	UIImage UserMarkerImageWithActionInfo (HTActionInfo actionInfo);

	// @optional -(UIImage * _Nullable)expectedPlaceMarkerImage __attribute__((warn_unused_result));
	[NullAllowed, Export ("expectedPlaceMarkerImage")]
	[Verify (MethodToProperty)]
	UIImage ExpectedPlaceMarkerImage { get; }

	// @optional -(UIImage * _Nullable)expectedPlaceMarkerImageWithActionInfo:(HTActionInfo * _Nonnull)actionInfo __attribute__((warn_unused_result));
	[Export ("expectedPlaceMarkerImageWithActionInfo:")]
	[return: NullAllowed]
	UIImage ExpectedPlaceMarkerImageWithActionInfo (HTActionInfo actionInfo);
}

// @interface HTMapData
[DisableDefaultCtor]
interface HTMapData
{
	// -(instancetype _Nonnull)initWithAnnotations:(id)annotations polylines:(id)polylines __attribute__((objc_designated_initializer));
	[Export ("initWithAnnotations:polylines:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject annotations, NSObject polylines);

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTMapData New ();
}

// @interface HTMapUtils
interface HTMapUtils
{
	// +(id)headingFrom:(id)previous next:(id)next __attribute__((warn_unused_result));
	[Static]
	[Export ("headingFrom:next:")]
	NSObject HeadingFrom (NSObject previous, NSObject next);

	// +(double)radiansToDegreesWithRadians:(double)radians __attribute__((warn_unused_result));
	[Static]
	[Export ("radiansToDegreesWithRadians:")]
	double RadiansToDegreesWithRadians (double radians);
}

// @interface HTMarkerContentView
interface HTMarkerContentView
{
	// @property (nonatomic, strong) UIColor * _Nullable pulseColor;
	[NullAllowed, Export ("pulseColor", ArgumentSemantic.Strong)]
	UIColor PulseColor { get; set; }

	// @property (nonatomic, strong) UIImage * _Nullable annotationImage;
	[NullAllowed, Export ("annotationImage", ArgumentSemantic.Strong)]
	UIImage AnnotationImage { get; set; }

	// @property (nonatomic, strong) UIImageView * _Nullable imageView;
	[NullAllowed, Export ("imageView", ArgumentSemantic.Strong)]
	UIImageView ImageView { get; set; }

	// @property (nonatomic) int scaleFactor;
	[Export ("scaleFactor")]
	int ScaleFactor { get; set; }

	// @property (nonatomic) double animationDuration;
	[Export ("animationDuration")]
	double AnimationDuration { get; set; }

	// @property (nonatomic) double animationDelay;
	[Export ("animationDelay")]
	double AnimationDelay { get; set; }

	// @property (nonatomic) int size;
	[Export ("size")]
	int Size { get; set; }

	// @property (nonatomic, strong) UIColor * _Nullable annotationColor;
	[NullAllowed, Export ("annotationColor", ArgumentSemantic.Strong)]
	UIColor AnnotationColor { get; set; }

	// @property (nonatomic) int isPulsating;
	[Export ("isPulsating")]
	int IsPulsating { get; set; }

	// -(instancetype _Nonnull)initWithFrame:(id)frame data:(HTAnnotationData * _Nullable)data;
	[Export ("initWithFrame:data:")]
	IntPtr Constructor (NSObject frame, [NullAllowed] HTAnnotationData data);

	// -(instancetype _Nonnull)initWithFrame:(id)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject frame);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);
}

// @protocol HTMarkerImagesProviderProtocol
[Protocol, Model]
interface HTMarkerImagesProviderProtocol
{
	// @required @property (nonatomic, strong) UIImage * _Nullable cycle;
	[Abstract]
	[NullAllowed, Export ("cycle", ArgumentSemantic.Strong)]
	UIImage Cycle { get; set; }

	// @required @property (nonatomic, strong) UIImage * _Nullable destination;
	[Abstract]
	[NullAllowed, Export ("destination", ArgumentSemantic.Strong)]
	UIImage Destination { get; set; }

	// @required @property (nonatomic, strong) UIImage * _Nullable drive;
	[Abstract]
	[NullAllowed, Export ("drive", ArgumentSemantic.Strong)]
	UIImage Drive { get; set; }

	// @required @property (nonatomic, strong) UIImage * _Nullable offline;
	[Abstract]
	[NullAllowed, Export ("offline", ArgumentSemantic.Strong)]
	UIImage Offline { get; set; }

	// @required @property (nonatomic, strong) UIImage * _Nullable stop;
	[Abstract]
	[NullAllowed, Export ("stop", ArgumentSemantic.Strong)]
	UIImage Stop { get; set; }

	// @required @property (nonatomic, strong) UIImage * _Nullable walk;
	[Abstract]
	[NullAllowed, Export ("walk", ArgumentSemantic.Strong)]
	UIImage Walk { get; set; }
}

// @interface HTMockLocationParams
[DisableDefaultCtor]
interface HTMockLocationParams
{
	// @property (readonly, nonatomic) int origin;
	[Export ("origin")]
	int Origin { get; }

	// @property (readonly, nonatomic) int destination;
	[Export ("destination")]
	int Destination { get; }

	// -(instancetype _Nonnull)initWithOrigin:(id)origin destination:(id)destination __attribute__((objc_designated_initializer));
	[Export ("initWithOrigin:destination:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject origin, NSObject destination);

	// -(instancetype _Nonnull)initWithDestination:(id)destination __attribute__((objc_designated_initializer));
	[Export ("initWithDestination:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject destination);

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTMockLocationParams New ();
}

// @interface HTOrderTrackingBottomCard
[DisableDefaultCtor]
interface HTOrderTrackingBottomCard
{
	// -(instancetype _Nonnull)init:(id)components __attribute__((objc_designated_initializer));
	[Export ("init:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject components);

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTOrderTrackingBottomCard New ();
}

// @protocol HTOrderTrackingStackViewProviderProtocol <HTTrackingViewProviderProtocol>
[Protocol, Model]
interface HTOrderTrackingStackViewProviderProtocol : IHTTrackingViewProviderProtocol
{
}

// @interface HTOrderTrackingUseCase : HTBaseTrackingUseCase <HTMapViewUseCase>
[BaseType (typeof(HTBaseTrackingUseCase))]
interface HTOrderTrackingUseCase : IHTMapViewUseCase
{
	[Wrap ("WeakMapDelegate")]
	[NullAllowed]
	HTMapUseCaseDelegate MapDelegate { get; set; }

	// @property (nonatomic, strong) id<HTMapUseCaseDelegate> _Nullable mapDelegate;
	[NullAllowed, Export ("mapDelegate", ArgumentSemantic.Strong)]
	NSObject WeakMapDelegate { get; set; }

	// @property (readonly, nonatomic, strong) HTButton * _Null_unspecified primaryAction;
	[Export ("primaryAction", ArgumentSemantic.Strong)]
	HTButton PrimaryAction { get; }

	[Wrap ("WeakCustomizationDelegate")]
	[NullAllowed]
	HTTrackingCustomizationUseCaseDelegate CustomizationDelegate { get; set; }

	// @property (nonatomic, weak) id<HTTrackingCustomizationUseCaseDelegate> _Nullable customizationDelegate;
	[NullAllowed, Export ("customizationDelegate", ArgumentSemantic.Weak)]
	NSObject WeakCustomizationDelegate { get; set; }

	// @property (nonatomic, strong) int * _Nonnull primaryActionButton;
	[Export ("primaryActionButton", ArgumentSemantic.Strong)]
	unsafe int* PrimaryActionButton { get; set; }

	// @property (nonatomic) int isPrimaryActionHidden;
	[Export ("isPrimaryActionHidden")]
	int IsPrimaryActionHidden { get; set; }

	// @property (nonatomic) int isBackButtonHidden;
	[Export ("isBackButtonHidden")]
	int IsBackButtonHidden { get; set; }

	[Wrap ("WeakTrackingDelegate")]
	[NullAllowed]
	HTOrderTrackingUseCaseDelegate TrackingDelegate { get; set; }

	// @property (nonatomic, weak) id<HTOrderTrackingUseCaseDelegate> _Nullable trackingDelegate;
	[NullAllowed, Export ("trackingDelegate", ArgumentSemantic.Weak)]
	NSObject WeakTrackingDelegate { get; set; }

	[Wrap ("WeakNavigationDelegate")]
	[NullAllowed]
	HTUseCaseNavigationDelegate NavigationDelegate { get; set; }

	// @property (nonatomic, weak) id<HTUseCaseNavigationDelegate> _Nullable navigationDelegate;
	[NullAllowed, Export ("navigationDelegate", ArgumentSemantic.Weak)]
	NSObject WeakNavigationDelegate { get; set; }

	// +(instancetype _Nonnull)new;
	[Static]
	[Export ("new")]
	HTOrderTrackingUseCase New ();

	// -(instancetype _Nonnull)initWithMapDelegate:(id<HTMapUseCaseDelegate> _Nullable)mapDelegate;
	[Export ("initWithMapDelegate:")]
	IntPtr Constructor ([NullAllowed] HTMapUseCaseDelegate mapDelegate);

	// -(instancetype _Nonnull)initWithViewModel:(id<HTOrderTrackingUseCaseViewModelProtocol> _Nullable)viewModel provider:(id<HTOrderTrackingStackViewProviderProtocol> _Nullable)provider __attribute__((objc_designated_initializer));
	[Export ("initWithViewModel:provider:")]
	[DesignatedInitializer]
	IntPtr Constructor ([NullAllowed] HTOrderTrackingUseCaseViewModelProtocol viewModel, [NullAllowed] HTOrderTrackingStackViewProviderProtocol provider);

	// -(void)stop;
	[Export ("stop")]
	void Stop ();

	// -(void)trackActionWithType:(HTTrackWithTypeData * _Nonnull)type pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithType:pollDuration:completionHandler:")]
	void TrackActionWithType (HTTrackWithTypeData type, double pollDuration, [NullAllowed] Action<int> completionHandler);

	// -(void)trackActionWithIds:(id)ids pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithIds:pollDuration:completionHandler:")]
	void TrackActionWithIds (NSObject ids, double pollDuration, [NullAllowed] Action<int> completionHandler);

	// -(void)trackActionWithCollectionId:(id)id pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithCollectionId:pollDuration:completionHandler:")]
	void TrackActionWithCollectionId (NSObject id, double pollDuration, [NullAllowed] Action<int> completionHandler);

	// -(void)trackActionWithUniqueId:(id)id pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithUniqueId:pollDuration:completionHandler:")]
	void TrackActionWithUniqueId (NSObject id, double pollDuration, [NullAllowed] Action<int> completionHandler);

	// -(void)trackActionWithShortCodes:(id)codes pollDuration:(double)pollDuration completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("trackActionWithShortCodes:pollDuration:completionHandler:")]
	void TrackActionWithShortCodes (NSObject codes, double pollDuration, [NullAllowed] Action<int> completionHandler);

	// -(void)update;
	[Export ("update")]
	void Update ();
}

// @interface HyperTrack_Swift_1298 (HTOrderTrackingUseCase) <HTUseCaseBackNavigationProtocol>
[Category]
[BaseType (typeof(HTOrderTrackingUseCase))]
interface HTOrderTrackingUseCase_HyperTrack_Swift_1298 : IHTUseCaseBackNavigationProtocol
{
	// -(void)performActionOnButtonClick;
	[Export ("performActionOnButtonClick")]
	void PerformActionOnButtonClick ();
}

// @interface HyperTrack_Swift_1303 (HTOrderTrackingUseCase)
[Category]
[BaseType (typeof(HTOrderTrackingUseCase))]
interface HTOrderTrackingUseCase_HyperTrack_Swift_1303
{
}

// @interface OrderData
[DisableDefaultCtor]
interface OrderData
{
	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	OrderData New ();
}

// @protocol HTOrderTrackingUseCaseDelegate <HTBaseUseCaseDelegate>
[Protocol, Model]
interface HTOrderTrackingUseCaseDelegate : IHTBaseUseCaseDelegate
{
	// @required -(void)placeOrderClicked;
	[Abstract]
	[Export ("placeOrderClicked")]
	void PlaceOrderClicked ();

	// @required -(void)orderTrackingEnded:(HTTrackWithTypeData * _Nonnull)type;
	[Abstract]
	[Export ("orderTrackingEnded:")]
	void OrderTrackingEnded (HTTrackWithTypeData type);
}

// @protocol HTOrderTrackingUseCaseViewModelProtocol <HTBaseTrackingViewModelProtocol>
[Protocol, Model]
interface HTOrderTrackingUseCaseViewModelProtocol : IHTBaseTrackingViewModelProtocol
{
	// @required -(OrderData * _Nonnull)mapToTrackingUseCaseWithActions:(id)actions __attribute__((warn_unused_result));
	[Abstract]
	[Export ("mapToTrackingUseCaseWithActions:")]
	OrderData MapToTrackingUseCaseWithActions (NSObject actions);
}

// @interface HTOrderTrackingUseCaseViewModel : HTBaseTrackingViewModel <HTOrderTrackingUseCaseViewModelProtocol>
[BaseType (typeof(HTBaseTrackingViewModel))]
interface HTOrderTrackingUseCaseViewModel : IHTOrderTrackingUseCaseViewModelProtocol
{
	// -(OrderData * _Nonnull)mapToTrackingUseCaseWithActions:(id)actions __attribute__((warn_unused_result));
	[Export ("mapToTrackingUseCaseWithActions:")]
	OrderData MapToTrackingUseCaseWithActions (NSObject actions);
}

// @protocol HTPaddingProviderProtocol
[Protocol, Model]
interface HTPaddingProviderProtocol
{
	// @required @property (nonatomic) int top;
	[Abstract]
	[Export ("top")]
	int Top { get; set; }

	// @required @property (nonatomic) int left;
	[Abstract]
	[Export ("left")]
	int Left { get; set; }

	// @required @property (nonatomic) int right;
	[Abstract]
	[Export ("right")]
	int Right { get; set; }

	// @required @property (nonatomic) int bottom;
	[Abstract]
	[Export ("bottom")]
	int Bottom { get; set; }

	// @required @property (nonatomic) int verticalInterItem;
	[Abstract]
	[Export ("verticalInterItem")]
	int VerticalInterItem { get; set; }

	// @required @property (nonatomic) int horizontalInterItem;
	[Abstract]
	[Export ("horizontalInterItem")]
	int HorizontalInterItem { get; set; }

	// @required @property (readonly, getter = default, nonatomic, strong, class) id<HTPaddingProviderProtocol> _Nonnull default_;
	[Static, Abstract]
	[Export ("default_", ArgumentSemantic.Strong)]
	HTPaddingProviderProtocol Default_ { [Bind ("default")] get; }

	// @required @property (readonly, nonatomic, strong, class) id<HTPaddingProviderProtocol> _Nonnull zero;
	[Static, Abstract]
	[Export ("zero", ArgumentSemantic.Strong)]
	HTPaddingProviderProtocol Zero { get; }
}

// @interface HTPlace
[DisableDefaultCtor]
interface HTPlace
{
	// @property (readonly, copy, nonatomic) int * _Nonnull id;
	[Export ("id", ArgumentSemantic.Copy)]
	unsafe int* Id { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull name;
	[Export ("name", ArgumentSemantic.Copy)]
	unsafe int* Name { get; }

	// @property (readonly, nonatomic, strong) HTGeoJSONLocation * _Nullable location;
	[NullAllowed, Export ("location", ArgumentSemantic.Strong)]
	HTGeoJSONLocation Location { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull address;
	[Export ("address", ArgumentSemantic.Copy)]
	unsafe int* Address { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull locality;
	[Export ("locality", ArgumentSemantic.Copy)]
	unsafe int* Locality { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull landmark;
	[Export ("landmark", ArgumentSemantic.Copy)]
	unsafe int* Landmark { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull zipCode;
	[Export ("zipCode", ArgumentSemantic.Copy)]
	unsafe int* ZipCode { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull city;
	[Export ("city", ArgumentSemantic.Copy)]
	unsafe int* City { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull state;
	[Export ("state", ArgumentSemantic.Copy)]
	unsafe int* State { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull country;
	[Export ("country", ArgumentSemantic.Copy)]
	unsafe int* Country { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull displayText;
	[Export ("displayText", ArgumentSemantic.Copy)]
	unsafe int* DisplayText { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull uniqueId;
	[Export ("uniqueId", ArgumentSemantic.Copy)]
	unsafe int* UniqueId { get; }

	// -(instancetype _Nonnull)initWithDict:(id)dict __attribute__((objc_designated_initializer));
	[Export ("initWithDict:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject dict);

	// -(id)getIdentifier __attribute__((warn_unused_result));
	[Export ("getIdentifier")]
	[Verify (MethodToProperty)]
	NSObject Identifier { get; }

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTPlace New ();
}

// @interface HTPlaceBuilder
interface HTPlaceBuilder
{
	// -(HTPlace * _Nonnull)build __attribute__((warn_unused_result));
	[Export ("build")]
	[Verify (MethodToProperty)]
	HTPlace Build { get; }

	// -(HTPlaceBuilder * _Nonnull)setId:(id)id __attribute__((warn_unused_result));
	[Export ("setId:")]
	HTPlaceBuilder SetId (NSObject id);

	// -(HTPlaceBuilder * _Nonnull)setName:(id)name __attribute__((warn_unused_result));
	[Export ("setName:")]
	HTPlaceBuilder SetName (NSObject name);

	// -(HTPlaceBuilder * _Nonnull)setLocation:(id)coordinates __attribute__((warn_unused_result));
	[Export ("setLocation:")]
	HTPlaceBuilder SetLocation (NSObject coordinates);

	// -(HTPlaceBuilder * _Nonnull)setAddress:(id)address __attribute__((warn_unused_result));
	[Export ("setAddress:")]
	HTPlaceBuilder SetAddress (NSObject address);

	// -(HTPlaceBuilder * _Nonnull)setLandmark:(id)landmark __attribute__((warn_unused_result));
	[Export ("setLandmark:")]
	HTPlaceBuilder SetLandmark (NSObject landmark);

	// -(HTPlaceBuilder * _Nonnull)setUniqueId:(id)uniqueId __attribute__((warn_unused_result));
	[Export ("setUniqueId:")]
	HTPlaceBuilder SetUniqueId (NSObject uniqueId);

	// -(HTPlaceBuilder * _Nonnull)setZipCode:(id)zipCode __attribute__((warn_unused_result));
	[Export ("setZipCode:")]
	HTPlaceBuilder SetZipCode (NSObject zipCode);

	// -(HTPlaceBuilder * _Nonnull)setCity:(id)city __attribute__((warn_unused_result));
	[Export ("setCity:")]
	HTPlaceBuilder SetCity (NSObject city);

	// -(HTPlaceBuilder * _Nonnull)setState:(id)state __attribute__((warn_unused_result));
	[Export ("setState:")]
	HTPlaceBuilder SetState (NSObject state);

	// -(HTPlaceBuilder * _Nonnull)setCountry:(id)country __attribute__((warn_unused_result));
	[Export ("setCountry:")]
	HTPlaceBuilder SetCountry (NSObject country);
}

// @interface HTPlaceLineUseCase : HTBaseUseCase <HTMapViewUseCase>
[BaseType (typeof(HTBaseUseCase))]
interface HTPlaceLineUseCase : IHTMapViewUseCase
{
	[Wrap ("WeakMapDelegate")]
	[NullAllowed]
	HTMapUseCaseDelegate MapDelegate { get; set; }

	// @property (nonatomic, weak) id<HTMapUseCaseDelegate> _Nullable mapDelegate;
	[NullAllowed, Export ("mapDelegate", ArgumentSemantic.Weak)]
	NSObject WeakMapDelegate { get; set; }

	// @property (nonatomic, strong) int * _Nonnull primaryActionButton;
	[Export ("primaryActionButton", ArgumentSemantic.Strong)]
	unsafe int* PrimaryActionButton { get; set; }

	// @property (nonatomic) int isBackButtonHidden;
	[Export ("isBackButtonHidden")]
	int IsBackButtonHidden { get; set; }

	// @property (nonatomic) int isPrimaryActionHidden;
	[Export ("isPrimaryActionHidden")]
	int IsPrimaryActionHidden { get; set; }

	[Wrap ("WeakNavigationDelegate")]
	[NullAllowed]
	HTUseCaseNavigationDelegate NavigationDelegate { get; set; }

	// @property (nonatomic, weak) id<HTUseCaseNavigationDelegate> _Nullable navigationDelegate;
	[NullAllowed, Export ("navigationDelegate", ArgumentSemantic.Weak)]
	NSObject WeakNavigationDelegate { get; set; }

	// -(instancetype _Nonnull)initWithMapDelegate:(id<HTMapUseCaseDelegate> _Nullable)mapDelegate;
	[Export ("initWithMapDelegate:")]
	IntPtr Constructor ([NullAllowed] HTMapUseCaseDelegate mapDelegate);

	// -(void)update;
	[Export ("update")]
	void Update ();

	// -(void)setDate:(id)date;
	[Export ("setDate:")]
	void SetDate (NSObject date);
}

// @interface HyperTrack_Swift_1416 (HTPlaceLineUseCase) <HTDateSwitcherViewDelegate>
[Category]
[BaseType (typeof(HTPlaceLineUseCase))]
interface HTPlaceLineUseCase_HyperTrack_Swift_1416 : IHTDateSwitcherViewDelegate
{
	// -(void)dateChanged:(id)date;
	[Export ("dateChanged:")]
	void DateChanged (NSObject date);
}

// @interface HyperTrack_Swift_1421 (HTPlaceLineUseCase) <HTUseCaseBackNavigationProtocol>
[Category]
[BaseType (typeof(HTPlaceLineUseCase))]
interface HTPlaceLineUseCase_HyperTrack_Swift_1421 : IHTUseCaseBackNavigationProtocol
{
	// -(void)performActionOnButtonClick;
	[Export ("performActionOnButtonClick")]
	void PerformActionOnButtonClick ();
}

// @interface HyperTrack_Swift_1426 (HTPlaceLineUseCase) <HTCalendarDelegate>
[Category]
[BaseType (typeof(HTPlaceLineUseCase))]
interface HTPlaceLineUseCase_HyperTrack_Swift_1426 : IHTCalendarDelegate
{
	// -(void)didSelectDate:(id)date;
	[Export ("didSelectDate:")]
	void DidSelectDate (NSObject date);

	// -(void)openCalendar:(id)open selectedDate:(id)selectedDate;
	[Export ("openCalendar:selectedDate:")]
	void OpenCalendar (NSObject open, NSObject selectedDate);
}

// @interface HyperTrack_Swift_1432 (HTPlaceLineUseCase)
[Category]
[BaseType (typeof(HTPlaceLineUseCase))]
interface HTPlaceLineUseCase_HyperTrack_Swift_1432
{
	// -(id)swipePosition:(enum HTSwipePosition)position __attribute__((warn_unused_result));
	[Export ("swipePosition:")]
	NSObject SwipePosition (HTSwipePosition position);

	// -(void)selectedActivity:(HTActivity * _Nonnull)activity;
	[Export ("selectedActivity:")]
	void SelectedActivity (HTActivity activity);
}

// @interface HTPlaceSelectionUseCase <HTMapViewUseCase>
interface HTPlaceSelectionUseCase : IHTMapViewUseCase
{
	[Wrap ("WeakMapDelegate")]
	[NullAllowed]
	HTMapUseCaseDelegate MapDelegate { get; set; }

	// @property (nonatomic, weak) id<HTMapUseCaseDelegate> _Nullable mapDelegate;
	[NullAllowed, Export ("mapDelegate", ArgumentSemantic.Weak)]
	NSObject WeakMapDelegate { get; set; }

	[Wrap ("WeakNavigationDelegate")]
	[NullAllowed]
	HTUseCaseNavigationDelegate NavigationDelegate { get; set; }

	// @property (nonatomic, weak) id<HTUseCaseNavigationDelegate> _Nullable navigationDelegate;
	[NullAllowed, Export ("navigationDelegate", ArgumentSemantic.Weak)]
	NSObject WeakNavigationDelegate { get; set; }

	[Wrap ("WeakDelegate")]
	[NullAllowed]
	HTPlaceSelectionDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<HTPlaceSelectionDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @property (readonly, nonatomic, strong) HTBottomViewContainer * _Null_unspecified bottomView;
	[Export ("bottomView", ArgumentSemantic.Strong)]
	HTBottomViewContainer BottomView { get; }

	// @property (nonatomic, strong) int * _Nonnull primaryActionButton;
	[Export ("primaryActionButton", ArgumentSemantic.Strong)]
	unsafe int* PrimaryActionButton { get; set; }

	// @property (nonatomic) int isPrimaryActionHidden;
	[Export ("isPrimaryActionHidden")]
	int IsPrimaryActionHidden { get; set; }

	// @property (copy, nonatomic) int * _Nonnull searchBarPlaceHolderText;
	[Export ("searchBarPlaceHolderText", ArgumentSemantic.Copy)]
	unsafe int* SearchBarPlaceHolderText { get; set; }

	// @property (nonatomic) int enableCurrentLocationSelection;
	[Export ("enableCurrentLocationSelection")]
	int EnableCurrentLocationSelection { get; set; }

	// @property (nonatomic) int enableChooseOnMapSelection;
	[Export ("enableChooseOnMapSelection")]
	int EnableChooseOnMapSelection { get; set; }

	// -(instancetype _Nonnull)initWithCoordinates:(id)coordinates;
	[Export ("initWithCoordinates:")]
	IntPtr Constructor (NSObject coordinates);

	// -(instancetype _Nonnull)initWithMapDelegate:(id<HTMapUseCaseDelegate> _Nullable)mapDelegate;
	[Export ("initWithMapDelegate:")]
	IntPtr Constructor ([NullAllowed] HTMapUseCaseDelegate mapDelegate);

	// -(void)update;
	[Export ("update")]
	void Update ();
}

// @interface HyperTrack_Swift_1458 (HTPlaceSelectionUseCase) <HTUseCaseBackNavigationProtocol>
[Category]
[BaseType (typeof(HTPlaceSelectionUseCase))]
interface HTPlaceSelectionUseCase_HyperTrack_Swift_1458 : IHTUseCaseBackNavigationProtocol
{
	// -(void)performActionOnButtonClick;
	[Export ("performActionOnButtonClick")]
	void PerformActionOnButtonClick ();
}

// @interface HyperTrack_Swift_1463 (HTPlaceSelectionUseCase) <HTMapViewUpdatesDelegate>
[Category]
[BaseType (typeof(HTPlaceSelectionUseCase))]
interface HTPlaceSelectionUseCase_HyperTrack_Swift_1463 : IHTMapViewUpdatesDelegate
{
	// -(void)mapViewDidChangeWithCenterCoordinate:(id)centerCoordinate;
	[Export ("mapViewDidChangeWithCenterCoordinate:")]
	void MapViewDidChangeWithCenterCoordinate (NSObject centerCoordinate);
}

// @protocol HTPrimaryActionIntDelegate <HTAuxillaryFlowDelegate>
[Protocol, Model]
interface HTPrimaryActionIntDelegate : IHTAuxillaryFlowDelegate
{
	// @required -(void)primaryActionClicked:(id)data;
	[Abstract]
	[Export ("primaryActionClicked:")]
	void PrimaryActionClicked (NSObject data);
}

// @interface HyperTrack_Swift_1476 (HTPlaceSelectionUseCase)
[Category]
[BaseType (typeof(HTPlaceSelectionUseCase))]
interface HTPlaceSelectionUseCase_HyperTrack_Swift_1476
{
	// -(void)cancelClicked;
	[Export ("cancelClicked")]
	void CancelClicked ();

	// -(void)primaryActionClicked:(id)data;
	[Export ("primaryActionClicked:")]
	void PrimaryActionClicked (NSObject data);

	// -(void)updatedQuery:(id)query;
	[Export ("updatedQuery:")]
	void UpdatedQuery (NSObject query);
}

// @interface HTPlaceline
[DisableDefaultCtor]
interface HTPlaceline
{
	// @property (readonly, copy, nonatomic) int * _Nullable id;
	[NullAllowed, Export ("id", ArgumentSemantic.Copy)]
	unsafe int* Id { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable groupId;
	[NullAllowed, Export ("groupId", ArgumentSemantic.Copy)]
	unsafe int* GroupId { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable uniqueId;
	[NullAllowed, Export ("uniqueId", ArgumentSemantic.Copy)]
	unsafe int* UniqueId { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable name;
	[NullAllowed, Export ("name", ArgumentSemantic.Copy)]
	unsafe int* Name { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable phone;
	[NullAllowed, Export ("phone", ArgumentSemantic.Copy)]
	unsafe int* Phone { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable photo;
	[NullAllowed, Export ("photo", ArgumentSemantic.Copy)]
	unsafe int* Photo { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable availabilityStatus;
	[NullAllowed, Export ("availabilityStatus", ArgumentSemantic.Copy)]
	unsafe int* AvailabilityStatus { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable vehicleType;
	[NullAllowed, Export ("vehicleType", ArgumentSemantic.Copy)]
	unsafe int* VehicleType { get; }

	// @property (readonly, nonatomic, strong) HTGeoJSONLocation * _Nullable location;
	[NullAllowed, Export ("location", ArgumentSemantic.Strong)]
	HTGeoJSONLocation Location { get; }

	// @property (readonly, nonatomic, strong) Display * _Nullable display;
	[NullAllowed, Export ("display", ArgumentSemantic.Strong)]
	Display Display { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable createdAt;
	[NullAllowed, Export ("createdAt", ArgumentSemantic.Copy)]
	unsafe int* CreatedAt { get; }

	// @property (readonly, nonatomic, strong) HTActivity * _Nullable activity;
	[NullAllowed, Export ("activity", ArgumentSemantic.Strong)]
	HTActivity Activity { get; }

	// @property (readonly, nonatomic, strong) HTHealth * _Nullable health;
	[NullAllowed, Export ("health", ArgumentSemantic.Strong)]
	HTHealth Health { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable placelineDate;
	[NullAllowed, Export ("placelineDate", ArgumentSemantic.Copy)]
	unsafe int* PlacelineDate { get; }

	// -(instancetype _Nonnull)initWithDict:(id)dict __attribute__((objc_designated_initializer));
	[Export ("initWithDict:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject dict);

	// -(id)toJson __attribute__((warn_unused_result));
	[Export ("toJson")]
	[Verify (MethodToProperty)]
	NSObject ToJson { get; }

	// -(id)toJsonData __attribute__((warn_unused_result));
	[Export ("toJsonData")]
	[Verify (MethodToProperty)]
	NSObject ToJsonData { get; }

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTPlaceline New ();
}

// @interface HTPolylineData
[DisableDefaultCtor]
interface HTPolylineData
{
	// @property (readonly, copy, nonatomic) int * _Nonnull id;
	[Export ("id", ArgumentSemantic.Copy)]
	unsafe int* Id { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable encodedRoute;
	[NullAllowed, Export ("encodedRoute", ArgumentSemantic.Copy)]
	unsafe int* EncodedRoute { get; }

	// -(HTPolylineData * _Nonnull)addCoordinate:(id)coordinate __attribute__((warn_unused_result));
	[Export ("addCoordinate:")]
	HTPolylineData AddCoordinate (NSObject coordinate);

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTPolylineData New ();
}

// @interface HTProvider
interface HTProvider
{
	// @property (nonatomic, strong, class) id<HTStyleProviderProtocol> _Nonnull style;
	[Static]
	[Export ("style", ArgumentSemantic.Strong)]
	HTStyleProviderProtocol Style { get; set; }

	// @property (nonatomic, class) double animationDuration;
	[Static]
	[Export ("animationDuration")]
	double AnimationDuration { get; set; }

	// @property (nonatomic, class) int numberOfPointsForAnimation;
	[Static]
	[Export ("numberOfPointsForAnimation")]
	int NumberOfPointsForAnimation { get; set; }

	// @property (nonatomic, class) double pollDuration;
	[Static]
	[Export ("pollDuration")]
	double PollDuration { get; set; }

	// @property (nonatomic, class) int shouldShowPulsatingMarkers;
	[Static]
	[Export ("shouldShowPulsatingMarkers")]
	int ShouldShowPulsatingMarkers { get; set; }

	// @property (nonatomic, class) int shouldShowCallouts;
	[Static]
	[Export ("shouldShowCallouts")]
	int ShouldShowCallouts { get; set; }

	// @property (nonatomic, class) int alwaysRotateUserMarker;
	[Static]
	[Export ("alwaysRotateUserMarker")]
	int AlwaysRotateUserMarker { get; set; }

	// @property (nonatomic, class) int userMarkerSize;
	[Static]
	[Export ("userMarkerSize")]
	int UserMarkerSize { get; set; }

	// @property (nonatomic, class) int destinationMarkerSize;
	[Static]
	[Export ("destinationMarkerSize")]
	int DestinationMarkerSize { get; set; }

	[Wrap ("WeakMapCustomizationDelegate"), Static]
	[NullAllowed]
	HTMapCustomizationDelegate MapCustomizationDelegate { get; set; }

	// @property (nonatomic, strong, class) id<HTMapCustomizationDelegate> _Nullable mapCustomizationDelegate;
	[Static]
	[NullAllowed, Export ("mapCustomizationDelegate", ArgumentSemantic.Strong)]
	NSObject WeakMapCustomizationDelegate { get; set; }

	// @property (copy, nonatomic, class) int * _Nullable orderTrackingSummaryTitle;
	[Static]
	[NullAllowed, Export ("orderTrackingSummaryTitle", ArgumentSemantic.Copy)]
	unsafe int* OrderTrackingSummaryTitle { get; set; }
}

// @interface HTReusableStackView
interface HTReusableStackView
{
	// -(instancetype _Nonnull)initWithFrame:(id)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject frame);

	// -(instancetype _Nonnull)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder coder);
}

// @protocol HTReusableStackViewDataSource
[Protocol, Model]
interface HTReusableStackViewDataSource
{
	// @required -(id)numberOfItemsIn:(HTReusableStackView * _Nonnull)stackView __attribute__((warn_unused_result));
	[Abstract]
	[Export ("numberOfItemsIn:")]
	NSObject NumberOfItemsIn (HTReusableStackView stackView);

	// @required -(HTStackViewItem * _Nonnull)stackView:(HTReusableStackView * _Nonnull)stackView viewForRowAt:(id)index __attribute__((warn_unused_result));
	[Abstract]
	[Export ("stackView:viewForRowAt:")]
	HTStackViewItem StackView (HTReusableStackView stackView, NSObject index);
}

// @protocol HTReusableStackViewDelegate
[Protocol, Model]
interface HTReusableStackViewDelegate
{
}

// @interface HTSegment
[DisableDefaultCtor]
interface HTSegment
{
	// @property (readonly, copy, nonatomic) int * _Nonnull lookupId;
	[Export ("lookupId", ArgumentSemantic.Copy)]
	unsafe int* LookupId { get; }

	// @property (copy, nonatomic) int * _Nonnull sessionId;
	[Export ("sessionId", ArgumentSemantic.Copy)]
	unsafe int* SessionId { get; set; }

	// @property (copy, nonatomic) int * _Nonnull deviceId;
	[Export ("deviceId", ArgumentSemantic.Copy)]
	unsafe int* DeviceId { get; set; }

	// @property (copy, nonatomic) int * _Nonnull recordedAt;
	[Export ("recordedAt", ArgumentSemantic.Copy)]
	unsafe int* RecordedAt { get; set; }

	// @property (copy, nonatomic) int * _Nonnull startTime;
	[Export ("startTime", ArgumentSemantic.Copy)]
	unsafe int* StartTime { get; set; }

	// @property (copy, nonatomic) int * _Nullable endTime;
	[NullAllowed, Export ("endTime", ArgumentSemantic.Copy)]
	unsafe int* EndTime { get; set; }

	// @property (copy, nonatomic) int * _Nullable uploadTime;
	[NullAllowed, Export ("uploadTime", ArgumentSemantic.Copy)]
	unsafe int* UploadTime { get; set; }

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTSegment New ();
}

// @interface HTSDKActivity : HTSegment
[BaseType (typeof(HTSegment))]
interface HTSDKActivity
{
	// @property (nonatomic) int stepDistance;
	[Export ("stepDistance")]
	int StepDistance { get; set; }

	// @property (nonatomic) int stepCount;
	[Export ("stepCount")]
	int StepCount { get; set; }

	// @property (copy, nonatomic) int * _Nullable experimentId;
	[NullAllowed, Export ("experimentId", ArgumentSemantic.Copy)]
	unsafe int* ExperimentId { get; set; }

	// @property (nonatomic) double confidence;
	[Export ("confidence")]
	double Confidence { get; set; }

	// +(HTSDKActivity * _Nonnull)getSDKActivityFromOSActivityWithOsActivity:(CMMotionActivity * _Nonnull)osActivity __attribute__((warn_unused_result));
	[Static]
	[Export ("getSDKActivityFromOSActivityWithOsActivity:")]
	HTSDKActivity GetSDKActivityFromOSActivityWithOsActivity (CMMotionActivity osActivity);

	// +(double)getConfidenceWithActivity:(CMMotionActivity * _Nonnull)activity __attribute__((warn_unused_result));
	[Static]
	[Export ("getConfidenceWithActivity:")]
	double GetConfidenceWithActivity (CMMotionActivity activity);

	// -(id)toDict __attribute__((warn_unused_result));
	[Export ("toDict")]
	[Verify (MethodToProperty)]
	NSObject ToDict { get; }

	// -(HTActivity * _Nonnull)toHTActivity __attribute__((warn_unused_result));
	[Export ("toHTActivity")]
	[Verify (MethodToProperty)]
	HTActivity ToHTActivity { get; }
}

// @interface HTSDKHealth : HTSegment
[BaseType (typeof(HTSegment))]
interface HTSDKHealth
{
	// -(id)toDict __attribute__((warn_unused_result));
	[Export ("toDict")]
	[Verify (MethodToProperty)]
	NSObject ToDict { get; }
}

// @protocol HTShareEtaViewModelProtocol <HTBaseViewModelProtocol>
[Protocol, Model]
interface HTShareEtaViewModelProtocol : IHTBaseViewModelProtocol
{
	// @required -(void)getAutocompleteResults:(id)query coordinate:(id)coordinate completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Abstract]
	[Export ("getAutocompleteResults:coordinate:completionHandler:")]
	void GetAutocompleteResults (NSObject query, NSObject coordinate, [NullAllowed] Action<int> completionHandler);

	// @required -(void)createPlaceWithGeoJson:(HTGeoJSONLocation * _Nonnull)geoJson completionHandler:(void (^ _Nullable)(HTPlace * _Nullable, HTError * _Nullable))completionHandler;
	[Abstract]
	[Export ("createPlaceWithGeoJson:completionHandler:")]
	void CreatePlaceWithGeoJson (HTGeoJSONLocation geoJson, [NullAllowed] Action<HTPlace, HTError> completionHandler);
}

// @interface HTShareEtaUseCaseViewModel <HTShareEtaViewModelProtocol>
interface HTShareEtaUseCaseViewModel : IHTShareEtaViewModelProtocol
{
	// -(void)getAutocompleteResults:(id)query coordinate:(id)coordinate completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Export ("getAutocompleteResults:coordinate:completionHandler:")]
	void GetAutocompleteResults (NSObject query, NSObject coordinate, [NullAllowed] Action<int> completionHandler);

	// -(void)createPlaceWithGeoJson:(HTGeoJSONLocation * _Nonnull)geoJson completionHandler:(void (^ _Nullable)(HTPlace * _Nullable, HTError * _Nullable))completionHandler;
	[Export ("createPlaceWithGeoJson:completionHandler:")]
	void CreatePlaceWithGeoJson (HTGeoJSONLocation geoJson, [NullAllowed] Action<HTPlace, HTError> completionHandler);
}

// @interface HTStackViewItem
interface HTStackViewItem
{
	// -(instancetype _Nonnull)initWithFrame:(id)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject frame);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);
}

// @protocol HTStyleProviderProtocol
[Protocol, Model]
interface HTStyleProviderProtocol
{
	// @required @property (nonatomic, strong) id<HTColorProviderProtocol> _Nonnull colors;
	[Abstract]
	[Export ("colors", ArgumentSemantic.Strong)]
	HTColorProviderProtocol Colors { get; set; }

	// @required @property (nonatomic, strong) id<HTFontProviderProtocol> _Nonnull fonts;
	[Abstract]
	[Export ("fonts", ArgumentSemantic.Strong)]
	HTFontProviderProtocol Fonts { get; set; }

	// @required @property (nonatomic, strong) id<HTPaddingProviderProtocol> _Nonnull padding;
	[Abstract]
	[Export ("padding", ArgumentSemantic.Strong)]
	HTPaddingProviderProtocol Padding { get; set; }

	// @required @property (nonatomic, strong) id<HTLayerProviderProtocol> _Nonnull layer;
	[Abstract]
	[Export ("layer", ArgumentSemantic.Strong)]
	HTLayerProviderProtocol Layer { get; set; }

	// @required @property (nonatomic, strong) id<HTMarkerImagesProviderProtocol> _Nonnull markerImages;
	[Abstract]
	[Export ("markerImages", ArgumentSemantic.Strong)]
	HTMarkerImagesProviderProtocol MarkerImages { get; set; }
}

// @interface HTStyleConfig <HTStyleProviderProtocol>
interface HTStyleConfig : IHTStyleProviderProtocol
{
	// @property (nonatomic, strong) id<HTColorProviderProtocol> _Nonnull colors;
	[Export ("colors", ArgumentSemantic.Strong)]
	HTColorProviderProtocol Colors { get; set; }

	// @property (nonatomic, strong) id<HTFontProviderProtocol> _Nonnull fonts;
	[Export ("fonts", ArgumentSemantic.Strong)]
	HTFontProviderProtocol Fonts { get; set; }

	// @property (nonatomic, strong) id<HTPaddingProviderProtocol> _Nonnull padding;
	[Export ("padding", ArgumentSemantic.Strong)]
	HTPaddingProviderProtocol Padding { get; set; }

	// @property (nonatomic, strong) id<HTLayerProviderProtocol> _Nonnull layer;
	[Export ("layer", ArgumentSemantic.Strong)]
	HTLayerProviderProtocol Layer { get; set; }

	// @property (nonatomic, strong) id<HTMarkerImagesProviderProtocol> _Nonnull markerImages;
	[Export ("markerImages", ArgumentSemantic.Strong)]
	HTMarkerImagesProviderProtocol MarkerImages { get; set; }
}

// @protocol HTSwipeableProtocol
[Protocol, Model]
interface HTSwipeableProtocol
{
	// @required @property (nonatomic) int isSwipeable;
	[Abstract]
	[Export ("isSwipeable")]
	int IsSwipeable { get; set; }

	// @required @property (nonatomic) enum HTSwipePosition position;
	[Abstract]
	[Export ("position", ArgumentSemantic.Assign)]
	HTSwipePosition Position { get; set; }
}

// @interface HTTimeAwarePolyline
[DisableDefaultCtor]
interface HTTimeAwarePolyline
{
	// -(HTTimeAwarePolyline * _Nonnull)slice:(id)maxSize date:(id)date __attribute__((warn_unused_result));
	[Export ("slice:date:")]
	HTTimeAwarePolyline Slice (NSObject maxSize, NSObject date);

	// -(HTPolylineData * _Nonnull)toPolyline __attribute__((warn_unused_result));
	[Export ("toPolyline")]
	[Verify (MethodToProperty)]
	HTPolylineData ToPolyline { get; }

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTTimeAwarePolyline New ();
}

// @interface HTTrackAction : HTAction
[BaseType (typeof(HTAction))]
interface HTTrackAction
{
	// @property (readonly, nonatomic, strong) HTPlace * _Nullable place;
	[NullAllowed, Export ("place", ArgumentSemantic.Strong)]
	HTPlace Place { get; }

	// -(instancetype _Nonnull)initWithDict:(id)dict __attribute__((objc_designated_initializer));
	[Export ("initWithDict:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject dict);
}

// @interface HTTrackResponse
[DisableDefaultCtor]
interface HTTrackResponse
{
	// @property (readonly, nonatomic) int count;
	[Export ("count")]
	int Count { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull next;
	[Export ("next", ArgumentSemantic.Copy)]
	unsafe int* Next { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull previous;
	[Export ("previous", ArgumentSemantic.Copy)]
	unsafe int* Previous { get; }

	// -(instancetype _Nonnull)initWithDict:(id)dict __attribute__((objc_designated_initializer));
	[Export ("initWithDict:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject dict);

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTTrackResponse New ();
}

// @interface HTTrackWithTypeData
[DisableDefaultCtor]
interface HTTrackWithTypeData
{
	// -(instancetype _Nonnull)initWithIds:(id)ids type:(enum HTTrackWithType)type __attribute__((objc_designated_initializer));
	[Export ("initWithIds:type:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject ids, HTTrackWithType type);

	// -(instancetype _Nonnull)initWithId:(id)id type:(enum HTTrackWithType)type __attribute__((objc_designated_initializer));
	[Export ("initWithId:type:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject id, HTTrackWithType type);

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTTrackWithTypeData New ();
}

// @protocol HTTrackingCustomizationUseCaseDelegate
[Protocol, Model]
interface HTTrackingCustomizationUseCaseDelegate
{
	// @required -(id)handleTrackingResponse:(id)actions error:(HTError * _Nullable)error mapDelegate:(id<HTMapUseCaseDelegate> _Nullable)mapDelegate __attribute__((warn_unused_result));
	[Abstract]
	[Export ("handleTrackingResponse:error:mapDelegate:")]
	NSObject Error (NSObject actions, [NullAllowed] HTError error, [NullAllowed] HTMapUseCaseDelegate mapDelegate);
}

// @interface HTUser
[DisableDefaultCtor]
interface HTUser
{
	// @property (readonly, copy, nonatomic) int * _Nonnull id;
	[Export ("id", ArgumentSemantic.Copy)]
	unsafe int* Id { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable groupId;
	[NullAllowed, Export ("groupId", ArgumentSemantic.Copy)]
	unsafe int* GroupId { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable uniqueId;
	[NullAllowed, Export ("uniqueId", ArgumentSemantic.Copy)]
	unsafe int* UniqueId { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable availabilityStatus;
	[NullAllowed, Export ("availabilityStatus", ArgumentSemantic.Copy)]
	unsafe int* AvailabilityStatus { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable vehicleType;
	[NullAllowed, Export ("vehicleType", ArgumentSemantic.Copy)]
	unsafe int* VehicleType { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable lastOnlineAt;
	[NullAllowed, Export ("lastOnlineAt", ArgumentSemantic.Copy)]
	unsafe int* LastOnlineAt { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable createdAt;
	[NullAllowed, Export ("createdAt", ArgumentSemantic.Copy)]
	unsafe int* CreatedAt { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable modifiedAt;
	[NullAllowed, Export ("modifiedAt", ArgumentSemantic.Copy)]
	unsafe int* ModifiedAt { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable segmentStatus;
	[NullAllowed, Export ("segmentStatus", ArgumentSemantic.Copy)]
	unsafe int* SegmentStatus { get; }

	// @property (readonly, nonatomic, strong) Display * _Nullable display;
	[NullAllowed, Export ("display", ArgumentSemantic.Strong)]
	Display Display { get; }

	// @property (readonly, nonatomic) int isTracking;
	[Export ("isTracking")]
	int IsTracking { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable name;
	[NullAllowed, Export ("name", ArgumentSemantic.Copy)]
	unsafe int* Name { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable phone;
	[NullAllowed, Export ("phone", ArgumentSemantic.Copy)]
	unsafe int* Phone { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable photo;
	[NullAllowed, Export ("photo", ArgumentSemantic.Copy)]
	unsafe int* Photo { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable lastHeartbeatAt;
	[NullAllowed, Export ("lastHeartbeatAt", ArgumentSemantic.Copy)]
	unsafe int* LastHeartbeatAt { get; }

	// @property (readonly, nonatomic, strong) HTLocation * _Nullable lastLocation;
	[NullAllowed, Export ("lastLocation", ArgumentSemantic.Strong)]
	HTLocation LastLocation { get; }

	// @property (readonly, nonatomic) int isConnected;
	[Export ("isConnected")]
	int IsConnected { get; }

	// @property (readonly, copy, nonatomic) int * _Nullable locationStatus;
	[NullAllowed, Export ("locationStatus", ArgumentSemantic.Copy)]
	unsafe int* LocationStatus { get; }

	// -(instancetype _Nonnull)initWithDict:(id)dict __attribute__((objc_designated_initializer));
	[Export ("initWithDict:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject dict);

	// -(id)toJson __attribute__((warn_unused_result));
	[Export ("toJson")]
	[Verify (MethodToProperty)]
	NSObject ToJson { get; }

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTUser New ();
}

// @interface HTUserInfoView : HTStackViewItem
[BaseType (typeof(HTStackViewItem))]
interface HTUserInfoView
{
	// @property (readonly, nonatomic, strong) UIImageView * _Null_unspecified imageView;
	[Export ("imageView", ArgumentSemantic.Strong)]
	UIImageView ImageView { get; }

	// @property (readonly, nonatomic, strong) HTLabel * _Null_unspecified titleLabel;
	[Export ("titleLabel", ArgumentSemantic.Strong)]
	HTLabel TitleLabel { get; }

	// @property (readonly, nonatomic, strong) HTLabel * _Null_unspecified descriptionLabel;
	[Export ("descriptionLabel", ArgumentSemantic.Strong)]
	HTLabel DescriptionLabel { get; }

	// @property (readonly, nonatomic, strong) HTButton * _Null_unspecified actionButton;
	[Export ("actionButton", ArgumentSemantic.Strong)]
	HTButton ActionButton { get; }

	// @property (nonatomic, strong) HTBottomViewActionData * _Null_unspecified actionType;
	[Export ("actionType", ArgumentSemantic.Strong)]
	HTBottomViewActionData ActionType { get; set; }

	// @property (copy, nonatomic) int * _Nonnull titleText;
	[Export ("titleText", ArgumentSemantic.Copy)]
	unsafe int* TitleText { get; set; }

	// @property (copy, nonatomic) int * _Nonnull descriptionText;
	[Export ("descriptionText", ArgumentSemantic.Copy)]
	unsafe int* DescriptionText { get; set; }

	// @property (nonatomic, strong) UIImage * _Nullable image;
	[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
	UIImage Image { get; set; }

	// @property (copy, nonatomic) int * _Nullable imageUrl;
	[NullAllowed, Export ("imageUrl", ArgumentSemantic.Copy)]
	unsafe int* ImageUrl { get; set; }

	// @property (copy, nonatomic) int * _Nonnull actionButtonText;
	[Export ("actionButtonText", ArgumentSemantic.Copy)]
	unsafe int* ActionButtonText { get; set; }

	// @property (nonatomic, strong) id<HTPaddingProviderProtocol> _Nonnull padding;
	[Export ("padding", ArgumentSemantic.Strong)]
	HTPaddingProviderProtocol Padding { get; set; }

	// -(instancetype _Nonnull)initWithFrame:(id)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject frame);

	// -(instancetype _Nonnull)initWithFrame:(id)frame padding:(id<HTPaddingProviderProtocol> _Nonnull)padding;
	[Export ("initWithFrame:padding:")]
	IntPtr Constructor (NSObject frame, HTPaddingProviderProtocol padding);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);
}

// @interface HTUserTrackingBottomCard
[DisableDefaultCtor]
interface HTUserTrackingBottomCard
{
	// -(instancetype _Nonnull)init:(id)components __attribute__((objc_designated_initializer));
	[Export ("init:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject components);

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HTUserTrackingBottomCard New ();
}

// @interface HyperTrack
interface HyperTrack
{
	// +(void)initialize:(id)publishableKey;
	[Static]
	[Export ("initialize:")]
	void Initialize (NSObject publishableKey);

	// +(id)getPublishableKey __attribute__((warn_unused_result));
	[Static]
	[Export ("getPublishableKey")]
	[Verify (MethodToProperty)]
	NSObject PublishableKey { get; }

	// +(void)resumeTracking;
	[Static]
	[Export ("resumeTracking")]
	void ResumeTracking ();

	// +(void)resumeTrackingWithCompletionHandler:(void (^ _Nonnull)(HTError * _Nullable))completionHandler;
	[Static]
	[Export ("resumeTrackingWithCompletionHandler:")]
	void ResumeTrackingWithCompletionHandler (Action<HTError> completionHandler);

	// +(id)getUserId __attribute__((warn_unused_result));
	[Static]
	[Export ("getUserId")]
	[Verify (MethodToProperty)]
	NSObject UserId { get; }

	// @property (readonly, nonatomic, class) int isTracking;
	[Static]
	[Export ("isTracking")]
	int IsTracking { get; }

	// +(void)getCurrentLocationWithCompletionHandler:(void (^ _Nonnull)(CLLocation * _Nullable, HTError * _Nullable))completionHandler;
	[Static]
	[Export ("getCurrentLocationWithCompletionHandler:")]
	void GetCurrentLocationWithCompletionHandler (Action<CLLocation, HTError> completionHandler);

	// +(void)getOrCreateUserWithName:(id)name phone:(id)phone uniqueId:(id)uniqueId completionHandler:(void (^ _Nonnull)(HTUser * _Nullable, HTError * _Nullable))completionHandler;
	[Static]
	[Export ("getOrCreateUserWithName:phone:uniqueId:completionHandler:")]
	void GetOrCreateUserWithName (NSObject name, NSObject phone, NSObject uniqueId, Action<HTUser, HTError> completionHandler);

	// +(void)getUserWithId:(id)id completionHandler:(void (^ _Nonnull)(HTUser * _Nullable, HTError * _Nullable))completionHandler;
	[Static]
	[Export ("getUserWithId:completionHandler:")]
	void GetUserWithId (NSObject id, Action<HTUser, HTError> completionHandler);

	// +(void)getOrCreateUserWithName:(id)name phone:(id)phone uniqueId:(id)uniqueId photo:(UIImage * _Nullable)photo completionHandler:(void (^ _Nonnull)(HTUser * _Nullable, HTError * _Nullable))completionHandler;
	[Static]
	[Export ("getOrCreateUserWithName:phone:uniqueId:photo:completionHandler:")]
	void GetOrCreateUserWithName (NSObject name, NSObject phone, NSObject uniqueId, [NullAllowed] UIImage photo, Action<HTUser, HTError> completionHandler);

	// +(void)updateUserWithName:(id)name phone:(id)phone uniqueId:(id)uniqueId photo:(UIImage * _Nullable)photo completionHandler:(void (^ _Nonnull)(HTUser * _Nullable, HTError * _Nullable))completionHandler;
	[Static]
	[Export ("updateUserWithName:phone:uniqueId:photo:completionHandler:")]
	void UpdateUserWithName (NSObject name, NSObject phone, NSObject uniqueId, [NullAllowed] UIImage photo, Action<HTUser, HTError> completionHandler);

	// +(void)createAction:(HTActionParams * _Nonnull)actionParams :(void (^ _Nonnull)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
	[Static]
	[Export ("createAction::")]
	void CreateAction (HTActionParams actionParams, Action<HTAction, HTError> completionHandler);

	// +(void)getActionForActionId:(id)actionId completionHandler:(void (^ _Nonnull)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
	[Static]
	[Export ("getActionForActionId:completionHandler:")]
	void GetActionForActionId (NSObject actionId, Action<HTAction, HTError> completionHandler);

	// +(void)getActionsForCollectionId:(id)collectionId completionHandler:(void (^ _Nonnull)(int))completionHandler;
	[Static]
	[Export ("getActionsForCollectionId:completionHandler:")]
	void GetActionsForCollectionId (NSObject collectionId, Action<int> completionHandler);

	// +(void)getActionsForUniqueId:(id)uniqueId :(void (^ _Nonnull)(int))completionHandler;
	[Static]
	[Export ("getActionsForUniqueId::")]
	void GetActionsForUniqueId (NSObject uniqueId, Action<int> completionHandler);

	// +(void)getActionsForShortCode:(id)shortCode :(void (^ _Nonnull)(int))completionHandler;
	[Static]
	[Export ("getActionsForShortCode::")]
	void GetActionsForShortCode (NSObject shortCode, Action<int> completionHandler);

	// +(void)trackActionForActionId:(id)actionId completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
	[Static]
	[Export ("trackActionForActionId:completionHandler:")]
	void TrackActionForActionId (NSObject actionId, [NullAllowed] Action<HTAction, HTError> completionHandler);

	// +(void)trackActionForShortCode:(id)shortCode completionHandler:(void (^ _Nullable)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
	[Static]
	[Export ("trackActionForShortCode:completionHandler:")]
	void TrackActionForShortCode (NSObject shortCode, [NullAllowed] Action<HTAction, HTError> completionHandler);

	// +(void)trackActionForUniqueId:(id)uniqueId completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Static]
	[Export ("trackActionForUniqueId:completionHandler:")]
	void TrackActionForUniqueId (NSObject uniqueId, [NullAllowed] Action<int> completionHandler);

	// +(void)trackActionForCollectionId:(id)collectionId completionHandler:(void (^ _Nullable)(int))completionHandler;
	[Static]
	[Export ("trackActionForCollectionId:completionHandler:")]
	void TrackActionForCollectionId (NSObject collectionId, [NullAllowed] Action<int> completionHandler);

	// +(void)completeAction:(id)actionId;
	[Static]
	[Export ("completeAction:")]
	void CompleteAction (NSObject actionId);

	// +(void)completeActionInSync:(id)actionId completionHandler:(void (^ _Nonnull)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
	[Static]
	[Export ("completeActionInSync:completionHandler:")]
	void CompleteActionInSync (NSObject actionId, Action<HTAction, HTError> completionHandler);

	// +(void)completeActionWithUniqueIdInSync:(id)uniqueId completionHandler:(void (^ _Nonnull)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
	[Static]
	[Export ("completeActionWithUniqueIdInSync:completionHandler:")]
	void CompleteActionWithUniqueIdInSync (NSObject uniqueId, Action<HTAction, HTError> completionHandler);

	// +(void)pauseTracking;
	[Static]
	[Export ("pauseTracking")]
	void PauseTracking ();

	// +(void)createMockAction:(HTLocationCoordinate * _Nullable)origin :(HTLocationCoordinate * _Nullable)destination :(HTActionParams * _Nonnull)params completionHandler:(void (^ _Nonnull)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
	[Static]
	[Export ("createMockAction:::completionHandler:")]
	void CreateMockAction ([NullAllowed] HTLocationCoordinate origin, [NullAllowed] HTLocationCoordinate destination, HTActionParams @params, Action<HTAction, HTError> completionHandler);

	// +(void)completeMockActionWithActionId:(id)actionId completionHandler:(void (^ _Nonnull)(HTAction * _Nullable, HTError * _Nullable))completionHandler;
	[Static]
	[Export ("completeMockActionWithActionId:completionHandler:")]
	void CompleteMockActionWithActionId (NSObject actionId, Action<HTAction, HTError> completionHandler);

	// +(id)locationAuthorizationStatus __attribute__((warn_unused_result));
	[Static]
	[Export ("locationAuthorizationStatus")]
	[Verify (MethodToProperty)]
	NSObject LocationAuthorizationStatus { get; }

	// +(void)requestAlwaysLocationAuthorizationWithCompletionHandler:(id)completionHandler;
	[Static]
	[Export ("requestAlwaysLocationAuthorizationWithCompletionHandler:")]
	void RequestAlwaysLocationAuthorizationWithCompletionHandler (NSObject completionHandler);

	// +(void)motionAuthorizationStatusWithCompletionHandler:(id)completionHandler;
	[Static]
	[Export ("motionAuthorizationStatusWithCompletionHandler:")]
	void MotionAuthorizationStatusWithCompletionHandler (NSObject completionHandler);

	// +(id)isActivityAvailable __attribute__((warn_unused_result));
	[Static]
	[Export ("isActivityAvailable")]
	[Verify (MethodToProperty)]
	NSObject IsActivityAvailable { get; }

	// +(void)requestMotionAuthorization;
	[Static]
	[Export ("requestMotionAuthorization")]
	void RequestMotionAuthorization ();

	// +(id)locationServicesEnabled __attribute__((warn_unused_result));
	[Static]
	[Export ("locationServicesEnabled")]
	[Verify (MethodToProperty)]
	NSObject LocationServicesEnabled { get; }

	// +(void)requestLocationServices;
	[Static]
	[Export ("requestLocationServices")]
	void RequestLocationServices ();

	// +(void)registerForNotifications;
	[Static]
	[Export ("registerForNotifications")]
	void RegisterForNotifications ();

	// +(void)didRegisterForRemoteNotificationsWithDeviceTokenWithDeviceToken:(id)deviceToken;
	[Static]
	[Export ("didRegisterForRemoteNotificationsWithDeviceTokenWithDeviceToken:")]
	void DidRegisterForRemoteNotificationsWithDeviceTokenWithDeviceToken (NSObject deviceToken);

	// +(void)didFailToRegisterForRemoteNotificationsWithErrorWithError:(id)error;
	[Static]
	[Export ("didFailToRegisterForRemoteNotificationsWithErrorWithError:")]
	void DidFailToRegisterForRemoteNotificationsWithErrorWithError (NSObject error);

	// +(void)didReceiveRemoteNotificationWithUserInfo:(id)userInfo;
	[Static]
	[Export ("didReceiveRemoteNotificationWithUserInfo:")]
	void DidReceiveRemoteNotificationWithUserInfo (NSObject userInfo);

	// +(id)isHyperTrackNotificationWithUserInfo:(id)userInfo __attribute__((warn_unused_result));
	[Static]
	[Export ("isHyperTrackNotificationWithUserInfo:")]
	NSObject IsHyperTrackNotificationWithUserInfo (NSObject userInfo);

	// +(void)getPlacelineWithDate:(id)date userId:(id)userId completionHandler:(void (^ _Nonnull)(HTPlaceline * _Nullable, HTError * _Nullable))completionHandler;
	[Static]
	[Export ("getPlacelineWithDate:userId:completionHandler:")]
	void GetPlacelineWithDate (NSObject date, NSObject userId, Action<HTPlaceline, HTError> completionHandler);

	// +(void)enableConsoleLogging;
	[Static]
	[Export ("enableConsoleLogging")]
	void EnableConsoleLogging ();

	// +(void)setEventsDelegateWithEventDelegate:(id<HTEventsDelegate> _Nonnull)eventDelegate;
	[Static]
	[Export ("setEventsDelegateWithEventDelegate:")]
	void SetEventsDelegateWithEventDelegate (HTEventsDelegate eventDelegate);

	// +(void)setGeofenceAtPlaceWithPlace:(HTPlace * _Nonnull)place radius:(id)radius identifier:(id)identifier;
	[Static]
	[Export ("setGeofenceAtPlaceWithPlace:radius:identifier:")]
	void SetGeofenceAtPlaceWithPlace (HTPlace place, NSObject radius, NSObject identifier);

	// +(CLLocation * _Nullable)getCurrentLocation __attribute__((warn_unused_result));
	[Static]
	[NullAllowed, Export ("getCurrentLocation")]
	[Verify (MethodToProperty)]
	CLLocation CurrentLocation { get; }

	// +(HTActivity * _Nullable)getCurrentActivity __attribute__((warn_unused_result));
	[Static]
	[NullAllowed, Export ("getCurrentActivity")]
	[Verify (MethodToProperty)]
	HTActivity CurrentActivity { get; }

	// +(void)getPendingActionsWithCompletionHandler:(void (^ _Nonnull)(int))completionHandler;
	[Static]
	[Export ("getPendingActionsWithCompletionHandler:")]
	void GetPendingActionsWithCompletionHandler (Action<int> completionHandler);

	// +(void)setLocationUpdatesDelegate:(id<HTLocationUpdatesDelegate> _Nullable)delegate;
	[Static]
	[Export ("setLocationUpdatesDelegate:")]
	void SetLocationUpdatesDelegate ([NullAllowed] HTLocationUpdatesDelegate @delegate);
}

// @interface HyperTrackEvent
[DisableDefaultCtor]
interface HyperTrackEvent
{
	// @property (readonly, copy, nonatomic) int * _Nonnull userId;
	[Export ("userId", ArgumentSemantic.Copy)]
	unsafe int* UserId { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull sessionId;
	[Export ("sessionId", ArgumentSemantic.Copy)]
	unsafe int* SessionId { get; }

	// @property (readonly, copy, nonatomic) int * _Nonnull deviceId;
	[Export ("deviceId", ArgumentSemantic.Copy)]
	unsafe int* DeviceId { get; }

	// @property (copy, nonatomic) int * _Nonnull recordedAt;
	[Export ("recordedAt", ArgumentSemantic.Copy)]
	unsafe int* RecordedAt { get; set; }

	// @property (readonly, copy, nonatomic) int * _Nonnull activityLookUpId;
	[Export ("activityLookUpId", ArgumentSemantic.Copy)]
	unsafe int* ActivityLookUpId { get; }

	// @property (copy, nonatomic) int * _Nonnull locationLookUpId;
	[Export ("locationLookUpId", ArgumentSemantic.Copy)]
	unsafe int* LocationLookUpId { get; set; }

	// @property (readonly, copy, nonatomic) int * _Nonnull healthLookUpId;
	[Export ("healthLookUpId", ArgumentSemantic.Copy)]
	unsafe int* HealthLookUpId { get; }

	// -(HTSDKActivity * _Nullable)getActivity __attribute__((warn_unused_result));
	[NullAllowed, Export ("getActivity")]
	[Verify (MethodToProperty)]
	HTSDKActivity Activity { get; }

	// -(HTLocation * _Nullable)getLocation __attribute__((warn_unused_result));
	[NullAllowed, Export ("getLocation")]
	[Verify (MethodToProperty)]
	HTLocation Location { get; }

	// -(HTSDKHealth * _Nullable)getHealth __attribute__((warn_unused_result));
	[NullAllowed, Export ("getHealth")]
	[Verify (MethodToProperty)]
	HTSDKHealth Health { get; }

	// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
	[Static]
	[Export ("new")]
	HyperTrackEvent New ();
}

// @interface LocationService
interface LocationService
{
}

// @interface HyperTrack_Swift_2046 (LocationService)
[Category]
[BaseType (typeof(LocationService))]
interface LocationService_HyperTrack_Swift_2046
{
	// -(void)start;
	[Export ("start")]
	void Start ();

	// -(void)stop;
	[Export ("stop")]
	void Stop ();
}

// @interface HyperTrack_Swift_2054 (LocationService)
[Category]
[BaseType (typeof(LocationService))]
interface LocationService_HyperTrack_Swift_2054
{
	// -(void)locationManager:(CLLocationManager * _Nonnull)manager didChangeAuthorizationStatus:(id)status;
	[Export ("locationManager:didChangeAuthorizationStatus:")]
	void LocationManager (CLLocationManager manager, NSObject status);

	// -(void)locationManager:(CLLocationManager * _Nonnull)manager didUpdateLocations:(id)locations;
	[Export ("locationManager:didUpdateLocations:")]
	void LocationManager (CLLocationManager manager, NSObject locations);

	// -(void)locationManager:(CLLocationManager * _Nonnull)manager didUpdateHeading:(CLHeading * _Nonnull)newHeading;
	[Export ("locationManager:didUpdateHeading:")]
	void LocationManager (CLLocationManager manager, CLHeading newHeading);
}

// @interface PolylineUtils
interface PolylineUtils
{
	// +(id)decodePolyline:(id)encodedPolyline precision:(double)precision __attribute__((warn_unused_result));
	[Static]
	[Export ("decodePolyline:precision:")]
	NSObject DecodePolyline (NSObject encodedPolyline, double precision);

	// +(id)decodePolylineToCLLocations:(id)encodedPolyline precision:(double)precision __attribute__((warn_unused_result));
	[Static]
	[Export ("decodePolylineToCLLocations:precision:")]
	NSObject DecodePolylineToCLLocations (NSObject encodedPolyline, double precision);
}

// @interface HyperTrack_Swift_2075 (UIFont)
[Category]
[BaseType (typeof(UIFont))]
interface UIFont_HyperTrack_Swift_2075
{
}

// @interface HyperTrack_Swift_2094 (UIImage)
[Category]
[BaseType (typeof(UIImage))]
interface UIImage_HyperTrack_Swift_2094
{
	// +(UIImage * _Nullable)getImageFromHTBundleWithNamed:(id)named __attribute__((warn_unused_result));
	[Static]
	[Export ("getImageFromHTBundleWithNamed:")]
	[return: NullAllowed]
	UIImage GetImageFromHTBundleWithNamed (NSObject named);
}

// @interface HyperTrack_Swift_2111 (UIView)
[Category]
[BaseType (typeof(UIView))]
interface UIView_HyperTrack_Swift_2111
{
	// -(void)edges:(id)padding;
	[Export ("edges:")]
	void Edges (NSObject padding);
}
