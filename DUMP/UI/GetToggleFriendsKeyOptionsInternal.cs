using System;


namespace Epic.OnlineServices.UI
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	internal struct GetToggleFriendsKeyOptionsInternal : ISettable<GetToggleFriendsKeyOptions>, IDisposable
	{
		// Token: 0x060004D0 RID: 1232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref GetToggleFriendsKeyOptions other)
		{
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x4A66C0", Offset = "0x4A4CC0", VA = "0x1804A66C0", Slot = "5")]
		public void Set(ref GetToggleFriendsKeyOptions? other)
		{
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
