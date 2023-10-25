using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003DB RID: 987
	[Token(Token = "0x20003DB")]
	public struct LeaveLobbyOptions
	{
		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000768")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001A1A")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001A1B")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A1D RID: 6685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000769")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001A1C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001A1D")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
