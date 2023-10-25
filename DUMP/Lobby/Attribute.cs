using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003A7 RID: 935
	[Token(Token = "0x20003A7")]
	public struct Attribute
	{
		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x00006E84 File Offset: 0x00005084
		// (set) Token: 0x0600188F RID: 6287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006BF")]
		public AttributeData? Data
		{
			[Token(Token = "0x600188E")]
			[Address(RVA = "0x4C7200", Offset = "0x4C5800", VA = "0x1804C7200")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600188F")]
			[Address(RVA = "0x4C7230", Offset = "0x4C5830", VA = "0x1804C7230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x00006E9C File Offset: 0x0000509C
		// (set) Token: 0x06001891 RID: 6289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006C0")]
		public LobbyAttributeVisibility Visibility
		{
			[Token(Token = "0x6001890")]
			[Address(RVA = "0x3D6600", Offset = "0x3D4C00", VA = "0x1803D6600")]
			[CompilerGenerated]
			readonly get
			{
				return LobbyAttributeVisibility.Public;
			}
			[Token(Token = "0x6001891")]
			[Address(RVA = "0x3E45C0", Offset = "0x3E2BC0", VA = "0x1803E45C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001892")]
		[Address(RVA = "0x5074F0", Offset = "0x505AF0", VA = "0x1805074F0")]
		internal void Set(ref AttributeInternal other)
		{
		}
	}
}
