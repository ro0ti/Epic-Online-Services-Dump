using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000324 RID: 804
	[Token(Token = "0x2000324")]
	public struct CloseConnectionOptions
	{
		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060015B4 RID: 5556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005DD")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60015B3")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60015B4")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005DE")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x60015B5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60015B6")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x000061DC File Offset: 0x000043DC
		// (set) Token: 0x060015B8 RID: 5560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005DF")]
		public SocketId? SocketId
		{
			[Token(Token = "0x60015B7")]
			[Address(RVA = "0x4EC380", Offset = "0x4EA980", VA = "0x1804EC380")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60015B8")]
			[Address(RVA = "0x4EC390", Offset = "0x4EA990", VA = "0x1804EC390")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
