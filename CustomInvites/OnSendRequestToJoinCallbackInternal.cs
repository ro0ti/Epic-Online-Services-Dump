using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005D2 RID: 1490
	// (Invoke) Token: 0x06002628 RID: 9768
	[Token(Token = "0x20005D2")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnSendRequestToJoinCallbackInternal(ref SendRequestToJoinCallbackInfoInternal data);
}
