using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000DB RID: 219
	// (Invoke) Token: 0x060007B4 RID: 1972
	[Token(Token = "0x20000DB")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnIngestStatCompleteCallbackInternal(ref IngestStatCompleteCallbackInfoInternal data);
}
