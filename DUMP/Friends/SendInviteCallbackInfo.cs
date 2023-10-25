using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000522 RID: 1314
	[Token(Token = "0x2000522")]
	public struct SendInviteCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06002199 RID: 8601 RVA: 0x00008EDC File Offset: 0x000070DC
		// (set) Token: 0x0600219A RID: 8602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000989")]
		public Result ResultCode
		{
			[Token(Token = "0x6002199")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600219A")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x0600219B RID: 8603 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600219C RID: 8604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700098A")]
		public object ClientData
		{
			[Token(Token = "0x600219B")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600219C")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600219E RID: 8606 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700098B")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600219D")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600219E")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x0600219F RID: 8607 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060021A0 RID: 8608 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700098C")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x600219F")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60021A0")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x00008EF4 File Offset: 0x000070F4
		[Token(Token = "0x60021A1")]
		[Address(RVA = "0x550A00", Offset = "0x54F000", VA = "0x180550A00", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60021A2")]
		[Address(RVA = "0x550A50", Offset = "0x54F050", VA = "0x180550A50")]
		internal void Set(ref SendInviteCallbackInfoInternal other)
		{
		}
	}
}
