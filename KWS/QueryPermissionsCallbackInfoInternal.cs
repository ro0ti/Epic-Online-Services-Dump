using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004CD RID: 1229
	[Token(Token = "0x20004CD")]
	internal struct QueryPermissionsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryPermissionsCallbackInfo>, ISettable<QueryPermissionsCallbackInfo>, IDisposable
	{
		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x000088AC File Offset: 0x00006AAC
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008EE")]
		public Result ResultCode
		{
			[Token(Token = "0x6001FA1")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001FA2")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008EF")]
		public object ClientData
		{
			[Token(Token = "0x6001FA3")]
			[Address(RVA = "0x534090", Offset = "0x532690", VA = "0x180534090")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FA4")]
			[Address(RVA = "0x534330", Offset = "0x532930", VA = "0x180534330")]
			set
			{
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x000088C4 File Offset: 0x00006AC4
		[Token(Token = "0x170008F0")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001FA5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FA7 RID: 8103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008F1")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001FA6")]
			[Address(RVA = "0x534240", Offset = "0x532840", VA = "0x180534240")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FA7")]
			[Address(RVA = "0x5344B0", Offset = "0x532AB0", VA = "0x1805344B0")]
			set
			{
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FA9 RID: 8105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008F2")]
		public Utf8String KWSUserId
		{
			[Token(Token = "0x6001FA8")]
			[Address(RVA = "0x5341D0", Offset = "0x5327D0", VA = "0x1805341D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FA9")]
			[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
			set
			{
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001FAA RID: 8106 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FAB RID: 8107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008F3")]
		public Utf8String DateOfBirth
		{
			[Token(Token = "0x6001FAA")]
			[Address(RVA = "0x534100", Offset = "0x532700", VA = "0x180534100")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FAB")]
			[Address(RVA = "0x534390", Offset = "0x532990", VA = "0x180534390")]
			set
			{
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x000088DC File Offset: 0x00006ADC
		// (set) Token: 0x06001FAD RID: 8109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008F4")]
		public bool IsMinor
		{
			[Token(Token = "0x6001FAC")]
			[Address(RVA = "0x534170", Offset = "0x532770", VA = "0x180534170")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FAD")]
			[Address(RVA = "0x5343F0", Offset = "0x5329F0", VA = "0x1805343F0")]
			set
			{
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FAF RID: 8111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008F5")]
		public Utf8String ParentEmail
		{
			[Token(Token = "0x6001FAE")]
			[Address(RVA = "0x5342C0", Offset = "0x5328C0", VA = "0x1805342C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FAF")]
			[Address(RVA = "0x534510", Offset = "0x532B10", VA = "0x180534510")]
			set
			{
			}
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FB0")]
		[Address(RVA = "0x533EC0", Offset = "0x5324C0", VA = "0x180533EC0", Slot = "6")]
		public void Set(ref QueryPermissionsCallbackInfo other)
		{
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FB1")]
		[Address(RVA = "0x533C40", Offset = "0x532240", VA = "0x180533C40", Slot = "7")]
		public void Set(ref QueryPermissionsCallbackInfo? other)
		{
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FB2")]
		[Address(RVA = "0x533B90", Offset = "0x532190", VA = "0x180533B90", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FB3")]
		[Address(RVA = "0x533C10", Offset = "0x532210", VA = "0x180533C10", Slot = "5")]
		public void Get(out QueryPermissionsCallbackInfo output)
		{
		}

		// Token: 0x04000DF7 RID: 3575
		[Token(Token = "0x4000DF7")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000DF8 RID: 3576
		[Token(Token = "0x4000DF8")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000DF9 RID: 3577
		[Token(Token = "0x4000DF9")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000DFA RID: 3578
		[Token(Token = "0x4000DFA")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_KWSUserId;

		// Token: 0x04000DFB RID: 3579
		[Token(Token = "0x4000DFB")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_DateOfBirth;

		// Token: 0x04000DFC RID: 3580
		[Token(Token = "0x4000DFC")]
		[FieldOffset(Offset = "0x28")]
		private int m_IsMinor;

		// Token: 0x04000DFD RID: 3581
		[Token(Token = "0x4000DFD")]
		[FieldOffset(Offset = "0x30")]
		private IntPtr m_ParentEmail;
	}
}
