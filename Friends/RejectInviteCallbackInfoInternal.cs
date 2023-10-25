using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x0200051F RID: 1311
	[Token(Token = "0x200051F")]
	internal struct RejectInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<RejectInviteCallbackInfo>, ISettable<RejectInviteCallbackInfo>, IDisposable
	{
		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x00008EAC File Offset: 0x000070AC
		// (set) Token: 0x06002184 RID: 8580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000980")]
		public Result ResultCode
		{
			[Token(Token = "0x6002183")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002184")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06002185 RID: 8581 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002186 RID: 8582 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000981")]
		public object ClientData
		{
			[Token(Token = "0x6002185")]
			[Address(RVA = "0x54F980", Offset = "0x54DF80", VA = "0x18054F980")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002186")]
			[Address(RVA = "0x54FAF0", Offset = "0x54E0F0", VA = "0x18054FAF0")]
			set
			{
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06002187 RID: 8583 RVA: 0x00008EC4 File Offset: 0x000070C4
		[Token(Token = "0x17000982")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002187")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002189 RID: 8585 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000983")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002188")]
			[Address(RVA = "0x54F9F0", Offset = "0x54DFF0", VA = "0x18054F9F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002189")]
			[Address(RVA = "0x54FB50", Offset = "0x54E150", VA = "0x18054FB50")]
			set
			{
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600218B RID: 8587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000984")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x600218A")]
			[Address(RVA = "0x54FA70", Offset = "0x54E070", VA = "0x18054FA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600218B")]
			[Address(RVA = "0x54FBB0", Offset = "0x54E1B0", VA = "0x18054FBB0")]
			set
			{
			}
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600218C")]
		[Address(RVA = "0x54F700", Offset = "0x54DD00", VA = "0x18054F700", Slot = "6")]
		public void Set(ref RejectInviteCallbackInfo other)
		{
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600218D")]
		[Address(RVA = "0x54F800", Offset = "0x54DE00", VA = "0x18054F800", Slot = "7")]
		public void Set(ref RejectInviteCallbackInfo? other)
		{
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600218E")]
		[Address(RVA = "0x54F670", Offset = "0x54DC70", VA = "0x18054F670", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600218F")]
		[Address(RVA = "0x54F6E0", Offset = "0x54DCE0", VA = "0x18054F6E0", Slot = "5")]
		public void Get(out RejectInviteCallbackInfo output)
		{
		}

		// Token: 0x04000EBC RID: 3772
		[Token(Token = "0x4000EBC")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000EBD RID: 3773
		[Token(Token = "0x4000EBD")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000EBE RID: 3774
		[Token(Token = "0x4000EBE")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000EBF RID: 3775
		[Token(Token = "0x4000EBF")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
