using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000316 RID: 790
	[Token(Token = "0x2000316")]
	public struct AcceptConnectionOptions
	{
		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005C1")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001574")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001575")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001577 RID: 5495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005C2")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x6001576")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001577")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x0000614C File Offset: 0x0000434C
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005C3")]
		public SocketId? SocketId
		{
			[Token(Token = "0x6001578")]
			[Address(RVA = "0x4EC380", Offset = "0x4EA980", VA = "0x1804EC380")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001579")]
			[Address(RVA = "0x4EC390", Offset = "0x4EA990", VA = "0x1804EC390")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
