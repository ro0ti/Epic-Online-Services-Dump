using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200061A RID: 1562
	[Token(Token = "0x200061A")]
	internal struct LoginStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LoginStatusChangedCallbackInfo>, ISettable<LoginStatusChangedCallbackInfo>, IDisposable
	{
		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002818 RID: 10264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BB2")]
		public object ClientData
		{
			[Token(Token = "0x6002817")]
			[Address(RVA = "0x55F3E0", Offset = "0x55D9E0", VA = "0x18055F3E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002818")]
			[Address(RVA = "0x55F620", Offset = "0x55DC20", VA = "0x18055F620")]
			set
			{
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x0000A2D4 File Offset: 0x000084D4
		[Token(Token = "0x17000BB3")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002819")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x0600281A RID: 10266 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600281B RID: 10267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BB4")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600281A")]
			[Address(RVA = "0x55F4C0", Offset = "0x55DAC0", VA = "0x18055F4C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600281B")]
			[Address(RVA = "0x55F680", Offset = "0x55DC80", VA = "0x18055F680")]
			set
			{
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x0600281C RID: 10268 RVA: 0x0000A2EC File Offset: 0x000084EC
		// (set) Token: 0x0600281D RID: 10269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BB5")]
		public LoginStatus PreviousStatus
		{
			[Token(Token = "0x600281C")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return LoginStatus.NotLoggedIn;
			}
			[Token(Token = "0x600281D")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x0600281E RID: 10270 RVA: 0x0000A304 File Offset: 0x00008504
		// (set) Token: 0x0600281F RID: 10271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BB6")]
		public LoginStatus CurrentStatus
		{
			[Token(Token = "0x600281E")]
			[Address(RVA = "0x3D5CE0", Offset = "0x3D42E0", VA = "0x1803D5CE0")]
			get
			{
				return LoginStatus.NotLoggedIn;
			}
			[Token(Token = "0x600281F")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			set
			{
			}
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002820")]
		[Address(RVA = "0x55F1D0", Offset = "0x55D7D0", VA = "0x18055F1D0", Slot = "6")]
		public void Set(ref LoginStatusChangedCallbackInfo other)
		{
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002821")]
		[Address(RVA = "0x55F2A0", Offset = "0x55D8A0", VA = "0x18055F2A0", Slot = "7")]
		public void Set(ref LoginStatusChangedCallbackInfo? other)
		{
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002822")]
		[Address(RVA = "0x55EEC0", Offset = "0x55D4C0", VA = "0x18055EEC0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002823")]
		[Address(RVA = "0x55EFA0", Offset = "0x55D5A0", VA = "0x18055EFA0", Slot = "5")]
		public void Get(out LoginStatusChangedCallbackInfo output)
		{
		}

		// Token: 0x04001196 RID: 4502
		[Token(Token = "0x4001196")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04001197 RID: 4503
		[Token(Token = "0x4001197")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001198 RID: 4504
		[Token(Token = "0x4001198")]
		[FieldOffset(Offset = "0x10")]
		private LoginStatus m_PreviousStatus;

		// Token: 0x04001199 RID: 4505
		[Token(Token = "0x4001199")]
		[FieldOffset(Offset = "0x14")]
		private LoginStatus m_CurrentStatus;
	}
}
