using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005BB RID: 1467
	[Token(Token = "0x20005BB")]
	public struct OnCustomInviteReceivedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025A3 RID: 9635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AEB")]
		public object ClientData
		{
			[Token(Token = "0x60025A2")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60025A3")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025A5 RID: 9637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AEC")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60025A4")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60025A5")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025A7 RID: 9639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AED")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60025A6")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60025A7")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025A9 RID: 9641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AEE")]
		public Utf8String CustomInviteId
		{
			[Token(Token = "0x60025A8")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60025A9")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025AB RID: 9643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AEF")]
		public Utf8String Payload
		{
			[Token(Token = "0x60025AA")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60025AB")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x00009BB4 File Offset: 0x00007DB4
		[Token(Token = "0x60025AC")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60025AD")]
		[Address(RVA = "0x561760", Offset = "0x55FD60", VA = "0x180561760")]
		internal void Set(ref OnCustomInviteReceivedCallbackInfoInternal other)
		{
		}
	}
}
