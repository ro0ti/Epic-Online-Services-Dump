using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000183 RID: 387
	[Token(Token = "0x2000183")]
	internal struct SessionSearchFindCallbackInfoInternal : ICallbackInfoInternal, IGettable<SessionSearchFindCallbackInfo>, ISettable<SessionSearchFindCallbackInfo>, IDisposable
	{
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0000413C File Offset: 0x0000233C
		// (set) Token: 0x06000B47 RID: 2887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700028F")]
		public Result ResultCode
		{
			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000B49 RID: 2889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000290")]
		public object ClientData
		{
			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x4CC0A0", Offset = "0x4CA6A0", VA = "0x1804CC0A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B49")]
			[Address(RVA = "0x4CC110", Offset = "0x4CA710", VA = "0x1804CC110")]
			set
			{
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x00004154 File Offset: 0x00002354
		[Token(Token = "0x17000291")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x4CBF80", Offset = "0x4CA580", VA = "0x1804CBF80", Slot = "6")]
		public void Set(ref SessionSearchFindCallbackInfo other)
		{
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x4CBFE0", Offset = "0x4CA5E0", VA = "0x1804CBFE0", Slot = "7")]
		public void Set(ref SessionSearchFindCallbackInfo? other)
		{
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x4CBF10", Offset = "0x4CA510", VA = "0x1804CBF10", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x4CBF60", Offset = "0x4CA560", VA = "0x1804CBF60", Slot = "5")]
		public void Get(out SessionSearchFindCallbackInfo output)
		{
		}

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
