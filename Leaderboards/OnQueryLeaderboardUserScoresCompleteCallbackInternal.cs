using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x0200049F RID: 1183
	// (Invoke) Token: 0x06001E81 RID: 7809
	[Token(Token = "0x200049F")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryLeaderboardUserScoresCompleteCallbackInternal(ref OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal data);
}
