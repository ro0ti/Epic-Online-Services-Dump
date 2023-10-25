using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000205 RID: 517
	// (Invoke) Token: 0x06000E3B RID: 3643
	[Token(Token = "0x2000205")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnUpdateReceivingCallbackInternal(ref UpdateReceivingCallbackInfoInternal data);
}
