using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x02000499 RID: 1177
	[Token(Token = "0x2000499")]
	internal struct OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryLeaderboardDefinitionsCompleteCallbackInfo>, ISettable<OnQueryLeaderboardDefinitionsCompleteCallbackInfo>, IDisposable
	{
		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x000084BC File Offset: 0x000066BC
		// (set) Token: 0x06001E5D RID: 7773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700088D")]
		public Result ResultCode
		{
			[Token(Token = "0x6001E5C")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001E5D")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700088E")]
		public object ClientData
		{
			[Token(Token = "0x6001E5E")]
			[Address(RVA = "0x52F070", Offset = "0x52D670", VA = "0x18052F070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E5F")]
			[Address(RVA = "0x52F0E0", Offset = "0x52D6E0", VA = "0x18052F0E0")]
			set
			{
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x000084D4 File Offset: 0x000066D4
		[Token(Token = "0x1700088F")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001E60")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E61")]
		[Address(RVA = "0x52EF50", Offset = "0x52D550", VA = "0x18052EF50", Slot = "6")]
		public void Set(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfo other)
		{
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E62")]
		[Address(RVA = "0x52EFB0", Offset = "0x52D5B0", VA = "0x18052EFB0", Slot = "7")]
		public void Set(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfo? other)
		{
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E63")]
		[Address(RVA = "0x52EEE0", Offset = "0x52D4E0", VA = "0x18052EEE0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E64")]
		[Address(RVA = "0x52EF30", Offset = "0x52D530", VA = "0x18052EF30", Slot = "5")]
		public void Get(out OnQueryLeaderboardDefinitionsCompleteCallbackInfo output)
		{
		}

		// Token: 0x04000D7F RID: 3455
		[Token(Token = "0x4000D7F")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000D80 RID: 3456
		[Token(Token = "0x4000D80")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
