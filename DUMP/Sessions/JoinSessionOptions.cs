using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	public struct JoinSessionOptions
	{
		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F0")]
		public Utf8String SessionName
		{
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F1")]
		public SessionDetails SessionHandle
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F2")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600090F")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000910")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x00003A04 File Offset: 0x00001C04
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F3")]
		public bool PresenceEnabled
		{
			[Token(Token = "0x6000911")]
			[Address(RVA = "0x4BED50", Offset = "0x4BD350", VA = "0x1804BED50")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000912")]
			[Address(RVA = "0x4BED60", Offset = "0x4BD360", VA = "0x1804BED60")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
