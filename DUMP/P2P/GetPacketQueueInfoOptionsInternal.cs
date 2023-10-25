using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200032F RID: 815
	[Token(Token = "0x200032F")]
	internal struct GetPacketQueueInfoOptionsInternal : ISettable<GetPacketQueueInfoOptions>, IDisposable
	{
		// Token: 0x060015D4 RID: 5588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D4")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref GetPacketQueueInfoOptions other)
		{
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x4F25F0", Offset = "0x4F0BF0", VA = "0x1804F25F0", Slot = "5")]
		public void Set(ref GetPacketQueueInfoOptions? other)
		{
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040009BA RID: 2490
		[Token(Token = "0x40009BA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
