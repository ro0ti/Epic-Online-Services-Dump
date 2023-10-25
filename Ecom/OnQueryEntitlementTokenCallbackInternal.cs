using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200056B RID: 1387
	// (Invoke) Token: 0x060023C1 RID: 9153
	[Token(Token = "0x200056B")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryEntitlementTokenCallbackInternal(ref QueryEntitlementTokenCallbackInfoInternal data);
}
