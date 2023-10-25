using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000622 RID: 1570
	// (Invoke) Token: 0x06002841 RID: 10305
	[Token(Token = "0x2000622")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnDeleteDeviceIdCallbackInternal(ref DeleteDeviceIdCallbackInfoInternal data);
}
