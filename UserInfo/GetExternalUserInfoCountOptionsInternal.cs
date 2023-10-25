using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	internal struct GetExternalUserInfoCountOptionsInternal : ISettable<GetExternalUserInfoCountOptions>, IDisposable
	{
		// Token: 0x1700004F RID: 79
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004F")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x4A5F50", Offset = "0x4A4550", VA = "0x1804A5F50")]
			set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000050")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x4A6000", Offset = "0x4A4600", VA = "0x1804A6000")]
			set
			{
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x4A5E70", Offset = "0x4A4470", VA = "0x1804A5E70", Slot = "4")]
		public void Set(ref GetExternalUserInfoCountOptions other)
		{
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x4A5EB0", Offset = "0x4A44B0", VA = "0x1804A5EB0", Slot = "5")]
		public void Set(ref GetExternalUserInfoCountOptions? other)
		{
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x4A5D90", Offset = "0x4A4390", VA = "0x1804A5D90", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
