using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000172 RID: 370
	[Token(Token = "0x2000172")]
	internal struct SessionModificationSetAllowedPlatformIdsOptionsInternal : ISettable<SessionModificationSetAllowedPlatformIdsOptions>, IDisposable
	{
		// Token: 0x1700027E RID: 638
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700027E")]
		public uint[] AllowedPlatformIds
		{
			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x4CAF80", Offset = "0x4C9580", VA = "0x1804CAF80")]
			set
			{
			}
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x4CAF60", Offset = "0x4C9560", VA = "0x1804CAF60", Slot = "4")]
		public void Set(ref SessionModificationSetAllowedPlatformIdsOptions other)
		{
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x4CAEF0", Offset = "0x4C94F0", VA = "0x1804CAEF0", Slot = "5")]
		public void Set(ref SessionModificationSetAllowedPlatformIdsOptions? other)
		{
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x4CAEA0", Offset = "0x4C94A0", VA = "0x1804CAEA0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000519 RID: 1305
		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_AllowedPlatformIds;

		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x10")]
		private uint m_AllowedPlatformIdsCount;
	}
}
