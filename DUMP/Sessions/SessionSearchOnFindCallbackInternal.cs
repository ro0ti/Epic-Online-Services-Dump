using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000189 RID: 393
	// (Invoke) Token: 0x06000B5D RID: 2909
	[Token(Token = "0x2000189")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void SessionSearchOnFindCallbackInternal(ref SessionSearchFindCallbackInfoInternal data);
}
