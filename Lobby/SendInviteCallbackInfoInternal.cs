using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000471 RID: 1137
	[Token(Token = "0x2000471")]
	internal struct SendInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendInviteCallbackInfo>, ISettable<SendInviteCallbackInfo>, IDisposable
	{
		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x0000815C File Offset: 0x0000635C
		// (set) Token: 0x06001D75 RID: 7541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700083F")]
		public Result ResultCode
		{
			[Token(Token = "0x6001D74")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001D75")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000840")]
		public object ClientData
		{
			[Token(Token = "0x6001D76")]
			[Address(RVA = "0x536420", Offset = "0x534A20", VA = "0x180536420")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D77")]
			[Address(RVA = "0x536500", Offset = "0x534B00", VA = "0x180536500")]
			set
			{
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x00008174 File Offset: 0x00006374
		[Token(Token = "0x17000841")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001D78")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000842")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001D79")]
			[Address(RVA = "0x536490", Offset = "0x534A90", VA = "0x180536490")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D7A")]
			[Address(RVA = "0x536560", Offset = "0x534B60", VA = "0x180536560")]
			set
			{
			}
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D7B")]
		[Address(RVA = "0x536360", Offset = "0x534960", VA = "0x180536360", Slot = "6")]
		public void Set(ref SendInviteCallbackInfo other)
		{
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D7C")]
		[Address(RVA = "0x536240", Offset = "0x534840", VA = "0x180536240", Slot = "7")]
		public void Set(ref SendInviteCallbackInfo? other)
		{
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D7D")]
		[Address(RVA = "0x5361C0", Offset = "0x5347C0", VA = "0x1805361C0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D7E")]
		[Address(RVA = "0x536220", Offset = "0x534820", VA = "0x180536220", Slot = "5")]
		public void Get(out SendInviteCallbackInfo output)
		{
		}

		// Token: 0x04000D0F RID: 3343
		[Token(Token = "0x4000D0F")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000D10 RID: 3344
		[Token(Token = "0x4000D10")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000D11 RID: 3345
		[Token(Token = "0x4000D11")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyId;
	}
}
