using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Friends
{
	// Token: 0x0200050D RID: 1293
	// (Invoke) Token: 0x0600210B RID: 8459
	[Token(Token = "0x200050D")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnBlockedUsersUpdateCallbackInternal(ref OnBlockedUsersUpdateInfoInternal data);
}
