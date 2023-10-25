using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003F9 RID: 1017
	[Token(Token = "0x20003F9")]
	public struct LobbyDetailsMemberInfo
	{
		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001ABA RID: 6842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700079F")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6001AB9")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001ABA")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001ABB RID: 6843 RVA: 0x00007814 File Offset: 0x00005A14
		// (set) Token: 0x06001ABC RID: 6844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007A0")]
		public uint Platform
		{
			[Token(Token = "0x6001ABB")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6001ABC")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x0000782C File Offset: 0x00005A2C
		// (set) Token: 0x06001ABE RID: 6846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007A1")]
		public bool AllowsCrossplay
		{
			[Token(Token = "0x6001ABD")]
			[Address(RVA = "0x4C8A90", Offset = "0x4C7090", VA = "0x1804C8A90")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001ABE")]
			[Address(RVA = "0x4C8AB0", Offset = "0x4C70B0", VA = "0x1804C8AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001ABF")]
		[Address(RVA = "0x513480", Offset = "0x511A80", VA = "0x180513480")]
		internal void Set(ref LobbyDetailsMemberInfoInternal other)
		{
		}
	}
}
