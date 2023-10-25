using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002B4 RID: 692
	// (Invoke) Token: 0x060012FD RID: 4861
	[Token(Token = "0x20002B4")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnJoinGameAcceptedCallbackInternal(ref JoinGameAcceptedCallbackInfoInternal data);
}
