using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004CB RID: 1227
	[Token(Token = "0x20004CB")]
	internal struct QueryAgeGateOptionsInternal : ISettable<QueryAgeGateOptions>, IDisposable
	{
		// Token: 0x06001F8E RID: 8078 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F8E")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref QueryAgeGateOptions other)
		{
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F8F")]
		[Address(RVA = "0x532690", Offset = "0x530C90", VA = "0x180532690", Slot = "5")]
		public void Set(ref QueryAgeGateOptions? other)
		{
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F90")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000DEF RID: 3567
		[Token(Token = "0x4000DEF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
