using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000439 RID: 1081
	// (Invoke) Token: 0x06001C5C RID: 7260
	[Token(Token = "0x2000439")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnHardMuteMemberCallbackInternal(ref HardMuteMemberCallbackInfoInternal data);
}
