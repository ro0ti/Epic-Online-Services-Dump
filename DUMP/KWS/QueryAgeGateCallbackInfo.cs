using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004C8 RID: 1224
	[Token(Token = "0x20004C8")]
	public struct QueryAgeGateCallbackInfo : ICallbackInfo
	{
		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x000087D4 File Offset: 0x000069D4
		// (set) Token: 0x06001F78 RID: 8056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008DE")]
		public Result ResultCode
		{
			[Token(Token = "0x6001F77")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001F78")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008DF")]
		public object ClientData
		{
			[Token(Token = "0x6001F79")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001F7A")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F7C RID: 8060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008E0")]
		public Utf8String CountryCode
		{
			[Token(Token = "0x6001F7B")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001F7C")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x000087EC File Offset: 0x000069EC
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008E1")]
		public uint AgeOfConsent
		{
			[Token(Token = "0x6001F7D")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6001F7E")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00008804 File Offset: 0x00006A04
		[Token(Token = "0x6001F7F")]
		[Address(RVA = "0x532550", Offset = "0x530B50", VA = "0x180532550", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F80")]
		[Address(RVA = "0x5325A0", Offset = "0x530BA0", VA = "0x1805325A0")]
		internal void Set(ref QueryAgeGateCallbackInfoInternal other)
		{
		}
	}
}
