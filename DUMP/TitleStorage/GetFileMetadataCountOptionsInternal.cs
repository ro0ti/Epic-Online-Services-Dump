using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	internal struct GetFileMetadataCountOptionsInternal : ISettable<GetFileMetadataCountOptions>, IDisposable
	{
		// Token: 0x17000128 RID: 296
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000128")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x4A61D0", Offset = "0x4A47D0", VA = "0x1804A61D0")]
			set
			{
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x4A6140", Offset = "0x4A4740", VA = "0x1804A6140", Slot = "4")]
		public void Set(ref GetFileMetadataCountOptions other)
		{
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x4A6160", Offset = "0x4A4760", VA = "0x1804A6160", Slot = "5")]
		public void Set(ref GetFileMetadataCountOptions? other)
		{
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x4A60B0", Offset = "0x4A46B0", VA = "0x1804A60B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
