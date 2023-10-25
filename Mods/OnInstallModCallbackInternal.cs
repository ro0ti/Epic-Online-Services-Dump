using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000374 RID: 884
	// (Invoke) Token: 0x060017BA RID: 6074
	[Token(Token = "0x2000374")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnInstallModCallbackInternal(ref InstallModCallbackInfoInternal data);
}
