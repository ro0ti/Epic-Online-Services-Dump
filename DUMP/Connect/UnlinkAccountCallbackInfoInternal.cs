using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000640 RID: 1600
	[Token(Token = "0x2000640")]
	internal struct UnlinkAccountCallbackInfoInternal : ICallbackInfoInternal, IGettable<UnlinkAccountCallbackInfo>, ISettable<UnlinkAccountCallbackInfo>, IDisposable
	{
		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x0000A49C File Offset: 0x0000869C
		// (set) Token: 0x060028EA RID: 10474 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE1")]
		public Result ResultCode
		{
			[Token(Token = "0x60028E9")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60028EA")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028EC RID: 10476 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE2")]
		public object ClientData
		{
			[Token(Token = "0x60028EB")]
			[Address(RVA = "0x569200", Offset = "0x567800", VA = "0x180569200")]
			get
			{
				return null;
			}
			[Token(Token = "0x60028EC")]
			[Address(RVA = "0x5692F0", Offset = "0x5678F0", VA = "0x1805692F0")]
			set
			{
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060028ED RID: 10477 RVA: 0x0000A4B4 File Offset: 0x000086B4
		[Token(Token = "0x17000BE3")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60028ED")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x060028EE RID: 10478 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028EF RID: 10479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE4")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60028EE")]
			[Address(RVA = "0x569270", Offset = "0x567870", VA = "0x180569270")]
			get
			{
				return null;
			}
			[Token(Token = "0x60028EF")]
			[Address(RVA = "0x569350", Offset = "0x567950", VA = "0x180569350")]
			set
			{
			}
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028F0")]
		[Address(RVA = "0x569140", Offset = "0x567740", VA = "0x180569140", Slot = "6")]
		public void Set(ref UnlinkAccountCallbackInfo other)
		{
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028F1")]
		[Address(RVA = "0x569020", Offset = "0x567620", VA = "0x180569020", Slot = "7")]
		public void Set(ref UnlinkAccountCallbackInfo? other)
		{
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028F2")]
		[Address(RVA = "0x568FA0", Offset = "0x5675A0", VA = "0x180568FA0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028F3")]
		[Address(RVA = "0x569000", Offset = "0x567600", VA = "0x180569000", Slot = "5")]
		public void Get(out UnlinkAccountCallbackInfo output)
		{
		}

		// Token: 0x040011C6 RID: 4550
		[Token(Token = "0x40011C6")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040011C7 RID: 4551
		[Token(Token = "0x40011C7")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040011C8 RID: 4552
		[Token(Token = "0x40011C8")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
