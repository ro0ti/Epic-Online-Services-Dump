using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002F1 RID: 753
	// (Invoke) Token: 0x06001464 RID: 5220
	[Token(Token = "0x20002F1")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnFileTransferProgressCallbackInternal(ref FileTransferProgressCallbackInfoInternal data);
}
