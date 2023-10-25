using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000521 RID: 1313
	[Token(Token = "0x2000521")]
	internal struct RejectInviteOptionsInternal : ISettable<RejectInviteOptions>, IDisposable
	{
		// Token: 0x17000987 RID: 2439
		// (set) Token: 0x06002194 RID: 8596 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000987")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002194")]
			[Address(RVA = "0x54FF50", Offset = "0x54E550", VA = "0x18054FF50")]
			set
			{
			}
		}

		// Token: 0x17000988 RID: 2440
		// (set) Token: 0x06002195 RID: 8597 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000988")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6002195")]
			[Address(RVA = "0x54FFB0", Offset = "0x54E5B0", VA = "0x18054FFB0")]
			set
			{
			}
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002196")]
		[Address(RVA = "0x54FD80", Offset = "0x54E380", VA = "0x18054FD80", Slot = "4")]
		public void Set(ref RejectInviteOptions other)
		{
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002197")]
		[Address(RVA = "0x54FE40", Offset = "0x54E440", VA = "0x18054FE40", Slot = "5")]
		public void Set(ref RejectInviteOptions? other)
		{
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002198")]
		[Address(RVA = "0x54FD20", Offset = "0x54E320", VA = "0x18054FD20", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000EC2 RID: 3778
		[Token(Token = "0x4000EC2")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000EC3 RID: 3779
		[Token(Token = "0x4000EC3")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000EC4 RID: 3780
		[Token(Token = "0x4000EC4")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
