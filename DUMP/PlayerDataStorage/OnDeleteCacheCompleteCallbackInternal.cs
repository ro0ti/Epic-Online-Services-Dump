using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002EB RID: 747
	// (Invoke) Token: 0x0600144C RID: 5196
	[Token(Token = "0x20002EB")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnDeleteCacheCompleteCallbackInternal(ref DeleteCacheCallbackInfoInternal data);
}
