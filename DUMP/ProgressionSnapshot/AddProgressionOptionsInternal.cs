using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.ProgressionSnapshot
{
	// Token: 0x0200028F RID: 655
	[Token(Token = "0x200028F")]
	internal struct AddProgressionOptionsInternal : ISettable<AddProgressionOptions>, IDisposable
	{
		// Token: 0x170004BC RID: 1212
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004BC")]
		public uint SnapshotId
		{
			[Token(Token = "0x6001223")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x170004BD RID: 1213
		// (set) Token: 0x06001224 RID: 4644 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004BD")]
		public Utf8String Key
		{
			[Token(Token = "0x6001224")]
			[Address(RVA = "0x4ED440", Offset = "0x4EBA40", VA = "0x1804ED440")]
			set
			{
			}
		}

		// Token: 0x170004BE RID: 1214
		// (set) Token: 0x06001225 RID: 4645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004BE")]
		public Utf8String Value
		{
			[Token(Token = "0x6001225")]
			[Address(RVA = "0x4ED4A0", Offset = "0x4EBAA0", VA = "0x1804ED4A0")]
			set
			{
			}
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001226")]
		[Address(RVA = "0x4ED240", Offset = "0x4EB840", VA = "0x1804ED240", Slot = "4")]
		public void Set(ref AddProgressionOptions other)
		{
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001227")]
		[Address(RVA = "0x4ED310", Offset = "0x4EB910", VA = "0x1804ED310", Slot = "5")]
		public void Set(ref AddProgressionOptions? other)
		{
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001228")]
		[Address(RVA = "0x4ED1E0", Offset = "0x4EB7E0", VA = "0x1804ED1E0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000813 RID: 2067
		[Token(Token = "0x4000813")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000814 RID: 2068
		[Token(Token = "0x4000814")]
		[FieldOffset(Offset = "0x4")]
		private uint m_SnapshotId;

		// Token: 0x04000815 RID: 2069
		[Token(Token = "0x4000815")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Key;

		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Value;
	}
}
