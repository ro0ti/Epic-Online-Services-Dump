using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000271 RID: 625
	// (Invoke) Token: 0x06001155 RID: 4437
	[Token(Token = "0x2000271")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnJoinRoomCallbackInternal(ref JoinRoomCallbackInfoInternal data);
}
