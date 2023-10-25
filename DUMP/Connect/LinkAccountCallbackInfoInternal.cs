using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000612 RID: 1554
	[Token(Token = "0x2000612")]
	internal struct LinkAccountCallbackInfoInternal : ICallbackInfoInternal, IGettable<LinkAccountCallbackInfo>, ISettable<LinkAccountCallbackInfo>, IDisposable
	{
		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060027D9 RID: 10201 RVA: 0x0000A1CC File Offset: 0x000083CC
		// (set) Token: 0x060027DA RID: 10202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B99")]
		public Result ResultCode
		{
			[Token(Token = "0x60027D9")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60027DA")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027DC RID: 10204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B9A")]
		public object ClientData
		{
			[Token(Token = "0x60027DB")]
			[Address(RVA = "0x55C610", Offset = "0x55AC10", VA = "0x18055C610")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027DC")]
			[Address(RVA = "0x55C950", Offset = "0x55AF50", VA = "0x18055C950")]
			set
			{
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x0000A1E4 File Offset: 0x000083E4
		[Token(Token = "0x17000B9B")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60027DD")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060027DE RID: 10206 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027DF RID: 10207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B9C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60027DE")]
			[Address(RVA = "0x55C770", Offset = "0x55AD70", VA = "0x18055C770")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027DF")]
			[Address(RVA = "0x55CA10", Offset = "0x55B010", VA = "0x18055CA10")]
			set
			{
			}
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027E0")]
		[Address(RVA = "0x55C0B0", Offset = "0x55A6B0", VA = "0x18055C0B0", Slot = "6")]
		public void Set(ref LinkAccountCallbackInfo other)
		{
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027E1")]
		[Address(RVA = "0x55C4F0", Offset = "0x55AAF0", VA = "0x18055C4F0", Slot = "7")]
		public void Set(ref LinkAccountCallbackInfo? other)
		{
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027E2")]
		[Address(RVA = "0x55BF80", Offset = "0x55A580", VA = "0x18055BF80", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027E3")]
		[Address(RVA = "0x55C090", Offset = "0x55A690", VA = "0x18055C090", Slot = "5")]
		public void Get(out LinkAccountCallbackInfo output)
		{
		}

		// Token: 0x0400117D RID: 4477
		[Token(Token = "0x400117D")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400117E RID: 4478
		[Token(Token = "0x400117E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x0400117F RID: 4479
		[Token(Token = "0x400117F")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
