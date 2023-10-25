using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200032B RID: 811
	[Token(Token = "0x200032B")]
	internal struct GetNATTypeOptionsInternal : ISettable<GetNATTypeOptions>, IDisposable
	{
		// Token: 0x060015C8 RID: 5576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref GetNATTypeOptions other)
		{
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015C9")]
		[Address(RVA = "0x4F22A0", Offset = "0x4F08A0", VA = "0x1804F22A0", Slot = "5")]
		public void Set(ref GetNATTypeOptions? other)
		{
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040009B4 RID: 2484
		[Token(Token = "0x40009B4")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
