using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002B6 RID: 694
	// (Invoke) Token: 0x06001305 RID: 4869
	[Token(Token = "0x20002B6")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnPresenceChangedCallbackInternal(ref PresenceChangedCallbackInfoInternal data);
}
