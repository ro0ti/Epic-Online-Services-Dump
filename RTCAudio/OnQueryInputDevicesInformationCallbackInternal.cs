using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001EB RID: 491
	// (Invoke) Token: 0x06000D99 RID: 3481
	[Token(Token = "0x20001EB")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryInputDevicesInformationCallbackInternal(ref OnQueryInputDevicesInformationCallbackInfoInternal data);
}
