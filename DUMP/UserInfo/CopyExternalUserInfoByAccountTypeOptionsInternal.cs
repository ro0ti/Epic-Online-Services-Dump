using System;


namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	internal struct CopyExternalUserInfoByAccountTypeOptionsInternal : ISettable<CopyExternalUserInfoByAccountTypeOptions>, IDisposable
	{
		// Token: 0x17000038 RID: 56
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000038")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x4A0A30", Offset = "0x49F030", VA = "0x1804A0A30")]
			set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000039")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x4A0AE0", Offset = "0x49F0E0", VA = "0x1804A0AE0")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003A")]
		public ExternalAccountType AccountType
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x4A09E0", Offset = "0x49EFE0", VA = "0x1804A09E0", Slot = "4")]
		public void Set(ref CopyExternalUserInfoByAccountTypeOptions other)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x4A0920", Offset = "0x49EF20", VA = "0x1804A0920", Slot = "5")]
		public void Set(ref CopyExternalUserInfoByAccountTypeOptions? other)
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x4A0840", Offset = "0x49EE40", VA = "0x1804A0840", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x18")]
		private ExternalAccountType m_AccountType;
	}
}
