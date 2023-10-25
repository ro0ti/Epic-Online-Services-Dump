using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003C3 RID: 963
	[Token(Token = "0x20003C3")]
	public struct GetRTCRoomNameOptions
	{
		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001954 RID: 6484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000712")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001953")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001954")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001956 RID: 6486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000713")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001955")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001956")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
