using System;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000690 RID: 1680
	[Token(Token = "0x2000690")]
	internal struct IOSCredentialsSystemAuthCredentialsOptionsInternal : IGettable<IOSCredentialsSystemAuthCredentialsOptions>, ISettable<IOSCredentialsSystemAuthCredentialsOptions>, IDisposable
	{
		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06002B4A RID: 11082 RVA: 0x0000ACF4 File Offset: 0x00008EF4
		// (set) Token: 0x06002B4B RID: 11083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CAF")]
		public IntPtr PresentationContextProviding
		{
			[Token(Token = "0x6002B4A")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002B4B")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B4C")]
		[Address(RVA = "0x4ACEA0", Offset = "0x4AB4A0", VA = "0x1804ACEA0", Slot = "5")]
		public void Set(ref IOSCredentialsSystemAuthCredentialsOptions other)
		{
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B4D")]
		[Address(RVA = "0x570B20", Offset = "0x56F120", VA = "0x180570B20", Slot = "6")]
		public void Set(ref IOSCredentialsSystemAuthCredentialsOptions? other)
		{
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B4E")]
		[Address(RVA = "0x570AC0", Offset = "0x56F0C0", VA = "0x180570AC0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B4F")]
		[Address(RVA = "0x570B10", Offset = "0x56F110", VA = "0x180570B10", Slot = "4")]
		public void Get(out IOSCredentialsSystemAuthCredentialsOptions output)
		{
		}

		// Token: 0x040012C7 RID: 4807
		[Token(Token = "0x40012C7")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040012C8 RID: 4808
		[Token(Token = "0x40012C8")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PresentationContextProviding;
	}
}
