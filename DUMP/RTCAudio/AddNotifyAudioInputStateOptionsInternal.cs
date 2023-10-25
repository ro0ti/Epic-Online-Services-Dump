using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001B7 RID: 439
	[Token(Token = "0x20001B7")]
	internal struct AddNotifyAudioInputStateOptionsInternal : ISettable<AddNotifyAudioInputStateOptions>, IDisposable
	{
		// Token: 0x170002E8 RID: 744
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002E8")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000C7A")]
			[Address(RVA = "0x4D35F0", Offset = "0x4D1BF0", VA = "0x1804D35F0")]
			set
			{
			}
		}

		// Token: 0x170002E9 RID: 745
		// (set) Token: 0x06000C7B RID: 3195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002E9")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000C7B")]
			[Address(RVA = "0x4D3650", Offset = "0x4D1C50", VA = "0x1804D3650")]
			set
			{
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x4D3420", Offset = "0x4D1A20", VA = "0x1804D3420", Slot = "4")]
		public void Set(ref AddNotifyAudioInputStateOptions other)
		{
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x4D34E0", Offset = "0x4D1AE0", VA = "0x1804D34E0", Slot = "5")]
		public void Set(ref AddNotifyAudioInputStateOptions? other)
		{
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x4D33C0", Offset = "0x4D19C0", VA = "0x1804D33C0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;
	}
}
