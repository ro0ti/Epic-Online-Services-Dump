using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000344 RID: 836
	[Token(Token = "0x2000344")]
	public struct OnPeerConnectionInterruptedInfo : ICallbackInfo
	{
		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001653 RID: 5715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700060E")]
		public object ClientData
		{
			[Token(Token = "0x6001652")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001653")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001655 RID: 5717 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700060F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001654")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001655")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001657 RID: 5719 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000610")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x6001656")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001657")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x00006434 File Offset: 0x00004634
		// (set) Token: 0x06001659 RID: 5721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000611")]
		public SocketId? SocketId
		{
			[Token(Token = "0x6001658")]
			[Address(RVA = "0x51A4B0", Offset = "0x518AB0", VA = "0x18051A4B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001659")]
			[Address(RVA = "0x51A4C0", Offset = "0x518AC0", VA = "0x18051A4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x0000644C File Offset: 0x0000464C
		[Token(Token = "0x600165A")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600165B")]
		[Address(RVA = "0x51BEC0", Offset = "0x51A4C0", VA = "0x18051BEC0")]
		internal void Set(ref OnPeerConnectionInterruptedInfoInternal other)
		{
		}
	}
}
