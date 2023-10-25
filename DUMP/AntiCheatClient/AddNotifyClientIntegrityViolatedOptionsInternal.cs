using System;


namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x020006EF RID: 1775
	[Token(Token = "0x20006EF")]
	internal struct AddNotifyClientIntegrityViolatedOptionsInternal : ISettable<AddNotifyClientIntegrityViolatedOptions>, IDisposable
	{
		// Token: 0x06002D8C RID: 11660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D8C")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyClientIntegrityViolatedOptions other)
		{
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D8D")]
		[Address(RVA = "0x56B340", Offset = "0x569940", VA = "0x18056B340", Slot = "5")]
		public void Set(ref AddNotifyClientIntegrityViolatedOptions? other)
		{
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D8E")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001439 RID: 5177
		[Token(Token = "0x4001439")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
