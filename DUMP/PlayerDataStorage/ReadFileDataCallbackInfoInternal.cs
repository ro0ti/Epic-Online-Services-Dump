using System;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x0200030B RID: 779
	[Token(Token = "0x200030B")]
	internal struct ReadFileDataCallbackInfoInternal : ICallbackInfoInternal, IGettable<ReadFileDataCallbackInfo>, ISettable<ReadFileDataCallbackInfo>, IDisposable
	{
		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001512 RID: 5394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000594")]
		public object ClientData
		{
			[Token(Token = "0x6001511")]
			[Address(RVA = "0x5008B0", Offset = "0x4FEEB0", VA = "0x1805008B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001512")]
			[Address(RVA = "0x500AF0", Offset = "0x4FF0F0", VA = "0x180500AF0")]
			set
			{
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x00005FFC File Offset: 0x000041FC
		[Token(Token = "0x17000595")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001513")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001515 RID: 5397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000596")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001514")]
			[Address(RVA = "0x500A70", Offset = "0x4FF070", VA = "0x180500A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001515")]
			[Address(RVA = "0x500C90", Offset = "0x4FF290", VA = "0x180500C90")]
			set
			{
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001517 RID: 5399 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000597")]
		public Utf8String Filename
		{
			[Token(Token = "0x6001516")]
			[Address(RVA = "0x5009A0", Offset = "0x4FEFA0", VA = "0x1805009A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001517")]
			[Address(RVA = "0x500BD0", Offset = "0x4FF1D0", VA = "0x180500BD0")]
			set
			{
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x00006014 File Offset: 0x00004214
		// (set) Token: 0x06001519 RID: 5401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000598")]
		public uint TotalFileSizeBytes
		{
			[Token(Token = "0x6001518")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001519")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x0000602C File Offset: 0x0000422C
		// (set) Token: 0x0600151B RID: 5403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000599")]
		public bool IsLastChunk
		{
			[Token(Token = "0x600151A")]
			[Address(RVA = "0x500A10", Offset = "0x4FF010", VA = "0x180500A10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600151B")]
			[Address(RVA = "0x500C30", Offset = "0x4FF230", VA = "0x180500C30")]
			set
			{
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x00006044 File Offset: 0x00004244
		// (set) Token: 0x0600151D RID: 5405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700059A")]
		public ArraySegment<byte> DataChunk
		{
			[Token(Token = "0x600151C")]
			[Address(RVA = "0x500920", Offset = "0x4FEF20", VA = "0x180500920")]
			get
			{
				return default(ArraySegment<byte>);
			}
			[Token(Token = "0x600151D")]
			[Address(RVA = "0x500B50", Offset = "0x4FF150", VA = "0x180500B50")]
			set
			{
			}
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600151E")]
		[Address(RVA = "0x5004C0", Offset = "0x4FEAC0", VA = "0x1805004C0", Slot = "6")]
		public void Set(ref ReadFileDataCallbackInfo other)
		{
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600151F")]
		[Address(RVA = "0x500660", Offset = "0x4FEC60", VA = "0x180500660", Slot = "7")]
		public void Set(ref ReadFileDataCallbackInfo? other)
		{
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001520")]
		[Address(RVA = "0x500430", Offset = "0x4FEA30", VA = "0x180500430", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001521")]
		[Address(RVA = "0x5004A0", Offset = "0x4FEAA0", VA = "0x1805004A0", Slot = "5")]
		public void Get(out ReadFileDataCallbackInfo output)
		{
		}

		// Token: 0x0400093C RID: 2364
		[Token(Token = "0x400093C")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x0400093D RID: 2365
		[Token(Token = "0x400093D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400093E RID: 2366
		[Token(Token = "0x400093E")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Filename;

		// Token: 0x0400093F RID: 2367
		[Token(Token = "0x400093F")]
		[FieldOffset(Offset = "0x18")]
		private uint m_TotalFileSizeBytes;

		// Token: 0x04000940 RID: 2368
		[Token(Token = "0x4000940")]
		[FieldOffset(Offset = "0x1C")]
		private int m_IsLastChunk;

		// Token: 0x04000941 RID: 2369
		[Token(Token = "0x4000941")]
		[FieldOffset(Offset = "0x20")]
		private uint m_DataChunkLengthBytes;

		// Token: 0x04000942 RID: 2370
		[Token(Token = "0x4000942")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_DataChunk;
	}
}
