using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002FB RID: 763
	// (Invoke) Token: 0x0600148C RID: 5260
	[Token(Token = "0x20002FB")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnWriteFileCompleteCallbackInternal(ref WriteFileCallbackInfoInternal data);
}
