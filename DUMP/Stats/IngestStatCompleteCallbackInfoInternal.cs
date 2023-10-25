using System;


namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	internal struct IngestStatCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<IngestStatCompleteCallbackInfo>, ISettable<IngestStatCompleteCallbackInfo>, IDisposable
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00003464 File Offset: 0x00001664
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000173")]
		public Result ResultCode
		{
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000174")]
		public object ClientData
		{
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x4BD620", Offset = "0x4BBC20", VA = "0x1804BD620")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000799")]
			[Address(RVA = "0x4BD790", Offset = "0x4BBD90", VA = "0x1804BD790")]
			set
			{
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x0000347C File Offset: 0x0000167C
		[Token(Token = "0x17000175")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600079A")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000176")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0x4BD690", Offset = "0x4BBC90", VA = "0x1804BD690")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x4BD7F0", Offset = "0x4BBDF0", VA = "0x1804BD7F0")]
			set
			{
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000177")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x600079D")]
			[Address(RVA = "0x4BD710", Offset = "0x4BBD10", VA = "0x1804BD710")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079E")]
			[Address(RVA = "0x4BD850", Offset = "0x4BBE50", VA = "0x1804BD850")]
			set
			{
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x4BD520", Offset = "0x4BBB20", VA = "0x1804BD520", Slot = "6")]
		public void Set(ref IngestStatCompleteCallbackInfo other)
		{
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x4BD3A0", Offset = "0x4BB9A0", VA = "0x1804BD3A0", Slot = "7")]
		public void Set(ref IngestStatCompleteCallbackInfo? other)
		{
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x4BD310", Offset = "0x4BB910", VA = "0x1804BD310", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x4BD380", Offset = "0x4BB980", VA = "0x1804BD380", Slot = "5")]
		public void Get(out IngestStatCompleteCallbackInfo output)
		{
		}

		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
