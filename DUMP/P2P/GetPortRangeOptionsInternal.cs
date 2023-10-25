using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000331 RID: 817
	[Token(Token = "0x2000331")]
	internal struct GetPortRangeOptionsInternal : ISettable<GetPortRangeOptions>, IDisposable
	{
		// Token: 0x060015D7 RID: 5591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D7")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref GetPortRangeOptions other)
		{
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x4F2640", Offset = "0x4F0C40", VA = "0x1804F2640", Slot = "5")]
		public void Set(ref GetPortRangeOptions? other)
		{
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D9")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040009BB RID: 2491
		[Token(Token = "0x40009BB")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
