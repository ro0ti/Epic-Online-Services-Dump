using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000537 RID: 1335
	[Token(Token = "0x2000537")]
	internal struct CopyEntitlementByNameAndIndexOptionsInternal : ISettable<CopyEntitlementByNameAndIndexOptions>, IDisposable
	{
		// Token: 0x170009F6 RID: 2550
		// (set) Token: 0x06002294 RID: 8852 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009F6")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002294")]
			[Address(RVA = "0x53DEA0", Offset = "0x53C4A0", VA = "0x18053DEA0")]
			set
			{
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (set) Token: 0x06002295 RID: 8853 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009F7")]
		public Utf8String EntitlementName
		{
			[Token(Token = "0x6002295")]
			[Address(RVA = "0x53DE40", Offset = "0x53C440", VA = "0x18053DE40")]
			set
			{
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (set) Token: 0x06002296 RID: 8854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009F8")]
		public uint Index
		{
			[Token(Token = "0x6002296")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002297")]
		[Address(RVA = "0x53DD70", Offset = "0x53C370", VA = "0x18053DD70", Slot = "4")]
		public void Set(ref CopyEntitlementByNameAndIndexOptions other)
		{
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002298")]
		[Address(RVA = "0x53DC40", Offset = "0x53C240", VA = "0x18053DC40", Slot = "5")]
		public void Set(ref CopyEntitlementByNameAndIndexOptions? other)
		{
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002299")]
		[Address(RVA = "0x53DBE0", Offset = "0x53C1E0", VA = "0x18053DBE0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000F3B RID: 3899
		[Token(Token = "0x4000F3B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F3C RID: 3900
		[Token(Token = "0x4000F3C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000F3D RID: 3901
		[Token(Token = "0x4000F3D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_EntitlementName;

		// Token: 0x04000F3E RID: 3902
		[Token(Token = "0x4000F3E")]
		[FieldOffset(Offset = "0x18")]
		private uint m_Index;
	}
}
