using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200057B RID: 1403
	[Token(Token = "0x200057B")]
	public struct QueryEntitlementTokenCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x0000971C File Offset: 0x0000791C
		// (set) Token: 0x0600240C RID: 9228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A6A")]
		public Result ResultCode
		{
			[Token(Token = "0x600240B")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600240C")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600240E RID: 9230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A6B")]
		public object ClientData
		{
			[Token(Token = "0x600240D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600240E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002410 RID: 9232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A6C")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600240F")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002410")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002412 RID: 9234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A6D")]
		public Utf8String EntitlementToken
		{
			[Token(Token = "0x6002411")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002412")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x00009734 File Offset: 0x00007934
		[Token(Token = "0x6002413")]
		[Address(RVA = "0x54B520", Offset = "0x549B20", VA = "0x18054B520", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002414")]
		[Address(RVA = "0x54B570", Offset = "0x549B70", VA = "0x18054B570")]
		internal void Set(ref QueryEntitlementTokenCallbackInfoInternal other)
		{
		}
	}
}
