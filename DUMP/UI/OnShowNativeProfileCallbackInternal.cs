using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.UI
{
	// Token: 0x02000083 RID: 131
	// (Invoke) Token: 0x06000555 RID: 1365
	[Token(Token = "0x2000083")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnShowNativeProfileCallbackInternal(ref ShowNativeProfileCallbackInfoInternal data);
}
