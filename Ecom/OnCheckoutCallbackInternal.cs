using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000567 RID: 1383
	// (Invoke) Token: 0x060023B1 RID: 9137
	[Token(Token = "0x2000567")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnCheckoutCallbackInternal(ref CheckoutCallbackInfoInternal data);
}
