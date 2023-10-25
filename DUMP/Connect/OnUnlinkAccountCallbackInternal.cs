using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000630 RID: 1584
	// (Invoke) Token: 0x06002879 RID: 10361
	[Token(Token = "0x2000630")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnUnlinkAccountCallbackInternal(ref UnlinkAccountCallbackInfoInternal data);
}
