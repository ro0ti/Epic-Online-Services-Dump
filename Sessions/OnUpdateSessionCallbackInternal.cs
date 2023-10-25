using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000143 RID: 323
	// (Invoke) Token: 0x060009AA RID: 2474
	[Token(Token = "0x2000143")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnUpdateSessionCallbackInternal(ref UpdateSessionCallbackInfoInternal data);
}
