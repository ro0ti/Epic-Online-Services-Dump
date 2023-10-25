using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000503 RID: 1283
	[Token(Token = "0x2000503")]
	internal struct GetBlockedUsersCountOptionsInternal : ISettable<GetBlockedUsersCountOptions>, IDisposable
	{
		// Token: 0x17000954 RID: 2388
		// (set) Token: 0x060020E2 RID: 8418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000954")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60020E2")]
			[Address(RVA = "0x5469E0", Offset = "0x544FE0", VA = "0x1805469E0")]
			set
			{
			}
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020E3")]
		[Address(RVA = "0x5468E0", Offset = "0x544EE0", VA = "0x1805468E0", Slot = "4")]
		public void Set(ref GetBlockedUsersCountOptions other)
		{
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020E4")]
		[Address(RVA = "0x546940", Offset = "0x544F40", VA = "0x180546940", Slot = "5")]
		public void Set(ref GetBlockedUsersCountOptions? other)
		{
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020E5")]
		[Address(RVA = "0x546890", Offset = "0x544E90", VA = "0x180546890", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E8E RID: 3726
		[Token(Token = "0x4000E8E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000E8F RID: 3727
		[Token(Token = "0x4000E8F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
