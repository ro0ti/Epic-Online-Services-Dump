using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004B9 RID: 1209
	// (Invoke) Token: 0x06001F20 RID: 7968
	[Token(Token = "0x20004B9")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnCreateUserCallbackInternal(ref CreateUserCallbackInfoInternal data);
}
