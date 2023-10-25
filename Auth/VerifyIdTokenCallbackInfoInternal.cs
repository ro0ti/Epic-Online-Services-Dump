using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000686 RID: 1670
	[Token(Token = "0x2000686")]
	internal struct VerifyIdTokenCallbackInfoInternal : ICallbackInfoInternal, IGettable<VerifyIdTokenCallbackInfo>, ISettable<VerifyIdTokenCallbackInfo>, IDisposable
	{
		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x0000AB5C File Offset: 0x00008D5C
		// (set) Token: 0x06002AF5 RID: 10997 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C8D")]
		public Result ResultCode
		{
			[Token(Token = "0x6002AF4")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002AF5")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06002AF6 RID: 10998 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AF7 RID: 10999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C8E")]
		public object ClientData
		{
			[Token(Token = "0x6002AF6")]
			[Address(RVA = "0x5810B0", Offset = "0x57F6B0", VA = "0x1805810B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AF7")]
			[Address(RVA = "0x581560", Offset = "0x57FB60", VA = "0x180581560")]
			set
			{
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x0000AB74 File Offset: 0x00008D74
		[Token(Token = "0x17000C8F")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002AF8")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06002AF9 RID: 11001 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AFA RID: 11002 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C90")]
		public Utf8String ApplicationId
		{
			[Token(Token = "0x6002AF9")]
			[Address(RVA = "0x581040", Offset = "0x57F640", VA = "0x180581040")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AFA")]
			[Address(RVA = "0x581500", Offset = "0x57FB00", VA = "0x180581500")]
			set
			{
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06002AFB RID: 11003 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AFC RID: 11004 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C91")]
		public Utf8String ClientId
		{
			[Token(Token = "0x6002AFB")]
			[Address(RVA = "0x581120", Offset = "0x57F720", VA = "0x180581120")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AFC")]
			[Address(RVA = "0x5815C0", Offset = "0x57FBC0", VA = "0x1805815C0")]
			set
			{
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AFE RID: 11006 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C92")]
		public Utf8String ProductId
		{
			[Token(Token = "0x6002AFD")]
			[Address(RVA = "0x581420", Offset = "0x57FA20", VA = "0x180581420")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AFE")]
			[Address(RVA = "0x581860", Offset = "0x57FE60", VA = "0x180581860")]
			set
			{
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002B00 RID: 11008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C93")]
		public Utf8String SandboxId
		{
			[Token(Token = "0x6002AFF")]
			[Address(RVA = "0x581490", Offset = "0x57FA90", VA = "0x180581490")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B00")]
			[Address(RVA = "0x5818C0", Offset = "0x57FEC0", VA = "0x1805818C0")]
			set
			{
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002B02 RID: 11010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C94")]
		public Utf8String DeploymentId
		{
			[Token(Token = "0x6002B01")]
			[Address(RVA = "0x581190", Offset = "0x57F790", VA = "0x180581190")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B02")]
			[Address(RVA = "0x581620", Offset = "0x57FC20", VA = "0x180581620")]
			set
			{
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06002B03 RID: 11011 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002B04 RID: 11012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C95")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x6002B03")]
			[Address(RVA = "0x581200", Offset = "0x57F800", VA = "0x180581200")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B04")]
			[Address(RVA = "0x581680", Offset = "0x57FC80", VA = "0x180581680")]
			set
			{
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x0000AB8C File Offset: 0x00008D8C
		// (set) Token: 0x06002B06 RID: 11014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C96")]
		public bool IsExternalAccountInfoPresent
		{
			[Token(Token = "0x6002B05")]
			[Address(RVA = "0x581350", Offset = "0x57F950", VA = "0x180581350")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002B06")]
			[Address(RVA = "0x5817A0", Offset = "0x57FDA0", VA = "0x1805817A0")]
			set
			{
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06002B07 RID: 11015 RVA: 0x0000ABA4 File Offset: 0x00008DA4
		// (set) Token: 0x06002B08 RID: 11016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C97")]
		public ExternalAccountType ExternalAccountIdType
		{
			[Token(Token = "0x6002B07")]
			[Address(RVA = "0x53BBD0", Offset = "0x53A1D0", VA = "0x18053BBD0")]
			get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x6002B08")]
			[Address(RVA = "0x53BF60", Offset = "0x53A560", VA = "0x18053BF60")]
			set
			{
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002B0A RID: 11018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C98")]
		public Utf8String ExternalAccountId
		{
			[Token(Token = "0x6002B09")]
			[Address(RVA = "0x5812E0", Offset = "0x57F8E0", VA = "0x1805812E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B0A")]
			[Address(RVA = "0x581740", Offset = "0x57FD40", VA = "0x180581740")]
			set
			{
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002B0C RID: 11020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C99")]
		public Utf8String ExternalAccountDisplayName
		{
			[Token(Token = "0x6002B0B")]
			[Address(RVA = "0x581270", Offset = "0x57F870", VA = "0x180581270")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B0C")]
			[Address(RVA = "0x5816E0", Offset = "0x57FCE0", VA = "0x1805816E0")]
			set
			{
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002B0E RID: 11022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C9A")]
		public Utf8String Platform
		{
			[Token(Token = "0x6002B0D")]
			[Address(RVA = "0x5813B0", Offset = "0x57F9B0", VA = "0x1805813B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B0E")]
			[Address(RVA = "0x581800", Offset = "0x57FE00", VA = "0x180581800")]
			set
			{
			}
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B0F")]
		[Address(RVA = "0x5808D0", Offset = "0x57EED0", VA = "0x1805808D0", Slot = "6")]
		public void Set(ref VerifyIdTokenCallbackInfo other)
		{
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B10")]
		[Address(RVA = "0x580C00", Offset = "0x57F200", VA = "0x180580C00", Slot = "7")]
		public void Set(ref VerifyIdTokenCallbackInfo? other)
		{
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B11")]
		[Address(RVA = "0x5807E0", Offset = "0x57EDE0", VA = "0x1805807E0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B12")]
		[Address(RVA = "0x5808A0", Offset = "0x57EEA0", VA = "0x1805808A0", Slot = "5")]
		public void Get(out VerifyIdTokenCallbackInfo output)
		{
		}

		// Token: 0x040012A4 RID: 4772
		[Token(Token = "0x40012A4")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040012A5 RID: 4773
		[Token(Token = "0x40012A5")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040012A6 RID: 4774
		[Token(Token = "0x40012A6")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ApplicationId;

		// Token: 0x040012A7 RID: 4775
		[Token(Token = "0x40012A7")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ClientId;

		// Token: 0x040012A8 RID: 4776
		[Token(Token = "0x40012A8")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ProductId;

		// Token: 0x040012A9 RID: 4777
		[Token(Token = "0x40012A9")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_SandboxId;

		// Token: 0x040012AA RID: 4778
		[Token(Token = "0x40012AA")]
		[FieldOffset(Offset = "0x30")]
		private IntPtr m_DeploymentId;

		// Token: 0x040012AB RID: 4779
		[Token(Token = "0x40012AB")]
		[FieldOffset(Offset = "0x38")]
		private IntPtr m_DisplayName;

		// Token: 0x040012AC RID: 4780
		[Token(Token = "0x40012AC")]
		[FieldOffset(Offset = "0x40")]
		private int m_IsExternalAccountInfoPresent;

		// Token: 0x040012AD RID: 4781
		[Token(Token = "0x40012AD")]
		[FieldOffset(Offset = "0x44")]
		private ExternalAccountType m_ExternalAccountIdType;

		// Token: 0x040012AE RID: 4782
		[Token(Token = "0x40012AE")]
		[FieldOffset(Offset = "0x48")]
		private IntPtr m_ExternalAccountId;

		// Token: 0x040012AF RID: 4783
		[Token(Token = "0x40012AF")]
		[FieldOffset(Offset = "0x50")]
		private IntPtr m_ExternalAccountDisplayName;

		// Token: 0x040012B0 RID: 4784
		[Token(Token = "0x40012B0")]
		[FieldOffset(Offset = "0x58")]
		private IntPtr m_Platform;
	}
}
