using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000337 RID: 823
	// (Invoke) Token: 0x060015E2 RID: 5602
	[Token(Token = "0x2000337")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnIncomingConnectionRequestCallbackInternal(ref OnIncomingConnectionRequestInfoInternal data);
}
