using System;


namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006CD RID: 1741
	[Token(Token = "0x20006CD")]
	internal struct LogPlayerReviveOptionsInternal : ISettable<LogPlayerReviveOptions>, IDisposable
	{
		// Token: 0x17000D09 RID: 3337
		// (set) Token: 0x06002C60 RID: 11360 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D09")]
		public IntPtr RevivedPlayerHandle
		{
			[Token(Token = "0x6002C60")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (set) Token: 0x06002C61 RID: 11361 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D0A")]
		public IntPtr ReviverPlayerHandle
		{
			[Token(Token = "0x6002C61")]
			[Address(RVA = "0x4A6940", Offset = "0x4A4F40", VA = "0x1804A6940")]
			set
			{
			}
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C62")]
		[Address(RVA = "0x51FA10", Offset = "0x51E010", VA = "0x18051FA10", Slot = "4")]
		public void Set(ref LogPlayerReviveOptions other)
		{
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C63")]
		[Address(RVA = "0x574DF0", Offset = "0x5733F0", VA = "0x180574DF0", Slot = "5")]
		public void Set(ref LogPlayerReviveOptions? other)
		{
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C64")]
		[Address(RVA = "0x574D90", Offset = "0x573390", VA = "0x180574D90", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040013A5 RID: 5029
		[Token(Token = "0x40013A5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040013A6 RID: 5030
		[Token(Token = "0x40013A6")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_RevivedPlayerHandle;

		// Token: 0x040013A7 RID: 5031
		[Token(Token = "0x40013A7")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ReviverPlayerHandle;
	}
}
