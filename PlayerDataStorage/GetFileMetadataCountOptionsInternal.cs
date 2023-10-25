using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002E9 RID: 745
	[Token(Token = "0x20002E9")]
	internal struct GetFileMetadataCountOptionsInternal : ISettable<GetFileMetadataCountOptions>, IDisposable
	{
		// Token: 0x1700056E RID: 1390
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700056E")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001443")]
			[Address(RVA = "0x4F1F50", Offset = "0x4F0550", VA = "0x1804F1F50")]
			set
			{
			}
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001444")]
		[Address(RVA = "0x4F1EF0", Offset = "0x4F04F0", VA = "0x1804F1EF0", Slot = "4")]
		public void Set(ref GetFileMetadataCountOptions other)
		{
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001445")]
		[Address(RVA = "0x4F1E50", Offset = "0x4F0450", VA = "0x1804F1E50", Slot = "5")]
		public void Set(ref GetFileMetadataCountOptions? other)
		{
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001446")]
		[Address(RVA = "0x4F1E00", Offset = "0x4F0400", VA = "0x1804F1E00", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040008FF RID: 2303
		[Token(Token = "0x40008FF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000900 RID: 2304
		[Token(Token = "0x4000900")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
