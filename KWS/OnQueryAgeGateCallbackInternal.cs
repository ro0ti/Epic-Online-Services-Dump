using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004BD RID: 1213
	// (Invoke) Token: 0x06001F30 RID: 7984
	[Token(Token = "0x20004BD")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryAgeGateCallbackInternal(ref QueryAgeGateCallbackInfoInternal data);
}
