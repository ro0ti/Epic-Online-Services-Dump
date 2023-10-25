using System;


namespace Epic.OnlineServices.UI
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	internal struct ShowNativeProfileCallbackInfoInternal : ICallbackInfoInternal, IGettable<ShowNativeProfileCallbackInfo>, ISettable<ShowNativeProfileCallbackInfo>, IDisposable
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00002DD4 File Offset: 0x00000FD4
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F6")]
		public Result ResultCode
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F7")]
		public object ClientData
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x4B09E0", Offset = "0x4AEFE0", VA = "0x1804B09E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x4B0B80", Offset = "0x4AF180", VA = "0x1804B0B80")]
			set
			{
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x170000F8")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F9")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x4B0A80", Offset = "0x4AF080", VA = "0x1804B0A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x4B0C20", Offset = "0x4AF220", VA = "0x1804B0C20")]
			set
			{
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000FA")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x4B0B00", Offset = "0x4AF100", VA = "0x1804B0B00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x4B0CD0", Offset = "0x4AF2D0", VA = "0x1804B0CD0")]
			set
			{
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x4B08B0", Offset = "0x4AEEB0", VA = "0x1804B08B0", Slot = "6")]
		public void Set(ref ShowNativeProfileCallbackInfo other)
		{
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x4B0900", Offset = "0x4AEF00", VA = "0x1804B0900", Slot = "7")]
		public void Set(ref ShowNativeProfileCallbackInfo? other)
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x4B0710", Offset = "0x4AED10", VA = "0x1804B0710", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x4B0830", Offset = "0x4AEE30", VA = "0x1804B0830", Slot = "5")]
		public void Get(out ShowNativeProfileCallbackInfo output)
		{
		}

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
