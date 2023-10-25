using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000110 RID: 272
	[Token(Token = "0x2000110")]
	public struct EndSessionCallbackInfo : ICallbackInfo
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x000038CC File Offset: 0x00001ACC
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D3")]
		public Result ResultCode
		{
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D4")]
		public object ClientData
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x000038E4 File Offset: 0x00001AE4
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x4BC810", Offset = "0x4BAE10", VA = "0x1804BC810", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x4BC860", Offset = "0x4BAE60", VA = "0x1804BC860")]
		internal void Set(ref EndSessionCallbackInfoInternal other)
		{
		}
	}
}
