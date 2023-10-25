using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200033B RID: 827
	// (Invoke) Token: 0x06001601 RID: 5633
	[Token(Token = "0x200033B")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnIncomingPacketQueueFullCallbackInternal(ref OnIncomingPacketQueueFullInfoInternal data);
}
