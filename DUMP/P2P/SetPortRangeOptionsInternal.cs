using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200035C RID: 860
	[Token(Token = "0x200035C")]
	internal struct SetPortRangeOptionsInternal : ISettable<SetPortRangeOptions>, IDisposable
	{
		// Token: 0x17000651 RID: 1617
		// (set) Token: 0x0600171C RID: 5916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000651")]
		public ushort Port
		{
			[Token(Token = "0x600171C")]
			[Address(RVA = "0x51FAE0", Offset = "0x51E0E0", VA = "0x18051FAE0")]
			set
			{
			}
		}

		// Token: 0x17000652 RID: 1618
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000652")]
		public ushort MaxAdditionalPortsToTry
		{
			[Token(Token = "0x600171D")]
			[Address(RVA = "0x51FAD0", Offset = "0x51E0D0", VA = "0x18051FAD0")]
			set
			{
			}
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600171E")]
		[Address(RVA = "0x51FAB0", Offset = "0x51E0B0", VA = "0x18051FAB0", Slot = "4")]
		public void Set(ref SetPortRangeOptions other)
		{
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600171F")]
		[Address(RVA = "0x51FA30", Offset = "0x51E030", VA = "0x18051FA30", Slot = "5")]
		public void Set(ref SetPortRangeOptions? other)
		{
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001720")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000A4C RID: 2636
		[Token(Token = "0x4000A4C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000A4D RID: 2637
		[Token(Token = "0x4000A4D")]
		[FieldOffset(Offset = "0x4")]
		private ushort m_Port;

		// Token: 0x04000A4E RID: 2638
		[Token(Token = "0x4000A4E")]
		[FieldOffset(Offset = "0x6")]
		private ushort m_MaxAdditionalPortsToTry;
	}
}
