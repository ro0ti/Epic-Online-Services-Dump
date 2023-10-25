using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	public struct QueryUserInfoCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0000278C File Offset: 0x0000098C
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000073")]
		public Result ResultCode
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000074")]
		public object ClientData
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000075")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000076")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x4AF260", Offset = "0x4AD860", VA = "0x1804AF260", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x4AF2B0", Offset = "0x4AD8B0", VA = "0x1804AF2B0")]
		internal void Set(ref QueryUserInfoCallbackInfoInternal other)
		{
		}
	}
}
