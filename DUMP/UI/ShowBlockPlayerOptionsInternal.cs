using System;


namespace Epic.OnlineServices.UI
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	internal struct ShowBlockPlayerOptionsInternal : ISettable<ShowBlockPlayerOptions>, IDisposable
	{
		// Token: 0x170000E7 RID: 231
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000E7")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x4AFE90", Offset = "0x4AE490", VA = "0x1804AFE90")]
			set
			{
			}
		}

		// Token: 0x170000E8 RID: 232
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000E8")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x4AFF40", Offset = "0x4AE540", VA = "0x1804AFF40")]
			set
			{
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x4AFDB0", Offset = "0x4AE3B0", VA = "0x1804AFDB0", Slot = "4")]
		public void Set(ref ShowBlockPlayerOptions other)
		{
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x4AFDF0", Offset = "0x4AE3F0", VA = "0x1804AFDF0", Slot = "5")]
		public void Set(ref ShowBlockPlayerOptions? other)
		{
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x4AFCD0", Offset = "0x4AE2D0", VA = "0x1804AFCD0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
