using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000333 RID: 819
	[Token(Token = "0x2000333")]
	internal struct GetRelayControlOptionsInternal : ISettable<GetRelayControlOptions>, IDisposable
	{
		// Token: 0x060015DA RID: 5594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref GetRelayControlOptions other)
		{
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x4F2690", Offset = "0x4F0C90", VA = "0x1804F2690", Slot = "5")]
		public void Set(ref GetRelayControlOptions? other)
		{
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040009BC RID: 2492
		[Token(Token = "0x40009BC")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
