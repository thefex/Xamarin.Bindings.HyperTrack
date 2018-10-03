//
//  NSObject+HyperTrack.m
//  HyperTrackObjC
//
//  Created by Przemek Raciborski on 26/09/2018.
//  Copyright © 2018 Przemek Raciborski. All rights reserved.
//

#import <HyperTrackObjC/NSObject+HyperTrack.h>
@import HyperTrack;

@implementation NSObject (HyperTrack)
+ (void) initialize:(NSString *)publishableKey {
    [HyperTrack initialize:publishableKey];
}

+ (NSString*) getPublishableKey {
    return @"sdsds";
    //return [HyperTrack getPublishableKey];
}

+ (void) pauseTracking {
    [HyperTrack pauseTracking];
}

+ (void) resumeTracking {
    [HyperTrack resumeTracking];
}

+ (void) requestMotionAuthorization {
    [HyperTrack requestMotionAuthorization];
}
 
@end
