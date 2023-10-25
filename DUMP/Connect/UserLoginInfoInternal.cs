using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000644 RID: 1604
	[Token(Token = "0x2000644")]
	internal struct UserLoginInfoInternal : IGettable<UserLoginInfo>, ISettable<UserLoginInfo>, IDisposable
	{
		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060028FF RID: 10495 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002900 RID: 10496 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE9")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x60028FF")]
			[Address(RVA = "0x5698B0", Offset = "0x567EB0", VA = "0x1805698B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002900")]
			[Address(RVA = "0x569990", Offset = "0x567F90", VA = "0x180569990")]
			set
			{
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002902 RID: 10498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BEA")]
		public Utf8String NsaIdToken
		{
			[Token(Token = "0x6002901")]
			[Address(RVA = "0x569920", Offset = "0x567F20", VA = "0x180569920")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002902")]
			[Address(RVA = "0x5699F0", Offset = "0x567FF0", VA = "0x1805699F0")]
			set
			{
			}
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002903")]
		[Address(RVA = "0x5696E0", Offset = "0x567CE0", VA = "0x1805696E0", Slot = "5")]
		public void Set(ref UserLoginInfo other)
		{
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002904")]
		[Address(RVA = "0x5697A0", Offset = "0x567DA0", VA = "0x1805697A0", Slot = "6")]
		public void Set(ref UserLoginInfo? other)
		{
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002905")]
		[Address(RVA = "0x569660", Offset = "0x567C60", VA = "0x180569660", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002906")]
		[Address(RVA = "0x5696C0", Offset = "0x567CC0", VA = "0x1805696C0", Slot = "4")]
		public void Get(out UserLoginInfo output)
		{
		}

		// Token: 0x040011CE RID: 4558
		[Token(Token = "0x40011CE")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040011CF RID: 4559
		[Token(Token = "0x40011CF")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_DisplayName;

		// Token: 0x040011D0 RID: 4560
		[Token(Token = "0x40011D0")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_NsaIdToken;
	}
}
