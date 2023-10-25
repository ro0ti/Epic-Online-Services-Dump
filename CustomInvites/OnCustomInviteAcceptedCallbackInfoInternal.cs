using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005B8 RID: 1464
	[Token(Token = "0x20005B8")]
	internal struct OnCustomInviteAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnCustomInviteAcceptedCallbackInfo>, ISettable<OnCustomInviteAcceptedCallbackInfo>, IDisposable
	{
		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600258C RID: 9612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AE5")]
		public object ClientData
		{
			[Token(Token = "0x600258B")]
			[Address(RVA = "0x560820", Offset = "0x55EE20", VA = "0x180560820")]
			get
			{
				return null;
			}
			[Token(Token = "0x600258C")]
			[Address(RVA = "0x560A70", Offset = "0x55F070", VA = "0x180560A70")]
			set
			{
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x00009B9C File Offset: 0x00007D9C
		[Token(Token = "0x17000AE6")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600258D")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600258F RID: 9615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AE7")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x600258E")]
			[Address(RVA = "0x5609F0", Offset = "0x55EFF0", VA = "0x1805609F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600258F")]
			[Address(RVA = "0x560BF0", Offset = "0x55F1F0", VA = "0x180560BF0")]
			set
			{
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002591 RID: 9617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AE8")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002590")]
			[Address(RVA = "0x560900", Offset = "0x55EF00", VA = "0x180560900")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002591")]
			[Address(RVA = "0x560B30", Offset = "0x55F130", VA = "0x180560B30")]
			set
			{
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002593 RID: 9619 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AE9")]
		public Utf8String CustomInviteId
		{
			[Token(Token = "0x6002592")]
			[Address(RVA = "0x560890", Offset = "0x55EE90", VA = "0x180560890")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002593")]
			[Address(RVA = "0x560AD0", Offset = "0x55F0D0", VA = "0x180560AD0")]
			set
			{
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002595 RID: 9621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AEA")]
		public Utf8String Payload
		{
			[Token(Token = "0x6002594")]
			[Address(RVA = "0x560980", Offset = "0x55EF80", VA = "0x180560980")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002595")]
			[Address(RVA = "0x560B90", Offset = "0x55F190", VA = "0x180560B90")]
			set
			{
			}
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002596")]
		[Address(RVA = "0x5606A0", Offset = "0x55ECA0", VA = "0x1805606A0", Slot = "6")]
		public void Set(ref OnCustomInviteAcceptedCallbackInfo other)
		{
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002597")]
		[Address(RVA = "0x560490", Offset = "0x55EA90", VA = "0x180560490", Slot = "7")]
		public void Set(ref OnCustomInviteAcceptedCallbackInfo? other)
		{
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002598")]
		[Address(RVA = "0x5603E0", Offset = "0x55E9E0", VA = "0x1805603E0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002599")]
		[Address(RVA = "0x560460", Offset = "0x55EA60", VA = "0x180560460", Slot = "5")]
		public void Get(out OnCustomInviteAcceptedCallbackInfo output)
		{
		}

		// Token: 0x0400109F RID: 4255
		[Token(Token = "0x400109F")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040010A0 RID: 4256
		[Token(Token = "0x40010A0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x040010A1 RID: 4257
		[Token(Token = "0x40010A1")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040010A2 RID: 4258
		[Token(Token = "0x40010A2")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_CustomInviteId;

		// Token: 0x040010A3 RID: 4259
		[Token(Token = "0x40010A3")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_Payload;
	}
}
