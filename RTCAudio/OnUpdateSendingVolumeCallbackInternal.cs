using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200020B RID: 523
	// (Invoke) Token: 0x06000E53 RID: 3667
	[Token(Token = "0x200020B")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnUpdateSendingVolumeCallbackInternal(ref UpdateSendingVolumeCallbackInfoInternal data);
}
