using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	internal struct GetStatCountOptionsInternal : ISettable<GetStatCountOptions>, IDisposable
	{
		// Token: 0x1700016A RID: 362
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700016A")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x4BCF90", Offset = "0x4BB590", VA = "0x1804BCF90")]
			set
			{
			}
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x4BCE90", Offset = "0x4BB490", VA = "0x1804BCE90", Slot = "4")]
		public void Set(ref GetStatCountOptions other)
		{
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x4BCEF0", Offset = "0x4BB4F0", VA = "0x1804BCEF0", Slot = "5")]
		public void Set(ref GetStatCountOptions? other)
		{
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x4BCE40", Offset = "0x4BB440", VA = "0x1804BCE40", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;
	}
}
