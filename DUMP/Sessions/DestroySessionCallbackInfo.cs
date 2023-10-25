using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200010A RID: 266
	[Token(Token = "0x200010A")]
	public struct DestroySessionCallbackInfo : ICallbackInfo
	{
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x0000386C File Offset: 0x00001A6C
		// (set) Token: 0x060008A2 RID: 2210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001CA")]
		public Result ResultCode
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001CB")]
		public object ClientData
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00003884 File Offset: 0x00001A84
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x4BC180", Offset = "0x4BA780", VA = "0x1804BC180", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x4BC1D0", Offset = "0x4BA7D0", VA = "0x1804BC1D0")]
		internal void Set(ref DestroySessionCallbackInfoInternal other)
		{
		}
	}
}
