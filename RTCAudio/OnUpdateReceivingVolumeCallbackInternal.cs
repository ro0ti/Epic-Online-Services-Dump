using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000207 RID: 519
	// (Invoke) Token: 0x06000E43 RID: 3651
	[Token(Token = "0x2000207")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnUpdateReceivingVolumeCallbackInternal(ref UpdateReceivingVolumeCallbackInfoInternal data);
}
