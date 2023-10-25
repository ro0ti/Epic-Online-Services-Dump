using System;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000655 RID: 1621
	[Token(Token = "0x2000655")]
	internal struct CredentialsInternal : IGettable<Credentials>, ISettable<Credentials>, IDisposable
	{
		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002980 RID: 10624 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002981 RID: 10625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C0F")]
		public Utf8String Id
		{
			[Token(Token = "0x6002980")]
			[Address(RVA = "0x5594E0", Offset = "0x557AE0", VA = "0x1805594E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002981")]
			[Address(RVA = "0x559630", Offset = "0x557C30", VA = "0x180559630")]
			set
			{
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06002982 RID: 10626 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002983 RID: 10627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C10")]
		public Utf8String Token
		{
			[Token(Token = "0x6002982")]
			[Address(RVA = "0x5595C0", Offset = "0x557BC0", VA = "0x1805595C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002983")]
			[Address(RVA = "0x5596F0", Offset = "0x557CF0", VA = "0x1805596F0")]
			set
			{
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06002984 RID: 10628 RVA: 0x0000A694 File Offset: 0x00008894
		// (set) Token: 0x06002985 RID: 10629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C11")]
		public LoginCredentialType Type
		{
			[Token(Token = "0x6002984")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return LoginCredentialType.Password;
			}
			[Token(Token = "0x6002985")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002986 RID: 10630 RVA: 0x0000A6AC File Offset: 0x000088AC
		// (set) Token: 0x06002987 RID: 10631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C12")]
		public IntPtr SystemAuthCredentialsOptions
		{
			[Token(Token = "0x6002986")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002987")]
			[Address(RVA = "0x4F4050", Offset = "0x4F2650", VA = "0x1804F4050")]
			set
			{
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002988 RID: 10632 RVA: 0x0000A6C4 File Offset: 0x000088C4
		// (set) Token: 0x06002989 RID: 10633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C13")]
		public ExternalCredentialType ExternalType
		{
			[Token(Token = "0x6002988")]
			[Address(RVA = "0x3D2E70", Offset = "0x3D1470", VA = "0x1803D2E70")]
			get
			{
				return ExternalCredentialType.Epic;
			}
			[Token(Token = "0x6002989")]
			[Address(RVA = "0x3D2EA0", Offset = "0x3D14A0", VA = "0x1803D2EA0")]
			set
			{
			}
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600298A")]
		[Address(RVA = "0x559410", Offset = "0x557A10", VA = "0x180559410", Slot = "5")]
		public void Set(ref Credentials other)
		{
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600298B")]
		[Address(RVA = "0x5592B0", Offset = "0x5578B0", VA = "0x1805592B0", Slot = "6")]
		public void Set(ref Credentials? other)
		{
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600298C")]
		[Address(RVA = "0x5590A0", Offset = "0x5576A0", VA = "0x1805590A0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600298D")]
		[Address(RVA = "0x559130", Offset = "0x557730", VA = "0x180559130", Slot = "4")]
		public void Get(out Credentials output)
		{
		}

		// Token: 0x04001214 RID: 4628
		[Token(Token = "0x4001214")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001215 RID: 4629
		[Token(Token = "0x4001215")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Id;

		// Token: 0x04001216 RID: 4630
		[Token(Token = "0x4001216")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Token;

		// Token: 0x04001217 RID: 4631
		[Token(Token = "0x4001217")]
		[FieldOffset(Offset = "0x18")]
		private LoginCredentialType m_Type;

		// Token: 0x04001218 RID: 4632
		[Token(Token = "0x4001218")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_SystemAuthCredentialsOptions;

		// Token: 0x04001219 RID: 4633
		[Token(Token = "0x4001219")]
		[FieldOffset(Offset = "0x28")]
		private ExternalCredentialType m_ExternalType;
	}
}
