using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x0200069F RID: 1695
	[Token(Token = "0x200069F")]
	internal struct GetProtectMessageOutputLengthOptionsInternal : ISettable<GetProtectMessageOutputLengthOptions>, IDisposable
	{
		// Token: 0x17000CBF RID: 3263
		// (set) Token: 0x06002B9A RID: 11162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CBF")]
		public uint DataLengthBytes
		{
			[Token(Token = "0x6002B9A")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B9B")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref GetProtectMessageOutputLengthOptions other)
		{
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B9C")]
		[Address(RVA = "0x570460", Offset = "0x56EA60", VA = "0x180570460", Slot = "5")]
		public void Set(ref GetProtectMessageOutputLengthOptions? other)
		{
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B9D")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040012EC RID: 4844
		[Token(Token = "0x40012EC")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040012ED RID: 4845
		[Token(Token = "0x40012ED")]
		[FieldOffset(Offset = "0x4")]
		private uint m_DataLengthBytes;
	}
}
