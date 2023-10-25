using System;


namespace Epic.OnlineServices.UI
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	internal struct HideFriendsOptionsInternal : ISettable<HideFriendsOptions>, IDisposable
	{
		// Token: 0x1700009C RID: 156
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009C")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x4AA570", Offset = "0x4A8B70", VA = "0x1804AA570")]
			set
			{
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x4AA4E0", Offset = "0x4A8AE0", VA = "0x1804AA4E0", Slot = "4")]
		public void Set(ref HideFriendsOptions other)
		{
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x4AA500", Offset = "0x4A8B00", VA = "0x1804AA500", Slot = "5")]
		public void Set(ref HideFriendsOptions? other)
		{
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x4AA450", Offset = "0x4A8A50", VA = "0x1804AA450", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
