using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005D6 RID: 1494
	[Token(Token = "0x20005D6")]
	internal struct RejectRequestToJoinOptionsInternal : ISettable<RejectRequestToJoinOptions>, IDisposable
	{
		// Token: 0x17000B0F RID: 2831
		// (set) Token: 0x06002646 RID: 9798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B0F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002646")]
			[Address(RVA = "0x565980", Offset = "0x563F80", VA = "0x180565980")]
			set
			{
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (set) Token: 0x06002647 RID: 9799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B10")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6002647")]
			[Address(RVA = "0x5659E0", Offset = "0x563FE0", VA = "0x1805659E0")]
			set
			{
			}
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002648")]
		[Address(RVA = "0x5657B0", Offset = "0x563DB0", VA = "0x1805657B0", Slot = "4")]
		public void Set(ref RejectRequestToJoinOptions other)
		{
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002649")]
		[Address(RVA = "0x565870", Offset = "0x563E70", VA = "0x180565870", Slot = "5")]
		public void Set(ref RejectRequestToJoinOptions? other)
		{
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600264A")]
		[Address(RVA = "0x565750", Offset = "0x563D50", VA = "0x180565750", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040010C4 RID: 4292
		[Token(Token = "0x40010C4")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040010C5 RID: 4293
		[Token(Token = "0x40010C5")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040010C6 RID: 4294
		[Token(Token = "0x40010C6")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
