using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200031D RID: 797
	[Token(Token = "0x200031D")]
	internal struct AddNotifyPeerConnectionEstablishedOptionsInternal : ISettable<AddNotifyPeerConnectionEstablishedOptions>, IDisposable
	{
		// Token: 0x170005CD RID: 1485
		// (set) Token: 0x06001590 RID: 5520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005CD")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001590")]
			[Address(RVA = "0x4ECA90", Offset = "0x4EB090", VA = "0x1804ECA90")]
			set
			{
			}
		}

		// Token: 0x170005CE RID: 1486
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005CE")]
		public SocketId? SocketId
		{
			[Token(Token = "0x6001591")]
			[Address(RVA = "0x4ECAF0", Offset = "0x4EB0F0", VA = "0x1804ECAF0")]
			set
			{
			}
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001592")]
		[Address(RVA = "0x4EC9B0", Offset = "0x4EAFB0", VA = "0x1804EC9B0", Slot = "4")]
		public void Set(ref AddNotifyPeerConnectionEstablishedOptions other)
		{
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x4EC880", Offset = "0x4EAE80", VA = "0x1804EC880", Slot = "5")]
		public void Set(ref AddNotifyPeerConnectionEstablishedOptions? other)
		{
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x4EC820", Offset = "0x4EAE20", VA = "0x1804EC820", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000985 RID: 2437
		[Token(Token = "0x4000985")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000986 RID: 2438
		[Token(Token = "0x4000986")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000987 RID: 2439
		[Token(Token = "0x4000987")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_SocketId;
	}
}
