using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200034B RID: 843
	// (Invoke) Token: 0x06001689 RID: 5769
	[Token(Token = "0x200034B")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnRemoteConnectionClosedCallbackInternal(ref OnRemoteConnectionClosedInfoInternal data);
}
