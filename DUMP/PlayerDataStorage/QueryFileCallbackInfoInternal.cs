using System;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x02000301 RID: 769
	[Token(Token = "0x2000301")]
	internal struct QueryFileCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryFileCallbackInfo>, ISettable<QueryFileCallbackInfo>, IDisposable
	{
		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x00005E7C File Offset: 0x0000407C
		// (set) Token: 0x060014BC RID: 5308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000572")]
		public Result ResultCode
		{
			[Token(Token = "0x60014BB")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60014BC")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060014BE RID: 5310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000573")]
		public object ClientData
		{
			[Token(Token = "0x60014BD")]
			[Address(RVA = "0x4FD4F0", Offset = "0x4FBAF0", VA = "0x1804FD4F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60014BE")]
			[Address(RVA = "0x4FD5E0", Offset = "0x4FBBE0", VA = "0x1804FD5E0")]
			set
			{
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x00005E94 File Offset: 0x00004094
		[Token(Token = "0x17000574")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60014BF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060014C1 RID: 5313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000575")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60014C0")]
			[Address(RVA = "0x4FD560", Offset = "0x4FBB60", VA = "0x1804FD560")]
			get
			{
				return null;
			}
			[Token(Token = "0x60014C1")]
			[Address(RVA = "0x4FD640", Offset = "0x4FBC40", VA = "0x1804FD640")]
			set
			{
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x4FD310", Offset = "0x4FB910", VA = "0x1804FD310", Slot = "6")]
		public void Set(ref QueryFileCallbackInfo other)
		{
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014C3")]
		[Address(RVA = "0x4FD3D0", Offset = "0x4FB9D0", VA = "0x1804FD3D0", Slot = "7")]
		public void Set(ref QueryFileCallbackInfo? other)
		{
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014C4")]
		[Address(RVA = "0x4FD290", Offset = "0x4FB890", VA = "0x1804FD290", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x4FD2F0", Offset = "0x4FB8F0", VA = "0x1804FD2F0", Slot = "5")]
		public void Get(out QueryFileCallbackInfo output)
		{
		}

		// Token: 0x0400091B RID: 2331
		[Token(Token = "0x400091B")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400091C RID: 2332
		[Token(Token = "0x400091C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x0400091D RID: 2333
		[Token(Token = "0x400091D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
