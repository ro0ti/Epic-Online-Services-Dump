using System;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002A2 RID: 674
	[Token(Token = "0x20002A2")]
	internal struct AddNotifyJoinGameAcceptedOptionsInternal : ISettable<AddNotifyJoinGameAcceptedOptions>, IDisposable
	{
		// Token: 0x06001280 RID: 4736 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001280")]
		[Address(RVA = "0x4EC400", Offset = "0x4EAA00", VA = "0x1804EC400", Slot = "4")]
		public void Set(ref AddNotifyJoinGameAcceptedOptions other)
		{
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001281")]
		[Address(RVA = "0x4EC410", Offset = "0x4EAA10", VA = "0x1804EC410", Slot = "5")]
		public void Set(ref AddNotifyJoinGameAcceptedOptions? other)
		{
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001282")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000835 RID: 2101
		[Token(Token = "0x4000835")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
