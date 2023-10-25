using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.ProgressionSnapshot
{
	// Token: 0x02000299 RID: 665
	// (Invoke) Token: 0x06001253 RID: 4691
	[Token(Token = "0x2000299")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnDeleteSnapshotCallbackInternal(ref DeleteSnapshotCallbackInfoInternal data);
}
