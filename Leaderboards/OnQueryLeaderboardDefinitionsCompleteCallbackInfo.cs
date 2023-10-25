using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x02000498 RID: 1176
	[Token(Token = "0x2000498")]
	public struct OnQueryLeaderboardDefinitionsCompleteCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x0000848C File Offset: 0x0000668C
		// (set) Token: 0x06001E57 RID: 7767 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700088B")]
		public Result ResultCode
		{
			[Token(Token = "0x6001E56")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001E57")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700088C")]
		public object ClientData
		{
			[Token(Token = "0x6001E58")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001E59")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x000084A4 File Offset: 0x000066A4
		[Token(Token = "0x6001E5A")]
		[Address(RVA = "0x52F140", Offset = "0x52D740", VA = "0x18052F140", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E5B")]
		[Address(RVA = "0x52F190", Offset = "0x52D790", VA = "0x18052F190")]
		internal void Set(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal other)
		{
		}
	}
}
