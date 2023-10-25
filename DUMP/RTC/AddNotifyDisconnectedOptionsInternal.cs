using System;


namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000258 RID: 600
	[Token(Token = "0x2000258")]
	internal struct AddNotifyDisconnectedOptionsInternal : ISettable<AddNotifyDisconnectedOptions>, IDisposable
	{
		// Token: 0x1700042E RID: 1070
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700042E")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600108E")]
			[Address(RVA = "0x4D3BD0", Offset = "0x4D21D0", VA = "0x1804D3BD0")]
			set
			{
			}
		}

		// Token: 0x1700042F RID: 1071
		// (set) Token: 0x0600108F RID: 4239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700042F")]
		public Utf8String RoomName
		{
			[Token(Token = "0x600108F")]
			[Address(RVA = "0x4D3C30", Offset = "0x4D2230", VA = "0x1804D3C30")]
			set
			{
			}
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001090")]
		[Address(RVA = "0x4D3B10", Offset = "0x4D2110", VA = "0x1804D3B10", Slot = "4")]
		public void Set(ref AddNotifyDisconnectedOptions other)
		{
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001091")]
		[Address(RVA = "0x4D3A00", Offset = "0x4D2000", VA = "0x1804D3A00", Slot = "5")]
		public void Set(ref AddNotifyDisconnectedOptions? other)
		{
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001092")]
		[Address(RVA = "0x4D39A0", Offset = "0x4D1FA0", VA = "0x1804D39A0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400075E RID: 1886
		[Token(Token = "0x400075E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400075F RID: 1887
		[Token(Token = "0x400075F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000760 RID: 1888
		[Token(Token = "0x4000760")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;
	}
}
