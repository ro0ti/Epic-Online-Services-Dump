using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000322 RID: 802
	[Token(Token = "0x2000322")]
	public struct ClearPacketQueueOptions
	{
		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060015A8 RID: 5544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005D7")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60015A7")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60015A8")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060015AA RID: 5546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005D8")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x60015A9")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60015AA")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x000061C4 File Offset: 0x000043C4
		// (set) Token: 0x060015AC RID: 5548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005D9")]
		public SocketId? SocketId
		{
			[Token(Token = "0x60015AB")]
			[Address(RVA = "0x4EC380", Offset = "0x4EA980", VA = "0x1804EC380")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60015AC")]
			[Address(RVA = "0x4EC390", Offset = "0x4EA990", VA = "0x1804EC390")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
