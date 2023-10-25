using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200012B RID: 299
	// (Invoke) Token: 0x06000952 RID: 2386
	[Token(Token = "0x200012B")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLeaveSessionRequestedCallbackInternal(ref LeaveSessionRequestedCallbackInfoInternal data);
}
