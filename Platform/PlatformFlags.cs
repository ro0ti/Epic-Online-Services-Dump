using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000732 RID: 1842
	[Token(Token = "0x2000732")]
	[Flags]
	public enum PlatformFlags : ulong
	{
		// Token: 0x0400152B RID: 5419
		[Token(Token = "0x400152B")]
		None = 0UL,
		// Token: 0x0400152C RID: 5420
		[Token(Token = "0x400152C")]
		LoadingInEditor = 1UL,
		// Token: 0x0400152D RID: 5421
		[Token(Token = "0x400152D")]
		DisableOverlay = 2UL,
		// Token: 0x0400152E RID: 5422
		[Token(Token = "0x400152E")]
		DisableSocialOverlay = 4UL,
		// Token: 0x0400152F RID: 5423
		[Token(Token = "0x400152F")]
		Reserved1 = 8UL,
		// Token: 0x04001530 RID: 5424
		[Token(Token = "0x4001530")]
		WindowsEnableOverlayD3D9 = 16UL,
		// Token: 0x04001531 RID: 5425
		[Token(Token = "0x4001531")]
		WindowsEnableOverlayD3D10 = 32UL,
		// Token: 0x04001532 RID: 5426
		[Token(Token = "0x4001532")]
		WindowsEnableOverlayOpengl = 64UL,
		// Token: 0x04001533 RID: 5427
		[Token(Token = "0x4001533")]
		ConsoleEnableOverlayAutomaticUnloading = 128UL
	}
}
