using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005DF RID: 1503
	[Token(Token = "0x20005DF")]
	internal struct SendCustomInviteOptionsInternal : ISettable<SendCustomInviteOptions>, IDisposable
	{
		// Token: 0x17000B2C RID: 2860
		// (set) Token: 0x06002690 RID: 9872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B2C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002690")]
			[Address(RVA = "0x566F00", Offset = "0x565500", VA = "0x180566F00")]
			set
			{
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (set) Token: 0x06002691 RID: 9873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B2D")]
		public ProductUserId[] TargetUserIds
		{
			[Token(Token = "0x6002691")]
			[Address(RVA = "0x566F60", Offset = "0x565560", VA = "0x180566F60")]
			set
			{
			}
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002692")]
		[Address(RVA = "0x566E70", Offset = "0x565470", VA = "0x180566E70", Slot = "4")]
		public void Set(ref SendCustomInviteOptions other)
		{
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002693")]
		[Address(RVA = "0x566D90", Offset = "0x565390", VA = "0x180566D90", Slot = "5")]
		public void Set(ref SendCustomInviteOptions? other)
		{
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002694")]
		[Address(RVA = "0x566D30", Offset = "0x565330", VA = "0x180566D30", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040010E3 RID: 4323
		[Token(Token = "0x40010E3")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040010E4 RID: 4324
		[Token(Token = "0x40010E4")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040010E5 RID: 4325
		[Token(Token = "0x40010E5")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserIds;

		// Token: 0x040010E6 RID: 4326
		[Token(Token = "0x40010E6")]
		[FieldOffset(Offset = "0x18")]
		private uint m_TargetUserIdsCount;
	}
}
