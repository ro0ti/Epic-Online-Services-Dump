using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000203 RID: 515
	// (Invoke) Token: 0x06000E33 RID: 3635
	[Token(Token = "0x2000203")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnUpdateParticipantVolumeCallbackInternal(ref UpdateParticipantVolumeCallbackInfoInternal data);
}
