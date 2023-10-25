using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004BF RID: 1215
	// (Invoke) Token: 0x06001F38 RID: 7992
	[Token(Token = "0x20004BF")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryPermissionsCallbackInternal(ref QueryPermissionsCallbackInfoInternal data);
}
