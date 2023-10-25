using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000408 RID: 1032
	[Token(Token = "0x2000408")]
	public struct LobbyModificationAddAttributeOptions
	{
		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x00007C64 File Offset: 0x00005E64
		// (set) Token: 0x06001B92 RID: 7058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007D4")]
		public AttributeData? Attribute
		{
			[Token(Token = "0x6001B91")]
			[Address(RVA = "0x4C7200", Offset = "0x4C5800", VA = "0x1804C7200")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B92")]
			[Address(RVA = "0x4C7230", Offset = "0x4C5830", VA = "0x1804C7230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x00007C7C File Offset: 0x00005E7C
		// (set) Token: 0x06001B94 RID: 7060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007D5")]
		public LobbyAttributeVisibility Visibility
		{
			[Token(Token = "0x6001B93")]
			[Address(RVA = "0x3D6600", Offset = "0x3D4C00", VA = "0x1803D6600")]
			[CompilerGenerated]
			readonly get
			{
				return LobbyAttributeVisibility.Public;
			}
			[Token(Token = "0x6001B94")]
			[Address(RVA = "0x3E45C0", Offset = "0x3E2BC0", VA = "0x1803E45C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
