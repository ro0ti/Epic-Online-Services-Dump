using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTC
{
	// Token: 0x0200026F RID: 623
	// (Invoke) Token: 0x0600114D RID: 4429
	[Token(Token = "0x200026F")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnDisconnectedCallbackInternal(ref DisconnectedCallbackInfoInternal data);
}
