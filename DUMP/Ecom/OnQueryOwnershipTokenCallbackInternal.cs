using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000573 RID: 1395
	// (Invoke) Token: 0x060023E1 RID: 9185
	[Token(Token = "0x2000573")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryOwnershipTokenCallbackInternal(ref QueryOwnershipTokenCallbackInfoInternal data);
}
