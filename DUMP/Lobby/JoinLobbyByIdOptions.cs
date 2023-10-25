using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003CF RID: 975
	[Token(Token = "0x20003CF")]
	public struct JoinLobbyByIdOptions
	{
		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019B2 RID: 6578 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000739")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x60019B1")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60019B2")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019B4 RID: 6580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700073A")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60019B3")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60019B4")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x00007364 File Offset: 0x00005564
		// (set) Token: 0x060019B6 RID: 6582 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700073B")]
		public bool PresenceEnabled
		{
			[Token(Token = "0x60019B5")]
			[Address(RVA = "0x3D3060", Offset = "0x3D1660", VA = "0x1803D3060")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60019B6")]
			[Address(RVA = "0x3D3070", Offset = "0x3D1670", VA = "0x1803D3070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x0000737C File Offset: 0x0000557C
		// (set) Token: 0x060019B8 RID: 6584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700073C")]
		public LocalRTCOptions? LocalRTCOptions
		{
			[Token(Token = "0x60019B7")]
			[Address(RVA = "0x50EE50", Offset = "0x50D450", VA = "0x18050EE50")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60019B8")]
			[Address(RVA = "0x50EE70", Offset = "0x50D470", VA = "0x18050EE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x00007394 File Offset: 0x00005594
		// (set) Token: 0x060019BA RID: 6586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700073D")]
		public bool CrossplayOptOut
		{
			[Token(Token = "0x60019B9")]
			[Address(RVA = "0x4BBE70", Offset = "0x4BA470", VA = "0x1804BBE70")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60019BA")]
			[Address(RVA = "0x4BBEA0", Offset = "0x4BA4A0", VA = "0x1804BBEA0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
