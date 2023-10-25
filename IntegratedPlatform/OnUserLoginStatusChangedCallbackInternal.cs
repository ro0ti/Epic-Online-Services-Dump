using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004E7 RID: 1255
	// (Invoke) Token: 0x06002022 RID: 8226
	[Token(Token = "0x20004E7")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnUserLoginStatusChangedCallbackInternal(ref UserLoginStatusChangedCallbackInfoInternal data);
}
