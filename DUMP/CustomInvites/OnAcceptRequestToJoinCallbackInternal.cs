using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005B4 RID: 1460
	// (Invoke) Token: 0x06002574 RID: 9588
	[Token(Token = "0x20005B4")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnAcceptRequestToJoinCallbackInternal(ref AcceptRequestToJoinCallbackInfoInternal data);
}
