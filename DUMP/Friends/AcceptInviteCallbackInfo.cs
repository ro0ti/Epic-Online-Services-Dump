using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Friends
{
	// Token: 0x020004F6 RID: 1270
	[Token(Token = "0x20004F6")]
	public struct AcceptInviteCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x0600209C RID: 8348 RVA: 0x00008C24 File Offset: 0x00006E24
		// (set) Token: 0x0600209D RID: 8349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000942")]
		public Result ResultCode
		{
			[Token(Token = "0x600209C")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600209D")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600209F RID: 8351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000943")]
		public object ClientData
		{
			[Token(Token = "0x600209E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600209F")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060020A1 RID: 8353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000944")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60020A0")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60020A1")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060020A3 RID: 8355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000945")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60020A2")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60020A3")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00008C3C File Offset: 0x00006E3C
		[Token(Token = "0x60020A4")]
		[Address(RVA = "0x538FC0", Offset = "0x5375C0", VA = "0x180538FC0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020A5")]
		[Address(RVA = "0x539010", Offset = "0x537610", VA = "0x180539010")]
		internal void Set(ref AcceptInviteCallbackInfoInternal other)
		{
		}
	}
}
