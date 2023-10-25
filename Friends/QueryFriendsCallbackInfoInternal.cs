using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x0200051B RID: 1307
	[Token(Token = "0x200051B")]
	internal struct QueryFriendsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryFriendsCallbackInfo>, ISettable<QueryFriendsCallbackInfo>, IDisposable
	{
		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x00008E4C File Offset: 0x0000704C
		// (set) Token: 0x06002169 RID: 8553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000976")]
		public Result ResultCode
		{
			[Token(Token = "0x6002168")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002169")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600216B RID: 8555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000977")]
		public object ClientData
		{
			[Token(Token = "0x600216A")]
			[Address(RVA = "0x54C440", Offset = "0x54AA40", VA = "0x18054C440")]
			get
			{
				return null;
			}
			[Token(Token = "0x600216B")]
			[Address(RVA = "0x54C530", Offset = "0x54AB30", VA = "0x18054C530")]
			set
			{
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x00008E64 File Offset: 0x00007064
		[Token(Token = "0x17000978")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600216C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600216E RID: 8558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000979")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600216D")]
			[Address(RVA = "0x54C4B0", Offset = "0x54AAB0", VA = "0x18054C4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600216E")]
			[Address(RVA = "0x54C590", Offset = "0x54AB90", VA = "0x18054C590")]
			set
			{
			}
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600216F")]
		[Address(RVA = "0x54C380", Offset = "0x54A980", VA = "0x18054C380", Slot = "6")]
		public void Set(ref QueryFriendsCallbackInfo other)
		{
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002170")]
		[Address(RVA = "0x54C260", Offset = "0x54A860", VA = "0x18054C260", Slot = "7")]
		public void Set(ref QueryFriendsCallbackInfo? other)
		{
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002171")]
		[Address(RVA = "0x54C1E0", Offset = "0x54A7E0", VA = "0x18054C1E0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002172")]
		[Address(RVA = "0x54C240", Offset = "0x54A840", VA = "0x18054C240", Slot = "5")]
		public void Get(out QueryFriendsCallbackInfo output)
		{
		}

		// Token: 0x04000EB2 RID: 3762
		[Token(Token = "0x4000EB2")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000EB3 RID: 3763
		[Token(Token = "0x4000EB3")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000EB4 RID: 3764
		[Token(Token = "0x4000EB4")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
