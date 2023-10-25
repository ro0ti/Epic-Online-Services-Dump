using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000653 RID: 1619
	[Token(Token = "0x2000653")]
	internal struct CopyUserAuthTokenOptionsInternal : ISettable<CopyUserAuthTokenOptions>, IDisposable
	{
		// Token: 0x06002972 RID: 10610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002972")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref CopyUserAuthTokenOptions other)
		{
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002973")]
		[Address(RVA = "0x558460", Offset = "0x556A60", VA = "0x180558460", Slot = "5")]
		public void Set(ref CopyUserAuthTokenOptions? other)
		{
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002974")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400120E RID: 4622
		[Token(Token = "0x400120E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
