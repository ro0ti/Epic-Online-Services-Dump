using System;


namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004F3 RID: 1267
	[Token(Token = "0x20004F3")]
	internal struct UserLoginStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<UserLoginStatusChangedCallbackInfo>, ISettable<UserLoginStatusChangedCallbackInfo>, IDisposable
	{
		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600206F RID: 8303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700092F")]
		public object ClientData
		{
			[Token(Token = "0x600206E")]
			[Address(RVA = "0x551C80", Offset = "0x550280", VA = "0x180551C80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600206F")]
			[Address(RVA = "0x551EB0", Offset = "0x5504B0", VA = "0x180551EB0")]
			set
			{
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x00008BAC File Offset: 0x00006DAC
		[Token(Token = "0x17000930")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002070")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002072 RID: 8306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000931")]
		public Utf8String PlatformType
		{
			[Token(Token = "0x6002071")]
			[Address(RVA = "0x551D60", Offset = "0x550360", VA = "0x180551D60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002072")]
			[Address(RVA = "0x551F70", Offset = "0x550570", VA = "0x180551F70")]
			set
			{
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002074 RID: 8308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000932")]
		public Utf8String LocalPlatformUserId
		{
			[Token(Token = "0x6002073")]
			[Address(RVA = "0x551CF0", Offset = "0x5502F0", VA = "0x180551CF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002074")]
			[Address(RVA = "0x551F10", Offset = "0x550510", VA = "0x180551F10")]
			set
			{
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000933")]
		public EpicAccountId AccountId
		{
			[Token(Token = "0x6002075")]
			[Address(RVA = "0x551C00", Offset = "0x550200", VA = "0x180551C00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002076")]
			[Address(RVA = "0x551E50", Offset = "0x550450", VA = "0x180551E50")]
			set
			{
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000934")]
		public ProductUserId ProductUserId
		{
			[Token(Token = "0x6002077")]
			[Address(RVA = "0x551DD0", Offset = "0x5503D0", VA = "0x180551DD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002078")]
			[Address(RVA = "0x551FD0", Offset = "0x5505D0", VA = "0x180551FD0")]
			set
			{
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x00008BC4 File Offset: 0x00006DC4
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000935")]
		public LoginStatus PreviousLoginStatus
		{
			[Token(Token = "0x6002079")]
			[Address(RVA = "0x3D2E70", Offset = "0x3D1470", VA = "0x1803D2E70")]
			get
			{
				return LoginStatus.NotLoggedIn;
			}
			[Token(Token = "0x600207A")]
			[Address(RVA = "0x3D2EA0", Offset = "0x3D14A0", VA = "0x1803D2EA0")]
			set
			{
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x00008BDC File Offset: 0x00006DDC
		// (set) Token: 0x0600207C RID: 8316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000936")]
		public LoginStatus CurrentLoginStatus
		{
			[Token(Token = "0x600207B")]
			[Address(RVA = "0x3D2E90", Offset = "0x3D1490", VA = "0x1803D2E90")]
			get
			{
				return LoginStatus.NotLoggedIn;
			}
			[Token(Token = "0x600207C")]
			[Address(RVA = "0x3D2EC0", Offset = "0x3D14C0", VA = "0x1803D2EC0")]
			set
			{
			}
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600207D")]
		[Address(RVA = "0x551A70", Offset = "0x550070", VA = "0x180551A70", Slot = "6")]
		public void Set(ref UserLoginStatusChangedCallbackInfo other)
		{
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600207E")]
		[Address(RVA = "0x551830", Offset = "0x54FE30", VA = "0x180551830", Slot = "7")]
		public void Set(ref UserLoginStatusChangedCallbackInfo? other)
		{
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600207F")]
		[Address(RVA = "0x551790", Offset = "0x54FD90", VA = "0x180551790", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002080")]
		[Address(RVA = "0x551810", Offset = "0x54FE10", VA = "0x180551810", Slot = "5")]
		public void Get(out UserLoginStatusChangedCallbackInfo output)
		{
		}

		// Token: 0x04000E58 RID: 3672
		[Token(Token = "0x4000E58")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000E59 RID: 3673
		[Token(Token = "0x4000E59")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PlatformType;

		// Token: 0x04000E5A RID: 3674
		[Token(Token = "0x4000E5A")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalPlatformUserId;

		// Token: 0x04000E5B RID: 3675
		[Token(Token = "0x4000E5B")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_AccountId;

		// Token: 0x04000E5C RID: 3676
		[Token(Token = "0x4000E5C")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ProductUserId;

		// Token: 0x04000E5D RID: 3677
		[Token(Token = "0x4000E5D")]
		[FieldOffset(Offset = "0x28")]
		private LoginStatus m_PreviousLoginStatus;

		// Token: 0x04000E5E RID: 3678
		[Token(Token = "0x4000E5E")]
		[FieldOffset(Offset = "0x2C")]
		private LoginStatus m_CurrentLoginStatus;
	}
}
