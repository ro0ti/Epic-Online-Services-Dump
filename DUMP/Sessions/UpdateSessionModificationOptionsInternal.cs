using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020001A0 RID: 416
	[Token(Token = "0x20001A0")]
	internal struct UpdateSessionModificationOptionsInternal : ISettable<UpdateSessionModificationOptions>, IDisposable
	{
		// Token: 0x170002BE RID: 702
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002BE")]
		public Utf8String SessionName
		{
			[Token(Token = "0x6000C02")]
			[Address(RVA = "0x4EB890", Offset = "0x4E9E90", VA = "0x1804EB890")]
			set
			{
			}
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x4EB830", Offset = "0x4E9E30", VA = "0x1804EB830", Slot = "4")]
		public void Set(ref UpdateSessionModificationOptions other)
		{
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x4EB790", Offset = "0x4E9D90", VA = "0x1804EB790", Slot = "5")]
		public void Set(ref UpdateSessionModificationOptions? other)
		{
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x4EB740", Offset = "0x4E9D40", VA = "0x1804EB740", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionName;
	}
}
