using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000762 RID: 1890
	// (Invoke) Token: 0x06003088 RID: 12424
	[Token(Token = "0x2000762")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnAchievementsUnlockedCallbackV2Internal(ref OnAchievementsUnlockedCallbackV2InfoInternal data);
}
