using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTC
{
	// Token: 0x0200025A RID: 602
	[Token(Token = "0x200025A")]
	internal struct AddNotifyParticipantStatusChangedOptionsInternal : ISettable<AddNotifyParticipantStatusChangedOptions>, IDisposable
	{
		// Token: 0x17000432 RID: 1074
		// (set) Token: 0x06001097 RID: 4247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000432")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001097")]
			[Address(RVA = "0x4D3EC0", Offset = "0x4D24C0", VA = "0x1804D3EC0")]
			set
			{
			}
		}

		// Token: 0x17000433 RID: 1075
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000433")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6001098")]
			[Address(RVA = "0x4D3F20", Offset = "0x4D2520", VA = "0x1804D3F20")]
			set
			{
			}
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001099")]
		[Address(RVA = "0x4D3CF0", Offset = "0x4D22F0", VA = "0x1804D3CF0", Slot = "4")]
		public void Set(ref AddNotifyParticipantStatusChangedOptions other)
		{
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600109A")]
		[Address(RVA = "0x4D3DB0", Offset = "0x4D23B0", VA = "0x1804D3DB0", Slot = "5")]
		public void Set(ref AddNotifyParticipantStatusChangedOptions? other)
		{
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600109B")]
		[Address(RVA = "0x4D3C90", Offset = "0x4D2290", VA = "0x1804D3C90", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000763 RID: 1891
		[Token(Token = "0x4000763")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000764 RID: 1892
		[Token(Token = "0x4000764")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000765 RID: 1893
		[Token(Token = "0x4000765")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;
	}
}
