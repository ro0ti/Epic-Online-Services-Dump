using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003D7 RID: 983
	[Token(Token = "0x20003D7")]
	public struct KickMemberOptions
	{
		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019FC RID: 6652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700075B")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x60019FB")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60019FC")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019FE RID: 6654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700075C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60019FD")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60019FE")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A00 RID: 6656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700075D")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60019FF")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001A00")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
