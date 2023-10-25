using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x020004A0 RID: 1184
	[Token(Token = "0x20004A0")]
	public struct OnQueryLeaderboardUserScoresCompleteCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x0000854C File Offset: 0x0000674C
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000895")]
		public Result ResultCode
		{
			[Token(Token = "0x6001E84")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001E85")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000896")]
		public object ClientData
		{
			[Token(Token = "0x6001E86")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001E87")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x00008564 File Offset: 0x00006764
		[Token(Token = "0x6001E88")]
		[Address(RVA = "0x52F9E0", Offset = "0x52DFE0", VA = "0x18052F9E0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E89")]
		[Address(RVA = "0x52FA30", Offset = "0x52E030", VA = "0x18052FA30")]
		internal void Set(ref OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal other)
		{
		}
	}
}
