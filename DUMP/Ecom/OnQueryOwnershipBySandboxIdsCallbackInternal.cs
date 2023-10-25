using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200056F RID: 1391
	// (Invoke) Token: 0x060023D1 RID: 9169
	[Token(Token = "0x200056F")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryOwnershipBySandboxIdsCallbackInternal(ref QueryOwnershipBySandboxIdsCallbackInfoInternal data);
}
