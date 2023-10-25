using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000662 RID: 1634
	[Token(Token = "0x2000662")]
	internal struct LoginCallbackInfoInternal : ICallbackInfoInternal, IGettable<LoginCallbackInfo>, ISettable<LoginCallbackInfo>, IDisposable
	{
		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x060029E7 RID: 10727 RVA: 0x0000A844 File Offset: 0x00008A44
		// (set) Token: 0x060029E8 RID: 10728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C37")]
		public Result ResultCode
		{
			[Token(Token = "0x60029E7")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60029E8")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x060029E9 RID: 10729 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029EA RID: 10730 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C38")]
		public object ClientData
		{
			[Token(Token = "0x60029E9")]
			[Address(RVA = "0x55DDA0", Offset = "0x55C3A0", VA = "0x18055DDA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029EA")]
			[Address(RVA = "0x55E180", Offset = "0x55C780", VA = "0x18055E180")]
			set
			{
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x060029EB RID: 10731 RVA: 0x0000A85C File Offset: 0x00008A5C
		[Token(Token = "0x17000C39")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60029EB")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x060029EC RID: 10732 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029ED RID: 10733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C3A")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60029EC")]
			[Address(RVA = "0x55DF10", Offset = "0x55C510", VA = "0x18055DF10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029ED")]
			[Address(RVA = "0x55E300", Offset = "0x55C900", VA = "0x18055E300")]
			set
			{
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x060029EE RID: 10734 RVA: 0x0000A874 File Offset: 0x00008A74
		// (set) Token: 0x060029EF RID: 10735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C3B")]
		public PinGrantInfo? PinGrantInfo
		{
			[Token(Token = "0x60029EE")]
			[Address(RVA = "0x55E010", Offset = "0x55C610", VA = "0x18055E010")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029EF")]
			[Address(RVA = "0x55E3C0", Offset = "0x55C9C0", VA = "0x18055E3C0")]
			set
			{
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x060029F0 RID: 10736 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029F1 RID: 10737 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C3C")]
		public ContinuanceToken ContinuanceToken
		{
			[Token(Token = "0x60029F0")]
			[Address(RVA = "0x55DE10", Offset = "0x55C410", VA = "0x18055DE10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029F1")]
			[Address(RVA = "0x55E240", Offset = "0x55C840", VA = "0x18055E240")]
			set
			{
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x060029F2 RID: 10738 RVA: 0x0000A88C File Offset: 0x00008A8C
		// (set) Token: 0x060029F3 RID: 10739 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C3D")]
		public AccountFeatureRestrictedInfo? AccountFeatureRestrictedInfo_DEPRECATED
		{
			[Token(Token = "0x60029F2")]
			[Address(RVA = "0x55DCB0", Offset = "0x55C2B0", VA = "0x18055DCB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029F3")]
			[Address(RVA = "0x55E110", Offset = "0x55C710", VA = "0x18055E110")]
			set
			{
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x060029F4 RID: 10740 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029F5 RID: 10741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C3E")]
		public EpicAccountId SelectedAccountId
		{
			[Token(Token = "0x60029F4")]
			[Address(RVA = "0x55E090", Offset = "0x55C690", VA = "0x18055E090")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029F5")]
			[Address(RVA = "0x55E430", Offset = "0x55CA30", VA = "0x18055E430")]
			set
			{
			}
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029F6")]
		[Address(RVA = "0x55D920", Offset = "0x55BF20", VA = "0x18055D920", Slot = "6")]
		public void Set(ref LoginCallbackInfo other)
		{
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029F7")]
		[Address(RVA = "0x55D540", Offset = "0x55BB40", VA = "0x18055D540", Slot = "7")]
		public void Set(ref LoginCallbackInfo? other)
		{
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029F8")]
		[Address(RVA = "0x55D3F0", Offset = "0x55B9F0", VA = "0x18055D3F0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029F9")]
		[Address(RVA = "0x55D510", Offset = "0x55BB10", VA = "0x18055D510", Slot = "5")]
		public void Get(out LoginCallbackInfo output)
		{
		}

		// Token: 0x04001241 RID: 4673
		[Token(Token = "0x4001241")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04001242 RID: 4674
		[Token(Token = "0x4001242")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04001243 RID: 4675
		[Token(Token = "0x4001243")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001244 RID: 4676
		[Token(Token = "0x4001244")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_PinGrantInfo;

		// Token: 0x04001245 RID: 4677
		[Token(Token = "0x4001245")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ContinuanceToken;

		// Token: 0x04001246 RID: 4678
		[Token(Token = "0x4001246")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_AccountFeatureRestrictedInfo_DEPRECATED;

		// Token: 0x04001247 RID: 4679
		[Token(Token = "0x4001247")]
		[FieldOffset(Offset = "0x30")]
		private IntPtr m_SelectedAccountId;
	}
}
