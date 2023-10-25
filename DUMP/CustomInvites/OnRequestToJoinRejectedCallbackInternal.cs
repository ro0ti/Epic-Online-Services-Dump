using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005C8 RID: 1480
	// (Invoke) Token: 0x060025F5 RID: 9717
	[Token(Token = "0x20005C8")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnRequestToJoinRejectedCallbackInternal(ref OnRequestToJoinRejectedCallbackInfoInternal data);
}
