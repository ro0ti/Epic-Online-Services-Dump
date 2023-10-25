using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000418 RID: 1048
	[Token(Token = "0x2000418")]
	public struct LobbyModificationSetPermissionLevelOptions
	{
		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x00007CF4 File Offset: 0x00005EF4
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007E8")]
		public LobbyPermissionLevel PermissionLevel
		{
			[Token(Token = "0x6001BC7")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return LobbyPermissionLevel.Publicadvertised;
			}
			[Token(Token = "0x6001BC8")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
