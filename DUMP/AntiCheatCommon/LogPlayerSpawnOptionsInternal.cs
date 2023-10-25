using System;


namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006CF RID: 1743
	[Token(Token = "0x20006CF")]
	internal struct LogPlayerSpawnOptionsInternal : ISettable<LogPlayerSpawnOptions>, IDisposable
	{
		// Token: 0x17000D0E RID: 3342
		// (set) Token: 0x06002C6B RID: 11371 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D0E")]
		public IntPtr SpawnedPlayerHandle
		{
			[Token(Token = "0x6002C6B")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (set) Token: 0x06002C6C RID: 11372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D0F")]
		public uint TeamId
		{
			[Token(Token = "0x6002C6C")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (set) Token: 0x06002C6D RID: 11373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D10")]
		public uint CharacterId
		{
			[Token(Token = "0x6002C6D")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			set
			{
			}
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C6E")]
		[Address(RVA = "0x574F80", Offset = "0x573580", VA = "0x180574F80", Slot = "4")]
		public void Set(ref LogPlayerSpawnOptions other)
		{
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C6F")]
		[Address(RVA = "0x574ED0", Offset = "0x5734D0", VA = "0x180574ED0", Slot = "5")]
		public void Set(ref LogPlayerSpawnOptions? other)
		{
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C70")]
		[Address(RVA = "0x574E80", Offset = "0x573480", VA = "0x180574E80", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040013AB RID: 5035
		[Token(Token = "0x40013AB")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040013AC RID: 5036
		[Token(Token = "0x40013AC")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SpawnedPlayerHandle;

		// Token: 0x040013AD RID: 5037
		[Token(Token = "0x40013AD")]
		[FieldOffset(Offset = "0x10")]
		private uint m_TeamId;

		// Token: 0x040013AE RID: 5038
		[Token(Token = "0x40013AE")]
		[FieldOffset(Offset = "0x14")]
		private uint m_CharacterId;
	}
}
