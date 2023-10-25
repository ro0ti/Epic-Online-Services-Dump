using System;


namespace Epic.OnlineServices.Sanctions
{
	// Token: 0x020001A4 RID: 420
	[Token(Token = "0x20001A4")]
	internal struct CopyPlayerSanctionByIndexOptionsInternal : ISettable<CopyPlayerSanctionByIndexOptions>, IDisposable
	{
		// Token: 0x170002C3 RID: 707
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002C3")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000C10")]
			[Address(RVA = "0x4D8A50", Offset = "0x4D7050", VA = "0x1804D8A50")]
			set
			{
			}
		}

		// Token: 0x170002C4 RID: 708
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002C4")]
		public uint SanctionIndex
		{
			[Token(Token = "0x6000C11")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x4D89D0", Offset = "0x4D6FD0", VA = "0x1804D89D0", Slot = "4")]
		public void Set(ref CopyPlayerSanctionByIndexOptions other)
		{
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x4D8900", Offset = "0x4D6F00", VA = "0x1804D8900", Slot = "5")]
		public void Set(ref CopyPlayerSanctionByIndexOptions? other)
		{
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x4D88B0", Offset = "0x4D6EB0", VA = "0x1804D88B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0x10")]
		private uint m_SanctionIndex;
	}
}
