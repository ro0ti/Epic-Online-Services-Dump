using System;


namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004D1 RID: 1233
	[Token(Token = "0x20004D1")]
	internal struct RequestPermissionsCallbackInfoInternal : ICallbackInfoInternal, IGettable<RequestPermissionsCallbackInfo>, ISettable<RequestPermissionsCallbackInfo>, IDisposable
	{
		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x00008924 File Offset: 0x00006B24
		// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008FB")]
		public Result ResultCode
		{
			[Token(Token = "0x6001FC2")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001FC3")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FC5 RID: 8133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008FC")]
		public object ClientData
		{
			[Token(Token = "0x6001FC4")]
			[Address(RVA = "0x535C50", Offset = "0x534250", VA = "0x180535C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FC5")]
			[Address(RVA = "0x535D40", Offset = "0x534340", VA = "0x180535D40")]
			set
			{
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x0000893C File Offset: 0x00006B3C
		[Token(Token = "0x170008FD")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001FC6")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008FE")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001FC7")]
			[Address(RVA = "0x535CC0", Offset = "0x5342C0", VA = "0x180535CC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FC8")]
			[Address(RVA = "0x535DA0", Offset = "0x5343A0", VA = "0x180535DA0")]
			set
			{
			}
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FC9")]
		[Address(RVA = "0x535B90", Offset = "0x534190", VA = "0x180535B90", Slot = "6")]
		public void Set(ref RequestPermissionsCallbackInfo other)
		{
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FCA")]
		[Address(RVA = "0x535A70", Offset = "0x534070", VA = "0x180535A70", Slot = "7")]
		public void Set(ref RequestPermissionsCallbackInfo? other)
		{
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FCB")]
		[Address(RVA = "0x5359F0", Offset = "0x533FF0", VA = "0x1805359F0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FCC")]
		[Address(RVA = "0x535A50", Offset = "0x534050", VA = "0x180535A50", Slot = "5")]
		public void Get(out RequestPermissionsCallbackInfo output)
		{
		}

		// Token: 0x04000E04 RID: 3588
		[Token(Token = "0x4000E04")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000E05 RID: 3589
		[Token(Token = "0x4000E05")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000E06 RID: 3590
		[Token(Token = "0x4000E06")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
