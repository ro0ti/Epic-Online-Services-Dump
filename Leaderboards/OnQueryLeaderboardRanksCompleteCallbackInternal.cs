using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x0200049B RID: 1179
	// (Invoke) Token: 0x06001E6A RID: 7786
	[Token(Token = "0x200049B")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryLeaderboardRanksCompleteCallbackInternal(ref OnQueryLeaderboardRanksCompleteCallbackInfoInternal data);
}
