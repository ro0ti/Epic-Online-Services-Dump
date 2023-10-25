using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001E9 RID: 489
	// (Invoke) Token: 0x06000D91 RID: 3473
	[Token(Token = "0x20001E9")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnParticipantUpdatedCallbackInternal(ref ParticipantUpdatedCallbackInfoInternal data);
}
