using System;
using ObjCRuntime;

namespace Xamarin.Bindings.HyperTrack
{
    [Native]
    public enum AnchorPosition : ulong
    {
        Top = 0,
        Bottom = 1,
        Left = 2,
        Right = 3,
        TopLeft = 4,
        TopRight = 5,
        Center = 6
    }

    [Native]
    public enum HTAnnotationType : ulong
    {
        User = 0,
        CurrentUser = 1,
        Destination = 2,
        Error = 3,
        None = 4
    }

    [Native]
    public enum HTBottomViewActionType : ulong
    {
        Share = 0,
        StopSharing = 1,
        Call = 2,
        None = 3
    }

    [Native]
    public enum HTComponentType : ulong
    {
        User = 0,
        Status = 1,
        UserDetails = 2,
        OrderStatus = 3,
        OrderInfo = 4,
        OrderInfoArray = 5
    }

    [Native]
    public enum HTErrorCode : ulong
    {
        PublishableKeyError = 100,
        UserIdError = 102,
        LocationPermissionsError = 104,
        LocationDisabledError = 105,
        InvalidLocationError = 121,
        InvalidETAError = 123,
        InvalidParamsError = 131,
        JsonError = 142,
        ServerError = 141,
        UnknownError = 151,
        AuthorizationFailedError = 403
    }

    [Native]
    public enum HTSwipePosition : ulong
    {
        Expanded = 0,
        Collapsed = 1,
        Partial = 2,
        None = 3
    }

    [Native]
    public enum HTTrackWithType : ulong
    {
        ActionIds = 0,
        CollectionId = 1,
        ShortCode = 2,
        UniqueId = 3
    }

    [Native]
    public enum HTSize : ulong
    {
        Title = 0,
        Normal = 1,
        Info = 2,
        Caption = 3
    }

    [Native]
    public enum HTFontWeight : ulong
    {
        Bold = 0,
        Medium = 1,
        Regular = 2
    }
}