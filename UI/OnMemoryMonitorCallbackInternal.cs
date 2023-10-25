using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.UI
{
	// Token: 0x0200007B RID: 123
	// (Invoke) Token: 0x06000526 RID: 1318
	[Token(Token = "0x200007B")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnMemoryMonitorCallbackInternal(ref MemoryMonitorCallbackInfoInternal data);
}
