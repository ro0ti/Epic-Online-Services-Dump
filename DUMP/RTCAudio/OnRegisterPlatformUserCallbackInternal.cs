using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001F3 RID: 499
	// (Invoke) Token: 0x06000DC7 RID: 3527
	[Token(Token = "0x20001F3")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnRegisterPlatformUserCallbackInternal(ref OnRegisterPlatformUserCallbackInfoInternal data);
}
