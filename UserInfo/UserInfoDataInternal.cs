using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	internal struct UserInfoDataInternal : IGettable<UserInfoData>, ISettable<UserInfoData>, IDisposable
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000086")]
		public EpicAccountId UserId
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x4B5400", Offset = "0x4B3A00", VA = "0x1804B5400")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x4B5660", Offset = "0x4B3C60", VA = "0x1804B5660")]
			set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000087")]
		public Utf8String Country
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x4B51D0", Offset = "0x4B37D0", VA = "0x1804B51D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x4B5480", Offset = "0x4B3A80", VA = "0x1804B5480")]
			set
			{
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000088")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x4B52B0", Offset = "0x4B38B0", VA = "0x1804B52B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x4B5540", Offset = "0x4B3B40", VA = "0x1804B5540")]
			set
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000089")]
		public Utf8String PreferredLanguage
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x4B5390", Offset = "0x4B3990", VA = "0x1804B5390")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x4B5600", Offset = "0x4B3C00", VA = "0x1804B5600")]
			set
			{
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008A")]
		public Utf8String Nickname
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x4B5320", Offset = "0x4B3920", VA = "0x1804B5320")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x4B55A0", Offset = "0x4B3BA0", VA = "0x1804B55A0")]
			set
			{
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008B")]
		public Utf8String DisplayNameSanitized
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x4B5240", Offset = "0x4B3840", VA = "0x1804B5240")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x4B54E0", Offset = "0x4B3AE0", VA = "0x1804B54E0")]
			set
			{
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x4B5030", Offset = "0x4B3630", VA = "0x1804B5030", Slot = "5")]
		public void Set(ref UserInfoData other)
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x4B4E00", Offset = "0x4B3400", VA = "0x1804B4E00", Slot = "6")]
		public void Set(ref UserInfoData? other)
		{
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x4B4BE0", Offset = "0x4B31E0", VA = "0x1804B4BE0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x4B4DE0", Offset = "0x4B33E0", VA = "0x1804B4DE0", Slot = "4")]
		public void Get(out UserInfoData output)
		{
		}

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Country;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_DisplayName;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_PreferredLanguage;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_Nickname;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x30")]
		private IntPtr m_DisplayNameSanitized;
	}
}
