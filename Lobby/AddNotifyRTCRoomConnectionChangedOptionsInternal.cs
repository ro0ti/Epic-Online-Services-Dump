using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003A4 RID: 932
	[Token(Token = "0x20003A4")]
	internal struct AddNotifyRTCRoomConnectionChangedOptionsInternal : ISettable<AddNotifyRTCRoomConnectionChangedOptions>, IDisposable
	{
		// Token: 0x170006BD RID: 1725
		// (set) Token: 0x06001886 RID: 6278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006BD")]
		public Utf8String LobbyId_DEPRECATED
		{
			[Token(Token = "0x6001886")]
			[Address(RVA = "0x505660", Offset = "0x503C60", VA = "0x180505660")]
			set
			{
			}
		}

		// Token: 0x170006BE RID: 1726
		// (set) Token: 0x06001887 RID: 6279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006BE")]
		public ProductUserId LocalUserId_DEPRECATED
		{
			[Token(Token = "0x6001887")]
			[Address(RVA = "0x5056C0", Offset = "0x503CC0", VA = "0x1805056C0")]
			set
			{
			}
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001888")]
		[Address(RVA = "0x5055A0", Offset = "0x503BA0", VA = "0x1805055A0", Slot = "4")]
		public void Set(ref AddNotifyRTCRoomConnectionChangedOptions other)
		{
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001889")]
		[Address(RVA = "0x505490", Offset = "0x503A90", VA = "0x180505490", Slot = "5")]
		public void Set(ref AddNotifyRTCRoomConnectionChangedOptions? other)
		{
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600188A")]
		[Address(RVA = "0x505430", Offset = "0x503A30", VA = "0x180505430", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B09 RID: 2825
		[Token(Token = "0x4000B09")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B0A RID: 2826
		[Token(Token = "0x4000B0A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyId_DEPRECATED;

		// Token: 0x04000B0B RID: 2827
		[Token(Token = "0x4000B0B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId_DEPRECATED;
	}
}
