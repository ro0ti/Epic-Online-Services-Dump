using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005FA RID: 1530
	[Token(Token = "0x20005FA")]
	internal struct CreateDeviceIdCallbackInfoInternal : ICallbackInfoInternal, IGettable<CreateDeviceIdCallbackInfo>, ISettable<CreateDeviceIdCallbackInfo>, IDisposable
	{
		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002746 RID: 10054 RVA: 0x00009FEC File Offset: 0x000081EC
		// (set) Token: 0x06002747 RID: 10055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B63")]
		public Result ResultCode
		{
			[Token(Token = "0x6002746")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002747")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002748 RID: 10056 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002749 RID: 10057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B64")]
		public object ClientData
		{
			[Token(Token = "0x6002748")]
			[Address(RVA = "0x558640", Offset = "0x556C40", VA = "0x180558640")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002749")]
			[Address(RVA = "0x5586B0", Offset = "0x556CB0", VA = "0x1805586B0")]
			set
			{
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x0600274A RID: 10058 RVA: 0x0000A004 File Offset: 0x00008204
		[Token(Token = "0x17000B65")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600274A")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600274B")]
		[Address(RVA = "0x5585E0", Offset = "0x556BE0", VA = "0x1805585E0", Slot = "6")]
		public void Set(ref CreateDeviceIdCallbackInfo other)
		{
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600274C")]
		[Address(RVA = "0x558520", Offset = "0x556B20", VA = "0x180558520", Slot = "7")]
		public void Set(ref CreateDeviceIdCallbackInfo? other)
		{
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600274D")]
		[Address(RVA = "0x5584B0", Offset = "0x556AB0", VA = "0x1805584B0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600274E")]
		[Address(RVA = "0x558500", Offset = "0x556B00", VA = "0x180558500", Slot = "5")]
		public void Get(out CreateDeviceIdCallbackInfo output)
		{
		}

		// Token: 0x04001141 RID: 4417
		[Token(Token = "0x4001141")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04001142 RID: 4418
		[Token(Token = "0x4001142")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
