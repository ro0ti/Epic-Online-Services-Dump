using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200067E RID: 1662
	[Token(Token = "0x200067E")]
	internal struct PinGrantInfoInternal : IGettable<PinGrantInfo>, ISettable<PinGrantInfo>, IDisposable
	{
		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06002A7F RID: 10879 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A80 RID: 10880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C5B")]
		public Utf8String UserCode
		{
			[Token(Token = "0x6002A7F")]
			[Address(RVA = "0x57A840", Offset = "0x578E40", VA = "0x18057A840")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A80")]
			[Address(RVA = "0x57A990", Offset = "0x578F90", VA = "0x18057A990")]
			set
			{
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06002A81 RID: 10881 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A82 RID: 10882 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C5C")]
		public Utf8String VerificationURI
		{
			[Token(Token = "0x6002A81")]
			[Address(RVA = "0x57A920", Offset = "0x578F20", VA = "0x18057A920")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A82")]
			[Address(RVA = "0x57AA50", Offset = "0x579050", VA = "0x18057AA50")]
			set
			{
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06002A83 RID: 10883 RVA: 0x0000A9F4 File Offset: 0x00008BF4
		// (set) Token: 0x06002A84 RID: 10884 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C5D")]
		public int ExpiresIn
		{
			[Token(Token = "0x6002A83")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002A84")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06002A85 RID: 10885 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A86 RID: 10886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C5E")]
		public Utf8String VerificationURIComplete
		{
			[Token(Token = "0x6002A85")]
			[Address(RVA = "0x57A8B0", Offset = "0x578EB0", VA = "0x18057A8B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A86")]
			[Address(RVA = "0x57A9F0", Offset = "0x578FF0", VA = "0x18057A9F0")]
			set
			{
			}
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A87")]
		[Address(RVA = "0x57A5B0", Offset = "0x578BB0", VA = "0x18057A5B0", Slot = "5")]
		public void Set(ref PinGrantInfo other)
		{
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A88")]
		[Address(RVA = "0x57A6C0", Offset = "0x578CC0", VA = "0x18057A6C0", Slot = "6")]
		public void Set(ref PinGrantInfo? other)
		{
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A89")]
		[Address(RVA = "0x57A520", Offset = "0x578B20", VA = "0x18057A520", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A8A")]
		[Address(RVA = "0x57A590", Offset = "0x578B90", VA = "0x18057A590", Slot = "4")]
		public void Get(out PinGrantInfo output)
		{
		}

		// Token: 0x04001270 RID: 4720
		[Token(Token = "0x4001270")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001271 RID: 4721
		[Token(Token = "0x4001271")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserCode;

		// Token: 0x04001272 RID: 4722
		[Token(Token = "0x4001272")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_VerificationURI;

		// Token: 0x04001273 RID: 4723
		[Token(Token = "0x4001273")]
		[FieldOffset(Offset = "0x18")]
		private int m_ExpiresIn;

		// Token: 0x04001274 RID: 4724
		[Token(Token = "0x4001274")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_VerificationURIComplete;
	}
}
