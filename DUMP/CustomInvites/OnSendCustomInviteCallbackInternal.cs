using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005CE RID: 1486
	// (Invoke) Token: 0x06002618 RID: 9752
	[Token(Token = "0x20005CE")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnSendCustomInviteCallbackInternal(ref SendCustomInviteCallbackInfoInternal data);
}
