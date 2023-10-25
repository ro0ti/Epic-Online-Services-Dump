using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000535 RID: 1333
	[Token(Token = "0x2000535")]
	internal struct CopyEntitlementByIndexOptionsInternal : ISettable<CopyEntitlementByIndexOptions>, IDisposable
	{
		// Token: 0x170009F1 RID: 2545
		// (set) Token: 0x06002289 RID: 8841 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009F1")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002289")]
			[Address(RVA = "0x53DB80", Offset = "0x53C180", VA = "0x18053DB80")]
			set
			{
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (set) Token: 0x0600228A RID: 8842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009F2")]
		public uint EntitlementIndex
		{
			[Token(Token = "0x600228A")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600228B")]
		[Address(RVA = "0x53DB00", Offset = "0x53C100", VA = "0x18053DB00", Slot = "4")]
		public void Set(ref CopyEntitlementByIndexOptions other)
		{
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600228C")]
		[Address(RVA = "0x53DA30", Offset = "0x53C030", VA = "0x18053DA30", Slot = "5")]
		public void Set(ref CopyEntitlementByIndexOptions? other)
		{
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600228D")]
		[Address(RVA = "0x53D9E0", Offset = "0x53BFE0", VA = "0x18053D9E0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000F35 RID: 3893
		[Token(Token = "0x4000F35")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F36 RID: 3894
		[Token(Token = "0x4000F36")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000F37 RID: 3895
		[Token(Token = "0x4000F37")]
		[FieldOffset(Offset = "0x10")]
		private uint m_EntitlementIndex;
	}
}
