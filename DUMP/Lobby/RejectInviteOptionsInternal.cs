using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200046D RID: 1133
	[Token(Token = "0x200046D")]
	internal struct RejectInviteOptionsInternal : ISettable<RejectInviteOptions>, IDisposable
	{
		// Token: 0x1700082F RID: 2095
		// (set) Token: 0x06001D4C RID: 7500 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700082F")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6001D4C")]
			[Address(RVA = "0x535930", Offset = "0x533F30", VA = "0x180535930")]
			set
			{
			}
		}

		// Token: 0x17000830 RID: 2096
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000830")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001D4D")]
			[Address(RVA = "0x535990", Offset = "0x533F90", VA = "0x180535990")]
			set
			{
			}
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D4E")]
		[Address(RVA = "0x535870", Offset = "0x533E70", VA = "0x180535870", Slot = "4")]
		public void Set(ref RejectInviteOptions other)
		{
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D4F")]
		[Address(RVA = "0x535760", Offset = "0x533D60", VA = "0x180535760", Slot = "5")]
		public void Set(ref RejectInviteOptions? other)
		{
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D50")]
		[Address(RVA = "0x535700", Offset = "0x533D00", VA = "0x180535700", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000CFF RID: 3327
		[Token(Token = "0x4000CFF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D00 RID: 3328
		[Token(Token = "0x4000D00")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_InviteId;

		// Token: 0x04000D01 RID: 3329
		[Token(Token = "0x4000D01")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
