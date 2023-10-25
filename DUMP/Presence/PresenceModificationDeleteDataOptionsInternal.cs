using System;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002C0 RID: 704
	[Token(Token = "0x20002C0")]
	internal struct PresenceModificationDeleteDataOptionsInternal : ISettable<PresenceModificationDeleteDataOptions>, IDisposable
	{
		// Token: 0x1700050E RID: 1294
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700050E")]
		public PresenceModificationDataRecordId[] Records
		{
			[Token(Token = "0x6001347")]
			[Address(RVA = "0x4FC190", Offset = "0x4FA790", VA = "0x1804FC190")]
			set
			{
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001348")]
		[Address(RVA = "0x4FC170", Offset = "0x4FA770", VA = "0x1804FC170", Slot = "4")]
		public void Set(ref PresenceModificationDeleteDataOptions other)
		{
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001349")]
		[Address(RVA = "0x4FC100", Offset = "0x4FA700", VA = "0x1804FC100", Slot = "5")]
		public void Set(ref PresenceModificationDeleteDataOptions? other)
		{
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600134A")]
		[Address(RVA = "0x4FC0B0", Offset = "0x4FA6B0", VA = "0x1804FC0B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000890 RID: 2192
		[Token(Token = "0x4000890")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000891 RID: 2193
		[Token(Token = "0x4000891")]
		[FieldOffset(Offset = "0x4")]
		private int m_RecordsCount;

		// Token: 0x04000892 RID: 2194
		[Token(Token = "0x4000892")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Records;
	}
}
