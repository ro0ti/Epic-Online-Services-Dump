using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005BA RID: 1466
	// (Invoke) Token: 0x0600259F RID: 9631
	[Token(Token = "0x20005BA")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnCustomInviteReceivedCallbackInternal(ref OnCustomInviteReceivedCallbackInfoInternal data);
}
