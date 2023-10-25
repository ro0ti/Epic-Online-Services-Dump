using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003D3 RID: 979
	[Token(Token = "0x20003D3")]
	public struct JoinLobbyOptions
	{
		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019D7 RID: 6615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700074A")]
		public LobbyDetails LobbyDetailsHandle
		{
			[Token(Token = "0x60019D6")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60019D7")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700074B")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60019D8")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60019D9")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x0000740C File Offset: 0x0000560C
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700074C")]
		public bool PresenceEnabled
		{
			[Token(Token = "0x60019DA")]
			[Address(RVA = "0x3D3060", Offset = "0x3D1660", VA = "0x1803D3060")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60019DB")]
			[Address(RVA = "0x3D3070", Offset = "0x3D1670", VA = "0x1803D3070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x00007424 File Offset: 0x00005624
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700074D")]
		public LocalRTCOptions? LocalRTCOptions
		{
			[Token(Token = "0x60019DC")]
			[Address(RVA = "0x50EE50", Offset = "0x50D450", VA = "0x18050EE50")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60019DD")]
			[Address(RVA = "0x50EE70", Offset = "0x50D470", VA = "0x18050EE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x0000743C File Offset: 0x0000563C
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700074E")]
		public bool CrossplayOptOut
		{
			[Token(Token = "0x60019DE")]
			[Address(RVA = "0x4BBE70", Offset = "0x4BA470", VA = "0x1804BBE70")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60019DF")]
			[Address(RVA = "0x4BBEA0", Offset = "0x4BA4A0", VA = "0x1804BBEA0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
