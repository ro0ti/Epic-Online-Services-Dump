using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000615 RID: 1557
	[Token(Token = "0x2000615")]
	public struct LoginCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x060027ED RID: 10221 RVA: 0x0000A1FC File Offset: 0x000083FC
		// (set) Token: 0x060027EE RID: 10222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BA1")]
		public Result ResultCode
		{
			[Token(Token = "0x60027ED")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60027EE")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027F0 RID: 10224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BA2")]
		public object ClientData
		{
			[Token(Token = "0x60027EF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60027F0")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x060027F1 RID: 10225 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027F2 RID: 10226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BA3")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60027F1")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60027F2")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x060027F3 RID: 10227 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027F4 RID: 10228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BA4")]
		public ContinuanceToken ContinuanceToken
		{
			[Token(Token = "0x60027F3")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60027F4")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x0000A214 File Offset: 0x00008414
		[Token(Token = "0x60027F5")]
		[Address(RVA = "0x55E4E0", Offset = "0x55CAE0", VA = "0x18055E4E0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027F6")]
		[Address(RVA = "0x55E530", Offset = "0x55CB30", VA = "0x18055E530")]
		internal void Set(ref LoginCallbackInfoInternal other)
		{
		}
	}
}
