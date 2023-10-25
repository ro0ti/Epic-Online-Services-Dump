using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000167 RID: 359
	[Token(Token = "0x2000167")]
	internal struct SessionInviteAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<SessionInviteAcceptedCallbackInfo>, ISettable<SessionInviteAcceptedCallbackInfo>, IDisposable
	{
		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700025D")]
		public object ClientData
		{
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x4C92B0", Offset = "0x4C78B0", VA = "0x1804C92B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x4C9500", Offset = "0x4C7B00", VA = "0x1804C9500")]
			set
			{
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x00003E6C File Offset: 0x0000206C
		[Token(Token = "0x1700025E")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700025F")]
		public Utf8String SessionId
		{
			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x4C9410", Offset = "0x4C7A10", VA = "0x1804C9410")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x4C9620", Offset = "0x4C7C20", VA = "0x1804C9620")]
			set
			{
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000260")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x4C9390", Offset = "0x4C7990", VA = "0x1804C9390")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x4C95C0", Offset = "0x4C7BC0", VA = "0x1804C95C0")]
			set
			{
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000261")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x4C9480", Offset = "0x4C7A80", VA = "0x1804C9480")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x4C9680", Offset = "0x4C7C80", VA = "0x1804C9680")]
			set
			{
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000262")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x4C9320", Offset = "0x4C7920", VA = "0x1804C9320")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x4C9560", Offset = "0x4C7B60", VA = "0x1804C9560")]
			set
			{
			}
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x4C9130", Offset = "0x4C7730", VA = "0x1804C9130", Slot = "6")]
		public void Set(ref SessionInviteAcceptedCallbackInfo other)
		{
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x4C8F20", Offset = "0x4C7520", VA = "0x1804C8F20", Slot = "7")]
		public void Set(ref SessionInviteAcceptedCallbackInfo? other)
		{
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x4C8E70", Offset = "0x4C7470", VA = "0x1804C8E70", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x4C8EF0", Offset = "0x4C74F0", VA = "0x1804C8EF0", Slot = "5")]
		public void Get(out SessionInviteAcceptedCallbackInfo output)
		{
		}

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionId;

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_InviteId;
	}
}
