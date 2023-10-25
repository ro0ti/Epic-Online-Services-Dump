using System;


namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x0200071A RID: 1818
	[Token(Token = "0x200071A")]
	internal struct UnprotectMessageOptionsInternal : ISettable<UnprotectMessageOptions>, IDisposable
	{
		// Token: 0x17000DC2 RID: 3522
		// (set) Token: 0x06002E4D RID: 11853 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DC2")]
		public ArraySegment<byte> Data
		{
			[Token(Token = "0x6002E4D")]
			[Address(RVA = "0x580530", Offset = "0x57EB30", VA = "0x180580530")]
			set
			{
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DC3")]
		public uint OutBufferSizeBytes
		{
			[Token(Token = "0x6002E4E")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E4F")]
		[Address(RVA = "0x580170", Offset = "0x57E770", VA = "0x180580170", Slot = "4")]
		public void Set(ref UnprotectMessageOptions other)
		{
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E50")]
		[Address(RVA = "0x5803C0", Offset = "0x57E9C0", VA = "0x1805803C0", Slot = "5")]
		public void Set(ref UnprotectMessageOptions? other)
		{
		}

		// Token: 0x06002E51 RID: 11857 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E51")]
		[Address(RVA = "0x580120", Offset = "0x57E720", VA = "0x180580120", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400149E RID: 5278
		[Token(Token = "0x400149E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400149F RID: 5279
		[Token(Token = "0x400149F")]
		[FieldOffset(Offset = "0x4")]
		private uint m_DataLengthBytes;

		// Token: 0x040014A0 RID: 5280
		[Token(Token = "0x40014A0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Data;

		// Token: 0x040014A1 RID: 5281
		[Token(Token = "0x40014A1")]
		[FieldOffset(Offset = "0x10")]
		private uint m_OutBufferSizeBytes;
	}
}
