using System;


namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006DD RID: 1757
	[Token(Token = "0x20006DD")]
	internal struct OnClientAuthStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnClientAuthStatusChangedCallbackInfo>, ISettable<OnClientAuthStatusChangedCallbackInfo>, IDisposable
	{
		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06002D14 RID: 11540 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002D15 RID: 11541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D65")]
		public object ClientData
		{
			[Token(Token = "0x6002D14")]
			[Address(RVA = "0x577BA0", Offset = "0x5761A0", VA = "0x180577BA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D15")]
			[Address(RVA = "0x577C10", Offset = "0x576210", VA = "0x180577C10")]
			set
			{
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06002D16 RID: 11542 RVA: 0x0000B954 File Offset: 0x00009B54
		[Token(Token = "0x17000D66")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002D16")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x0000B96C File Offset: 0x00009B6C
		// (set) Token: 0x06002D18 RID: 11544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D67")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002D17")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002D18")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06002D19 RID: 11545 RVA: 0x0000B984 File Offset: 0x00009B84
		// (set) Token: 0x06002D1A RID: 11546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D68")]
		public AntiCheatCommonClientAuthStatus ClientAuthStatus
		{
			[Token(Token = "0x6002D19")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return AntiCheatCommonClientAuthStatus.Invalid;
			}
			[Token(Token = "0x6002D1A")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D1B")]
		[Address(RVA = "0x577B20", Offset = "0x576120", VA = "0x180577B20", Slot = "6")]
		public void Set(ref OnClientAuthStatusChangedCallbackInfo other)
		{
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D1C")]
		[Address(RVA = "0x577A40", Offset = "0x576040", VA = "0x180577A40", Slot = "7")]
		public void Set(ref OnClientAuthStatusChangedCallbackInfo? other)
		{
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D1D")]
		[Address(RVA = "0x5779C0", Offset = "0x575FC0", VA = "0x1805779C0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D1E")]
		[Address(RVA = "0x577A20", Offset = "0x576020", VA = "0x180577A20", Slot = "5")]
		public void Get(out OnClientAuthStatusChangedCallbackInfo output)
		{
		}

		// Token: 0x04001406 RID: 5126
		[Token(Token = "0x4001406")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04001407 RID: 5127
		[Token(Token = "0x4001407")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientHandle;

		// Token: 0x04001408 RID: 5128
		[Token(Token = "0x4001408")]
		[FieldOffset(Offset = "0x10")]
		private AntiCheatCommonClientAuthStatus m_ClientAuthStatus;
	}
}
