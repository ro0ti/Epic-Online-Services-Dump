using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000355 RID: 853
	[Token(Token = "0x2000355")]
	internal struct ReceivePacketOptionsInternal : ISettable<ReceivePacketOptions>, IDisposable
	{
		// Token: 0x17000638 RID: 1592
		// (set) Token: 0x060016EE RID: 5870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000638")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60016EE")]
			[Address(RVA = "0x51F070", Offset = "0x51D670", VA = "0x18051F070")]
			set
			{
			}
		}

		// Token: 0x17000639 RID: 1593
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000639")]
		public uint MaxDataSizeBytes
		{
			[Token(Token = "0x60016EF")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x1700063A RID: 1594
		// (set) Token: 0x060016F0 RID: 5872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700063A")]
		public byte? RequestedChannel
		{
			[Token(Token = "0x60016F0")]
			[Address(RVA = "0x51F0D0", Offset = "0x51D6D0", VA = "0x18051F0D0")]
			set
			{
			}
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016F1")]
		[Address(RVA = "0x51EF90", Offset = "0x51D590", VA = "0x18051EF90", Slot = "4")]
		public void Set(ref ReceivePacketOptions other)
		{
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016F2")]
		[Address(RVA = "0x51EE90", Offset = "0x51D490", VA = "0x18051EE90", Slot = "5")]
		public void Set(ref ReceivePacketOptions? other)
		{
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016F3")]
		[Address(RVA = "0x51EE30", Offset = "0x51D430", VA = "0x18051EE30", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000A2B RID: 2603
		[Token(Token = "0x4000A2B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000A2C RID: 2604
		[Token(Token = "0x4000A2C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000A2D RID: 2605
		[Token(Token = "0x4000A2D")]
		[FieldOffset(Offset = "0x10")]
		private uint m_MaxDataSizeBytes;

		// Token: 0x04000A2E RID: 2606
		[Token(Token = "0x4000A2E")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_RequestedChannel;
	}
}
