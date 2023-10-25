using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000661 RID: 1633
	[Token(Token = "0x2000661")]
	public struct LoginCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x0000A7E4 File Offset: 0x000089E4
		// (set) Token: 0x060029D8 RID: 10712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C30")]
		public Result ResultCode
		{
			[Token(Token = "0x60029D7")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60029D8")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C31")]
		public object ClientData
		{
			[Token(Token = "0x60029D9")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60029DA")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029DC RID: 10716 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C32")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60029DB")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60029DC")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x0000A7FC File Offset: 0x000089FC
		// (set) Token: 0x060029DE RID: 10718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C33")]
		public PinGrantInfo? PinGrantInfo
		{
			[Token(Token = "0x60029DD")]
			[Address(RVA = "0x4C8050", Offset = "0x4C6650", VA = "0x1804C8050")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60029DE")]
			[Address(RVA = "0x4C8080", Offset = "0x4C6680", VA = "0x1804C8080")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x060029DF RID: 10719 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029E0 RID: 10720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C34")]
		public ContinuanceToken ContinuanceToken
		{
			[Token(Token = "0x60029DF")]
			[Address(RVA = "0x4C33D0", Offset = "0x4C19D0", VA = "0x1804C33D0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60029E0")]
			[Address(RVA = "0x4C3420", Offset = "0x4C1A20", VA = "0x1804C3420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x0000A814 File Offset: 0x00008A14
		// (set) Token: 0x060029E2 RID: 10722 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C35")]
		public AccountFeatureRestrictedInfo? AccountFeatureRestrictedInfo_DEPRECATED
		{
			[Token(Token = "0x60029E1")]
			[Address(RVA = "0x55E7D0", Offset = "0x55CDD0", VA = "0x18055E7D0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60029E2")]
			[Address(RVA = "0x55E7F0", Offset = "0x55CDF0", VA = "0x18055E7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x060029E3 RID: 10723 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029E4 RID: 10724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C36")]
		public EpicAccountId SelectedAccountId
		{
			[Token(Token = "0x60029E3")]
			[Address(RVA = "0x55E7E0", Offset = "0x55CDE0", VA = "0x18055E7E0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60029E4")]
			[Address(RVA = "0x55E810", Offset = "0x55CE10", VA = "0x18055E810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x0000A82C File Offset: 0x00008A2C
		[Token(Token = "0x60029E5")]
		[Address(RVA = "0x55E490", Offset = "0x55CA90", VA = "0x18055E490", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029E6")]
		[Address(RVA = "0x55E5F0", Offset = "0x55CBF0", VA = "0x18055E5F0")]
		internal void Set(ref LoginCallbackInfoInternal other)
		{
		}
	}
}
