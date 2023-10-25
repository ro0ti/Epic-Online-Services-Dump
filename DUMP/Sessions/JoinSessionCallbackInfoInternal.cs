using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	internal struct JoinSessionCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinSessionCallbackInfo>, ISettable<JoinSessionCallbackInfo>, IDisposable
	{
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x000039D4 File Offset: 0x00001BD4
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001ED")]
		public Result ResultCode
		{
			[Token(Token = "0x6000902")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000903")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001EE")]
		public object ClientData
		{
			[Token(Token = "0x6000904")]
			[Address(RVA = "0x4BE6B0", Offset = "0x4BCCB0", VA = "0x1804BE6B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000905")]
			[Address(RVA = "0x4BE720", Offset = "0x4BCD20", VA = "0x1804BE720")]
			set
			{
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x000039EC File Offset: 0x00001BEC
		[Token(Token = "0x170001EF")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000906")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x4BE590", Offset = "0x4BCB90", VA = "0x1804BE590", Slot = "6")]
		public void Set(ref JoinSessionCallbackInfo other)
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x4BE5F0", Offset = "0x4BCBF0", VA = "0x1804BE5F0", Slot = "7")]
		public void Set(ref JoinSessionCallbackInfo? other)
		{
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x4BE520", Offset = "0x4BCB20", VA = "0x1804BE520", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x4BE570", Offset = "0x4BCB70", VA = "0x1804BE570", Slot = "5")]
		public void Get(out JoinSessionCallbackInfo output)
		{
		}

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
