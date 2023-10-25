using System;


namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x020006FC RID: 1788
	[Token(Token = "0x20006FC")]
	internal struct BeginSessionOptionsInternal : ISettable<BeginSessionOptions>, IDisposable
	{
		// Token: 0x17000D96 RID: 3478
		// (set) Token: 0x06002DBB RID: 11707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D96")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002DBB")]
			[Address(RVA = "0x56FCA0", Offset = "0x56E2A0", VA = "0x18056FCA0")]
			set
			{
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (set) Token: 0x06002DBC RID: 11708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D97")]
		public AntiCheatClientMode Mode
		{
			[Token(Token = "0x6002DBC")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DBD")]
		[Address(RVA = "0x56F860", Offset = "0x56DE60", VA = "0x18056F860", Slot = "4")]
		public void Set(ref BeginSessionOptions other)
		{
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DBE")]
		[Address(RVA = "0x56FB70", Offset = "0x56E170", VA = "0x18056FB70", Slot = "5")]
		public void Set(ref BeginSessionOptions? other)
		{
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DBF")]
		[Address(RVA = "0x56F7B0", Offset = "0x56DDB0", VA = "0x18056F7B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001468 RID: 5224
		[Token(Token = "0x4001468")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001469 RID: 5225
		[Token(Token = "0x4001469")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400146A RID: 5226
		[Token(Token = "0x400146A")]
		[FieldOffset(Offset = "0x10")]
		private AntiCheatClientMode m_Mode;
	}
}
