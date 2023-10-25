using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000358 RID: 856
	[Token(Token = "0x2000358")]
	internal struct SendPacketOptionsInternal : ISettable<SendPacketOptions>, IDisposable
	{
		// Token: 0x17000643 RID: 1603
		// (set) Token: 0x06001704 RID: 5892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000643")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001704")]
			[Address(RVA = "0x51F810", Offset = "0x51DE10", VA = "0x18051F810")]
			set
			{
			}
		}

		// Token: 0x17000644 RID: 1604
		// (set) Token: 0x06001705 RID: 5893 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000644")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x6001705")]
			[Address(RVA = "0x51F870", Offset = "0x51DE70", VA = "0x18051F870")]
			set
			{
			}
		}

		// Token: 0x17000645 RID: 1605
		// (set) Token: 0x06001706 RID: 5894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000645")]
		public SocketId? SocketId
		{
			[Token(Token = "0x6001706")]
			[Address(RVA = "0x51F8D0", Offset = "0x51DED0", VA = "0x18051F8D0")]
			set
			{
			}
		}

		// Token: 0x17000646 RID: 1606
		// (set) Token: 0x06001707 RID: 5895 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000646")]
		public byte Channel
		{
			[Token(Token = "0x6001707")]
			[Address(RVA = "0x4BBEA0", Offset = "0x4BA4A0", VA = "0x1804BBEA0")]
			set
			{
			}
		}

		// Token: 0x17000647 RID: 1607
		// (set) Token: 0x06001708 RID: 5896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000647")]
		public ArraySegment<byte> Data
		{
			[Token(Token = "0x6001708")]
			[Address(RVA = "0x51F730", Offset = "0x51DD30", VA = "0x18051F730")]
			set
			{
			}
		}

		// Token: 0x17000648 RID: 1608
		// (set) Token: 0x06001709 RID: 5897 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000648")]
		public bool AllowDelayedDelivery
		{
			[Token(Token = "0x6001709")]
			[Address(RVA = "0x51F6D0", Offset = "0x51DCD0", VA = "0x18051F6D0")]
			set
			{
			}
		}

		// Token: 0x17000649 RID: 1609
		// (set) Token: 0x0600170A RID: 5898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000649")]
		public PacketReliability Reliability
		{
			[Token(Token = "0x600170A")]
			[Address(RVA = "0x3D76F0", Offset = "0x3D5CF0", VA = "0x1803D76F0")]
			set
			{
			}
		}

		// Token: 0x1700064A RID: 1610
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700064A")]
		public bool DisableAutoAcceptConnection
		{
			[Token(Token = "0x600170B")]
			[Address(RVA = "0x51F7B0", Offset = "0x51DDB0", VA = "0x18051F7B0")]
			set
			{
			}
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600170C")]
		[Address(RVA = "0x51F4C0", Offset = "0x51DAC0", VA = "0x18051F4C0", Slot = "4")]
		public void Set(ref SendPacketOptions other)
		{
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600170D")]
		[Address(RVA = "0x51F1E0", Offset = "0x51D7E0", VA = "0x18051F1E0", Slot = "5")]
		public void Set(ref SendPacketOptions? other)
		{
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600170E")]
		[Address(RVA = "0x51F160", Offset = "0x51D760", VA = "0x18051F160", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000A3B RID: 2619
		[Token(Token = "0x4000A3B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000A3C RID: 2620
		[Token(Token = "0x4000A3C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000A3D RID: 2621
		[Token(Token = "0x4000A3D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RemoteUserId;

		// Token: 0x04000A3E RID: 2622
		[Token(Token = "0x4000A3E")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_SocketId;

		// Token: 0x04000A3F RID: 2623
		[Token(Token = "0x4000A3F")]
		[FieldOffset(Offset = "0x20")]
		private byte m_Channel;

		// Token: 0x04000A40 RID: 2624
		[Token(Token = "0x4000A40")]
		[FieldOffset(Offset = "0x24")]
		private uint m_DataLengthBytes;

		// Token: 0x04000A41 RID: 2625
		[Token(Token = "0x4000A41")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_Data;

		// Token: 0x04000A42 RID: 2626
		[Token(Token = "0x4000A42")]
		[FieldOffset(Offset = "0x30")]
		private int m_AllowDelayedDelivery;

		// Token: 0x04000A43 RID: 2627
		[Token(Token = "0x4000A43")]
		[FieldOffset(Offset = "0x34")]
		private PacketReliability m_Reliability;

		// Token: 0x04000A44 RID: 2628
		[Token(Token = "0x4000A44")]
		[FieldOffset(Offset = "0x38")]
		private int m_DisableAutoAcceptConnection;
	}
}
