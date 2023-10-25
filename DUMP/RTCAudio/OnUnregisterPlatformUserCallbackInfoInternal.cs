using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000201 RID: 513
	[Token(Token = "0x2000201")]
	internal struct OnUnregisterPlatformUserCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnUnregisterPlatformUserCallbackInfo>, ISettable<OnUnregisterPlatformUserCallbackInfo>, IDisposable
	{
		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x00004AB4 File Offset: 0x00002CB4
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700035D")]
		public Result ResultCode
		{
			[Token(Token = "0x6000E23")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000E24")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700035E")]
		public object ClientData
		{
			[Token(Token = "0x6000E25")]
			[Address(RVA = "0x4DCDF0", Offset = "0x4DB3F0", VA = "0x1804DCDF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E26")]
			[Address(RVA = "0x4DCED0", Offset = "0x4DB4D0", VA = "0x1804DCED0")]
			set
			{
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x00004ACC File Offset: 0x00002CCC
		[Token(Token = "0x1700035F")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000E27")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000360")]
		public Utf8String PlatformUserId
		{
			[Token(Token = "0x6000E28")]
			[Address(RVA = "0x4DCE60", Offset = "0x4DB460", VA = "0x1804DCE60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E29")]
			[Address(RVA = "0x4DCF30", Offset = "0x4DB530", VA = "0x1804DCF30")]
			set
			{
			}
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E2A")]
		[Address(RVA = "0x4DCD30", Offset = "0x4DB330", VA = "0x1804DCD30", Slot = "6")]
		public void Set(ref OnUnregisterPlatformUserCallbackInfo other)
		{
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E2B")]
		[Address(RVA = "0x4DCC10", Offset = "0x4DB210", VA = "0x1804DCC10", Slot = "7")]
		public void Set(ref OnUnregisterPlatformUserCallbackInfo? other)
		{
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E2C")]
		[Address(RVA = "0x4DCB90", Offset = "0x4DB190", VA = "0x1804DCB90", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E2D")]
		[Address(RVA = "0x4DCBF0", Offset = "0x4DB1F0", VA = "0x1804DCBF0", Slot = "5")]
		public void Get(out OnUnregisterPlatformUserCallbackInfo output)
		{
		}

		// Token: 0x04000646 RID: 1606
		[Token(Token = "0x4000646")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x4000647")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_PlatformUserId;
	}
}
