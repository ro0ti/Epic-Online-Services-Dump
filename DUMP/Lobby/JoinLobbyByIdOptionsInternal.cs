using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003D0 RID: 976
	[Token(Token = "0x20003D0")]
	internal struct JoinLobbyByIdOptionsInternal : ISettable<JoinLobbyByIdOptions>, IDisposable
	{
		// Token: 0x1700073E RID: 1854
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700073E")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x60019BB")]
			[Address(RVA = "0x50ECC0", Offset = "0x50D2C0", VA = "0x18050ECC0")]
			set
			{
			}
		}

		// Token: 0x1700073F RID: 1855
		// (set) Token: 0x060019BC RID: 6588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700073F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60019BC")]
			[Address(RVA = "0x50ED90", Offset = "0x50D390", VA = "0x18050ED90")]
			set
			{
			}
		}

		// Token: 0x17000740 RID: 1856
		// (set) Token: 0x060019BD RID: 6589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000740")]
		public bool PresenceEnabled
		{
			[Token(Token = "0x60019BD")]
			[Address(RVA = "0x50EDF0", Offset = "0x50D3F0", VA = "0x18050EDF0")]
			set
			{
			}
		}

		// Token: 0x17000741 RID: 1857
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000741")]
		public LocalRTCOptions? LocalRTCOptions
		{
			[Token(Token = "0x60019BE")]
			[Address(RVA = "0x50ED20", Offset = "0x50D320", VA = "0x18050ED20")]
			set
			{
			}
		}

		// Token: 0x17000742 RID: 1858
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000742")]
		public bool CrossplayOptOut
		{
			[Token(Token = "0x60019BF")]
			[Address(RVA = "0x50EC60", Offset = "0x50D260", VA = "0x18050EC60")]
			set
			{
			}
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019C0")]
		[Address(RVA = "0x50E880", Offset = "0x50CE80", VA = "0x18050E880", Slot = "4")]
		public void Set(ref JoinLobbyByIdOptions other)
		{
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019C1")]
		[Address(RVA = "0x50EA30", Offset = "0x50D030", VA = "0x18050EA30", Slot = "5")]
		public void Set(ref JoinLobbyByIdOptions? other)
		{
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019C2")]
		[Address(RVA = "0x50E810", Offset = "0x50CE10", VA = "0x18050E810", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B97 RID: 2967
		[Token(Token = "0x4000B97")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B98 RID: 2968
		[Token(Token = "0x4000B98")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyId;

		// Token: 0x04000B99 RID: 2969
		[Token(Token = "0x4000B99")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000B9A RID: 2970
		[Token(Token = "0x4000B9A")]
		[FieldOffset(Offset = "0x18")]
		private int m_PresenceEnabled;

		// Token: 0x04000B9B RID: 2971
		[Token(Token = "0x4000B9B")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_LocalRTCOptions;

		// Token: 0x04000B9C RID: 2972
		[Token(Token = "0x4000B9C")]
		[FieldOffset(Offset = "0x28")]
		private int m_CrossplayOptOut;
	}
}
