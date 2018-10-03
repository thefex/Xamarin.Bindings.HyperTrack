//
//  NSObject+HyperTrack.h
//  HyperTrackObjC
//
//  Created by Przemek Raciborski on 26/09/2018.
//  Copyright © 2018 Przemek Raciborski. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface NSObject (HyperTrack)
+ (void) initialize: (NSString*)publishableKey;
+ (NSString*) getPublishableKey;

+ (void) resumeTracking;
+ (void) pauseTracking;
+ (void) requestMotionAuthorization;

@end
