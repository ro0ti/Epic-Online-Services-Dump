using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000273 RID: 627
	// (Invoke) Token: 0x0600115D RID: 4445
	[Token(Token = "0x2000273")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLeaveRoomCallbackInternal(ref LeaveRoomCallbackInfoInternal data);
}
