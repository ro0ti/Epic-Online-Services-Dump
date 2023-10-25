using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x02000700 RID: 1792
	[Token(Token = "0x2000700")]
	internal struct GetProtectMessageOutputLengthOptionsInternal : ISettable<GetProtectMessageOutputLengthOptions>, IDisposable
	{
		// Token: 0x17000D99 RID: 3481
		// (set) Token: 0x06002DC5 RID: 11717 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D99")]
		public uint DataLengthBytes
		{
			[Token(Token = "0x6002DC5")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DC6")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref GetProtectMessageOutputLengthOptions other)
		{
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DC7")]
		[Address(RVA = "0x570400", Offset = "0x56EA00", VA = "0x180570400", Slot = "5")]
		public void Set(ref GetProtectMessageOutputLengthOptions? other)
		{
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DC8")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400146D RID: 5229
		[Token(Token = "0x400146D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400146E RID: 5230
		[Token(Token = "0x400146E")]
		[FieldOffset(Offset = "0x4")]
		private uint m_DataLengthBytes;
	}
}
