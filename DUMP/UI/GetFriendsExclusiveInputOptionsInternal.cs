using System;


namespace Epic.OnlineServices.UI
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	internal struct GetFriendsExclusiveInputOptionsInternal : ISettable<GetFriendsExclusiveInputOptions>, IDisposable
	{
		// Token: 0x17000091 RID: 145
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000091")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x4A63A0", Offset = "0x4A49A0", VA = "0x1804A63A0")]
			set
			{
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x4A6380", Offset = "0x4A4980", VA = "0x1804A6380", Slot = "4")]
		public void Set(ref GetFriendsExclusiveInputOptions other)
		{
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x4A6310", Offset = "0x4A4910", VA = "0x1804A6310", Slot = "5")]
		public void Set(ref GetFriendsExclusiveInputOptions? other)
		{
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x4A6280", Offset = "0x4A4880", VA = "0x1804A6280", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
