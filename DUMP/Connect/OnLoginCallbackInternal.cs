using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000626 RID: 1574
	// (Invoke) Token: 0x06002851 RID: 10321
	[Token(Token = "0x2000626")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLoginCallbackInternal(ref LoginCallbackInfoInternal data);
}
