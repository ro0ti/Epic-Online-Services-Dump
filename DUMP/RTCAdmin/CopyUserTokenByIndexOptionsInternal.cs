using System;


namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x0200023F RID: 575
	[Token(Token = "0x200023F")]
	internal struct CopyUserTokenByIndexOptionsInternal : ISettable<CopyUserTokenByIndexOptions>, IDisposable
	{
		// Token: 0x170003F9 RID: 1017
		// (set) Token: 0x06000FEC RID: 4076 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003F9")]
		public uint UserTokenIndex
		{
			[Token(Token = "0x6000FEC")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x170003FA RID: 1018
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003FA")]
		public uint QueryId
		{
			[Token(Token = "0x6000FED")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			set
			{
			}
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0x4D8AB0", Offset = "0x4D70B0", VA = "0x1804D8AB0", Slot = "4")]
		public void Set(ref CopyUserTokenByIndexOptions other)
		{
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x4D8AD0", Offset = "0x4D70D0", VA = "0x1804D8AD0", Slot = "5")]
		public void Set(ref CopyUserTokenByIndexOptions? other)
		{
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x4")]
		private uint m_UserTokenIndex;

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x8")]
		private uint m_QueryId;
	}
}
