using System;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200068E RID: 1678
	[Token(Token = "0x200068E")]
	internal struct IOSCredentialsInternal : IGettable<IOSCredentials>, ISettable<IOSCredentials>, IDisposable
	{
		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06002B39 RID: 11065 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002B3A RID: 11066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CA9")]
		public Utf8String Id
		{
			[Token(Token = "0x6002B39")]
			[Address(RVA = "0x570830", Offset = "0x56EE30", VA = "0x180570830")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B3A")]
			[Address(RVA = "0x570990", Offset = "0x56EF90", VA = "0x180570990")]
			set
			{
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002B3C RID: 11068 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CAA")]
		public Utf8String Token
		{
			[Token(Token = "0x6002B3B")]
			[Address(RVA = "0x570920", Offset = "0x56EF20", VA = "0x180570920")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B3C")]
			[Address(RVA = "0x570A60", Offset = "0x56F060", VA = "0x180570A60")]
			set
			{
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x0000AC94 File Offset: 0x00008E94
		// (set) Token: 0x06002B3E RID: 11070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CAB")]
		public LoginCredentialType Type
		{
			[Token(Token = "0x6002B3D")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return LoginCredentialType.Password;
			}
			[Token(Token = "0x6002B3E")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06002B3F RID: 11071 RVA: 0x0000ACAC File Offset: 0x00008EAC
		// (set) Token: 0x06002B40 RID: 11072 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CAC")]
		public IOSCredentialsSystemAuthCredentialsOptions? SystemAuthCredentialsOptions
		{
			[Token(Token = "0x6002B3F")]
			[Address(RVA = "0x5708A0", Offset = "0x56EEA0", VA = "0x1805708A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B40")]
			[Address(RVA = "0x5709F0", Offset = "0x56EFF0", VA = "0x1805709F0")]
			set
			{
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06002B41 RID: 11073 RVA: 0x0000ACC4 File Offset: 0x00008EC4
		// (set) Token: 0x06002B42 RID: 11074 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CAD")]
		public ExternalCredentialType ExternalType
		{
			[Token(Token = "0x6002B41")]
			[Address(RVA = "0x3D2E70", Offset = "0x3D1470", VA = "0x1803D2E70")]
			get
			{
				return ExternalCredentialType.Epic;
			}
			[Token(Token = "0x6002B42")]
			[Address(RVA = "0x3D2EA0", Offset = "0x3D14A0", VA = "0x1803D2EA0")]
			set
			{
			}
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B43")]
		[Address(RVA = "0x570550", Offset = "0x56EB50", VA = "0x180570550", Slot = "5")]
		public void Set(ref IOSCredentials other)
		{
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B44")]
		[Address(RVA = "0x570680", Offset = "0x56EC80", VA = "0x180570680", Slot = "6")]
		public void Set(ref IOSCredentials? other)
		{
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B45")]
		[Address(RVA = "0x5704C0", Offset = "0x56EAC0", VA = "0x1805704C0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B46")]
		[Address(RVA = "0x570530", Offset = "0x56EB30", VA = "0x180570530", Slot = "4")]
		public void Get(out IOSCredentials output)
		{
		}

		// Token: 0x040012C0 RID: 4800
		[Token(Token = "0x40012C0")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040012C1 RID: 4801
		[Token(Token = "0x40012C1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Id;

		// Token: 0x040012C2 RID: 4802
		[Token(Token = "0x40012C2")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Token;

		// Token: 0x040012C3 RID: 4803
		[Token(Token = "0x40012C3")]
		[FieldOffset(Offset = "0x18")]
		private LoginCredentialType m_Type;

		// Token: 0x040012C4 RID: 4804
		[Token(Token = "0x40012C4")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_SystemAuthCredentialsOptions;

		// Token: 0x040012C5 RID: 4805
		[Token(Token = "0x40012C5")]
		[FieldOffset(Offset = "0x28")]
		private ExternalCredentialType m_ExternalType;
	}
}
