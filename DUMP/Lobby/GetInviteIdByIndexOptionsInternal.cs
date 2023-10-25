using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003C2 RID: 962
	[Token(Token = "0x20003C2")]
	internal struct GetInviteIdByIndexOptionsInternal : ISettable<GetInviteIdByIndexOptions>, IDisposable
	{
		// Token: 0x17000710 RID: 1808
		// (set) Token: 0x0600194E RID: 6478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000710")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600194E")]
			[Address(RVA = "0x50BF30", Offset = "0x50A530", VA = "0x18050BF30")]
			set
			{
			}
		}

		// Token: 0x17000711 RID: 1809
		// (set) Token: 0x0600194F RID: 6479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000711")]
		public uint Index
		{
			[Token(Token = "0x600194F")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001950")]
		[Address(RVA = "0x50BEB0", Offset = "0x50A4B0", VA = "0x18050BEB0", Slot = "4")]
		public void Set(ref GetInviteIdByIndexOptions other)
		{
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001951")]
		[Address(RVA = "0x50BDE0", Offset = "0x50A3E0", VA = "0x18050BDE0", Slot = "5")]
		public void Set(ref GetInviteIdByIndexOptions? other)
		{
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001952")]
		[Address(RVA = "0x50BD90", Offset = "0x50A390", VA = "0x18050BD90", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B68 RID: 2920
		[Token(Token = "0x4000B68")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B69 RID: 2921
		[Token(Token = "0x4000B69")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000B6A RID: 2922
		[Token(Token = "0x4000B6A")]
		[FieldOffset(Offset = "0x10")]
		private uint m_Index;
	}
}
