using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000575 RID: 1397
	// (Invoke) Token: 0x060023E9 RID: 9193
	[Token(Token = "0x2000575")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnRedeemEntitlementsCallbackInternal(ref RedeemEntitlementsCallbackInfoInternal data);
}
