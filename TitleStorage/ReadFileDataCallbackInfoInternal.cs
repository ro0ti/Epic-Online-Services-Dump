using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	internal struct ReadFileDataCallbackInfoInternal : ICallbackInfoInternal, IGettable<ReadFileDataCallbackInfo>, ISettable<ReadFileDataCallbackInfo>, IDisposable
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000150")]
		public object ClientData
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x4C3FA0", Offset = "0x4C25A0", VA = "0x1804C3FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x4C41E0", Offset = "0x4C27E0", VA = "0x1804C41E0")]
			set
			{
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x000032B4 File Offset: 0x000014B4
		[Token(Token = "0x17000151")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000152")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x4C4160", Offset = "0x4C2760", VA = "0x1804C4160")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x4C4380", Offset = "0x4C2980", VA = "0x1804C4380")]
			set
			{
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000153")]
		public Utf8String Filename
		{
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x4C4090", Offset = "0x4C2690", VA = "0x1804C4090")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x4C42C0", Offset = "0x4C28C0", VA = "0x1804C42C0")]
			set
			{
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x000032CC File Offset: 0x000014CC
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000154")]
		public uint TotalFileSizeBytes
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x000032E4 File Offset: 0x000014E4
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000155")]
		public bool IsLastChunk
		{
			[Token(Token = "0x6000738")]
			[Address(RVA = "0x4C4100", Offset = "0x4C2700", VA = "0x1804C4100")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x4C4320", Offset = "0x4C2920", VA = "0x1804C4320")]
			set
			{
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x000032FC File Offset: 0x000014FC
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000156")]
		public ArraySegment<byte> DataChunk
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x4C4010", Offset = "0x4C2610", VA = "0x1804C4010")]
			get
			{
				return default(ArraySegment<byte>);
			}
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x4C4240", Offset = "0x4C2840", VA = "0x1804C4240")]
			set
			{
			}
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x4C3BB0", Offset = "0x4C21B0", VA = "0x1804C3BB0", Slot = "6")]
		public void Set(ref ReadFileDataCallbackInfo other)
		{
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x4C3D50", Offset = "0x4C2350", VA = "0x1804C3D50", Slot = "7")]
		public void Set(ref ReadFileDataCallbackInfo? other)
		{
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x4C3B20", Offset = "0x4C2120", VA = "0x1804C3B20", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x4C3B90", Offset = "0x4C2190", VA = "0x1804C3B90", Slot = "5")]
		public void Get(out ReadFileDataCallbackInfo output)
		{
		}

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x0400037C RID: 892
		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Filename;

		// Token: 0x0400037E RID: 894
		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0x18")]
		private uint m_TotalFileSizeBytes;

		// Token: 0x0400037F RID: 895
		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0x1C")]
		private int m_IsLastChunk;

		// Token: 0x04000380 RID: 896
		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x20")]
		private uint m_DataChunkLengthBytes;

		// Token: 0x04000381 RID: 897
		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_DataChunk;
	}
}
