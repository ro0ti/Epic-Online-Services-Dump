using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000400 RID: 1024
	[Token(Token = "0x2000400")]
	public struct LobbyInviteRejectedCallbackInfo : ICallbackInfo
	{
		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007B9")]
		public object ClientData
		{
			[Token(Token = "0x6001B40")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B41")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B43 RID: 6979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007BA")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6001B42")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B43")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B45 RID: 6981 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007BB")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001B44")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B45")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B47 RID: 6983 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007BC")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001B46")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B47")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B49 RID: 6985 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007BD")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001B48")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B49")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x00007ACC File Offset: 0x00005CCC
		[Token(Token = "0x6001B4A")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B4B")]
		[Address(RVA = "0x5291A0", Offset = "0x5277A0", VA = "0x1805291A0")]
		internal void Set(ref LobbyInviteRejectedCallbackInfoInternal other)
		{
		}
	}
}
