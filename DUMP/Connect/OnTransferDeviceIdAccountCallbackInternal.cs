using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200062E RID: 1582
	// (Invoke) Token: 0x06002871 RID: 10353
	[Token(Token = "0x200062E")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnTransferDeviceIdAccountCallbackInternal(ref TransferDeviceIdAccountCallbackInfoInternal data);
}
