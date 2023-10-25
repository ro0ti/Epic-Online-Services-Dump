using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005B7 RID: 1463
	[Token(Token = "0x20005B7")]
	public struct OnCustomInviteAcceptedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002580 RID: 9600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AE0")]
		public object ClientData
		{
			[Token(Token = "0x600257F")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002580")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06002581 RID: 9601 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002582 RID: 9602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AE1")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6002581")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002582")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06002583 RID: 9603 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002584 RID: 9604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AE2")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002583")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002584")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06002585 RID: 9605 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002586 RID: 9606 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AE3")]
		public Utf8String CustomInviteId
		{
			[Token(Token = "0x6002585")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002586")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002588 RID: 9608 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AE4")]
		public Utf8String Payload
		{
			[Token(Token = "0x6002587")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002588")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00009B84 File Offset: 0x00007D84
		[Token(Token = "0x6002589")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600258A")]
		[Address(RVA = "0x560C50", Offset = "0x55F250", VA = "0x180560C50")]
		internal void Set(ref OnCustomInviteAcceptedCallbackInfoInternal other)
		{
		}
	}
}
