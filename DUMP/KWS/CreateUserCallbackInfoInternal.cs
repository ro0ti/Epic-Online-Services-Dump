using System;


namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004AF RID: 1199
	[Token(Token = "0x20004AF")]
	internal struct CreateUserCallbackInfoInternal : ICallbackInfoInternal, IGettable<CreateUserCallbackInfo>, ISettable<CreateUserCallbackInfo>, IDisposable
	{
		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x0000869C File Offset: 0x0000689C
		// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008BB")]
		public Result ResultCode
		{
			[Token(Token = "0x6001EDF")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001EE0")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008BC")]
		public object ClientData
		{
			[Token(Token = "0x6001EE1")]
			[Address(RVA = "0x522460", Offset = "0x520A60", VA = "0x180522460")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EE2")]
			[Address(RVA = "0x522620", Offset = "0x520C20", VA = "0x180522620")]
			set
			{
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x000086B4 File Offset: 0x000068B4
		[Token(Token = "0x170008BD")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001EE3")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001EE5 RID: 7909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008BE")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001EE4")]
			[Address(RVA = "0x5225A0", Offset = "0x520BA0", VA = "0x1805225A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EE5")]
			[Address(RVA = "0x522740", Offset = "0x520D40", VA = "0x180522740")]
			set
			{
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001EE7 RID: 7911 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008BF")]
		public Utf8String KWSUserId
		{
			[Token(Token = "0x6001EE6")]
			[Address(RVA = "0x522530", Offset = "0x520B30", VA = "0x180522530")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EE7")]
			[Address(RVA = "0x5226E0", Offset = "0x520CE0", VA = "0x1805226E0")]
			set
			{
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x000086CC File Offset: 0x000068CC
		// (set) Token: 0x06001EE9 RID: 7913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008C0")]
		public bool IsMinor
		{
			[Token(Token = "0x6001EE8")]
			[Address(RVA = "0x5224D0", Offset = "0x520AD0", VA = "0x1805224D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EE9")]
			[Address(RVA = "0x522680", Offset = "0x520C80", VA = "0x180522680")]
			set
			{
			}
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EEA")]
		[Address(RVA = "0x522310", Offset = "0x520910", VA = "0x180522310", Slot = "6")]
		public void Set(ref CreateUserCallbackInfo other)
		{
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EEB")]
		[Address(RVA = "0x522140", Offset = "0x520740", VA = "0x180522140", Slot = "7")]
		public void Set(ref CreateUserCallbackInfo? other)
		{
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EEC")]
		[Address(RVA = "0x5220A0", Offset = "0x5206A0", VA = "0x1805220A0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EED")]
		[Address(RVA = "0x522110", Offset = "0x520710", VA = "0x180522110", Slot = "5")]
		public void Get(out CreateUserCallbackInfo output)
		{
		}

		// Token: 0x04000DB2 RID: 3506
		[Token(Token = "0x4000DB2")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000DB3 RID: 3507
		[Token(Token = "0x4000DB3")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000DB4 RID: 3508
		[Token(Token = "0x4000DB4")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000DB5 RID: 3509
		[Token(Token = "0x4000DB5")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_KWSUserId;

		// Token: 0x04000DB6 RID: 3510
		[Token(Token = "0x4000DB6")]
		[FieldOffset(Offset = "0x20")]
		private int m_IsMinor;
	}
}
