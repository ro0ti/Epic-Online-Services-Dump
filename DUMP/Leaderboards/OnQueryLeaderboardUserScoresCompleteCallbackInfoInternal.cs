using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x020004A1 RID: 1185
	[Token(Token = "0x20004A1")]
	internal struct OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryLeaderboardUserScoresCompleteCallbackInfo>, ISettable<OnQueryLeaderboardUserScoresCompleteCallbackInfo>, IDisposable
	{
		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x0000857C File Offset: 0x0000677C
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000897")]
		public Result ResultCode
		{
			[Token(Token = "0x6001E8A")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001E8B")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000898")]
		public object ClientData
		{
			[Token(Token = "0x6001E8C")]
			[Address(RVA = "0x52F910", Offset = "0x52DF10", VA = "0x18052F910")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E8D")]
			[Address(RVA = "0x52F980", Offset = "0x52DF80", VA = "0x18052F980")]
			set
			{
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x00008594 File Offset: 0x00006794
		[Token(Token = "0x17000899")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001E8E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E8F")]
		[Address(RVA = "0x52F7F0", Offset = "0x52DDF0", VA = "0x18052F7F0", Slot = "6")]
		public void Set(ref OnQueryLeaderboardUserScoresCompleteCallbackInfo other)
		{
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E90")]
		[Address(RVA = "0x52F850", Offset = "0x52DE50", VA = "0x18052F850", Slot = "7")]
		public void Set(ref OnQueryLeaderboardUserScoresCompleteCallbackInfo? other)
		{
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E91")]
		[Address(RVA = "0x52F780", Offset = "0x52DD80", VA = "0x18052F780", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E92")]
		[Address(RVA = "0x52F7D0", Offset = "0x52DDD0", VA = "0x18052F7D0", Slot = "5")]
		public void Get(out OnQueryLeaderboardUserScoresCompleteCallbackInfo output)
		{
		}

		// Token: 0x04000D87 RID: 3463
		[Token(Token = "0x4000D87")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000D88 RID: 3464
		[Token(Token = "0x4000D88")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
