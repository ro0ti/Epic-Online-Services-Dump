using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	internal struct CopyBestDisplayNameWithPlatformOptionsInternal : ISettable<CopyBestDisplayNameWithPlatformOptions>, IDisposable
	{
		// Token: 0x1700002C RID: 44
		// (set) Token: 0x060003AA RID: 938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002C")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x4A0290", Offset = "0x49E890", VA = "0x1804A0290")]
			set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002D")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x4A0340", Offset = "0x49E940", VA = "0x1804A0340")]
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002E")]
		public uint TargetPlatformType
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x4A0180", Offset = "0x49E780", VA = "0x1804A0180", Slot = "4")]
		public void Set(ref CopyBestDisplayNameWithPlatformOptions other)
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x4A01D0", Offset = "0x49E7D0", VA = "0x1804A01D0", Slot = "5")]
		public void Set(ref CopyBestDisplayNameWithPlatformOptions? other)
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x4A00A0", Offset = "0x49E6A0", VA = "0x1804A00A0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x18")]
		private uint m_TargetPlatformType;
	}
}
