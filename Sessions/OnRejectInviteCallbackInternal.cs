using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000133 RID: 307
	// (Invoke) Token: 0x0600096A RID: 2410
	[Token(Token = "0x2000133")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnRejectInviteCallbackInternal(ref RejectInviteCallbackInfoInternal data);
}
