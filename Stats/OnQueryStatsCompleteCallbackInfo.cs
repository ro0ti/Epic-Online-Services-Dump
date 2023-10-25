using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000DE RID: 222
	[Token(Token = "0x20000DE")]
	public struct OnQueryStatsCompleteCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00003494 File Offset: 0x00001694
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700017E")]
		public Result ResultCode
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700017F")]
		public object ClientData
		{
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000180")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000181")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x000034AC File Offset: 0x000016AC
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x4C05D0", Offset = "0x4BEBD0", VA = "0x1804C05D0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x4C0620", Offset = "0x4BEC20", VA = "0x1804C0620")]
		internal void Set(ref OnQueryStatsCompleteCallbackInfoInternal other)
		{
		}
	}
}
