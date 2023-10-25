using System;


namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x0200049D RID: 1181
	[Token(Token = "0x200049D")]
	internal struct OnQueryLeaderboardRanksCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryLeaderboardRanksCompleteCallbackInfo>, ISettable<OnQueryLeaderboardRanksCompleteCallbackInfo>, IDisposable
	{
		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x0000851C File Offset: 0x0000671C
		// (set) Token: 0x06001E74 RID: 7796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000892")]
		public Result ResultCode
		{
			[Token(Token = "0x6001E73")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001E74")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001E76 RID: 7798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000893")]
		public object ClientData
		{
			[Token(Token = "0x6001E75")]
			[Address(RVA = "0x52F4C0", Offset = "0x52DAC0", VA = "0x18052F4C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E76")]
			[Address(RVA = "0x52F530", Offset = "0x52DB30", VA = "0x18052F530")]
			set
			{
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x00008534 File Offset: 0x00006734
		[Token(Token = "0x17000894")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001E77")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E78")]
		[Address(RVA = "0x52F3A0", Offset = "0x52D9A0", VA = "0x18052F3A0", Slot = "6")]
		public void Set(ref OnQueryLeaderboardRanksCompleteCallbackInfo other)
		{
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E79")]
		[Address(RVA = "0x52F400", Offset = "0x52DA00", VA = "0x18052F400", Slot = "7")]
		public void Set(ref OnQueryLeaderboardRanksCompleteCallbackInfo? other)
		{
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E7A")]
		[Address(RVA = "0x52F330", Offset = "0x52D930", VA = "0x18052F330", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E7B")]
		[Address(RVA = "0x52F380", Offset = "0x52D980", VA = "0x18052F380", Slot = "5")]
		public void Get(out OnQueryLeaderboardRanksCompleteCallbackInfo output)
		{
		}

		// Token: 0x04000D83 RID: 3459
		[Token(Token = "0x4000D83")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000D84 RID: 3460
		[Token(Token = "0x4000D84")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
