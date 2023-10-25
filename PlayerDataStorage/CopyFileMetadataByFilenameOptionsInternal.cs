using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002D7 RID: 727
	[Token(Token = "0x20002D7")]
	internal struct CopyFileMetadataByFilenameOptionsInternal : ISettable<CopyFileMetadataByFilenameOptions>, IDisposable
	{
		// Token: 0x17000535 RID: 1333
		// (set) Token: 0x060013B4 RID: 5044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000535")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60013B4")]
			[Address(RVA = "0x4EE700", Offset = "0x4ECD00", VA = "0x1804EE700")]
			set
			{
			}
		}

		// Token: 0x17000536 RID: 1334
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000536")]
		public Utf8String Filename
		{
			[Token(Token = "0x60013B5")]
			[Address(RVA = "0x4EE6A0", Offset = "0x4ECCA0", VA = "0x1804EE6A0")]
			set
			{
			}
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B6")]
		[Address(RVA = "0x4EE5E0", Offset = "0x4ECBE0", VA = "0x1804EE5E0", Slot = "4")]
		public void Set(ref CopyFileMetadataByFilenameOptions other)
		{
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B7")]
		[Address(RVA = "0x4EE4D0", Offset = "0x4ECAD0", VA = "0x1804EE4D0", Slot = "5")]
		public void Set(ref CopyFileMetadataByFilenameOptions? other)
		{
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B8")]
		[Address(RVA = "0x4EE470", Offset = "0x4ECA70", VA = "0x1804EE470", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x40008C5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040008C6 RID: 2246
		[Token(Token = "0x40008C6")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040008C7 RID: 2247
		[Token(Token = "0x40008C7")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Filename;
	}
}
