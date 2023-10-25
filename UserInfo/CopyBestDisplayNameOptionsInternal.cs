using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	internal struct CopyBestDisplayNameOptionsInternal : ISettable<CopyBestDisplayNameOptions>, IDisposable
	{
		// Token: 0x17000027 RID: 39
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000027")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x49FF40", Offset = "0x49E540", VA = "0x18049FF40")]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000028")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x49FFF0", Offset = "0x49E5F0", VA = "0x18049FFF0")]
			set
			{
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x49FE60", Offset = "0x49E460", VA = "0x18049FE60", Slot = "4")]
		public void Set(ref CopyBestDisplayNameOptions other)
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x49FEA0", Offset = "0x49E4A0", VA = "0x18049FEA0", Slot = "5")]
		public void Set(ref CopyBestDisplayNameOptions? other)
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x49FD80", Offset = "0x49E380", VA = "0x18049FD80", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
