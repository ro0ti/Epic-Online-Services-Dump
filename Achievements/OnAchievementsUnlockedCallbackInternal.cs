using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200075E RID: 1886
	// (Invoke) Token: 0x0600306D RID: 12397
	[Token(Token = "0x200075E")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnAchievementsUnlockedCallbackInternal(ref OnAchievementsUnlockedCallbackInfoInternal data);
}
