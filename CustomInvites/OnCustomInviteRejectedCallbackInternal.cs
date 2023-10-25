using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005BE RID: 1470
	// (Invoke) Token: 0x060025C2 RID: 9666
	[Token(Token = "0x20005BE")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnCustomInviteRejectedCallbackInternal(ref CustomInviteRejectedCallbackInfoInternal data);
}
