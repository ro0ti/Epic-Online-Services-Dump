using System;
using Epic.OnlineServices.AntiCheatCommon;


namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x02000718 RID: 1816
	[Token(Token = "0x2000718")]
	internal struct RegisterPeerOptionsInternal : ISettable<RegisterPeerOptions>, IDisposable
	{
		// Token: 0x17000DB9 RID: 3513
		// (set) Token: 0x06002E3F RID: 11839 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DB9")]
		public IntPtr PeerHandle
		{
			[Token(Token = "0x6002E3F")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (set) Token: 0x06002E40 RID: 11840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DBA")]
		public AntiCheatCommonClientType ClientType
		{
			[Token(Token = "0x6002E40")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (set) Token: 0x06002E41 RID: 11841 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DBB")]
		public AntiCheatCommonClientPlatform ClientPlatform
		{
			[Token(Token = "0x6002E41")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			set
			{
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (set) Token: 0x06002E42 RID: 11842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DBC")]
		public uint AuthenticationTimeout
		{
			[Token(Token = "0x6002E42")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (set) Token: 0x06002E43 RID: 11843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DBD")]
		public Utf8String AccountId_DEPRECATED
		{
			[Token(Token = "0x6002E43")]
			[Address(RVA = "0x57EAE0", Offset = "0x57D0E0", VA = "0x18057EAE0")]
			set
			{
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (set) Token: 0x06002E44 RID: 11844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DBE")]
		public Utf8String IpAddress
		{
			[Token(Token = "0x6002E44")]
			[Address(RVA = "0x57EB40", Offset = "0x57D140", VA = "0x18057EB40")]
			set
			{
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (set) Token: 0x06002E45 RID: 11845 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DBF")]
		public ProductUserId PeerProductUserId
		{
			[Token(Token = "0x6002E45")]
			[Address(RVA = "0x57EBA0", Offset = "0x57D1A0", VA = "0x18057EBA0")]
			set
			{
			}
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E46")]
		[Address(RVA = "0x57E9C0", Offset = "0x57CFC0", VA = "0x18057E9C0", Slot = "4")]
		public void Set(ref RegisterPeerOptions other)
		{
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E47")]
		[Address(RVA = "0x57E7E0", Offset = "0x57CDE0", VA = "0x18057E7E0", Slot = "5")]
		public void Set(ref RegisterPeerOptions? other)
		{
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E48")]
		[Address(RVA = "0x57E760", Offset = "0x57CD60", VA = "0x18057E760", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001494 RID: 5268
		[Token(Token = "0x4001494")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001495 RID: 5269
		[Token(Token = "0x4001495")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PeerHandle;

		// Token: 0x04001496 RID: 5270
		[Token(Token = "0x4001496")]
		[FieldOffset(Offset = "0x10")]
		private AntiCheatCommonClientType m_ClientType;

		// Token: 0x04001497 RID: 5271
		[Token(Token = "0x4001497")]
		[FieldOffset(Offset = "0x14")]
		private AntiCheatCommonClientPlatform m_ClientPlatform;

		// Token: 0x04001498 RID: 5272
		[Token(Token = "0x4001498")]
		[FieldOffset(Offset = "0x18")]
		private uint m_AuthenticationTimeout;

		// Token: 0x04001499 RID: 5273
		[Token(Token = "0x4001499")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_AccountId_DEPRECATED;

		// Token: 0x0400149A RID: 5274
		[Token(Token = "0x400149A")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_IpAddress;

		// Token: 0x0400149B RID: 5275
		[Token(Token = "0x400149B")]
		[FieldOffset(Offset = "0x30")]
		private IntPtr m_PeerProductUserId;
	}
}
