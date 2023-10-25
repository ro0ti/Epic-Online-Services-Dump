using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200076E RID: 1902
	// (Invoke) Token: 0x060030D9 RID: 12505
	[Token(Token = "0x200076E")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnUnlockAchievementsCompleteCallbackInternal(ref OnUnlockAchievementsCompleteCallbackInfoInternal data);
}
