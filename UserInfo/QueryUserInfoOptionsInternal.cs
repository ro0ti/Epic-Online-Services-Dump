using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	internal struct QueryUserInfoOptionsInternal : ISettable<QueryUserInfoOptions>, IDisposable
	{
		// Token: 0x1700007E RID: 126
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007E")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x4AF4E0", Offset = "0x4ADAE0", VA = "0x1804AF4E0")]
			set
			{
			}
		}

		// Token: 0x1700007F RID: 127
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007F")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x4AF590", Offset = "0x4ADB90", VA = "0x1804AF590")]
			set
			{
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x4AF4A0", Offset = "0x4ADAA0", VA = "0x1804AF4A0", Slot = "4")]
		public void Set(ref QueryUserInfoOptions other)
		{
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x4AF400", Offset = "0x4ADA00", VA = "0x1804AF400", Slot = "5")]
		public void Set(ref QueryUserInfoOptions? other)
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x4AF320", Offset = "0x4AD920", VA = "0x1804AF320", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
