using System;


namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004E4 RID: 1252
	[Token(Token = "0x20004E4")]
	internal struct IntegratedPlatformOptionsContainerAddOptionsInternal : ISettable<IntegratedPlatformOptionsContainerAddOptions>, IDisposable
	{
		// Token: 0x17000915 RID: 2325
		// (set) Token: 0x06002019 RID: 8217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000915")]
		public Options? Options
		{
			[Token(Token = "0x6002019")]
			[Address(RVA = "0x524B00", Offset = "0x523100", VA = "0x180524B00")]
			set
			{
			}
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600201A")]
		[Address(RVA = "0x5249B0", Offset = "0x522FB0", VA = "0x1805249B0", Slot = "4")]
		public void Set(ref IntegratedPlatformOptionsContainerAddOptions other)
		{
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600201B")]
		[Address(RVA = "0x524A30", Offset = "0x523030", VA = "0x180524A30", Slot = "5")]
		public void Set(ref IntegratedPlatformOptionsContainerAddOptions? other)
		{
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600201C")]
		[Address(RVA = "0x524960", Offset = "0x522F60", VA = "0x180524960", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E36 RID: 3638
		[Token(Token = "0x4000E36")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000E37 RID: 3639
		[Token(Token = "0x4000E37")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Options;
	}
}
