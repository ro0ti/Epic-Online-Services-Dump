using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000646 RID: 1606
	[Token(Token = "0x2000646")]
	internal struct VerifyIdTokenCallbackInfoInternal : ICallbackInfoInternal, IGettable<VerifyIdTokenCallbackInfo>, ISettable<VerifyIdTokenCallbackInfo>, IDisposable
	{
		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06002921 RID: 10529 RVA: 0x0000A52C File Offset: 0x0000872C
		// (set) Token: 0x06002922 RID: 10530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BF7")]
		public Result ResultCode
		{
			[Token(Token = "0x6002921")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002922")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06002923 RID: 10531 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002924 RID: 10532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BF8")]
		public object ClientData
		{
			[Token(Token = "0x6002923")]
			[Address(RVA = "0x56A370", Offset = "0x568970", VA = "0x18056A370")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002924")]
			[Address(RVA = "0x56A7C0", Offset = "0x568DC0", VA = "0x18056A7C0")]
			set
			{
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06002925 RID: 10533 RVA: 0x0000A544 File Offset: 0x00008744
		[Token(Token = "0x17000BF9")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002925")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06002926 RID: 10534 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002927 RID: 10535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BFA")]
		public ProductUserId ProductUserId
		{
			[Token(Token = "0x6002926")]
			[Address(RVA = "0x56A670", Offset = "0x568C70", VA = "0x18056A670")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002927")]
			[Address(RVA = "0x56AA60", Offset = "0x569060", VA = "0x18056AA60")]
			set
			{
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06002928 RID: 10536 RVA: 0x0000A55C File Offset: 0x0000875C
		// (set) Token: 0x06002929 RID: 10537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BFB")]
		public bool IsAccountInfoPresent
		{
			[Token(Token = "0x6002928")]
			[Address(RVA = "0x56A530", Offset = "0x568B30", VA = "0x18056A530")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002929")]
			[Address(RVA = "0x56A940", Offset = "0x568F40", VA = "0x18056A940")]
			set
			{
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x0600292A RID: 10538 RVA: 0x0000A574 File Offset: 0x00008774
		// (set) Token: 0x0600292B RID: 10539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BFC")]
		public ExternalAccountType AccountIdType
		{
			[Token(Token = "0x600292A")]
			[Address(RVA = "0x4A5AF0", Offset = "0x4A40F0", VA = "0x1804A5AF0")]
			get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x600292B")]
			[Address(RVA = "0x4A5CB0", Offset = "0x4A42B0", VA = "0x1804A5CB0")]
			set
			{
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600292D RID: 10541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BFD")]
		public Utf8String AccountId
		{
			[Token(Token = "0x600292C")]
			[Address(RVA = "0x56A300", Offset = "0x568900", VA = "0x18056A300")]
			get
			{
				return null;
			}
			[Token(Token = "0x600292D")]
			[Address(RVA = "0x56A760", Offset = "0x568D60", VA = "0x18056A760")]
			set
			{
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600292F RID: 10543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BFE")]
		public Utf8String Platform
		{
			[Token(Token = "0x600292E")]
			[Address(RVA = "0x56A590", Offset = "0x568B90", VA = "0x18056A590")]
			get
			{
				return null;
			}
			[Token(Token = "0x600292F")]
			[Address(RVA = "0x56A9A0", Offset = "0x568FA0", VA = "0x18056A9A0")]
			set
			{
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002931 RID: 10545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BFF")]
		public Utf8String DeviceType
		{
			[Token(Token = "0x6002930")]
			[Address(RVA = "0x56A4C0", Offset = "0x568AC0", VA = "0x18056A4C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002931")]
			[Address(RVA = "0x56A8E0", Offset = "0x568EE0", VA = "0x18056A8E0")]
			set
			{
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06002932 RID: 10546 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002933 RID: 10547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C00")]
		public Utf8String ClientId
		{
			[Token(Token = "0x6002932")]
			[Address(RVA = "0x56A3E0", Offset = "0x5689E0", VA = "0x18056A3E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002933")]
			[Address(RVA = "0x56A820", Offset = "0x568E20", VA = "0x18056A820")]
			set
			{
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06002934 RID: 10548 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002935 RID: 10549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C01")]
		public Utf8String ProductId
		{
			[Token(Token = "0x6002934")]
			[Address(RVA = "0x56A600", Offset = "0x568C00", VA = "0x18056A600")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002935")]
			[Address(RVA = "0x56AA00", Offset = "0x569000", VA = "0x18056AA00")]
			set
			{
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06002936 RID: 10550 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002937 RID: 10551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C02")]
		public Utf8String SandboxId
		{
			[Token(Token = "0x6002936")]
			[Address(RVA = "0x56A6F0", Offset = "0x568CF0", VA = "0x18056A6F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002937")]
			[Address(RVA = "0x56AAC0", Offset = "0x5690C0", VA = "0x18056AAC0")]
			set
			{
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06002938 RID: 10552 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002939 RID: 10553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C03")]
		public Utf8String DeploymentId
		{
			[Token(Token = "0x6002938")]
			[Address(RVA = "0x56A450", Offset = "0x568A50", VA = "0x18056A450")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002939")]
			[Address(RVA = "0x56A880", Offset = "0x568E80", VA = "0x18056A880")]
			set
			{
			}
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600293A")]
		[Address(RVA = "0x56A010", Offset = "0x568610", VA = "0x18056A010", Slot = "6")]
		public void Set(ref VerifyIdTokenCallbackInfo other)
		{
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600293B")]
		[Address(RVA = "0x569C20", Offset = "0x568220", VA = "0x180569C20", Slot = "7")]
		public void Set(ref VerifyIdTokenCallbackInfo? other)
		{
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600293C")]
		[Address(RVA = "0x569B40", Offset = "0x568140", VA = "0x180569B40", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600293D")]
		[Address(RVA = "0x569BF0", Offset = "0x5681F0", VA = "0x180569BF0", Slot = "5")]
		public void Get(out VerifyIdTokenCallbackInfo output)
		{
		}

		// Token: 0x040011DD RID: 4573
		[Token(Token = "0x40011DD")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040011DE RID: 4574
		[Token(Token = "0x40011DE")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040011DF RID: 4575
		[Token(Token = "0x40011DF")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ProductUserId;

		// Token: 0x040011E0 RID: 4576
		[Token(Token = "0x40011E0")]
		[FieldOffset(Offset = "0x18")]
		private int m_IsAccountInfoPresent;

		// Token: 0x040011E1 RID: 4577
		[Token(Token = "0x40011E1")]
		[FieldOffset(Offset = "0x1C")]
		private ExternalAccountType m_AccountIdType;

		// Token: 0x040011E2 RID: 4578
		[Token(Token = "0x40011E2")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_AccountId;

		// Token: 0x040011E3 RID: 4579
		[Token(Token = "0x40011E3")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_Platform;

		// Token: 0x040011E4 RID: 4580
		[Token(Token = "0x40011E4")]
		[FieldOffset(Offset = "0x30")]
		private IntPtr m_DeviceType;

		// Token: 0x040011E5 RID: 4581
		[Token(Token = "0x40011E5")]
		[FieldOffset(Offset = "0x38")]
		private IntPtr m_ClientId;

		// Token: 0x040011E6 RID: 4582
		[Token(Token = "0x40011E6")]
		[FieldOffset(Offset = "0x40")]
		private IntPtr m_ProductId;

		// Token: 0x040011E7 RID: 4583
		[Token(Token = "0x40011E7")]
		[FieldOffset(Offset = "0x48")]
		private IntPtr m_SandboxId;

		// Token: 0x040011E8 RID: 4584
		[Token(Token = "0x40011E8")]
		[FieldOffset(Offset = "0x50")]
		private IntPtr m_DeploymentId;
	}
}
