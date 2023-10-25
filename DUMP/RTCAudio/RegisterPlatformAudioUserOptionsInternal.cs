using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000215 RID: 533
	[Token(Token = "0x2000215")]
	internal struct RegisterPlatformAudioUserOptionsInternal : ISettable<RegisterPlatformAudioUserOptions>, IDisposable
	{
		// Token: 0x17000375 RID: 885
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000375")]
		public Utf8String UserId
		{
			[Token(Token = "0x6000E8E")]
			[Address(RVA = "0x4E44D0", Offset = "0x4E2AD0", VA = "0x1804E44D0")]
			set
			{
			}
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x4E43D0", Offset = "0x4E29D0", VA = "0x1804E43D0", Slot = "4")]
		public void Set(ref RegisterPlatformAudioUserOptions other)
		{
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x4E4430", Offset = "0x4E2A30", VA = "0x1804E4430", Slot = "5")]
		public void Set(ref RegisterPlatformAudioUserOptions? other)
		{
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x4E4380", Offset = "0x4E2980", VA = "0x1804E4380", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000660 RID: 1632
		[Token(Token = "0x4000660")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;
	}
}
