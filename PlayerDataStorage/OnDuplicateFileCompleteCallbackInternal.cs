using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002EF RID: 751
	// (Invoke) Token: 0x0600145C RID: 5212
	[Token(Token = "0x20002EF")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnDuplicateFileCompleteCallbackInternal(ref DuplicateFileCallbackInfoInternal data);
}
