using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000604 RID: 1540
	[Token(Token = "0x2000604")]
	internal struct DeleteDeviceIdCallbackInfoInternal : ICallbackInfoInternal, IGettable<DeleteDeviceIdCallbackInfo>, ISettable<DeleteDeviceIdCallbackInfo>, IDisposable
	{
		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x0000A0DC File Offset: 0x000082DC
		// (set) Token: 0x06002782 RID: 10114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B77")]
		public Result ResultCode
		{
			[Token(Token = "0x6002781")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002782")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06002783 RID: 10115 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002784 RID: 10116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B78")]
		public object ClientData
		{
			[Token(Token = "0x6002783")]
			[Address(RVA = "0x559A70", Offset = "0x558070", VA = "0x180559A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002784")]
			[Address(RVA = "0x559AE0", Offset = "0x5580E0", VA = "0x180559AE0")]
			set
			{
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x0000A0F4 File Offset: 0x000082F4
		[Token(Token = "0x17000B79")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002785")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002786")]
		[Address(RVA = "0x559A10", Offset = "0x558010", VA = "0x180559A10", Slot = "6")]
		public void Set(ref DeleteDeviceIdCallbackInfo other)
		{
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002787")]
		[Address(RVA = "0x559950", Offset = "0x557F50", VA = "0x180559950", Slot = "7")]
		public void Set(ref DeleteDeviceIdCallbackInfo? other)
		{
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002788")]
		[Address(RVA = "0x5598E0", Offset = "0x557EE0", VA = "0x1805598E0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002789")]
		[Address(RVA = "0x559930", Offset = "0x557F30", VA = "0x180559930", Slot = "5")]
		public void Get(out DeleteDeviceIdCallbackInfo output)
		{
		}

		// Token: 0x04001156 RID: 4438
		[Token(Token = "0x4001156")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04001157 RID: 4439
		[Token(Token = "0x4001157")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
