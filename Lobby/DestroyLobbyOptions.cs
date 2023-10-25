using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003BB RID: 955
	[Token(Token = "0x20003BB")]
	public struct DestroyLobbyOptions
	{
		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000704")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001932")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001933")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000705")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001934")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001935")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
