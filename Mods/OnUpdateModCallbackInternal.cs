using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000378 RID: 888
	// (Invoke) Token: 0x060017CA RID: 6090
	[Token(Token = "0x2000378")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnUpdateModCallbackInternal(ref UpdateModCallbackInfoInternal data);
}
