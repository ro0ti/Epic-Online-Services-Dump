using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200056D RID: 1389
	// (Invoke) Token: 0x060023C9 RID: 9161
	[Token(Token = "0x200056D")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryOffersCallbackInternal(ref QueryOffersCallbackInfoInternal data);
}
