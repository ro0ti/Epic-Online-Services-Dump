using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003D4 RID: 980
	[Token(Token = "0x20003D4")]
	internal struct JoinLobbyOptionsInternal : ISettable<JoinLobbyOptions>, IDisposable
	{
		// Token: 0x1700074F RID: 1871
		// (set) Token: 0x060019E0 RID: 6624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700074F")]
		public LobbyDetails LobbyDetailsHandle
		{
			[Token(Token = "0x60019E0")]
			[Address(RVA = "0x50F870", Offset = "0x50DE70", VA = "0x18050F870")]
			set
			{
			}
		}

		// Token: 0x17000750 RID: 1872
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000750")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60019E1")]
			[Address(RVA = "0x50F940", Offset = "0x50DF40", VA = "0x18050F940")]
			set
			{
			}
		}

		// Token: 0x17000751 RID: 1873
		// (set) Token: 0x060019E2 RID: 6626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000751")]
		public bool PresenceEnabled
		{
			[Token(Token = "0x60019E2")]
			[Address(RVA = "0x50F9A0", Offset = "0x50DFA0", VA = "0x18050F9A0")]
			set
			{
			}
		}

		// Token: 0x17000752 RID: 1874
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000752")]
		public LocalRTCOptions? LocalRTCOptions
		{
			[Token(Token = "0x60019E3")]
			[Address(RVA = "0x50F8D0", Offset = "0x50DED0", VA = "0x18050F8D0")]
			set
			{
			}
		}

		// Token: 0x17000753 RID: 1875
		// (set) Token: 0x060019E4 RID: 6628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000753")]
		public bool CrossplayOptOut
		{
			[Token(Token = "0x60019E4")]
			[Address(RVA = "0x50F810", Offset = "0x50DE10", VA = "0x18050F810")]
			set
			{
			}
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019E5")]
		[Address(RVA = "0x50F660", Offset = "0x50DC60", VA = "0x18050F660", Slot = "4")]
		public void Set(ref JoinLobbyOptions other)
		{
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019E6")]
		[Address(RVA = "0x50F430", Offset = "0x50DA30", VA = "0x18050F430", Slot = "5")]
		public void Set(ref JoinLobbyOptions? other)
		{
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019E7")]
		[Address(RVA = "0x50F3C0", Offset = "0x50D9C0", VA = "0x18050F3C0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000BA8 RID: 2984
		[Token(Token = "0x4000BA8")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000BA9 RID: 2985
		[Token(Token = "0x4000BA9")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyDetailsHandle;

		// Token: 0x04000BAA RID: 2986
		[Token(Token = "0x4000BAA")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000BAB RID: 2987
		[Token(Token = "0x4000BAB")]
		[FieldOffset(Offset = "0x18")]
		private int m_PresenceEnabled;

		// Token: 0x04000BAC RID: 2988
		[Token(Token = "0x4000BAC")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_LocalRTCOptions;

		// Token: 0x04000BAD RID: 2989
		[Token(Token = "0x4000BAD")]
		[FieldOffset(Offset = "0x28")]
		private int m_CrossplayOptOut;
	}
}
