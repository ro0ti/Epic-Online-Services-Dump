using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000684 RID: 1668
	[Token(Token = "0x2000684")]
	internal struct TokenInternal : IGettable<Token>, ISettable<Token>, IDisposable
	{
		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AC1 RID: 10945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C76")]
		public Utf8String App
		{
			[Token(Token = "0x6002AC0")]
			[Address(RVA = "0x57F8E0", Offset = "0x57DEE0", VA = "0x18057F8E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AC1")]
			[Address(RVA = "0x57FBF0", Offset = "0x57E1F0", VA = "0x18057FBF0")]
			set
			{
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AC3 RID: 10947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C77")]
		public Utf8String ClientId
		{
			[Token(Token = "0x6002AC2")]
			[Address(RVA = "0x57F950", Offset = "0x57DF50", VA = "0x18057F950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AC3")]
			[Address(RVA = "0x57FC50", Offset = "0x57E250", VA = "0x18057FC50")]
			set
			{
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AC5 RID: 10949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C78")]
		public EpicAccountId AccountId
		{
			[Token(Token = "0x6002AC4")]
			[Address(RVA = "0x57F860", Offset = "0x57DE60", VA = "0x18057F860")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AC5")]
			[Address(RVA = "0x57FB90", Offset = "0x57E190", VA = "0x18057FB90")]
			set
			{
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AC7 RID: 10951 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C79")]
		public Utf8String AccessToken
		{
			[Token(Token = "0x6002AC6")]
			[Address(RVA = "0x57F7F0", Offset = "0x57DDF0", VA = "0x18057F7F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AC7")]
			[Address(RVA = "0x57FB30", Offset = "0x57E130", VA = "0x18057FB30")]
			set
			{
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x0000AAB4 File Offset: 0x00008CB4
		// (set) Token: 0x06002AC9 RID: 10953 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C7A")]
		public double ExpiresIn
		{
			[Token(Token = "0x6002AC8")]
			[Address(RVA = "0x57FA30", Offset = "0x57E030", VA = "0x18057FA30")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6002AC9")]
			[Address(RVA = "0x57FD10", Offset = "0x57E310", VA = "0x18057FD10")]
			set
			{
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002ACB RID: 10955 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C7B")]
		public Utf8String ExpiresAt
		{
			[Token(Token = "0x6002ACA")]
			[Address(RVA = "0x57F9C0", Offset = "0x57DFC0", VA = "0x18057F9C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002ACB")]
			[Address(RVA = "0x57FCB0", Offset = "0x57E2B0", VA = "0x18057FCB0")]
			set
			{
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06002ACC RID: 10956 RVA: 0x0000AACC File Offset: 0x00008CCC
		// (set) Token: 0x06002ACD RID: 10957 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C7C")]
		public AuthTokenType AuthType
		{
			[Token(Token = "0x6002ACC")]
			[Address(RVA = "0x4D13A0", Offset = "0x4CF9A0", VA = "0x1804D13A0")]
			get
			{
				return AuthTokenType.Client;
			}
			[Token(Token = "0x6002ACD")]
			[Address(RVA = "0x4D13B0", Offset = "0x4CF9B0", VA = "0x1804D13B0")]
			set
			{
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06002ACE RID: 10958 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002ACF RID: 10959 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C7D")]
		public Utf8String RefreshToken
		{
			[Token(Token = "0x6002ACE")]
			[Address(RVA = "0x57FAC0", Offset = "0x57E0C0", VA = "0x18057FAC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002ACF")]
			[Address(RVA = "0x57FD90", Offset = "0x57E390", VA = "0x18057FD90")]
			set
			{
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06002AD0 RID: 10960 RVA: 0x0000AAE4 File Offset: 0x00008CE4
		// (set) Token: 0x06002AD1 RID: 10961 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C7E")]
		public double RefreshExpiresIn
		{
			[Token(Token = "0x6002AD0")]
			[Address(RVA = "0x57FAB0", Offset = "0x57E0B0", VA = "0x18057FAB0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6002AD1")]
			[Address(RVA = "0x57FD80", Offset = "0x57E380", VA = "0x18057FD80")]
			set
			{
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06002AD2 RID: 10962 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AD3 RID: 10963 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C7F")]
		public Utf8String RefreshExpiresAt
		{
			[Token(Token = "0x6002AD2")]
			[Address(RVA = "0x57FA40", Offset = "0x57E040", VA = "0x18057FA40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AD3")]
			[Address(RVA = "0x57FD20", Offset = "0x57E320", VA = "0x18057FD20")]
			set
			{
			}
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002AD4")]
		[Address(RVA = "0x57F2A0", Offset = "0x57D8A0", VA = "0x18057F2A0", Slot = "5")]
		public void Set(ref Token other)
		{
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002AD5")]
		[Address(RVA = "0x57F4D0", Offset = "0x57DAD0", VA = "0x18057F4D0", Slot = "6")]
		public void Set(ref Token? other)
		{
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002AD6")]
		[Address(RVA = "0x57F1D0", Offset = "0x57D7D0", VA = "0x18057F1D0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002AD7")]
		[Address(RVA = "0x57F270", Offset = "0x57D870", VA = "0x18057F270", Slot = "4")]
		public void Get(out Token output)
		{
		}

		// Token: 0x0400128C RID: 4748
		[Token(Token = "0x400128C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400128D RID: 4749
		[Token(Token = "0x400128D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_App;

		// Token: 0x0400128E RID: 4750
		[Token(Token = "0x400128E")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ClientId;

		// Token: 0x0400128F RID: 4751
		[Token(Token = "0x400128F")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_AccountId;

		// Token: 0x04001290 RID: 4752
		[Token(Token = "0x4001290")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_AccessToken;

		// Token: 0x04001291 RID: 4753
		[Token(Token = "0x4001291")]
		[FieldOffset(Offset = "0x28")]
		private double m_ExpiresIn;

		// Token: 0x04001292 RID: 4754
		[Token(Token = "0x4001292")]
		[FieldOffset(Offset = "0x30")]
		private IntPtr m_ExpiresAt;

		// Token: 0x04001293 RID: 4755
		[Token(Token = "0x4001293")]
		[FieldOffset(Offset = "0x38")]
		private AuthTokenType m_AuthType;

		// Token: 0x04001294 RID: 4756
		[Token(Token = "0x4001294")]
		[FieldOffset(Offset = "0x40")]
		private IntPtr m_RefreshToken;

		// Token: 0x04001295 RID: 4757
		[Token(Token = "0x4001295")]
		[FieldOffset(Offset = "0x48")]
		private double m_RefreshExpiresIn;

		// Token: 0x04001296 RID: 4758
		[Token(Token = "0x4001296")]
		[FieldOffset(Offset = "0x50")]
		private IntPtr m_RefreshExpiresAt;
	}
}
