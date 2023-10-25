using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	internal struct StartSessionOptionsInternal : ISettable<StartSessionOptions>, IDisposable
	{
		// Token: 0x170002A8 RID: 680
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002A8")]
		public Utf8String SessionName
		{
			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x4E69E0", Offset = "0x4E4FE0", VA = "0x1804E69E0")]
			set
			{
			}
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x4E68E0", Offset = "0x4E4EE0", VA = "0x1804E68E0", Slot = "4")]
		public void Set(ref StartSessionOptions other)
		{
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x4E6940", Offset = "0x4E4F40", VA = "0x1804E6940", Slot = "5")]
		public void Set(ref StartSessionOptions? other)
		{
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x4E6890", Offset = "0x4E4E90", VA = "0x1804E6890", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionName;
	}
}
