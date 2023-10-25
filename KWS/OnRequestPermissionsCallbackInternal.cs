using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004C1 RID: 1217
	// (Invoke) Token: 0x06001F40 RID: 8000
	[Token(Token = "0x20004C1")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnRequestPermissionsCallbackInternal(ref RequestPermissionsCallbackInfoInternal data);
}
