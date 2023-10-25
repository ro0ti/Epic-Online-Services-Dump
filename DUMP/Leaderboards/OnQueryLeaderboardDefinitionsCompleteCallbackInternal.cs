using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x02000497 RID: 1175
	// (Invoke) Token: 0x06001E53 RID: 7763
	[Token(Token = "0x2000497")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryLeaderboardDefinitionsCompleteCallbackInternal(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal data);
}
