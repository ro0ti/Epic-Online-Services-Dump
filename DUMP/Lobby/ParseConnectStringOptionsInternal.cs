using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000461 RID: 1121
	[Token(Token = "0x2000461")]
	internal struct ParseConnectStringOptionsInternal : ISettable<ParseConnectStringOptions>, IDisposable
	{
		// Token: 0x1700080F RID: 2063
		// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700080F")]
		public Utf8String ConnectString
		{
			[Token(Token = "0x6001CF9")]
			[Address(RVA = "0x5308B0", Offset = "0x52EEB0", VA = "0x1805308B0")]
			set
			{
			}
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CFA")]
		[Address(RVA = "0x5307B0", Offset = "0x52EDB0", VA = "0x1805307B0", Slot = "4")]
		public void Set(ref ParseConnectStringOptions other)
		{
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CFB")]
		[Address(RVA = "0x530810", Offset = "0x52EE10", VA = "0x180530810", Slot = "5")]
		public void Set(ref ParseConnectStringOptions? other)
		{
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CFC")]
		[Address(RVA = "0x530760", Offset = "0x52ED60", VA = "0x180530760", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000CDF RID: 3295
		[Token(Token = "0x4000CDF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000CE0 RID: 3296
		[Token(Token = "0x4000CE0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ConnectString;
	}
}
