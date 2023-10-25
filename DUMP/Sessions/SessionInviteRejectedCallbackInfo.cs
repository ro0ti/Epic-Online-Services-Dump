using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200016A RID: 362
	[Token(Token = "0x200016A")]
	public struct SessionInviteRejectedCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700026C")]
		public object ClientData
		{
			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700026D")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700026E")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700026F")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000270")]
		public Utf8String SessionId
		{
			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00003EB4 File Offset: 0x000020B4
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x4CA8D0", Offset = "0x4C8ED0", VA = "0x1804CA8D0")]
		internal void Set(ref SessionInviteRejectedCallbackInfoInternal other)
		{
		}
	}
}
