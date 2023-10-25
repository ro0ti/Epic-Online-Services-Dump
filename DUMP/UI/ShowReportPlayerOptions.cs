using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UI
{
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	public struct ShowReportPlayerOptions
	{
		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000FF")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000100")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
