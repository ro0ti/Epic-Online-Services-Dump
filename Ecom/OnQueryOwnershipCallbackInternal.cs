using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000571 RID: 1393
	// (Invoke) Token: 0x060023D9 RID: 9177
	[Token(Token = "0x2000571")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryOwnershipCallbackInternal(ref QueryOwnershipCallbackInfoInternal data);
}
