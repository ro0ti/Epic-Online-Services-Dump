using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000651 RID: 1617
	[Token(Token = "0x2000651")]
	internal struct CopyIdTokenOptionsInternal : ISettable<CopyIdTokenOptions>, IDisposable
	{
		// Token: 0x17000C09 RID: 3081
		// (set) Token: 0x0600296E RID: 10606 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C09")]
		public EpicAccountId AccountId
		{
			[Token(Token = "0x600296E")]
			[Address(RVA = "0x557B00", Offset = "0x556100", VA = "0x180557B00")]
			set
			{
			}
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600296F")]
		[Address(RVA = "0x5579A0", Offset = "0x555FA0", VA = "0x1805579A0", Slot = "4")]
		public void Set(ref CopyIdTokenOptions other)
		{
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002970")]
		[Address(RVA = "0x557A60", Offset = "0x556060", VA = "0x180557A60", Slot = "5")]
		public void Set(ref CopyIdTokenOptions? other)
		{
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002971")]
		[Address(RVA = "0x5578B0", Offset = "0x555EB0", VA = "0x1805578B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400120C RID: 4620
		[Token(Token = "0x400120C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400120D RID: 4621
		[Token(Token = "0x400120D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_AccountId;
	}
}
