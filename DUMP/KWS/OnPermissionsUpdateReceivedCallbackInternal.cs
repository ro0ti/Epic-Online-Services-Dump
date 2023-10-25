using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004BB RID: 1211
	// (Invoke) Token: 0x06001F28 RID: 7976
	[Token(Token = "0x20004BB")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnPermissionsUpdateReceivedCallbackInternal(ref PermissionsUpdateReceivedCallbackInfoInternal data);
}
