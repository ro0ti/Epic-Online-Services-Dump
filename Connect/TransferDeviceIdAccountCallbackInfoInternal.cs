using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200063C RID: 1596
	[Token(Token = "0x200063C")]
	internal struct TransferDeviceIdAccountCallbackInfoInternal : ICallbackInfoInternal, IGettable<TransferDeviceIdAccountCallbackInfo>, ISettable<TransferDeviceIdAccountCallbackInfo>, IDisposable
	{
		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x0000A43C File Offset: 0x0000863C
		// (set) Token: 0x060028CB RID: 10443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BD4")]
		public Result ResultCode
		{
			[Token(Token = "0x60028CA")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60028CB")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x060028CC RID: 10444 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028CD RID: 10445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BD5")]
		public object ClientData
		{
			[Token(Token = "0x60028CC")]
			[Address(RVA = "0x568900", Offset = "0x566F00", VA = "0x180568900")]
			get
			{
				return null;
			}
			[Token(Token = "0x60028CD")]
			[Address(RVA = "0x5689F0", Offset = "0x566FF0", VA = "0x1805689F0")]
			set
			{
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x060028CE RID: 10446 RVA: 0x0000A454 File Offset: 0x00008654
		[Token(Token = "0x17000BD6")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60028CE")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x060028CF RID: 10447 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028D0 RID: 10448 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BD7")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60028CF")]
			[Address(RVA = "0x568970", Offset = "0x566F70", VA = "0x180568970")]
			get
			{
				return null;
			}
			[Token(Token = "0x60028D0")]
			[Address(RVA = "0x568A50", Offset = "0x567050", VA = "0x180568A50")]
			set
			{
			}
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028D1")]
		[Address(RVA = "0x568720", Offset = "0x566D20", VA = "0x180568720", Slot = "6")]
		public void Set(ref TransferDeviceIdAccountCallbackInfo other)
		{
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028D2")]
		[Address(RVA = "0x5687E0", Offset = "0x566DE0", VA = "0x1805687E0", Slot = "7")]
		public void Set(ref TransferDeviceIdAccountCallbackInfo? other)
		{
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028D3")]
		[Address(RVA = "0x5686A0", Offset = "0x566CA0", VA = "0x1805686A0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028D4")]
		[Address(RVA = "0x568700", Offset = "0x566D00", VA = "0x180568700", Slot = "5")]
		public void Get(out TransferDeviceIdAccountCallbackInfo output)
		{
		}

		// Token: 0x040011B9 RID: 4537
		[Token(Token = "0x40011B9")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040011BA RID: 4538
		[Token(Token = "0x40011BA")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040011BB RID: 4539
		[Token(Token = "0x40011BB")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
