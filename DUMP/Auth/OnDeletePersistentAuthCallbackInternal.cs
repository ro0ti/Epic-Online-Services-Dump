using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200066E RID: 1646
	// (Invoke) Token: 0x06002A3B RID: 10811
	[Token(Token = "0x200066E")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnDeletePersistentAuthCallbackInternal(ref DeletePersistentAuthCallbackInfoInternal data);
}
