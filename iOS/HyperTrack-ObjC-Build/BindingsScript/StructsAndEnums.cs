public enum AnchorPosition
{
	Top = 0,
	Bottom = 1,
	Left = 2,
	Right = 3,
	TopLeft = 4,
	TopRight = 5,
	Center = 6
}

public enum HTAnnotationType
{
	User = 0,
	CurrentUser = 1,
	Destination = 2,
	Error = 3,
	None = 4
}

public enum HTBottomViewActionType
{
	Share = 0,
	StopSharing = 1,
	Call = 2,
	None = 3
}

public enum HTComponentType
{
	User = 0,
	Status = 1,
	UserDetails = 2,
	OrderStatus = 3,
	OrderInfo = 4,
	OrderInfoArray = 5
}

public enum HTErrorCode
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

public enum HTSwipePosition
{
	Expanded = 0,
	Collapsed = 1,
	Partial = 2,
	None = 3
}

public enum HTTrackWithType
{
	ActionIds = 0,
	CollectionId = 1,
	ShortCode = 2,
	UniqueId = 3
}

public enum HTSize
{
	Title = 0,
	Normal = 1,
	Info = 2,
	Caption = 3
}

public enum HTFontWeight
{
	Bold = 0,
	Medium = 1,
	Regular = 2
}
