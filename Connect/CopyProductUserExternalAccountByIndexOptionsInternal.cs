using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005F6 RID: 1526
	[Token(Token = "0x20005F6")]
	internal struct CopyProductUserExternalAccountByIndexOptionsInternal : ISettable<CopyProductUserExternalAccountByIndexOptions>, IDisposable
	{
		// Token: 0x17000B5D RID: 2909
		// (set) Token: 0x06002735 RID: 10037 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B5D")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6002735")]
			[Address(RVA = "0x558250", Offset = "0x556850", VA = "0x180558250")]
			set
			{
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (set) Token: 0x06002736 RID: 10038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B5E")]
		public uint ExternalAccountInfoIndex
		{
			[Token(Token = "0x6002736")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002737")]
		[Address(RVA = "0x5581D0", Offset = "0x5567D0", VA = "0x1805581D0", Slot = "4")]
		public void Set(ref CopyProductUserExternalAccountByIndexOptions other)
		{
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002738")]
		[Address(RVA = "0x558100", Offset = "0x556700", VA = "0x180558100", Slot = "5")]
		public void Set(ref CopyProductUserExternalAccountByIndexOptions? other)
		{
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002739")]
		[Address(RVA = "0x5580B0", Offset = "0x5566B0", VA = "0x1805580B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001139 RID: 4409
		[Token(Token = "0x4001139")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400113A RID: 4410
		[Token(Token = "0x400113A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x0400113B RID: 4411
		[Token(Token = "0x400113B")]
		[FieldOffset(Offset = "0x10")]
		private uint m_ExternalAccountInfoIndex;
	}
}
