using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	internal struct ExternalUserInfoInternal : IGettable<ExternalUserInfo>, ISettable<ExternalUserInfo>, IDisposable
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0000266C File Offset: 0x0000086C
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000049")]
		public ExternalAccountType AccountType
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x4A4D40", Offset = "0x4A3340", VA = "0x1804A4D40")]
			get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004A")]
		public Utf8String AccountId
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x4A4CD0", Offset = "0x4A32D0", VA = "0x1804A4CD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x4A4E30", Offset = "0x4A3430", VA = "0x1804A4E30")]
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004B")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x4A4DC0", Offset = "0x4A33C0", VA = "0x1804A4DC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x4A4F00", Offset = "0x4A3500", VA = "0x1804A4F00")]
			set
			{
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004C")]
		public Utf8String DisplayNameSanitized
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x4A4D50", Offset = "0x4A3350", VA = "0x1804A4D50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x4A4EA0", Offset = "0x4A34A0", VA = "0x1804A4EA0")]
			set
			{
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x4A4BC0", Offset = "0x4A31C0", VA = "0x1804A4BC0", Slot = "5")]
		public void Set(ref ExternalUserInfo other)
		{
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x4A4A40", Offset = "0x4A3040", VA = "0x1804A4A40", Slot = "6")]
		public void Set(ref ExternalUserInfo? other)
		{
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x4A4900", Offset = "0x4A2F00", VA = "0x1804A4900", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x4A4A20", Offset = "0x4A3020", VA = "0x1804A4A20", Slot = "4")]
		public void Get(out ExternalUserInfo output)
		{
		}

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x4")]
		private ExternalAccountType m_AccountType;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_AccountId;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_DisplayName;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_DisplayNameSanitized;
	}
}
