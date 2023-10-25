using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001B3 RID: 435
	[Token(Token = "0x20001B3")]
	internal struct AddNotifyAudioBeforeSendOptionsInternal : ISettable<AddNotifyAudioBeforeSendOptions>, IDisposable
	{
		// Token: 0x170002E4 RID: 740
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002E4")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000C6E")]
			[Address(RVA = "0x4D32B0", Offset = "0x4D18B0", VA = "0x1804D32B0")]
			set
			{
			}
		}

		// Token: 0x170002E5 RID: 741
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002E5")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000C6F")]
			[Address(RVA = "0x4D3310", Offset = "0x4D1910", VA = "0x1804D3310")]
			set
			{
			}
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x4D30E0", Offset = "0x4D16E0", VA = "0x1804D30E0", Slot = "4")]
		public void Set(ref AddNotifyAudioBeforeSendOptions other)
		{
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x4D31A0", Offset = "0x4D17A0", VA = "0x1804D31A0", Slot = "5")]
		public void Set(ref AddNotifyAudioBeforeSendOptions? other)
		{
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x4D3080", Offset = "0x4D1680", VA = "0x1804D3080", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040005C5 RID: 1477
		[Token(Token = "0x40005C5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;
	}
}
