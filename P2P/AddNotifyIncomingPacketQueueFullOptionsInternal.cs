using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000319 RID: 793
	[Token(Token = "0x2000319")]
	internal struct AddNotifyIncomingPacketQueueFullOptionsInternal : ISettable<AddNotifyIncomingPacketQueueFullOptions>, IDisposable
	{
		// Token: 0x06001580 RID: 5504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyIncomingPacketQueueFullOptions other)
		{
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x4EC3B0", Offset = "0x4EA9B0", VA = "0x1804EC3B0", Slot = "5")]
		public void Set(ref AddNotifyIncomingPacketQueueFullOptions? other)
		{
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001582")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400097D RID: 2429
		[Token(Token = "0x400097D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
