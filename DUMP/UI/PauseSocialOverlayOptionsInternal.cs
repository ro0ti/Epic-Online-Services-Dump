using System;


namespace Epic.OnlineServices.UI
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	internal struct PauseSocialOverlayOptionsInternal : ISettable<PauseSocialOverlayOptions>, IDisposable
	{
		// Token: 0x170000BC RID: 188
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000BC")]
		public bool IsPaused
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x4ACCF0", Offset = "0x4AB2F0", VA = "0x1804ACCF0")]
			set
			{
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x4ACC60", Offset = "0x4AB260", VA = "0x1804ACC60", Slot = "4")]
		public void Set(ref PauseSocialOverlayOptions other)
		{
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x4ACC80", Offset = "0x4AB280", VA = "0x1804ACC80", Slot = "5")]
		public void Set(ref PauseSocialOverlayOptions? other)
		{
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x4")]
		private int m_IsPaused;
	}
}
