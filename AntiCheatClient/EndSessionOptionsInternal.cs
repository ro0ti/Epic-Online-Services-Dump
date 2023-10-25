using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x020006FE RID: 1790
	[Token(Token = "0x20006FE")]
	internal struct EndSessionOptionsInternal : ISettable<EndSessionOptions>, IDisposable
	{
		// Token: 0x06002DC0 RID: 11712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DC0")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref EndSessionOptions other)
		{
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DC1")]
		[Address(RVA = "0x570310", Offset = "0x56E910", VA = "0x180570310", Slot = "5")]
		public void Set(ref EndSessionOptions? other)
		{
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DC2")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400146B RID: 5227
		[Token(Token = "0x400146B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
