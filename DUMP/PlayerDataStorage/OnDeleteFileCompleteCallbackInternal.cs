using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002ED RID: 749
	// (Invoke) Token: 0x06001454 RID: 5204
	[Token(Token = "0x20002ED")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnDeleteFileCompleteCallbackInternal(ref DeleteFileCallbackInfoInternal data);
}
