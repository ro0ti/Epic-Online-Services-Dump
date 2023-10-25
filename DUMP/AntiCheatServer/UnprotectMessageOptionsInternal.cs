using System;


namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x020006AF RID: 1711
	[Token(Token = "0x20006AF")]
	internal struct UnprotectMessageOptionsInternal : ISettable<UnprotectMessageOptions>, IDisposable
	{
		// Token: 0x17000CDD RID: 3293
		// (set) Token: 0x06002BEF RID: 11247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CDD")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002BEF")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (set) Token: 0x06002BF0 RID: 11248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CDE")]
		public ArraySegment<byte> Data
		{
			[Token(Token = "0x6002BF0")]
			[Address(RVA = "0x5804B0", Offset = "0x57EAB0", VA = "0x1805804B0")]
			set
			{
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (set) Token: 0x06002BF1 RID: 11249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CDF")]
		public uint OutBufferSizeBytes
		{
			[Token(Token = "0x6002BF1")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			set
			{
			}
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BF2")]
		[Address(RVA = "0x580320", Offset = "0x57E920", VA = "0x180580320", Slot = "4")]
		public void Set(ref UnprotectMessageOptions other)
		{
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BF3")]
		[Address(RVA = "0x580210", Offset = "0x57E810", VA = "0x180580210", Slot = "5")]
		public void Set(ref UnprotectMessageOptions? other)
		{
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BF4")]
		[Address(RVA = "0x5800C0", Offset = "0x57E6C0", VA = "0x1805800C0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001311 RID: 4881
		[Token(Token = "0x4001311")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001312 RID: 4882
		[Token(Token = "0x4001312")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientHandle;

		// Token: 0x04001313 RID: 4883
		[Token(Token = "0x4001313")]
		[FieldOffset(Offset = "0x10")]
		private uint m_DataLengthBytes;

		// Token: 0x04001314 RID: 4884
		[Token(Token = "0x4001314")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_Data;

		// Token: 0x04001315 RID: 4885
		[Token(Token = "0x4001315")]
		[FieldOffset(Offset = "0x20")]
		private uint m_OutBufferSizeBytes;
	}
}
