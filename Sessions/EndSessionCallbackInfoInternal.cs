using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000111 RID: 273
	[Token(Token = "0x2000111")]
	internal struct EndSessionCallbackInfoInternal : ICallbackInfoInternal, IGettable<EndSessionCallbackInfo>, ISettable<EndSessionCallbackInfo>, IDisposable
	{
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x000038FC File Offset: 0x00001AFC
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D5")]
		public Result ResultCode
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D6")]
		public object ClientData
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x4BC740", Offset = "0x4BAD40", VA = "0x1804BC740")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x4BC7B0", Offset = "0x4BADB0", VA = "0x1804BC7B0")]
			set
			{
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00003914 File Offset: 0x00001B14
		[Token(Token = "0x170001D7")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x4BC6E0", Offset = "0x4BACE0", VA = "0x1804BC6E0", Slot = "6")]
		public void Set(ref EndSessionCallbackInfo other)
		{
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x4BC620", Offset = "0x4BAC20", VA = "0x1804BC620", Slot = "7")]
		public void Set(ref EndSessionCallbackInfo? other)
		{
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x4BC5B0", Offset = "0x4BABB0", VA = "0x1804BC5B0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x4BC600", Offset = "0x4BAC00", VA = "0x1804BC600", Slot = "5")]
		public void Get(out EndSessionCallbackInfo output)
		{
		}

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
