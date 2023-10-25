using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002F3 RID: 755
	// (Invoke) Token: 0x0600146C RID: 5228
	[Token(Token = "0x20002F3")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryFileCompleteCallbackInternal(ref QueryFileCallbackInfoInternal data);
}
