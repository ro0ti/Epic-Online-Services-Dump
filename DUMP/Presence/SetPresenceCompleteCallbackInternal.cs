using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002D0 RID: 720
	// (Invoke) Token: 0x0600139B RID: 5019
	[Token(Token = "0x20002D0")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void SetPresenceCompleteCallbackInternal(ref SetPresenceCallbackInfoInternal data);
}
