using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005E0 RID: 1504
	[Token(Token = "0x20005E0")]
	public struct SendCustomNativeInviteRequestedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002695 RID: 9877 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002696 RID: 9878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B2E")]
		public object ClientData
		{
			[Token(Token = "0x6002695")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002696")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002697 RID: 9879 RVA: 0x00009D94 File Offset: 0x00007F94
		// (set) Token: 0x06002698 RID: 9880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B2F")]
		public ulong UiEventId
		{
			[Token(Token = "0x6002697")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x6002698")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002699 RID: 9881 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600269A RID: 9882 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B30")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002699")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600269A")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600269C RID: 9884 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B31")]
		public Utf8String TargetNativeAccountType
		{
			[Token(Token = "0x600269B")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600269C")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x0600269D RID: 9885 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600269E RID: 9886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B32")]
		public Utf8String TargetUserNativeAccountId
		{
			[Token(Token = "0x600269D")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600269E")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x0600269F RID: 9887 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060026A0 RID: 9888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B33")]
		public Utf8String InviteId
		{
			[Token(Token = "0x600269F")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60026A0")]
			[Address(RVA = "0x444800", Offset = "0x442E00", VA = "0x180444800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x00009DAC File Offset: 0x00007FAC
		[Token(Token = "0x60026A1")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026A2")]
		[Address(RVA = "0x567850", Offset = "0x565E50", VA = "0x180567850")]
		internal void Set(ref SendCustomNativeInviteRequestedCallbackInfoInternal other)
		{
		}
	}
}
