using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200040A RID: 1034
	[Token(Token = "0x200040A")]
	public struct LobbyModificationAddMemberAttributeOptions
	{
		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x00007C94 File Offset: 0x00005E94
		// (set) Token: 0x06001B9B RID: 7067 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007D8")]
		public AttributeData? Attribute
		{
			[Token(Token = "0x6001B9A")]
			[Address(RVA = "0x4C7200", Offset = "0x4C5800", VA = "0x1804C7200")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B9B")]
			[Address(RVA = "0x4C7230", Offset = "0x4C5830", VA = "0x1804C7230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x00007CAC File Offset: 0x00005EAC
		// (set) Token: 0x06001B9D RID: 7069 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007D9")]
		public LobbyAttributeVisibility Visibility
		{
			[Token(Token = "0x6001B9C")]
			[Address(RVA = "0x3D6600", Offset = "0x3D4C00", VA = "0x1803D6600")]
			[CompilerGenerated]
			readonly get
			{
				return LobbyAttributeVisibility.Public;
			}
			[Token(Token = "0x6001B9D")]
			[Address(RVA = "0x3E45C0", Offset = "0x3E2BC0", VA = "0x1803E45C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
