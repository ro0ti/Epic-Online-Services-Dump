using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000137 RID: 311
	// (Invoke) Token: 0x0600097A RID: 2426
	[Token(Token = "0x2000137")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnSendSessionNativeInviteRequestedCallbackInternal(ref SendSessionNativeInviteRequestedCallbackInfoInternal data);
}
