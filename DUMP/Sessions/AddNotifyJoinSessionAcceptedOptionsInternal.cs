using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000EF")]
	internal struct AddNotifyJoinSessionAcceptedOptionsInternal : ISettable<AddNotifyJoinSessionAcceptedOptions>, IDisposable
	{
		// Token: 0x0600082D RID: 2093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyJoinSessionAcceptedOptions other)
		{
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x4B8FC0", Offset = "0x4B75C0", VA = "0x1804B8FC0", Slot = "5")]
		public void Set(ref AddNotifyJoinSessionAcceptedOptions? other)
		{
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
