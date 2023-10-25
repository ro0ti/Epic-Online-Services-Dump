using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000227 RID: 551
	[Token(Token = "0x2000227")]
	internal struct UnregisterPlatformAudioUserOptionsInternal : ISettable<UnregisterPlatformAudioUserOptions>, IDisposable
	{
		// Token: 0x17000397 RID: 919
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000397")]
		public Utf8String UserId
		{
			[Token(Token = "0x6000F0D")]
			[Address(RVA = "0x4E6B90", Offset = "0x4E5190", VA = "0x1804E6B90")]
			set
			{
			}
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x4E6B30", Offset = "0x4E5130", VA = "0x1804E6B30", Slot = "4")]
		public void Set(ref UnregisterPlatformAudioUserOptions other)
		{
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x4E6A90", Offset = "0x4E5090", VA = "0x1804E6A90", Slot = "5")]
		public void Set(ref UnregisterPlatformAudioUserOptions? other)
		{
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x4E6A40", Offset = "0x4E5040", VA = "0x1804E6A40", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040006BB RID: 1723
		[Token(Token = "0x40006BB")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040006BC RID: 1724
		[Token(Token = "0x40006BC")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;
	}
}
