using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x0200050B RID: 1291
	// (Invoke) Token: 0x06002103 RID: 8451
	[Token(Token = "0x200050B")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnAcceptInviteCallbackInternal(ref AcceptInviteCallbackInfoInternal data);
}
