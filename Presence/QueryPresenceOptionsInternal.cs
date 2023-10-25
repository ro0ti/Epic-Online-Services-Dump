using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002CC RID: 716
	[Token(Token = "0x20002CC")]
	internal struct QueryPresenceOptionsInternal : ISettable<QueryPresenceOptions>, IDisposable
	{
		// Token: 0x17000522 RID: 1314
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000522")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600137E")]
			[Address(RVA = "0x4FEA60", Offset = "0x4FD060", VA = "0x1804FEA60")]
			set
			{
			}
		}

		// Token: 0x17000523 RID: 1315
		// (set) Token: 0x0600137F RID: 4991 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000523")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x600137F")]
			[Address(RVA = "0x4FEAC0", Offset = "0x4FD0C0", VA = "0x1804FEAC0")]
			set
			{
			}
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001380")]
		[Address(RVA = "0x4FE890", Offset = "0x4FCE90", VA = "0x1804FE890", Slot = "4")]
		public void Set(ref QueryPresenceOptions other)
		{
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001381")]
		[Address(RVA = "0x4FE950", Offset = "0x4FCF50", VA = "0x1804FE950", Slot = "5")]
		public void Set(ref QueryPresenceOptions? other)
		{
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001382")]
		[Address(RVA = "0x4FE830", Offset = "0x4FCE30", VA = "0x1804FE830", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040008AA RID: 2218
		[Token(Token = "0x40008AA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040008AB RID: 2219
		[Token(Token = "0x40008AB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040008AC RID: 2220
		[Token(Token = "0x40008AC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
