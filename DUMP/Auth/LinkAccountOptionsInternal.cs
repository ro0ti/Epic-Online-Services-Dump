using System;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000660 RID: 1632
	[Token(Token = "0x2000660")]
	internal struct LinkAccountOptionsInternal : ISettable<LinkAccountOptions>, IDisposable
	{
		// Token: 0x17000C2D RID: 3117
		// (set) Token: 0x060029D1 RID: 10705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C2D")]
		public LinkAccountFlags LinkAccountFlags
		{
			[Token(Token = "0x60029D1")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (set) Token: 0x060029D2 RID: 10706 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C2E")]
		public ContinuanceToken ContinuanceToken
		{
			[Token(Token = "0x60029D2")]
			[Address(RVA = "0x55D2D0", Offset = "0x55B8D0", VA = "0x18055D2D0")]
			set
			{
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (set) Token: 0x060029D3 RID: 10707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C2F")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60029D3")]
			[Address(RVA = "0x55D330", Offset = "0x55B930", VA = "0x18055D330")]
			set
			{
			}
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029D4")]
		[Address(RVA = "0x55CF60", Offset = "0x55B560", VA = "0x18055CF60", Slot = "4")]
		public void Set(ref LinkAccountOptions other)
		{
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029D5")]
		[Address(RVA = "0x55D030", Offset = "0x55B630", VA = "0x18055D030", Slot = "5")]
		public void Set(ref LinkAccountOptions? other)
		{
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029D6")]
		[Address(RVA = "0x55CDE0", Offset = "0x55B3E0", VA = "0x18055CDE0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001236 RID: 4662
		[Token(Token = "0x4001236")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001237 RID: 4663
		[Token(Token = "0x4001237")]
		[FieldOffset(Offset = "0x4")]
		private LinkAccountFlags m_LinkAccountFlags;

		// Token: 0x04001238 RID: 4664
		[Token(Token = "0x4001238")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ContinuanceToken;

		// Token: 0x04001239 RID: 4665
		[Token(Token = "0x4001239")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
