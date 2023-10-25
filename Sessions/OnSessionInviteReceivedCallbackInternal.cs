using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200013B RID: 315
	// (Invoke) Token: 0x0600098A RID: 2442
	[Token(Token = "0x200013B")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnSessionInviteReceivedCallbackInternal(ref SessionInviteReceivedCallbackInfoInternal data);
}
