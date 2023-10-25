using System;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x0200059D RID: 1437
	[Token(Token = "0x200059D")]
	internal struct AcceptRequestToJoinOptionsInternal : ISettable<AcceptRequestToJoinOptions>, IDisposable
	{
		// Token: 0x17000ACB RID: 2763
		// (set) Token: 0x06002504 RID: 9476 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ACB")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002504")]
			[Address(RVA = "0x539CA0", Offset = "0x5382A0", VA = "0x180539CA0")]
			set
			{
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (set) Token: 0x06002505 RID: 9477 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ACC")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6002505")]
			[Address(RVA = "0x539D00", Offset = "0x538300", VA = "0x180539D00")]
			set
			{
			}
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002506")]
		[Address(RVA = "0x539BE0", Offset = "0x5381E0", VA = "0x180539BE0", Slot = "4")]
		public void Set(ref AcceptRequestToJoinOptions other)
		{
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002507")]
		[Address(RVA = "0x539AD0", Offset = "0x5380D0", VA = "0x180539AD0", Slot = "5")]
		public void Set(ref AcceptRequestToJoinOptions? other)
		{
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002508")]
		[Address(RVA = "0x539A70", Offset = "0x538070", VA = "0x180539A70", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400106D RID: 4205
		[Token(Token = "0x400106D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400106E RID: 4206
		[Token(Token = "0x400106E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400106F RID: 4207
		[Token(Token = "0x400106F")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
