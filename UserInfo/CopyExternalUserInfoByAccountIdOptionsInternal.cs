using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	internal struct CopyExternalUserInfoByAccountIdOptionsInternal : ISettable<CopyExternalUserInfoByAccountIdOptions>, IDisposable
	{
		// Token: 0x17000032 RID: 50
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000032")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x4A06E0", Offset = "0x49ECE0", VA = "0x1804A06E0")]
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000033")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x4A0790", Offset = "0x49ED90", VA = "0x1804A0790")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000034")]
		public Utf8String AccountId
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x4A0680", Offset = "0x49EC80", VA = "0x1804A0680")]
			set
			{
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x4A0600", Offset = "0x49EC00", VA = "0x1804A0600", Slot = "4")]
		public void Set(ref CopyExternalUserInfoByAccountIdOptions other)
		{
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x4A0510", Offset = "0x49EB10", VA = "0x1804A0510", Slot = "5")]
		public void Set(ref CopyExternalUserInfoByAccountIdOptions? other)
		{
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x4A03F0", Offset = "0x49E9F0", VA = "0x1804A03F0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_AccountId;
	}
}
