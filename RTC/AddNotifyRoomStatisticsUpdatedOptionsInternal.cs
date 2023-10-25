using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTC
{
	// Token: 0x0200025C RID: 604
	[Token(Token = "0x200025C")]
	internal struct AddNotifyRoomStatisticsUpdatedOptionsInternal : ISettable<AddNotifyRoomStatisticsUpdatedOptions>, IDisposable
	{
		// Token: 0x17000436 RID: 1078
		// (set) Token: 0x060010A0 RID: 4256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000436")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60010A0")]
			[Address(RVA = "0x4D44A0", Offset = "0x4D2AA0", VA = "0x1804D44A0")]
			set
			{
			}
		}

		// Token: 0x17000437 RID: 1079
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000437")]
		public Utf8String RoomName
		{
			[Token(Token = "0x60010A1")]
			[Address(RVA = "0x4D4500", Offset = "0x4D2B00", VA = "0x1804D4500")]
			set
			{
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x4D42D0", Offset = "0x4D28D0", VA = "0x1804D42D0", Slot = "4")]
		public void Set(ref AddNotifyRoomStatisticsUpdatedOptions other)
		{
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010A3")]
		[Address(RVA = "0x4D4390", Offset = "0x4D2990", VA = "0x1804D4390", Slot = "5")]
		public void Set(ref AddNotifyRoomStatisticsUpdatedOptions? other)
		{
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010A4")]
		[Address(RVA = "0x4D4270", Offset = "0x4D2870", VA = "0x1804D4270", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000769 RID: 1897
		[Token(Token = "0x4000769")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400076A RID: 1898
		[Token(Token = "0x400076A")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;
	}
}
