using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000162 RID: 354
	[Token(Token = "0x2000162")]
	public struct SessionDetailsInfo
	{
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700023E")]
		public Utf8String SessionId
		{
			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700023F")]
		public Utf8String HostAddress
		{
			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00003D04 File Offset: 0x00001F04
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000240")]
		public uint NumOpenPublicConnections
		{
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00003D1C File Offset: 0x00001F1C
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000241")]
		public SessionDetailsSettings? Settings
		{
			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x4C8050", Offset = "0x4C6650", VA = "0x1804C8050")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x4C8080", Offset = "0x4C6680", VA = "0x1804C8080")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000242")]
		public ProductUserId OwnerUserId
		{
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x4C33D0", Offset = "0x4C19D0", VA = "0x1804C33D0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x4C3420", Offset = "0x4C1A20", VA = "0x1804C3420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000243")]
		public Utf8String OwnerServerClientId
		{
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x4C8040", Offset = "0x4C6640", VA = "0x1804C8040")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x4C8070", Offset = "0x4C6670", VA = "0x1804C8070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x4C7E40", Offset = "0x4C6440", VA = "0x1804C7E40")]
		internal void Set(ref SessionDetailsInfoInternal other)
		{
		}
	}
}
