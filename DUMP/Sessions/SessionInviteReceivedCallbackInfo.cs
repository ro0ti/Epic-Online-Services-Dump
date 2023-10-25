using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	public struct SessionInviteReceivedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000263")]
		public object ClientData
		{
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000264")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000265")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000266")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00003E84 File Offset: 0x00002084
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x4C9F40", Offset = "0x4C8540", VA = "0x1804C9F40")]
		internal void Set(ref SessionInviteReceivedCallbackInfoInternal other)
		{
		}
	}
}
