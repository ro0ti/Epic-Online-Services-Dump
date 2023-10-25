using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200035E RID: 862
	[Token(Token = "0x200035E")]
	internal struct SetRelayControlOptionsInternal : ISettable<SetRelayControlOptions>, IDisposable
	{
		// Token: 0x17000654 RID: 1620
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000654")]
		public RelayControl RelayControl
		{
			[Token(Token = "0x6001723")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001724")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref SetRelayControlOptions other)
		{
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001725")]
		[Address(RVA = "0x51FB30", Offset = "0x51E130", VA = "0x18051FB30", Slot = "5")]
		public void Set(ref SetRelayControlOptions? other)
		{
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001726")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000A50 RID: 2640
		[Token(Token = "0x4000A50")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000A51 RID: 2641
		[Token(Token = "0x4000A51")]
		[FieldOffset(Offset = "0x4")]
		private RelayControl m_RelayControl;
	}
}
