//
//  UIFont+LTEAdditions.swift
//
//  Generated by Zeplin on 2/7/18.
//  Copyright (c) 2018 __MyCompanyName__. All rights reserved. 
//

import UIKit

/********** Font Provider **********/
@objc public protocol HTFontProviderProtocol: class {
    func getFont(_ size: UIFont.HTSize, weight: UIFont.HTFontWeight) -> UIFont
}

class HTFontProvider: HTFontProviderProtocol {
    fileprivate func getWeight(_ weight: UIFont.HTFontWeight) -> UIFontWeight {
        switch weight {
        case .bold:
            return UIFontWeightSemibold
        case .medium:
            return UIFontWeightMedium
        case .regular:
            return UIFontWeightRegular
        }
    }
    
    fileprivate func getSize(_ size: UIFont.HTSize) -> CGFloat {
        switch size {
        case .title:
            return 16
        case .normal:
            return 14
        case .info:
            return 12
        case .caption:
            return 10
        }
    }
    
    func getFont(_ size: UIFont.HTSize, weight: UIFont.HTFontWeight) -> UIFont {
        return UIFont.systemFont(ofSize: getSize(size), weight: getWeight(weight))
    }
}

extension UIFont {
    @objc public enum HTSize: Int {
        case title
        case normal
        case info
        case caption
    }
    
    @objc public enum HTFontWeight: Int {
        case bold = 0
        case medium
        case regular
        
    }
}

/********** Color Provider **********/
@objc public protocol HTColorProviderProtocol: class {
    var text: UIColor { get }
    var `default`: UIColor { get }
    var primary: UIColor { get }
    var secondary: UIColor { get }
    var gray: UIColor { get }
    var error: UIColor { get }
    var brand: UIColor { get }
    var positive: UIColor { get }
    var dropShadow: UIColor { get }
    var errorDark: UIColor { get }
    var lightGray: UIColor { get }
}

class HTColorProvider: HTColorProviderProtocol {
    var `default`: UIColor {
        return UIColor.black
    }
    var text: UIColor {
        return UIColor.white
    }
    var primary: UIColor {
        return UIColor.htDarkIndigo
    }
    var secondary: UIColor {
        return UIColor.htSlate
    }
    var gray: UIColor {
        return UIColor.htCoolGrey
    }
    var error: UIColor {
        return UIColor.htGrapeFruit
    }
    var brand: UIColor {
        return UIColor.htVividPurple
    }
    var positive: UIColor {
        return UIColor.htShamrockGreen
    }
    var dropShadow: UIColor {
        return UIColor.htWarmGrey
    }
    var errorDark: UIColor {
        return UIColor(red: (202/255), green: (77/255), blue: (74/255), alpha: 1)
    }
    var lightGray: UIColor {
        return UIColor(red: (230/255), green: (230/255), blue: (230/255), alpha: 1)
    }
}

/********** Layer Provider **********/
@objc public protocol HTLayerProviderProtocol: class {
    var cornerRadius: CGFloat { get }
    var borderWidth: CGFloat { get }
}

class HTLayerProvider: HTLayerProviderProtocol {
    var cornerRadius: CGFloat {
        return 4
    }
    var borderWidth: CGFloat {
        return 1
    }
}

/********** Padding Provider **********/
@objc public protocol HTPaddingProviderProtocol: class {
    var top: CGFloat { get set }
    var left: CGFloat { get set }
    var right: CGFloat { get set }
    var bottom: CGFloat { get set }
    var verticalInterItem: CGFloat { get set }
    var horizontalInterItem: CGFloat { get set }
    static var `default`: HTPaddingProviderProtocol { get }
    static var zero: HTPaddingProviderProtocol { get }
}

class HTPaddingProvider: HTPaddingProviderProtocol {
    var top: CGFloat = 10
    var left: CGFloat = 10
    var right: CGFloat = 10
    var bottom: CGFloat = 10
    var verticalInterItem: CGFloat = 1
    var horizontalInterItem: CGFloat = 8
    
    static var `default`: HTPaddingProviderProtocol {
        return HTPaddingProvider()
    }
    static var zero: HTPaddingProviderProtocol {
        return HTPaddingProvider(top: 0, left: 0, right: 0, bottom: 0, verticalInterItem: 0, horizontalInterItem: 0)
    }
    
    convenience init() {
        self.init(top: 10, left: 10, right: 10, bottom: 10, verticalInterItem: 1, horizontalInterItem: 8)
    }
    
    init(top: CGFloat, left: CGFloat, right: CGFloat, bottom: CGFloat, verticalInterItem: CGFloat, horizontalInterItem: CGFloat) {
        self.top = top
        self.left = left
        self.right = right
        self.bottom = bottom
        self.verticalInterItem = verticalInterItem
        self.horizontalInterItem = horizontalInterItem
    }
}

/********** Layer Provider **********/
@objc public protocol HTMarkerImagesProviderProtocol: class {
    var cycle: UIImage? { get set }
    var destination: UIImage? { get set }
    var drive: UIImage? { get set }
    var offline: UIImage? { get set }
    var stop: UIImage? { get set }
    var walk: UIImage? { get set }
}

class HTMarkerImagesProvider: HTMarkerImagesProviderProtocol {
    var cycle: UIImage? = UIImage.getImageFromHTBundle(named: HTConstants.ImageNames.Marker.cycle)
    var destination: UIImage? = UIImage.getImageFromHTBundle(named: HTConstants.ImageNames.Marker.destination)
    var drive: UIImage? = UIImage.getImageFromHTBundle(named: HTConstants.ImageNames.Marker.drive)
    var offline: UIImage? = UIImage.getImageFromHTBundle(named: HTConstants.ImageNames.Marker.offline)
    var stop: UIImage? = UIImage.getImageFromHTBundle(named: HTConstants.ImageNames.Marker.stop)
    var walk: UIImage? = UIImage.getImageFromHTBundle(named: HTConstants.ImageNames.Marker.walk)
}