using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000317 RID: 791
	[Token(Token = "0x2000317")]
	internal struct AcceptConnectionOptionsInternal : ISettable<AcceptConnectionOptions>, IDisposable
	{
		// Token: 0x170005C4 RID: 1476
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005C4")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600157A")]
			[Address(RVA = "0x4EC250", Offset = "0x4EA850", VA = "0x1804EC250")]
			set
			{
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005C5")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x600157B")]
			[Address(RVA = "0x4EC2B0", Offset = "0x4EA8B0", VA = "0x1804EC2B0")]
			set
			{
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005C6")]
		public SocketId? SocketId
		{
			[Token(Token = "0x600157C")]
			[Address(RVA = "0x4EC310", Offset = "0x4EA910", VA = "0x1804EC310")]
			set
			{
			}
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600157D")]
		[Address(RVA = "0x4EC130", Offset = "0x4EA730", VA = "0x1804EC130", Slot = "4")]
		public void Set(ref AcceptConnectionOptions other)
		{
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600157E")]
		[Address(RVA = "0x4EBFB0", Offset = "0x4EA5B0", VA = "0x1804EBFB0", Slot = "5")]
		public void Set(ref AcceptConnectionOptions? other)
		{
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600157F")]
		[Address(RVA = "0x4EBF40", Offset = "0x4EA540", VA = "0x1804EBF40", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000979 RID: 2425
		[Token(Token = "0x4000979")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400097A RID: 2426
		[Token(Token = "0x400097A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400097B RID: 2427
		[Token(Token = "0x400097B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RemoteUserId;

		// Token: 0x0400097C RID: 2428
		[Token(Token = "0x400097C")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_SocketId;
	}
}
