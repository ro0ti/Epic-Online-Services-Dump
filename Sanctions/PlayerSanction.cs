using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sanctions
{
	// Token: 0x020001A9 RID: 425
	[Token(Token = "0x20001A9")]
	public struct PlayerSanction
	{
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x0000449C File Offset: 0x0000269C
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002C7")]
		public long TimePlaced
		{
			[Token(Token = "0x6000C23")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0L;
			}
			[Token(Token = "0x6000C24")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002C8")]
		public Utf8String Action
		{
			[Token(Token = "0x6000C25")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C26")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x000044B4 File Offset: 0x000026B4
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002C9")]
		public long TimeExpires
		{
			[Token(Token = "0x6000C27")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return 0L;
			}
			[Token(Token = "0x6000C28")]
			[Address(RVA = "0x4A6940", Offset = "0x4A4F40", VA = "0x1804A6940")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002CA")]
		public Utf8String ReferenceId
		{
			[Token(Token = "0x6000C29")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x4DEC50", Offset = "0x4DD250", VA = "0x1804DEC50")]
		internal void Set(ref PlayerSanctionInternal other)
		{
		}
	}
}
