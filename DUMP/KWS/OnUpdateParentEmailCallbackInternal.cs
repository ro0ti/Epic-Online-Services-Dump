using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004C3 RID: 1219
	// (Invoke) Token: 0x06001F48 RID: 8008
	[Token(Token = "0x20004C3")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnUpdateParentEmailCallbackInternal(ref UpdateParentEmailCallbackInfoInternal data);
}
