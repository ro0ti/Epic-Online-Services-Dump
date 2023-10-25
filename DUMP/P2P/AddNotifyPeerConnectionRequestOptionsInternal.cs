using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000321 RID: 801
	[Token(Token = "0x2000321")]
	internal struct AddNotifyPeerConnectionRequestOptionsInternal : ISettable<AddNotifyPeerConnectionRequestOptions>, IDisposable
	{
		// Token: 0x170005D5 RID: 1493
		// (set) Token: 0x060015A2 RID: 5538 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005D5")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60015A2")]
			[Address(RVA = "0x4ED110", Offset = "0x4EB710", VA = "0x1804ED110")]
			set
			{
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005D6")]
		public SocketId? SocketId
		{
			[Token(Token = "0x60015A3")]
			[Address(RVA = "0x4ED170", Offset = "0x4EB770", VA = "0x1804ED170")]
			set
			{
			}
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x4ED030", Offset = "0x4EB630", VA = "0x1804ED030", Slot = "4")]
		public void Set(ref AddNotifyPeerConnectionRequestOptions other)
		{
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x4ECF00", Offset = "0x4EB500", VA = "0x1804ECF00", Slot = "5")]
		public void Set(ref AddNotifyPeerConnectionRequestOptions? other)
		{
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x4ECEA0", Offset = "0x4EB4A0", VA = "0x1804ECEA0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400098F RID: 2447
		[Token(Token = "0x400098F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000990 RID: 2448
		[Token(Token = "0x4000990")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000991 RID: 2449
		[Token(Token = "0x4000991")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_SocketId;
	}
}
