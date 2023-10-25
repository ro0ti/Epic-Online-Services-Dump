using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x02000702 RID: 1794
	// (Invoke) Token: 0x06002DCE RID: 11726
	[Token(Token = "0x2000702")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnClientIntegrityViolatedCallbackInternal(ref OnClientIntegrityViolatedCallbackInfoInternal data);
}
