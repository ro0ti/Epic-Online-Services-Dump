using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000343 RID: 835
	// (Invoke) Token: 0x0600164F RID: 5711
	[Token(Token = "0x2000343")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnPeerConnectionInterruptedCallbackInternal(ref OnPeerConnectionInterruptedInfoInternal data);
}
