using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000616 RID: 1558
	[Token(Token = "0x2000616")]
	internal struct LoginCallbackInfoInternal : ICallbackInfoInternal, IGettable<LoginCallbackInfo>, ISettable<LoginCallbackInfo>, IDisposable
	{
		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x060027F7 RID: 10231 RVA: 0x0000A22C File Offset: 0x0000842C
		// (set) Token: 0x060027F8 RID: 10232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BA5")]
		public Result ResultCode
		{
			[Token(Token = "0x60027F7")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60027F8")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027FA RID: 10234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BA6")]
		public object ClientData
		{
			[Token(Token = "0x60027F9")]
			[Address(RVA = "0x55DD30", Offset = "0x55C330", VA = "0x18055DD30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027FA")]
			[Address(RVA = "0x55E1E0", Offset = "0x55C7E0", VA = "0x18055E1E0")]
			set
			{
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x060027FB RID: 10235 RVA: 0x0000A244 File Offset: 0x00008444
		[Token(Token = "0x17000BA7")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60027FB")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x060027FC RID: 10236 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027FD RID: 10237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BA8")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60027FC")]
			[Address(RVA = "0x55DF90", Offset = "0x55C590", VA = "0x18055DF90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027FD")]
			[Address(RVA = "0x55E360", Offset = "0x55C960", VA = "0x18055E360")]
			set
			{
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027FF RID: 10239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BA9")]
		public ContinuanceToken ContinuanceToken
		{
			[Token(Token = "0x60027FE")]
			[Address(RVA = "0x55DE90", Offset = "0x55C490", VA = "0x18055DE90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027FF")]
			[Address(RVA = "0x55E2A0", Offset = "0x55C8A0", VA = "0x18055E2A0")]
			set
			{
			}
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002800")]
		[Address(RVA = "0x55D820", Offset = "0x55BE20", VA = "0x18055D820", Slot = "6")]
		public void Set(ref LoginCallbackInfo other)
		{
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002801")]
		[Address(RVA = "0x55DB30", Offset = "0x55C130", VA = "0x18055DB30", Slot = "7")]
		public void Set(ref LoginCallbackInfo? other)
		{
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002802")]
		[Address(RVA = "0x55D480", Offset = "0x55BA80", VA = "0x18055D480", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002803")]
		[Address(RVA = "0x55D4F0", Offset = "0x55BAF0", VA = "0x18055D4F0", Slot = "5")]
		public void Get(out LoginCallbackInfo output)
		{
		}

		// Token: 0x04001189 RID: 4489
		[Token(Token = "0x4001189")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400118A RID: 4490
		[Token(Token = "0x400118A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x0400118B RID: 4491
		[Token(Token = "0x400118B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400118C RID: 4492
		[Token(Token = "0x400118C")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ContinuanceToken;
	}
}
