using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Mods
{
	// Token: 0x0200036A RID: 874
	[Token(Token = "0x200036A")]
	internal struct InstallModOptionsInternal : ISettable<InstallModOptions>, IDisposable
	{
		// Token: 0x17000674 RID: 1652
		// (set) Token: 0x06001776 RID: 6006 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000674")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001776")]
			[Address(RVA = "0x50D9A0", Offset = "0x50BFA0", VA = "0x18050D9A0")]
			set
			{
			}
		}

		// Token: 0x17000675 RID: 1653
		// (set) Token: 0x06001777 RID: 6007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000675")]
		public ModIdentifier? Mod
		{
			[Token(Token = "0x6001777")]
			[Address(RVA = "0x50DA00", Offset = "0x50C000", VA = "0x18050DA00")]
			set
			{
			}
		}

		// Token: 0x17000676 RID: 1654
		// (set) Token: 0x06001778 RID: 6008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000676")]
		public bool RemoveAfterExit
		{
			[Token(Token = "0x6001778")]
			[Address(RVA = "0x50DA70", Offset = "0x50C070", VA = "0x18050DA70")]
			set
			{
			}
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001779")]
		[Address(RVA = "0x50D870", Offset = "0x50BE70", VA = "0x18050D870", Slot = "4")]
		public void Set(ref InstallModOptions other)
		{
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600177A")]
		[Address(RVA = "0x50D6D0", Offset = "0x50BCD0", VA = "0x18050D6D0", Slot = "5")]
		public void Set(ref InstallModOptions? other)
		{
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600177B")]
		[Address(RVA = "0x50D670", Offset = "0x50BC70", VA = "0x18050D670", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000A72 RID: 2674
		[Token(Token = "0x4000A72")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000A73 RID: 2675
		[Token(Token = "0x4000A73")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000A74 RID: 2676
		[Token(Token = "0x4000A74")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Mod;

		// Token: 0x04000A75 RID: 2677
		[Token(Token = "0x4000A75")]
		[FieldOffset(Offset = "0x18")]
		private int m_RemoveAfterExit;
	}
}
