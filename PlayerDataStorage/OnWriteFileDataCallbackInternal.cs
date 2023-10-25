using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002FD RID: 765
	// (Invoke) Token: 0x06001494 RID: 5268
	[Token(Token = "0x20002FD")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate WriteResult OnWriteFileDataCallbackInternal(ref WriteFileDataCallbackInfoInternal data, IntPtr outDataBuffer, ref uint outDataWritten);
}
