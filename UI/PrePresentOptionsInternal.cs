using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UI
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	internal struct PrePresentOptionsInternal : ISettable<PrePresentOptions>, IDisposable
	{
		// Token: 0x170000BE RID: 190
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000BE")]
		public IntPtr PlatformSpecificData
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x4ACEA0", Offset = "0x4AB4A0", VA = "0x1804ACEA0", Slot = "4")]
		public void Set(ref PrePresentOptions other)
		{
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x4ACE30", Offset = "0x4AB430", VA = "0x1804ACE30", Slot = "5")]
		public void Set(ref PrePresentOptions? other)
		{
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x4ACDA0", Offset = "0x4AB3A0", VA = "0x1804ACDA0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PlatformSpecificData;
	}
}
