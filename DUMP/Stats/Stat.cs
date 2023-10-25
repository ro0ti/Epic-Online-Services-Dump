using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	public struct Stat
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000191")]
		public Utf8String Name
		{
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00003524 File Offset: 0x00001724
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000192")]
		public DateTimeOffset? StartTime
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x4C33B0", Offset = "0x4C19B0", VA = "0x1804C33B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x4C3400", Offset = "0x4C1A00", VA = "0x1804C3400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0000353C File Offset: 0x0000173C
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000193")]
		public DateTimeOffset? EndTime
		{
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x4C3390", Offset = "0x4C1990", VA = "0x1804C3390")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x4C33E0", Offset = "0x4C19E0", VA = "0x1804C33E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00003554 File Offset: 0x00001754
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000194")]
		public int Value
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x4D13A0", Offset = "0x4CF9A0", VA = "0x1804D13A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x4D13B0", Offset = "0x4CF9B0", VA = "0x1804D13B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x4D1240", Offset = "0x4CF840", VA = "0x1804D1240")]
		internal void Set(ref StatInternal other)
		{
		}
	}
}
