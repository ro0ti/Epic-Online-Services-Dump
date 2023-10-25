using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000376 RID: 886
	// (Invoke) Token: 0x060017C2 RID: 6082
	[Token(Token = "0x2000376")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnUninstallModCallbackInternal(ref UninstallModCallbackInfoInternal data);
}
