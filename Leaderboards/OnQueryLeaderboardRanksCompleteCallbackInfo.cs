using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x0200049C RID: 1180
	[Token(Token = "0x200049C")]
	public struct OnQueryLeaderboardRanksCompleteCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001E6D RID: 7789 RVA: 0x000084EC File Offset: 0x000066EC
		// (set) Token: 0x06001E6E RID: 7790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000890")]
		public Result ResultCode
		{
			[Token(Token = "0x6001E6D")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001E6E")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001E6F RID: 7791 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001E70 RID: 7792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000891")]
		public object ClientData
		{
			[Token(Token = "0x6001E6F")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001E70")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00008504 File Offset: 0x00006704
		[Token(Token = "0x6001E71")]
		[Address(RVA = "0x52F590", Offset = "0x52DB90", VA = "0x18052F590", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E72")]
		[Address(RVA = "0x52F5E0", Offset = "0x52DBE0", VA = "0x18052F5E0")]
		internal void Set(ref OnQueryLeaderboardRanksCompleteCallbackInfoInternal other)
		{
		}
	}
}
