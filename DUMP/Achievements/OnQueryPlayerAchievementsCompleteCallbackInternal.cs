using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200076A RID: 1898
	// (Invoke) Token: 0x060030BE RID: 12478
	[Token(Token = "0x200076A")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryPlayerAchievementsCompleteCallbackInternal(ref OnQueryPlayerAchievementsCompleteCallbackInfoInternal data);
}
