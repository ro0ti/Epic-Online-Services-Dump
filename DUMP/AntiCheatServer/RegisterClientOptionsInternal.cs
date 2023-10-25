using System;
using Epic.OnlineServices.AntiCheatCommon;


namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x020006AB RID: 1707
	[Token(Token = "0x20006AB")]
	internal struct RegisterClientOptionsInternal : ISettable<RegisterClientOptions>, IDisposable
	{
		// Token: 0x17000CD0 RID: 3280
		// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CD0")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002BD7")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (set) Token: 0x06002BD8 RID: 11224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CD1")]
		public AntiCheatCommonClientType ClientType
		{
			[Token(Token = "0x6002BD8")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CD2")]
		public AntiCheatCommonClientPlatform ClientPlatform
		{
			[Token(Token = "0x6002BD9")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			set
			{
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (set) Token: 0x06002BDA RID: 11226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CD3")]
		public Utf8String AccountId_DEPRECATED
		{
			[Token(Token = "0x6002BDA")]
			[Address(RVA = "0x57E050", Offset = "0x57C650", VA = "0x18057E050")]
			set
			{
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (set) Token: 0x06002BDB RID: 11227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CD4")]
		public Utf8String IpAddress
		{
			[Token(Token = "0x6002BDB")]
			[Address(RVA = "0x57E0B0", Offset = "0x57C6B0", VA = "0x18057E0B0")]
			set
			{
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (set) Token: 0x06002BDC RID: 11228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CD5")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6002BDC")]
			[Address(RVA = "0x57E110", Offset = "0x57C710", VA = "0x18057E110")]
			set
			{
			}
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BDD")]
		[Address(RVA = "0x57DF30", Offset = "0x57C530", VA = "0x18057DF30", Slot = "4")]
		public void Set(ref RegisterClientOptions other)
		{
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BDE")]
		[Address(RVA = "0x57DD70", Offset = "0x57C370", VA = "0x18057DD70", Slot = "5")]
		public void Set(ref RegisterClientOptions? other)
		{
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BDF")]
		[Address(RVA = "0x57DCF0", Offset = "0x57C2F0", VA = "0x18057DCF0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001302 RID: 4866
		[Token(Token = "0x4001302")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001303 RID: 4867
		[Token(Token = "0x4001303")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientHandle;

		// Token: 0x04001304 RID: 4868
		[Token(Token = "0x4001304")]
		[FieldOffset(Offset = "0x10")]
		private AntiCheatCommonClientType m_ClientType;

		// Token: 0x04001305 RID: 4869
		[Token(Token = "0x4001305")]
		[FieldOffset(Offset = "0x14")]
		private AntiCheatCommonClientPlatform m_ClientPlatform;

		// Token: 0x04001306 RID: 4870
		[Token(Token = "0x4001306")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_AccountId_DEPRECATED;

		// Token: 0x04001307 RID: 4871
		[Token(Token = "0x4001307")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_IpAddress;

		// Token: 0x04001308 RID: 4872
		[Token(Token = "0x4001308")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_UserId;
	}
}
