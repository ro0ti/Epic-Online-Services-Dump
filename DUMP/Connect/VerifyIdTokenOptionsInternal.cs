using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000648 RID: 1608
	[Token(Token = "0x2000648")]
	internal struct VerifyIdTokenOptionsInternal : ISettable<VerifyIdTokenOptions>, IDisposable
	{
		// Token: 0x17000C05 RID: 3077
		// (set) Token: 0x06002940 RID: 10560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C05")]
		public IdToken? IdToken
		{
			[Token(Token = "0x6002940")]
			[Address(RVA = "0x56B080", Offset = "0x569680", VA = "0x18056B080")]
			set
			{
			}
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002941")]
		[Address(RVA = "0x56AF30", Offset = "0x569530", VA = "0x18056AF30", Slot = "4")]
		public void Set(ref VerifyIdTokenOptions other)
		{
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002942")]
		[Address(RVA = "0x56AFB0", Offset = "0x5695B0", VA = "0x18056AFB0", Slot = "5")]
		public void Set(ref VerifyIdTokenOptions? other)
		{
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002943")]
		[Address(RVA = "0x56AEE0", Offset = "0x5694E0", VA = "0x18056AEE0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040011EA RID: 4586
		[Token(Token = "0x40011EA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040011EB RID: 4587
		[Token(Token = "0x40011EB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_IdToken;
	}
}
