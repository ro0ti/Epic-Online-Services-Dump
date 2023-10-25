using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200033F RID: 831
	// (Invoke) Token: 0x06001628 RID: 5672
	[Token(Token = "0x200033F")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnPeerConnectionEstablishedCallbackInternal(ref OnPeerConnectionEstablishedInfoInternal data);
}
