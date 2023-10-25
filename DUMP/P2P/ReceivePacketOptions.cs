using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000354 RID: 852
	[Token(Token = "0x2000354")]
	public struct ReceivePacketOptions
	{
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000635")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60016E8")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60016E9")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x0000689C File Offset: 0x00004A9C
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000636")]
		public uint MaxDataSizeBytes
		{
			[Token(Token = "0x60016EA")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60016EB")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x000068B4 File Offset: 0x00004AB4
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000637")]
		public byte? RequestedChannel
		{
			[Token(Token = "0x60016EC")]
			[Address(RVA = "0x51F140", Offset = "0x51D740", VA = "0x18051F140")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60016ED")]
			[Address(RVA = "0x51F150", Offset = "0x51D750", VA = "0x18051F150")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
