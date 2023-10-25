using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000414 RID: 1044
	[Token(Token = "0x2000414")]
	public struct LobbyModificationSetInvitesAllowedOptions
	{
		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x00007CC4 File Offset: 0x00005EC4
		// (set) Token: 0x06001BBC RID: 7100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007E4")]
		public bool InvitesAllowed
		{
			[Token(Token = "0x6001BBB")]
			[Address(RVA = "0x4ACD70", Offset = "0x4AB370", VA = "0x1804ACD70")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BBC")]
			[Address(RVA = "0x4ACD80", Offset = "0x4AB380", VA = "0x1804ACD80")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
