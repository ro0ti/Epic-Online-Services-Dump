using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000682 RID: 1666
	[Token(Token = "0x2000682")]
	internal struct QueryIdTokenOptionsInternal : ISettable<QueryIdTokenOptions>, IDisposable
	{
		// Token: 0x17000C6A RID: 3178
		// (set) Token: 0x06002AA6 RID: 10918 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C6A")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002AA6")]
			[Address(RVA = "0x57D310", Offset = "0x57B910", VA = "0x18057D310")]
			set
			{
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (set) Token: 0x06002AA7 RID: 10919 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C6B")]
		public EpicAccountId TargetAccountId
		{
			[Token(Token = "0x6002AA7")]
			[Address(RVA = "0x57D370", Offset = "0x57B970", VA = "0x18057D370")]
			set
			{
			}
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002AA8")]
		[Address(RVA = "0x57D140", Offset = "0x57B740", VA = "0x18057D140", Slot = "4")]
		public void Set(ref QueryIdTokenOptions other)
		{
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002AA9")]
		[Address(RVA = "0x57D200", Offset = "0x57B800", VA = "0x18057D200", Slot = "5")]
		public void Set(ref QueryIdTokenOptions? other)
		{
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002AAA")]
		[Address(RVA = "0x57D0E0", Offset = "0x57B6E0", VA = "0x18057D0E0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400127F RID: 4735
		[Token(Token = "0x400127F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001280 RID: 4736
		[Token(Token = "0x4001280")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001281 RID: 4737
		[Token(Token = "0x4001281")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetAccountId;
	}
}
