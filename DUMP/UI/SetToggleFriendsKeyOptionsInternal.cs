using System;


namespace Epic.OnlineServices.UI
{
	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	internal struct SetToggleFriendsKeyOptionsInternal : ISettable<SetToggleFriendsKeyOptions>, IDisposable
	{
		// Token: 0x170000E4 RID: 228
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000E4")]
		public KeyCombination KeyCombination
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref SetToggleFriendsKeyOptions other)
		{
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x4AFC70", Offset = "0x4AE270", VA = "0x1804AFC70", Slot = "5")]
		public void Set(ref SetToggleFriendsKeyOptions? other)
		{
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x4")]
		private KeyCombination m_KeyCombination;
	}
}
