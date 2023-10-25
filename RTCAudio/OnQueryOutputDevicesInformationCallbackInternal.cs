using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001EF RID: 495
	// (Invoke) Token: 0x06000DB0 RID: 3504
	[Token(Token = "0x20001EF")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryOutputDevicesInformationCallbackInternal(ref OnQueryOutputDevicesInformationCallbackInfoInternal data);
}
