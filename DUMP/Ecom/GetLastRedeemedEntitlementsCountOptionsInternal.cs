using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000559 RID: 1369
	[Token(Token = "0x2000559")]
	internal struct GetLastRedeemedEntitlementsCountOptionsInternal : ISettable<GetLastRedeemedEntitlementsCountOptions>, IDisposable
	{
		// Token: 0x17000A44 RID: 2628
		// (set) Token: 0x06002368 RID: 9064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A44")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002368")]
			[Address(RVA = "0x5479C0", Offset = "0x545FC0", VA = "0x1805479C0")]
			set
			{
			}
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002369")]
		[Address(RVA = "0x5478C0", Offset = "0x545EC0", VA = "0x1805478C0", Slot = "4")]
		public void Set(ref GetLastRedeemedEntitlementsCountOptions other)
		{
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600236A")]
		[Address(RVA = "0x547920", Offset = "0x545F20", VA = "0x180547920", Slot = "5")]
		public void Set(ref GetLastRedeemedEntitlementsCountOptions? other)
		{
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600236B")]
		[Address(RVA = "0x547870", Offset = "0x545E70", VA = "0x180547870", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000FD0 RID: 4048
		[Token(Token = "0x4000FD0")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000FD1 RID: 4049
		[Token(Token = "0x4000FD1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
