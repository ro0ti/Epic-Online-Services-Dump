using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000229 RID: 553
	[Token(Token = "0x2000229")]
	internal struct UnregisterPlatformUserOptionsInternal : ISettable<UnregisterPlatformUserOptions>, IDisposable
	{
		// Token: 0x17000399 RID: 921
		// (set) Token: 0x06000F13 RID: 3859 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000399")]
		public Utf8String PlatformUserId
		{
			[Token(Token = "0x6000F13")]
			[Address(RVA = "0x4E6D40", Offset = "0x4E5340", VA = "0x1804E6D40")]
			set
			{
			}
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F14")]
		[Address(RVA = "0x4E6CE0", Offset = "0x4E52E0", VA = "0x1804E6CE0", Slot = "4")]
		public void Set(ref UnregisterPlatformUserOptions other)
		{
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F15")]
		[Address(RVA = "0x4E6C40", Offset = "0x4E5240", VA = "0x1804E6C40", Slot = "5")]
		public void Set(ref UnregisterPlatformUserOptions? other)
		{
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F16")]
		[Address(RVA = "0x4E6BF0", Offset = "0x4E51F0", VA = "0x1804E6BF0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040006BE RID: 1726
		[Token(Token = "0x40006BE")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040006BF RID: 1727
		[Token(Token = "0x40006BF")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PlatformUserId;
	}
}
