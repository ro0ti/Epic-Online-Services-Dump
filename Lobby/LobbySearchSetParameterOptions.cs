using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200042C RID: 1068
	[Token(Token = "0x200042C")]
	public struct LobbySearchSetParameterOptions
	{
		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x00007E5C File Offset: 0x0000605C
		// (set) Token: 0x06001C15 RID: 7189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007FB")]
		public AttributeData? Parameter
		{
			[Token(Token = "0x6001C14")]
			[Address(RVA = "0x4C7200", Offset = "0x4C5800", VA = "0x1804C7200")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001C15")]
			[Address(RVA = "0x4C7230", Offset = "0x4C5830", VA = "0x1804C7230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x00007E74 File Offset: 0x00006074
		// (set) Token: 0x06001C17 RID: 7191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007FC")]
		public ComparisonOp ComparisonOp
		{
			[Token(Token = "0x6001C16")]
			[Address(RVA = "0x3D6600", Offset = "0x3D4C00", VA = "0x1803D6600")]
			[CompilerGenerated]
			readonly get
			{
				return ComparisonOp.Equal;
			}
			[Token(Token = "0x6001C17")]
			[Address(RVA = "0x3E45C0", Offset = "0x3E2BC0", VA = "0x1803E45C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
