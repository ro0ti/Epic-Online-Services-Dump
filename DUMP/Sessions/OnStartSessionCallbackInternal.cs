using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200013F RID: 319
	// (Invoke) Token: 0x0600099A RID: 2458
	[Token(Token = "0x200013F")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnStartSessionCallbackInternal(ref StartSessionCallbackInfoInternal data);
}
