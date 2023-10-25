using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200057F RID: 1407
	[Token(Token = "0x200057F")]
	public struct QueryOffersCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x0000977C File Offset: 0x0000797C
		// (set) Token: 0x0600242C RID: 9260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A77")]
		public Result ResultCode
		{
			[Token(Token = "0x600242B")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600242C")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600242E RID: 9262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A78")]
		public object ClientData
		{
			[Token(Token = "0x600242D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600242E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002430 RID: 9264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A79")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600242F")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002430")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00009794 File Offset: 0x00007994
		[Token(Token = "0x6002431")]
		[Address(RVA = "0x54CCB0", Offset = "0x54B2B0", VA = "0x18054CCB0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002432")]
		[Address(RVA = "0x54CD00", Offset = "0x54B300", VA = "0x18054CD00")]
		internal void Set(ref QueryOffersCallbackInfoInternal other)
		{
		}
	}
}
