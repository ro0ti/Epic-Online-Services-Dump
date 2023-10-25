using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	public struct SessionInviteAcceptedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000258")]
		public object ClientData
		{
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000259")]
		public Utf8String SessionId
		{
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700025A")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700025B")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700025C")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00003E54 File Offset: 0x00002054
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x4C96E0", Offset = "0x4C7CE0", VA = "0x1804C96E0")]
		internal void Set(ref SessionInviteAcceptedCallbackInfoInternal other)
		{
		}
	}
}
