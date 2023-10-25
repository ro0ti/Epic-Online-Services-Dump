using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200035A RID: 858
	[Token(Token = "0x200035A")]
	internal struct SetPacketQueueSizeOptionsInternal : ISettable<SetPacketQueueSizeOptions>, IDisposable
	{
		// Token: 0x1700064D RID: 1613
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700064D")]
		public ulong IncomingPacketQueueMaxSizeBytes
		{
			[Token(Token = "0x6001713")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x1700064E RID: 1614
		// (set) Token: 0x06001714 RID: 5908 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700064E")]
		public ulong OutgoingPacketQueueMaxSizeBytes
		{
			[Token(Token = "0x6001714")]
			[Address(RVA = "0x4A6940", Offset = "0x4A4F40", VA = "0x1804A6940")]
			set
			{
			}
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001715")]
		[Address(RVA = "0x51FA10", Offset = "0x51E010", VA = "0x18051FA10", Slot = "4")]
		public void Set(ref SetPacketQueueSizeOptions other)
		{
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001716")]
		[Address(RVA = "0x51F980", Offset = "0x51DF80", VA = "0x18051F980", Slot = "5")]
		public void Set(ref SetPacketQueueSizeOptions? other)
		{
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001717")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000A47 RID: 2631
		[Token(Token = "0x4000A47")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000A48 RID: 2632
		[Token(Token = "0x4000A48")]
		[FieldOffset(Offset = "0x8")]
		private ulong m_IncomingPacketQueueMaxSizeBytes;

		// Token: 0x04000A49 RID: 2633
		[Token(Token = "0x4000A49")]
		[FieldOffset(Offset = "0x10")]
		private ulong m_OutgoingPacketQueueMaxSizeBytes;
	}
}
