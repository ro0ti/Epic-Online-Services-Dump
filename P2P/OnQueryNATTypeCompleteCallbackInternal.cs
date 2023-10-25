using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000347 RID: 839
	// (Invoke) Token: 0x0600166E RID: 5742
	[Token(Token = "0x2000347")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryNATTypeCompleteCallbackInternal(ref OnQueryNATTypeCompleteInfoInternal data);
}
