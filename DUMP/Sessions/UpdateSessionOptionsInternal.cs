using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020001A2 RID: 418
	[Token(Token = "0x20001A2")]
	internal struct UpdateSessionOptionsInternal : ISettable<UpdateSessionOptions>, IDisposable
	{
		// Token: 0x170002C0 RID: 704
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002C0")]
		public SessionModification SessionModificationHandle
		{
			[Token(Token = "0x6000C08")]
			[Address(RVA = "0x4EBA40", Offset = "0x4EA040", VA = "0x1804EBA40")]
			set
			{
			}
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x4EB940", Offset = "0x4E9F40", VA = "0x1804EB940", Slot = "4")]
		public void Set(ref UpdateSessionOptions other)
		{
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x4EB9A0", Offset = "0x4E9FA0", VA = "0x1804EB9A0", Slot = "5")]
		public void Set(ref UpdateSessionOptions? other)
		{
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x4EB8F0", Offset = "0x4E9EF0", VA = "0x1804EB8F0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionModificationHandle;
	}
}
