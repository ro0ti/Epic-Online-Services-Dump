using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	internal struct CopyExternalUserInfoByIndexOptionsInternal : ISettable<CopyExternalUserInfoByIndexOptions>, IDisposable
	{
		// Token: 0x1700003E RID: 62
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003E")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x4A0D80", Offset = "0x49F380", VA = "0x1804A0D80")]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003F")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x4A0E30", Offset = "0x49F430", VA = "0x1804A0E30")]
			set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000040")]
		public uint Index
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x4A0C70", Offset = "0x49F270", VA = "0x1804A0C70", Slot = "4")]
		public void Set(ref CopyExternalUserInfoByIndexOptions other)
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x4A0CC0", Offset = "0x49F2C0", VA = "0x1804A0CC0", Slot = "5")]
		public void Set(ref CopyExternalUserInfoByIndexOptions? other)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x4A0B90", Offset = "0x49F190", VA = "0x1804A0B90", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x18")]
		private uint m_Index;
	}
}
