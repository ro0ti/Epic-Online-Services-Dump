using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200013D RID: 317
	// (Invoke) Token: 0x06000992 RID: 2450
	[Token(Token = "0x200013D")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnSessionInviteRejectedCallbackInternal(ref SessionInviteRejectedCallbackInfoInternal data);
}
