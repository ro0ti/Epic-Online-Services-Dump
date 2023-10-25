using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005D0 RID: 1488
	// (Invoke) Token: 0x06002620 RID: 9760
	[Token(Token = "0x20005D0")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnSendCustomNativeInviteRequestedCallbackInternal(ref SendCustomNativeInviteRequestedCallbackInfoInternal data);
}
